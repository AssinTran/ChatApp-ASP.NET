using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class ReactIcon
    {
        [Key]
        [Required]
        [Length(32, 32)]
        public required string Id { get; set; }

        [Required]
        [Length(2,10)]
        public required string Name { get; set; }

        [Required]
        [StringLength(255)]
        public required string Image { get; set; }
    }
}
