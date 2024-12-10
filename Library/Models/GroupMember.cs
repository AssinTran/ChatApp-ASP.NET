using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public partial class GroupMember
    {
        [Key]
        [Required]
        [Length(32, 32)]
        public required string Id { get; set; }

        [ForeignKey(nameof(Id))]
        public virtual User User { get; set; } = null!;

        [Length(32, 32)]
        public string? RoleId { get; set; }

        [ForeignKey(nameof(RoleId))]
        public virtual GroupRole? Role { get; set; }
    }
}
