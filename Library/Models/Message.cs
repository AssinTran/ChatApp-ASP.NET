using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public partial class Message
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

        [Required]
        [StringLength(255)]
        public required string Content { get; set; }

        [Required]
        public DateTime Time { get; set; }

        public virtual IEnumerable<ReactIcon>? Reacts { get; set; }

    }
}
