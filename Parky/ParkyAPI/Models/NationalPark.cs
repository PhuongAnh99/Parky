using System.ComponentModel.DataAnnotations;

namespace ParkyAPI.Models
{
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public class NationalPark
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string State { get; set; }
        public DateTime Created { get; set; }
        public byte[] Picture { get; set; }
        public DateTime Established { get; set; }
    }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
}
