using System.Data.Entity.ModelConfiguration;
using Cookbook.Db.EntityTypes;
using Cookbook.Objects;

namespace Cookbook.Db.Extensions {
    internal static class EntityTypeConfigurationExtensions {
        public static void ConfigureIDbItem<T>(this EntityTypeConfiguration<T> configuration) where T : class, IDbItem {
            configuration.HasKey(i => i.Id);
        }

        public static void ConfigureITracable<T>(this EntityTypeConfiguration<T> configuration)
            where T : class, ITracable {
            configuration.Property(t => t.CreatedOn).HasColumnName("CreatedOn").IsRequired();
            configuration.Property(t => t.UpdatedOn).HasColumnName("UpdatedOn").IsRequired();
        }

        public static void ConfigureITrackable<T>(this EntityTypeConfiguration<T> configuration)
            where T : class, ITrackable {
            configuration.HasRequired(t => t.CreatedBy).WithOptional();
            configuration.HasRequired(t => t.UpdatedBy).WithOptional();
        }

        public static void ConfigureAll<T>(this EntityTypeConfiguration<T> configuration)
            where T : class, IDbItem, ITrackable, ITracable {
            configuration.ConfigureIDbItem();
            configuration.ConfigureITracable();
            configuration.ConfigureITrackable();
        }
    }
}