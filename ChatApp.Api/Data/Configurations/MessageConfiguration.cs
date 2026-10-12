using ChatApp.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChatApp.Api.Data.Configurations;

public class MessageConfiguration : IEntityTypeConfiguration<Message>
{
    public void Configure(EntityTypeBuilder<Message> builder)
    {
        builder.ToTable("messages");
        
        builder.HasKey(m => m.Id);

        builder.Property(m => m.Input)
            .IsRequired()
            .HasMaxLength(2000);

        builder.Property(m => m.CreatedAt)
            .HasDefaultValueSql("NOW()");
    }
}