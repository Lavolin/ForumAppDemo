using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ForumAppDemo.Models
{
    public class PostViewModel
    {
        [UIHint("hidden")]
        public int Id { get; set; }

        [DisplayName("Заглавие")]
        [Required(ErrorMessage = "Полето {0} е задължително")]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "Полето {0} трябва да е между {2} и {1} символа")]
        public string Title { get; set; }

        [DisplayName("Съдържание")]
        [Required(ErrorMessage = "Полето {0} е задължително")]
        [StringLength(1500, MinimumLength = 30, ErrorMessage = "Полето {0} трябва да е между {2} и {1} символа")]
        public string Content { get; set; }
    }
}
