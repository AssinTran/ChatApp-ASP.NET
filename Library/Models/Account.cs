using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public partial class Account
    {
        [Key]
        [Required]
        [Length(6, 32, ErrorMessage = "Username must have 6 to 32 characters!")]
        public required string Username { get; set; }

        [Required]
        [Length(8, 32, ErrorMessage = "Password must have 8 to 32 characters!")]
        public required string Password { get; set; }

        [Compare("Password")]
        public string? ConfirmPassword { get; set; }

        [Required]
        [StringLength(100)]
        public required string Email { get; set; }

        [Required]
        [DefaultValue(true)]
        public bool Status { get; set; }

        [Required]
        [DefaultValue(false)]
        public bool Active { get; set; }

        [Required]
        [Length(32, 32, ErrorMessage = "Length of role id must have 32 characters")]
        public required string RoleId { get; set; }

        [ForeignKey(nameof(RoleId))]
        public virtual RoleUser? Role { get; set; }

        public virtual IEnumerable<User>? Users { get; set; }
    }
}
