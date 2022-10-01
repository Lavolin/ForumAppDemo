using ForumAppDemo.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ForumAppDemo.Data.Configure
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            List<Post> posts = GetPosts();
            builder.HasData(posts);
        }

        private List<Post> GetPosts()
        {
            return new List<Post>()
            {
                new Post()
                {
                    Id = 1,
                    Title = "My first post",
                    Content = "This is my first post"
                },
                new Post()
                {
                    Id = 2,
                    Title = "My second post",
                    Content = "This is my second post and more"
                },
                new Post()
                {
                    Id = 3,
                    Title = "My third post",
                    Content = "This is my third post whatever"
                }
            };
        }
    }
}
