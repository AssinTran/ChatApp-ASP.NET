using System.ComponentModel.DataAnnotations;

namespace Models
{
    public partial class GroupConversation
    {
        [Key]
        [Required]
        [Length(32, 32)]
        public required string Id { get; set; }

        public virtual IEnumerable<GroupMember>? Members { get; set; }
        public virtual IEnumerable<Message>? Messages { get; set; }
    }
}
