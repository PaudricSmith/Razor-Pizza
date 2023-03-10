using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizza.Models;

namespace RazorPizza.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel() { ImageTitle="Margerita", PizzaName="Margerita", BasePrice=2, TomatoSauce=true, Cheese=true, TotalPrice=4 },
            new PizzasModel() { ImageTitle="Bolognese", PizzaName="Bolognese", BasePrice=2, TomatoSauce=true, Cheese=true, Beef=true, TotalPrice=5 },
            new PizzasModel() { ImageTitle="Hawaiian", PizzaName="Hawaiian", BasePrice=2, TomatoSauce=true, Cheese=true, Ham=true, Pineapple=true, TotalPrice=6 },
            new PizzasModel() { ImageTitle="Carbonara", PizzaName="Carbonara", BasePrice=2, TomatoSauce=true, Cheese=true, Ham=true, Mushroom=true, TotalPrice=6 },
            new PizzasModel() { ImageTitle="MeatFeast", PizzaName="MeatFeast", BasePrice=2, TomatoSauce=true, Cheese=true, Ham=true, Beef=true, TotalPrice=6 },
            new PizzasModel() { ImageTitle="Mushroom", PizzaName="Mushroom", BasePrice=2, TomatoSauce=true, Cheese=true, Mushroom=true, TotalPrice=5 },
            new PizzasModel() { ImageTitle="Pepperoni", PizzaName="Pepperoni", BasePrice=2, TomatoSauce=true, Cheese=true, Pepperoni=true, TotalPrice=5 },
            new PizzasModel() { ImageTitle="Seafood", PizzaName="Seafood", BasePrice=2, TomatoSauce=true, Cheese=true, Tuna=true, Prawns=true, TotalPrice=6 },
            new PizzasModel() { ImageTitle="Vegetarian", PizzaName="Vegetarian", BasePrice=2, TomatoSauce=true, Cheese=true, Mushroom = true, Pineapple=true, TotalPrice=3 }
        };

        public void OnGet()
        {
        }
    }
}
