using Microsoft.AspNetCore.Mvc;
using Pizzerie.Models;

namespace Pizzerie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()//this is for /helloworld browser address
        {                   //in this case will be localhost
            DogViewModel dog = new DogViewModel() { Name = "Silly", Age=10 };
            return View(dog);
        }
        
        public String Hello()//this is for /helloworld/hello browser address
        {
            return "Hello good sir.";
        }
        public IActionResult Doc()//this is for /helloworld/Doc browser address
        {
            return View();
        }
        public IActionResult DogList()//this is for /helloworld/DogList browser address
        {
            return View();
        }
        public IActionResult DogForm()//this is for /helloworld/DogForm browser address
        {
            DogViewModel dogViewModel = new DogViewModel();

            return View(dogViewModel);
        }
        public IActionResult CreateDogFromForm(DogViewModel newDog)//this is for /helloworld/CreateDogFromForm browser address
        {
            
            return View("DogList");
        }
        public IActionResult CreateDog()//this is for /helloworld/CreateDog browser address
        {
            return View();
        }
    }
}
