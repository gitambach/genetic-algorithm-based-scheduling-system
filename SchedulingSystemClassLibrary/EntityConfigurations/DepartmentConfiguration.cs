﻿using SchedulingSystemClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingSystemClassLibrary.EntityConfigurations
{
    public class DepartmentConfiguration : EntityTypeConfiguration<Department>
    {
        public DepartmentConfiguration()
        {
            //this.HasOptional(d => d.DepartmentHead)
            //    .WithRequired(i => i.Department)
            //    .WillCascadeOnDelete(false);
        }
    }
}
