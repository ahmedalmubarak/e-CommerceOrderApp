using e_CommerceOrderApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace e_CommerceOrderApp.Controllers
{
    public class OrderController : Controller
    {
        [Route("/order")]
        public IActionResult GetOrder([Bind(nameof(Order.OrderDate), nameof(Order.InvoicePrice), nameof(Order.Products))] Order order)
        {
            if (!ModelState.IsValid)
            {
                var errors = string.Join("\n", ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage));
                return BadRequest(errors);
            }

            Random random = new Random();
            int randomOrderNumber = random.Next(1, 99999);

            return Json(new { orderNumber = randomOrderNumber });

        }
    }
}
