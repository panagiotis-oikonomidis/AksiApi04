using AksiApi.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AksiApi.EntityConfigurations
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.ApplicationName).IsRequired().HasMaxLength(200);
            builder.Property(e => e.Email).IsRequired().HasMaxLength(200);
            builder.Property(e => e.Filename).HasMaxLength(300);
            builder.Property(e => e.Url).IsRequired().HasMaxLength(200);
            builder.Property(e => e.Inception).IsRequired();
            builder.Property(e => e.Amount).IsRequired();
            builder.Property(e => e.Allocation).HasColumnType("decimal(18, 2)");
        }
    }
}
