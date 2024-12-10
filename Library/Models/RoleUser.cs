using System.ComponentModel.DataAnnotations;

namespace Models
{
    public partial class RoleUser
    {
        [Key]
        [Length(32, 32)]
        [Required]
        public string Id { get; set; } = default!;

        [Required]
        [Length(2,20, ErrorMessage = "Name of role user must in range of 2 to 20!")]
        public string Name { get; set; } = default!;

        public virtual IEnumerable<Account>? Accounts { get; set; }
    }
}
