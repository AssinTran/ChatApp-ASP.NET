using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public partial class Conversation
    {
        [Key]
        [Required]
        [Length(32, 32)]
        public required string Id { get; set; }

        [Required]
        [Length(32, 32)]
        public string SenderId { get; set; } = default!;

        [ForeignKey(nameof(SenderId))]
        public virtual User Sender { get; set; } = null!;

        [Required]
        [Length(32, 32)]
        public string ReceiverId { get; set; } = default!;

        [ForeignKey(nameof(ReceiverId))]
        public User Receiver { get; set; } = null!;

        public virtual IEnumerable<Message>? Messages { get; set; }
    }
}
