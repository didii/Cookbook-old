﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cookbook.Db.EntityTypes;
using Cookbook.Db.Extensions;

namespace Cookbook.Db.EntityTypeConfigurations {
    internal class IngredientConfiguration : EntityTypeConfiguration<Ingredient> {
        public IngredientConfiguration() {
            this.ConfigureAll();
            Property(i => i.QuantityValue).HasColumnName("QuantityValue").IsRequired();
            HasRequired(i => i.Food).WithRequiredDependent();
            HasRequired(i => i.Quantity).WithRequiredDependent();
            HasMany(i => i.Comments).WithRequired();
        }
    }
}
