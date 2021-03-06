﻿using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Ioc;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace AIForAgedClient.ViewModel
{
    public abstract class BaseFourVideoVM : ViewModelBase
    {
        #region 设置Image Source属性
        private BitmapSource _img1;
        public BitmapSource Image1
        {
            get
            {
                return _img1;
            }
            set
            {
                if (_img1 != value)
                {
                    _img1 = value;
                    RaisePropertyChanged(nameof(Image1));
                }
            }
        }

        private BitmapSource _img2;
        public BitmapSource Image2
        {
            get
            {
                return _img2;
            }
            set
            {
                if (_img2 != value)
                {
                    _img2 = value;
                    RaisePropertyChanged(nameof(Image2));
                }
            }
        }

        private BitmapSource _img3;
        public BitmapSource Image3
        {
            get
            {
                return _img3;
            }
            set
            {
                if (_img3 != value)
                {
                    _img3 = value;
                    RaisePropertyChanged(nameof(Image3));
                }
            }
        }

        private BitmapSource _img4;
        public BitmapSource Image4
        {
            get
            {
                return _img4;
            }
            set
            {
                if (_img4 != value)
                {
                    _img4 = value;
                    RaisePropertyChanged(nameof(Image4));
                }
            }
        }
        #endregion

        #region 设置Image Row 和Image Column 属性
        private int _img1Row = 0;
        public int Img1Row
        {
            get
            {
                return _img1Row;
            }
            set
            {
                if (_img1Row != value)
                {
                    _img1Row = value;
                    RaisePropertyChanged(nameof(Img1Row));
                }
            }
        }
        private int _img1Column = 0;
        public int Img1Column
        {
            get
            {
                return _img1Column;
            }
            set
            {
                if (_img1Column != value)
                {
                    _img1Column = value;
                    RaisePropertyChanged(nameof(Img1Column));
                }
            }
        }

        private int _img2Row = 0;
        public int Img2Row
        {
            get
            {
                return _img2Row;
            }
            set
            {
                if (_img2Row != value)
                {
                    _img2Row = value;
                    RaisePropertyChanged(nameof(Img2Row));
                }
            }
        }
        private int _img2Column = 1;
        public int Img2Column
        {
            get
            {
                return _img2Column;
            }
            set
            {
                if (_img2Column != value)
                {
                    _img2Column = value;
                    RaisePropertyChanged(nameof(Img2Column));
                }
            }
        }

        private int _img3Row = 1;
        public int Img3Row
        {
            get
            {
                return _img3Row;
            }
            set
            {
                if (_img3Row != value)
                {
                    _img3Row = value;
                    RaisePropertyChanged(nameof(Img3Row));
                }
            }
        }
        private int _img3Column = 0;
        public int Img3Column
        {
            get
            {
                return _img3Column;
            }
            set
            {
                if (_img3Column != value)
                {
                    _img3Column = value;
                    RaisePropertyChanged(nameof(Img3Column));
                }
            }
        }

        private int _img4Row = 1;
        public int Img4Row
        {
            get
            {
                return _img4Row;
            }
            set
            {
                if (_img4Row != value)
                {
                    _img4Row = value;
                    RaisePropertyChanged(nameof(Img4Row));
                }
            }
        }

        private int _img4Column = 1;
        public int Img4Column
        {
            get
            {
                return _img4Column;
            }
            set
            {
                if (_img4Column != value)
                {
                    _img4Column = value;
                    RaisePropertyChanged(nameof(Img4Column));
                }
            }
        }
        #endregion

        #region 设置Image RowSpan 和 ColumnSpan属性
        private int _img1RowSpan = 1;
        public int Img1RowSpan
        {
            get
            {
                return _img1RowSpan;
            }
            set
            {
                if (_img1RowSpan != value)
                {
                    _img1RowSpan = value;
                    RaisePropertyChanged(nameof(Img1RowSpan));
                }
            }
        }

        private int _img1ColumnSpan = 1;
        public int Img1ColumnSpan
        {
            get
            {
                return _img1ColumnSpan;
            }
            set
            {
                if (_img1ColumnSpan != value)
                {
                    _img1ColumnSpan = value;
                    RaisePropertyChanged(nameof(Img1ColumnSpan));
                }
            }
        }

        private int _img2RowSpan = 1;
        public int Img2RowSpan
        {
            get
            {
                return _img2RowSpan;
            }
            set
            {
                if (_img2RowSpan != value)
                {
                    _img2RowSpan = value;
                    RaisePropertyChanged(nameof(Img2RowSpan));
                }
            }
        }

        private int _img2ColumnSpan = 1;
        public int Img2ColumnSpan
        {
            get
            {
                return _img2ColumnSpan;
            }
            set
            {
                if (_img2ColumnSpan != value)
                {
                    _img2ColumnSpan = value;
                    RaisePropertyChanged(nameof(Img2ColumnSpan));
                }
            }
        }

        private int _img3RowSpan = 1;
        public int Img3RowSpan
        {
            get
            {
                return _img3RowSpan;
            }
            set
            {
                if (_img3RowSpan != value)
                {
                    _img3RowSpan = value;
                    RaisePropertyChanged(nameof(Img3RowSpan));
                }
            }
        }

        private int _img3ColumnSpan = 1;
        public int Img3ColumnSpan
        {
            get
            {
                return _img3ColumnSpan;
            }
            set
            {
                if (_img3ColumnSpan != value)
                {
                    _img3ColumnSpan = value;
                    RaisePropertyChanged(nameof(Img3ColumnSpan));
                }
            }
        }

        private int _img4RowSpan = 1;
        public int Img4RowSpan
        {
            get
            {
                return _img4RowSpan;
            }
            set
            {
                if (_img4RowSpan != value)
                {
                    _img4RowSpan = value;
                    RaisePropertyChanged(nameof(Img4RowSpan));
                }
            }
        }

        private int _img4ColumnSpan = 1;
        public int Img4ColumnSpan
        {
            get
            {
                return _img4ColumnSpan;
            }
            set
            {
                if (_img4ColumnSpan != value)
                {
                    _img4ColumnSpan = value;
                    RaisePropertyChanged(nameof(Img4ColumnSpan));
                }
            }
        }
        #endregion

        #region 设置Image Visibility属性
        private Visibility _img1Visibility = Visibility.Visible;
        public Visibility Img1Visibility
        {
            get
            {
                return _img1Visibility;
            }
            set
            {
                if (_img1Visibility != value)
                {
                    _img1Visibility = value;
                    RaisePropertyChanged(nameof(Img1Visibility));
                }
            }
        }

        private Visibility _img2Visibility = Visibility.Visible;
        public Visibility Img2Visibility
        {
            get
            {
                return _img2Visibility;
            }
            set
            {
                if (_img2Visibility != value)
                {
                    _img2Visibility = value;
                    RaisePropertyChanged(nameof(Img2Visibility));
                }
            }
        }

        private Visibility _img3Visibility = Visibility.Visible;
        public Visibility Img3Visibility
        {
            get
            {
                return _img3Visibility;
            }
            set
            {
                if (_img3Visibility != value)
                {
                    _img3Visibility = value;
                    RaisePropertyChanged(nameof(Img3Visibility));
                }
            }
        }

        private Visibility _img4Visibility = Visibility.Visible;
        public Visibility Img4Visibility
        {
            get
            {
                return _img4Visibility;
            }
            set
            {
                if (_img4Visibility != value)
                {
                    _img4Visibility = value;
                    RaisePropertyChanged(nameof(Img4Visibility));
                }
            }
        }
        #endregion

        #region 设置Image doubleClick 命令
        private RelayCommand _img1Dbclick;
        public ICommand Img1DoubleClickCmd
        {
            get
            {
                if (_img1Dbclick == null)
                    _img1Dbclick = new RelayCommand(() => { Img1DoubleClick(); });
                return _img1Dbclick;
            }
        }

        private RelayCommand _img2Dbclick;
        public ICommand Img2DoubleClickCmd
        {
            get
            {
                if (_img2Dbclick == null)
                    _img2Dbclick = new RelayCommand(() => { Img2DoubleClick(); });
                return _img2Dbclick;
            }
        }

        private RelayCommand _img3Dbclick;
        public ICommand Img3DoubleClickCmd
        {
            get
            {
                if (_img3Dbclick == null)
                    _img3Dbclick = new RelayCommand(() => { Img3DoubleClick(); });
                return _img3Dbclick;
            }
        }

        private RelayCommand _img4Dbclick;
        public ICommand Img4DoubleClickCmd
        {
            get
            {
                if (_img4Dbclick == null)
                    _img4Dbclick = new RelayCommand(() => { Img4DoubleClick(); });
                return _img4Dbclick;
            }
        }
        #endregion


        public string Url1 { get; set; }
        public string Url2 { get; set; }
        public string Url3 { get; set; }
        public string Url4 { get; set; }

        [PreferredConstructor]
        public BaseFourVideoVM()
        {

        }
        public BaseFourVideoVM(string url1, string url2 = null, string url3 = null, string url4 = null)
        {
            Url1 = url1;
            Url2 = url2;
            Url3 = url3;
            Url4 = url4;
        }

        public abstract void Start();

        public abstract void Stop();

        private void Img1DoubleClick()
        {
            System.Console.WriteLine("Image1 Double click.");

            if (Img1ColumnSpan == 1)
            {
                Img2Visibility = Visibility.Collapsed;
                Img3Visibility = Visibility.Collapsed;
                Img4Visibility = Visibility.Collapsed;
                Img1ColumnSpan = 2;
                Img1RowSpan = 2;
            }
            else
            {
                Img2Visibility = Visibility.Visible;
                Img3Visibility = Visibility.Visible;
                Img4Visibility = Visibility.Visible;
                Img1RowSpan = 1;
                Img1ColumnSpan = 1;
            }
        }

        private void Img2DoubleClick()
        {
            System.Console.WriteLine("Image2 Double click.");
            if (Img2ColumnSpan == 1)
            {
                Img2Row = 0;
                Img2Column = 0;
                Img1Visibility = Visibility.Collapsed;
                Img3Visibility = Visibility.Collapsed;
                Img4Visibility = Visibility.Collapsed;
                Img2ColumnSpan = 2;
                Img2RowSpan = 2;
            }
            else
            {
                Img2Row = 0;
                Img2Column = 1;
                Img1Visibility = Visibility.Visible;
                Img3Visibility = Visibility.Visible;
                Img4Visibility = Visibility.Visible;
                Img2RowSpan = 1;
                Img2ColumnSpan = 1;
            }
        }

        private void Img3DoubleClick()
        {
            System.Console.WriteLine("Image3 Double click.");
            if (Img3ColumnSpan == 1)
            {
                Img3Row = 0;
                Img3Column = 0;
                Img1Visibility = Visibility.Collapsed;
                Img2Visibility = Visibility.Collapsed;
                Img4Visibility = Visibility.Collapsed;
                Img3ColumnSpan = 2;
                Img3RowSpan = 2;
            }
            else
            {
                Img3Row = 1;
                Img3Column = 0;
                Img1Visibility = Visibility.Visible;
                Img2Visibility = Visibility.Visible;
                Img4Visibility = Visibility.Visible;
                Img3RowSpan = 1;
                Img3ColumnSpan = 1;
            }
        }

        private void Img4DoubleClick()
        {
            System.Console.WriteLine("Image4 Double click.");
            if (Img4ColumnSpan == 1)
            {
                Img4Row = 0;
                Img4Column = 0;
                Img1Visibility = Visibility.Collapsed;
                Img3Visibility = Visibility.Collapsed;
                Img2Visibility = Visibility.Collapsed;
                Img4ColumnSpan = 2;
                Img4RowSpan = 2;
            }
            else
            {
                Img4Row = 1;
                Img4Column = 1;
                Img1Visibility = Visibility.Visible;
                Img3Visibility = Visibility.Visible;
                Img2Visibility = Visibility.Visible;
                Img4RowSpan = 1;
                Img4ColumnSpan = 1;
            }
        }
    }
}
