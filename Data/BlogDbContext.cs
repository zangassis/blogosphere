namespace Blogosphere.Data;

using Blogosphere.Models;
using Microsoft.EntityFrameworkCore;

public class BlogDbContext : DbContext
{
    public DbSet<Post> Posts { get; set; }
    public DbSet<Comment> Comments { get; set; }

    public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
    {
    }
}