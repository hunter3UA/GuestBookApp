using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Gb.Domain.DbEntities;

namespace DogApp.Іnfrastructure.Configurations
{
    public class BaseEntityTypeConfiguration<TEntity> : IEntityTypeConfiguration<TEntity>
        where TEntity : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            
            builder.HasKey(entity => entity.Id);
            builder.Property(e => e.Id)
                .HasColumnType("uniqueidentifier")
                .IsRequired();
            builder.Property(e => e.CreatedAt)
                .HasDefaultValueSql("Getutcdate()");
        }
    }
}