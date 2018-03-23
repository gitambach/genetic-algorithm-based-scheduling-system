﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingSystem.Models
{
    public class Day
    {
        public int Id { get; set; }
        public string DayName { get; set; }
        public int DayNumber { get; set; }
        public Schedule Schedule { get; set; }
        public int ScheduleId { get; set; }
        public virtual List<ScheduleEntry> Periods { get; set; } = new List<ScheduleEntry>(GlobalConfig.NUM_OF_PERIODS); 
    }
}
