using Microsoft.AspNetCore.Mvc;
using Proniaproject.DAL;
using Proniaproject.Models;
using Proniaproject.ViewModels;

namespace Proniaproject.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {

            List<Slider> sliders = _context.Sliders.OrderBy(s => s.Order).ToList();

            List<Person> persons = _context.Persons.ToList();

            List<Card> cards = _context.Cards.ToList();



            HomeVM homeVM = new HomeVM
            {
                Sliders = sliders,
                Cards = cards,
                Persons = persons
            };

            


            return View(homeVM);


        }
        
        
    }
}
