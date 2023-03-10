using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizza.Models;

namespace RazorPizza.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel PizzaModel { get; set; }
        public decimal PizzaPrice { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost() 
        {
            PizzaPrice = PizzaModel.BasePrice;

            if (PizzaModel.TomatoSauce) PizzaPrice++;
            if (PizzaModel.Cheese) PizzaPrice++;
            if (PizzaModel.Pepperoni) PizzaPrice++;
            if (PizzaModel.Mushroom) PizzaPrice++;
            if (PizzaModel.Tuna) PizzaPrice++;
            if (PizzaModel.Pineapple) PizzaPrice++;
            if (PizzaModel.Ham) PizzaPrice++;
            if (PizzaModel.Beef) PizzaPrice++;
            if (PizzaModel.Prawns) PizzaPrice += 2;

            return RedirectToPage("/Checkout/Checkout", new { PizzaModel.PizzaName, PizzaPrice });
        }
    }
}
