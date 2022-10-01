using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static ForumAppDemo.Constants.DataConstants.Post;

namespace ForumAppDemo.Data.Models
{
    [Comment("Publish Posts")]
    public class Post
    {
        [Comment("Post Identifier")]
        [Key]
        public int Id { get; set; }

        [Comment("Post title")]
        [Required]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; } = null!;

        [Comment("Content")]
        [Required]
        [MaxLength(ContextMaxLength)]
        public string Content { get; set; } = null!;
    }
}
