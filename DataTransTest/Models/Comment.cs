using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace DataTransTest.Models
{
    public class Comment
    {

        public int Id { get; set; }

        [MaxLength(2500)]
        public string Content { get; set; } = string.Empty;        

        [Display(Name = "Post")]
        public int PostId { get; set; }
        public Post? Post { get; set; }

        [Display(Name = "User")]
        public string AppUserId { get; set; } = string.Empty;
        public AppUser? AppUser { get; set; }
    }
}
