using ChatApp.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace ChatApp.Api.Data;

public class ChatAppDbContext(DbContextOptions<ChatAppDbContext> options) : DbContext(options)
{
    public DbSet<User> Users => Set<User>();
    public DbSet<Message> Messages => Set<Message>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ChatAppDbContext).Assembly);
    }
}
