﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Cookbook.Db.EntityTypes;
using Cookbook.Db.Extensions;

namespace Cookbook.Db.EntityTypeConfigurations {
    internal class RecipeConfiguration : EntityTypeConfiguration<Recipe> {
        public RecipeConfiguration() {
            this.ConfigureAll();

            Property(r => r.Name).HasColumnName("Name").HasMaxLength(ConfigurationValues.NameStringLength).IsRequired();
            Property(r => r.Description)
                .HasColumnName("Description")
                .HasMaxLength(ConfigurationValues.DescriptionStringLength)
                .IsOptional();
            HasRequired(r => r.RecipeInfo).WithRequiredDependent();
            HasMany(r => r.Ingredients).WithOptional();
            HasRequired(r => r.HowTo).WithMany();
            HasMany(r => r.Comments).WithRequired();
        }
    }
}