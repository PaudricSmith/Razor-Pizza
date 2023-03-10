using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizza.Data;
using RazorPizza.Models;

namespace RazorPizza.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]
    public class CheckoutModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public string PizzaName { get; set; }
        public string ImageTitle { get; set; }
        public decimal PizzaPrice { get; set; }

        public CheckoutModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            if (string.IsNullOrEmpty(ImageTitle))
            {
                ImageTitle = "Custom";
            }
            if (string.IsNullOrEmpty(PizzaName))
            {
                PizzaName = ImageTitle;
            }
            
            PizzaOrder pizzaOrder = new PizzaOrder();
            pizzaOrder.PizzaName = PizzaName;
            pizzaOrder.BasePrice = PizzaPrice;

            _context.PizzaOrders.Add(pizzaOrder);
            _context.SaveChanges();
        }
    }
}
