using System.ComponentModel.DataAnnotations;

namespace Models
{
    public partial class GroupRole
    {
        [Key]
        [Required]
        [Length(32,32)]
        public required string Id { get; set; }

        [Required]
        [StringLength(50)]
        public required string Name { get; set; }

        public virtual IEnumerable<GroupMember>? Members { get; set; }
    }
}
