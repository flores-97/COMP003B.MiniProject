using System.ComponentModel.DataAnnotations;

namespace COMP003B.MiniProject.Models
{
    public class PreOrder
    {
        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Full Name cannot be blank.")]
        public string FullName { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Enter a Valid Email to receive important information.")]
        public string Email { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "Enter a correct platfrom.")]
        public string Platform { get; set; }

        [Required]
        [Range(1, 3, ErrorMessage = "Max limit per customer is 3.")]
        public int OrderUnit { get; set; }

        public string? Discount { get; set; }
    }
}
