using System.Data.Entity.ModelConfiguration;
using Cookbook.Db.EntityTypes;
using Cookbook.Db.Extensions;

namespace Cookbook.Db.EntityTypeConfigurations {
    internal class CommentConfiguration : EntityTypeConfiguration<Comment> {
        public CommentConfiguration() {
            this.ConfigureAll();

            Property(c => c.Message)
                .HasColumnName("Message")
                .IsRequired()
                .HasMaxLength(ConfigurationValues.DescriptionStringLength);
            HasOptional(c => c.Reply).WithOptionalPrincipal();
        }
    }
}
