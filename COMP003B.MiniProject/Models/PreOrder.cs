using System.ComponentModel.DataAnnotations;

namespace COMP003B.MiniProject.Models
{
    public class PreOrder
    {
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Platform { get; set; }

        [Required]
        [Range(1, 3, ErrorMessage = "Max limit per customer is 3.")]
        public int OrderUnit { get; set; }

        public string? Discount { get; set; }
    }
}
