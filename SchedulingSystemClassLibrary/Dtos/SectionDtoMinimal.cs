﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingSystemClassLibrary.Dtos
{
    public class SectionDtoMinimal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int EntranceYear { get; set; }
        public int StudentCount { get; set; }
        public byte CurrentYear { get; set; }
    }
}
