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
                CreateComment("John", "This is nice place!"),
                CreateComment("Ray", "Everything is fine"),
                CreateComment("Alex", "This is the best place i have ever seen"),
                CreateComment("Sam", "You should visit this place"),
                CreateComment("James", "Not bad, everything is ok!"),
                CreateComment("Ann", "Niccccccccccccccccceeeeeeeeeeeee"),
                CreateComment("Jason", "This is nice place!"),
                CreateComment("Alice", "This is the best place i have ever seen"),
                CreateComment("Jim", "Everything is fine"),
                CreateComment("Jakob", "Not bad, everything is ok!"),
                CreateComment("Susan", "You should visit this place"),
                CreateComment("Ron", "Good place, i will come again"),
                CreateComment("Andy", "You should visit this place"),
                CreateComment("Enthony", "Good place, i will come again"),
                CreateComment("Bred", "This is nice place!")
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