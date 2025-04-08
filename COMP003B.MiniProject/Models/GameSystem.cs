using System.ComponentModel.DataAnnotations;

namespace COMP003B.MiniProject.Models
{
    public class GameSystem
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Platform { get; set; }

        [Required]
        [StringLength(300)]
        public string Summary { get; set; }

        [Range(100, 1000)]
        public decimal Price { get; set; }

        [Range(100, 1000)]
        public decimal StorageGB { get; set; }
    }
}
