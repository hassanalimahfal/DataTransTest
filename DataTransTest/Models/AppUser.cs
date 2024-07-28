using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace DataTransTest.Models
{
    public class AppUser : IdentityUser
    {
        [MaxLength(250)]
        public string FullName { get; set; } = string.Empty;

        public ICollection<Post> Posts{ get; set; } = new List<Post>();

        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}
