﻿using System.Data.Entity.ModelConfiguration.Conventions;

namespace Core.Conventions
{
    public class NameConvention : Convention
    {
        public NameConvention()
        {
            Properties<string>().Where(p=>p.Name == "Name").Configure(p=>p.IsRequired().HasMaxLength(50));
        }
    }
}