using la_mia_pizzeria_static.Data;
using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            PizzeriaDbContext db = new PizzeriaDbContext();
            List<Pizza> pizzas = db.Pizzas.ToList<Pizza>();
            return View(pizzas);
        }

        public IActionResult Detail(int id)
        {
            PizzeriaDbContext db = new PizzeriaDbContext();
            Pizza pizza = db.Pizzas.Find(id);
            return View(pizza);
        }
    }
}
