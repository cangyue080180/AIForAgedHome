﻿using GalaSoft.MvvmLight;
using System.ComponentModel.DataAnnotations;

namespace BackendClient.Model
{
    public class CameraInfoVM : ViewModelValidationBase
    {
        public CameraInfoVM()
        {
            ValidationKey(new string[] { nameof(IpAddress), nameof(VideoAddress),nameof(FactoryInfo) });
            this.PropertyChanged += delegate { IsBeginValidation = true; };
        }
        public long Id { get; set; }

        private string _factoryInfo;
        [StringLength(100, ErrorMessage = "最大长度100字符")]
        public string FactoryInfo
        {
            get => _factoryInfo;
            set => Set(nameof(FactoryInfo), ref _factoryInfo, value);
        }

        private string _IpAddress;
        [StringLength(15,ErrorMessage ="IP地址不正确")]
        public string IpAddress
        {
            get => _IpAddress;
            set => Set(() => IpAddress, ref _IpAddress, value);
        }

        private string _videoAddress;
        [Required(ErrorMessage ="不能为空")]
        [StringLength(100,ErrorMessage ="最大长度100字符")]
        public string VideoAddress
        {
            get => _videoAddress;
            set => Set(() => VideoAddress, ref _videoAddress, value);
        }

        public long ServerInfoId
        {
            get; set;
        }

        private ServerInfoVM _serverInfo;
        public ServerInfoVM ServerInfo
        {
            get => _serverInfo;
            set => Set(() => ServerInfo, ref _serverInfo, value);
        }

        public long RoomInfoId { get; set; }

        private RoomInfoVM _roomInfo;
        public RoomInfoVM RoomInfo
        {
            get => _roomInfo;
            set => Set(() => RoomInfo, ref _roomInfo, value);
        }
    }
}
