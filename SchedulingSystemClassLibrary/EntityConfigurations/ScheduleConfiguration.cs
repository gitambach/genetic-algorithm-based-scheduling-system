﻿using SchedulingSystemClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SchedulingSystemClassLibrary.EntityConfigurations
{
    public class ScheduleConfiguration : EntityTypeConfiguration<Schedule>
    {
        public ScheduleConfiguration()
        {
            this.Ignore(s => s.MaximumScore)
                .Ignore(s => s.scheduleEntries);

            //this.HasRequired(s => s.Section)
            //    .WithRequiredDependent()
            //    .WillCascadeOnDelete(false);
        }
    }
}
