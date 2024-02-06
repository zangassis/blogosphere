using Blogosphere.Models;
using Faker;

namespace Blogosphere.Data
{
    public static class DataSeeder
    {
        public static void SeedData(BlogDbContext dbContext)
        {
            if (!dbContext.Posts.Any())
            {
                for (int i = 1; i <= 10; i++)
                {
                    var post = new Post
                    {
                        Title = Lorem.Sentence(),
                        Content = Lorem.Paragraphs(3).FirstOrDefault(),
                        Author = Name.FullName(),
                        CreatedAt = DateTime.Now,
                    };

                    dbContext.Posts.Add(post);

                    for (int j = 1; j <= 10; j++)
                    {
                        var comment = new Comment
                        {
                            Content = Lorem.Sentence(),
                            Author = Name.FullName(),
                            CreatedAt = DateTime.Now,
                            Post = post
                        };

                        dbContext.Comments.Add(comment);
                    }
                }
                dbContext.SaveChanges();
            }
        }
    }
}
