using OrderSolution.CustomValidators;
using System.ComponentModel.DataAnnotations;

namespace e_CommerceOrderApp.Models
{
    public class Order
    {
        [Required]
        [Display(Name = "Order Number")]
        public int? OrderNo { get; set; }

        [Required(ErrorMessage = "{0} can't be blank")]
        [Display(Name = "Order Date")]
        [MinimumDateValidator("2000-01-01", ErrorMessage = "Order date should be grater than or equal to 2000")]
        public DateTime? OrderDate { get; set; }


        [Required(ErrorMessage = "{0} can't be blank")]
        [Display(Name = "Invoice Price")]
        [Range(1, double.MaxValue, ErrorMessage = "{0} Should be between a valid number")]
        [InvoicePriceValidator]
        public decimal? InvoicePrice { get; set; }

        [ProductsListValidator]
        public List<Product> Products { get; set; } = new List<Product>();


    }
}
