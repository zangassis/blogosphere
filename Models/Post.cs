using System.ComponentModel.DataAnnotations;

namespace Blogosphere.Models;

public class Post
{
    [Key]
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime CreatedAt { get; set; }
    public string Author { get; set; }
    public ICollection<Comment> Comments { get; set; }

    public Post()
    {
        Id = Guid.NewGuid();
        CreatedAt = DateTime.UtcNow;
    }
}