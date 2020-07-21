﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgedPoseDatabse.Models
{
    [Table("PoseInfo")]
    public class PoseInfo
    {
        public long AgesInfoId { get; set; }

        [Column(TypeName = "Date")]
        public DateTime Date { get; set; }

        public int TimeStand { get; set; }

        public int TimeSit { get; set; }
        public int TimeLie { get; set; }
        public int TimeDown { get; set; }
        public int TimeOther { get; set; }
        public TimeSpan TimeIn { get; set; }
    }
}
