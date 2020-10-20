﻿using System;
using System.Configuration;
using System.IO;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace AIForAgedClient.ViewModel
{
    /// <summary>
    /// 用于接收显示远端的火柴人图像
    /// 需要设置RoomId,是需要打开图像显示的房间Id
    /// 需要设置Url1,Url2,Url3,Url4,分别是CameraId，即指定哪个摄像头显示在哪个Image框中
    /// </summary>
    public class HuoChaiRenFourVideoVM : BaseFourVideoVM
    {
        public UInt32 RoomId { get; set; }

        TcpClient tcpClient;
        NetworkStream stream;
        CancellationTokenSource cancellationTokenSource;
        int remote_port = 8008;
        string remote_ip = "127.0.0.1";

        private async Task<byte[]> tcp_recv(NetworkStream stream,int data_len)
        {
            byte[] tempBuffer = new byte[data_len];
            int recv_len = await stream.ReadAsync(tempBuffer, 0, tempBuffer.Length);
            
            while (recv_len < data_len)
            {
                int temp_recv_len = await stream.ReadAsync(tempBuffer,recv_len,data_len-recv_len);
                recv_len += temp_recv_len;
            }
            return tempBuffer;
        }

        public override void Start()
        {
            remote_ip = ConfigurationManager.AppSettings["TcpServerIp"];
            Console.WriteLine($"tcp_server_ip: {remote_ip}");
            tcpClient = new TcpClient(remote_ip,remote_port);
            stream = tcpClient.GetStream();

            //发送角色数据包
            Role role = new Role(3,1,1);
            byte[] send_bytes = StructToBytes<Role>(role);
            stream.WriteAsync(send_bytes,0,send_bytes.Length);

            //发送获取图像请求命令包
            VideoCmd videoCmd = new VideoCmd(1,5,RoomId,1);
            byte[] videoCmd_bytes = StructToBytes<VideoCmd>(videoCmd);
            stream.WriteAsync(videoCmd_bytes,0,videoCmd_bytes.Length);

            //接收图像数据并显示
            cancellationTokenSource = new CancellationTokenSource();
            Task recvVideoTask = new Task(()=>RecvVideo(cancellationTokenSource.Token),cancellationTokenSource.Token);
            recvVideoTask.Start();
        }

        private async void RecvVideo(CancellationToken token)
        {
            while (true)
            {
                token.ThrowIfCancellationRequested();

                byte[] video_header_bytes = await tcp_recv(stream, 9);
                VideoHeader videoHeader = BytesToStruct<VideoHeader>(video_header_bytes);
                if (videoHeader.type == 2)
                {
                    byte[] video_image_bytes = await tcp_recv(stream, (int)(videoHeader.len) - 4);

                    BitmapImage bitmap = new BitmapImage();
                    bitmap.BeginInit();
                    bitmap.StreamSource = new MemoryStream(video_image_bytes);
                    bitmap.EndInit();
                    bitmap.Freeze();

                    if (videoHeader.cameraId == uint.Parse(Url1))
                    {
                        Image1 = bitmap;
                    }
                    else if (videoHeader.cameraId == uint.Parse(Url2))
                    {
                        Image2 = bitmap;
                    }
                    else if (videoHeader.cameraId == uint.Parse(Url3))
                    {
                        Image3 = bitmap;
                    }
                    else if (videoHeader.cameraId == uint.Parse(Url4))
                    {
                        Image4 = bitmap;
                    }
                    else
                    {

                    }
                }
            }
        }

        public override void Stop()
        {
            cancellationTokenSource.Cancel();

            //发送关闭图像命令
            VideoCmd videoCmd = new VideoCmd(1, 5, RoomId, 0);
            byte[] videoCmd_bytes = StructToBytes<VideoCmd>(videoCmd);
            stream.WriteAsync(videoCmd_bytes, 0, videoCmd_bytes.Length);

            stream?.Close(); 
            tcpClient?.Close();
        }

        //结构体转数组
        private byte[] StructToBytes<T>(T instance)where T:struct
        {
            int size = Marshal.SizeOf(instance);
            byte[] temp = new byte[size];

            IntPtr ptr = Marshal.AllocHGlobal(size);
            Marshal.StructureToPtr(instance,ptr,true);
            Marshal.Copy(ptr,temp,0,size);
            Marshal.FreeHGlobal(ptr);
            return temp;
        }

        //数组转结构体
        private T BytesToStruct<T>(byte[] data)where T:struct
        {
            T t = new T();
            IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(t));
            Marshal.Copy(data,0,ptr,data.Length);
            t = (T)Marshal.PtrToStructure(ptr,t.GetType());
            Marshal.FreeHGlobal(ptr);
            return t;
        }

    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct Role
    {
        public byte type;
        public UInt32 len;
        public byte role;

        public Role(byte type,UInt32 len,byte role)
        {
            this.type = type;
            this.len = len;
            this.role = role;
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct VideoCmd
    {
        public byte type;
        public UInt32 len;
        public UInt32 roomId;
        public byte isOpen;

        public VideoCmd(byte type,UInt32 len,UInt32 roomId,byte isOpen)
        {
            this.type = type;
            this.len = len;
            this.roomId = roomId;
            this.isOpen = isOpen;
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct VideoHeader
    {
        public byte type;
        public UInt32 len;
        public UInt32 cameraId;

        public VideoHeader(byte type,UInt32 len, UInt32 cameraId)
        {
            this.type = type;
            this.len = len;
            this.cameraId = cameraId;
        }
    }
}