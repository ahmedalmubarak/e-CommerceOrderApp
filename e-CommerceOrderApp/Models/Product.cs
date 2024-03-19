using System.ComponentModel.DataAnnotations;

namespace e_CommerceOrderApp.Models
{
    public class Product
    {
        [Required(ErrorMessage = "{0} Can't be blank")]
        [Display(Name = "Product Number")]
        [Range(1, int.MaxValue, ErrorMessage = "{0} Should be between a valid number")]
        public int? ProductCode { get; set; }

        [Required(ErrorMessage = "{0} Can't be blank")]
        [Display(Name = "Product Price")]
        [Range(1, double.MaxValue, ErrorMessage = "{0} Should be between a valid number")]
        public double? Price { get; set; }

        [Required(ErrorMessage = "{0} Can't be blank")]
        [Display(Name = "Product Quntity")]
        [Range(1, double.MaxValue, ErrorMessage = "{0} Should be between a valid number")]

        public int? Quantity { get; set; }
    }
}
