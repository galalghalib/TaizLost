using System.ComponentModel.DataAnnotations;

namespace TaizlostSmart.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        // 0 = User , 1 = Admin (مستقبلاً)
        public int Role { get; set; } = 0;
    }
}
