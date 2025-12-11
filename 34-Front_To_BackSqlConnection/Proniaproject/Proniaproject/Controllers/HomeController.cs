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


            //Lazim deyiller
            //List<Slider> sliders = new List<Slider>
            //{
            //    new Slider
            //    {
            //        //Id = 1,
            //        Title = "Sok Endrimler",
            //        SubTitle = "Dibcekde gullerden qalmadi",
            //        Description = "Discover the latest trends in fashion with Pronia. Shop now and elevate your style!",
            //        ImageUrl = "1-1-524x617.png",
            //        Order = 1,
            //        IsDeleted = false,
            //        CreateTime = DateTime.Now
            //    },
            //    new Slider
            //    {
            //        //Id = 2,
            //        Title = "Endrim Devam edir",
            //        SubTitle = "Indi al 3 ay sonra ode",
            //        Description = "Explore our vibrant summer collection and find the perfect outfits for the sunny season.",
            //        ImageUrl = "1-2-524x617.png",
            //        Order = 2,
            //        IsDeleted = false,
            //        CreateTime = DateTime.Now
            //    },
            //    new Slider
            //    {
            //        //Id = 3,
            //        Title = "Sok Sok",
            //        SubTitle = "Guller su qiymetine",
            //        Description = "Don't miss out on our exclusive offers! Shop now and enjoy great discounts on your favorite styles.",
            //        ImageUrl = "2-2-70x78.png",
            //        Order = 3,
            //        IsDeleted = false,
            //        CreateTime = DateTime.Now
            //    }
            //};

            //_context.Sliders.AddRange(sliders);
            //_context.SaveChanges();

            //List<Slider> sortedSliders = sliders.OrderBy(s => s.Order).Take(2).ToList();




            //List<Person> persons = new List<Person>
            //{
            //    new Person
            //    {
            //        //Id = 1,
            //        ImageUrl3 = "1-3-70x78.png",
            //        PersonName = "John Doe",
            //        PersonDetail = "Fashion Designer",
            //        PersonDescription = "John is a renowned fashion designer with over 10 years of experience in the industry.",
            //        IsDeleted = false,
            //        CreateTime = DateTime.Now
            //    },
            //    new Person
            //    {
            //        //Id = 2,
            //        ImageUrl3 = "2-3-70x78.png",
            //        PersonName = "Jane Smith",
            //        PersonDetail = "Style Consultant",
            //        PersonDescription = "Jane has a keen eye for style and helps clients find their perfect look.",
            //        IsDeleted = false,
            //        CreateTime = DateTime.Now
            //    },
            //    new Person
            //    {
            //        //Id = 3,
            //        ImageUrl3 = "3-3-70x78.png",
            //        PersonName = "Mike Johnson",
            //        PersonDetail = "Brand Ambassador",
            //        PersonDescription = "Mike represents our brand with passion and dedication, embodying our values.",
            //        IsDeleted = false,
            //        CreateTime = DateTime.Now
            //    }

            //};

            //_context.Persons.AddRange(persons);
            //_context.SaveChanges();


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
