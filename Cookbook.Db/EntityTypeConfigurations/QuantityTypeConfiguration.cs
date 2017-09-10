using System.Data.Entity.ModelConfiguration;
using Cookbook.Db.EntityTypes;
using Cookbook.Db.Extensions;

namespace Cookbook.Db.EntityTypeConfigurations {
    internal class QuantityTypeConfiguration : EntityTypeConfiguration<QuantityType> {
        public QuantityTypeConfiguration() {
            this.ConfigureAll();

            Property(qt => qt.Name)
                .HasColumnName("Name")
                .IsRequired()
                .HasMaxLength(ConfigurationValues.NameStringLength);
            HasOptional(qt => qt.BaseQuantity).WithOptionalDependent();
        }
    }
}