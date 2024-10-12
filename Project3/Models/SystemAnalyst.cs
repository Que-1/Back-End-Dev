using System.ComponentModel.DataAnnotations;
namespace Project3.Models
{
    public class SystemAnalyst
    {
        [Key]
        public string Username { get; set; }
        [Required]
        [StringLength(100)]

        public int Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]

        public int Token { get; set; }
    }
}
