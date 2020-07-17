﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AgedPoseDatabse.Models
{
    [Table("CameraInfo")]
    public class CameraInfo
    {
        public long Id { get; set; }
        [StringLength(100)]
        public string FactoryInfo { get; set; }
        [StringLength(15)]
        public string IpAddress { get; set; }
        [StringLength(100)]
        public string VideoAddress { get; set; }
        public long ServerInfoId { get; set; }
        public ServerInfo ServerInfo { get; set; }

        public long RoomInfoId { get; set; }
        public RoomInfo RoomInfo { get; set; }
    }
}
