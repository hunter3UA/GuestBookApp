using DogApp.Іnfrastructure.Configurations;
using Gb.Domain.Constants;
using Gb.Domain.DbEntities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gb.Infrastructure.Configurations
{
    public class CommentTypeConfiguration : BaseEntityTypeConfiguration<CommentDb>
    {

        public override void Configure(EntityTypeBuilder<CommentDb> builder)
        {
            base.Configure(builder);

            builder.Property(e => e.Name)
                .HasMaxLength(EntityConstants.CommentConstants.MaxNameLength)
                .IsRequired();

            builder.Property(e => e.Text)
                .HasMaxLength(EntityConstants.CommentConstants.MaxCommentLength)
                .IsRequired();


            builder.HasData(
                CreateComment("John1", "Niccccccccccccccccceeeeeeeeeeeee"),
                CreateComment("John2", "Niccccccccccccccccceeeeeeeeeeeee"),
                CreateComment("John3", "Niccccccccccccccccceeeeeeeeeeeee"),
                CreateComment("John4", "Niccccccccccccccccceeeeeeeeeeeee"),
                CreateComment("John5", "Niccccccccccccccccceeeeeeeeeeeee"),
                CreateComment("John6", "Niccccccccccccccccceeeeeeeeeeeee"),
                CreateComment("John7", "Niccccccccccccccccceeeeeeeeeeeee"),
                CreateComment("John8", "Niccccccccccccccccceeeeeeeeeeeee"),
                CreateComment("John9", "Niccccccccccccccccceeeeeeeeeeeee"),
                CreateComment("John10", "Niccccccccccccccccceeeeeeeeeeeee"),
                CreateComment("John11", "Niccccccccccccccccceeeeeeeeeeeee"),
                CreateComment("John12", "Niccccccccccccccccceeeeeeeeeeeee"),
                CreateComment("John13", "Niccccccccccccccccceeeeeeeeeeeee"),
                CreateComment("John14", "Niccccccccccccccccceeeeeeeeeeeee"),
                CreateComment("John15", "Niccccccccccccccccceeeeeeeeeeeee")
                );

        }

        private CommentDb CreateComment(string name, string text)
        {
            return new CommentDb
            {
                Id = Guid.NewGuid(),
                Name = name,
                Text = text
            };
        }
    }
}
