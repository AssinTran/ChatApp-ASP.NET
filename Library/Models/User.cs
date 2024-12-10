using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public partial class User
    {
        [Key]
        [Required]
        [Length(32, 32, ErrorMessage = "ID user must have 32 character!")]
        public required string Id { get; set; }

        [Required]
        [Length(2, 20)]
        public required string Firstname { get; set; }

        [Required]
        [Length(2, 20)]
        public required string Lastname { get; set; }

        [Required]
        [Length(2, 20)]
        public required string Gender { get; set; }

        [Required]
        public DateOnly BirthDate { get; set; }

        [Required]
        [StringLength(200)]
        public required string Avatar { get; set; }

        [Required]
        [StringLength(200)]
        public required string Banner { get; set; }

        [Required]
        [Length(6, 32, ErrorMessage = "Username must have length in range 6 to 32 characters!")]
        public required string Username { get; set; }

        [ForeignKey(nameof(Username))]
        public virtual Account Account { get; set; } = default!;

        public virtual IEnumerable<FriendShip>? Friends { get; set; }
        public virtual IEnumerable<Conversation>? Conversations { get; set; }
        public virtual IEnumerable<GroupConversation>? GroupConversations { get; set; }
    }

    public class FriendShip
    {
        [Key]
        [Required]
        [Length(32, 32)]
        public required string Id { get; set; }

        [Required]
        [Length(32, 32)]
        public string UserId { get; set; } = default!;

        [ForeignKey(nameof(UserId))]
        public virtual User User { get; set; } = default!;

        [Required]
        [Length(32, 32)]
        public required string FriendId { get; set; }

        [ForeignKey(nameof(FriendId))]
        public virtual User Friend { get; set; } = default!;
    }
}
