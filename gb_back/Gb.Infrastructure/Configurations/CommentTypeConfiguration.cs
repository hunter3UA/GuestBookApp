using DogApp.Іnfrastructure.Configurations;
using Gb.Domain.Constants;
using Gb.Domain.DbEntities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gb.Infrastructure.Configurations
{
    public class CommentTypeConfiguration : BaseEntityTypeConfiguration<DbComment>
    {

        public override void Configure(EntityTypeBuilder<DbComment> builder)
        {
            base.Configure(builder);

            builder.Property(e => e.Name)
                .HasMaxLength(EntityConstants.CommentConstants.MaxNameLength)
                .IsRequired();

            builder.Property(e => e.Text)
                .HasMaxLength(EntityConstants.CommentConstants.MaxCommentLength)
                .IsRequired();
        }
    }
}
