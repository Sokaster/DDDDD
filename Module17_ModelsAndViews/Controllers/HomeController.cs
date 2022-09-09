using Microsoft.AspNetCore.Mvc;
using Module17_ModelsAndViews.Models;
using Module17_ModelsAndViews.ViewModels;

namespace Module17_ModelsAndViews.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private static readonly User[] Users = new[]
                                           {
                                               new User
                                               {
                                                   Name = "Sasha",
                                                   Age = "22",
                                                   City = "Minsk"
                                               },
                                               new User
                                               {
                                                   Name = "Ira",
                                                   Age = "25",
                                                   City = "Minsk"
                                               },
                                               new User
                                               {
                                                   Name = "Kolya",
                                                   Age = "32",
                                                   City = "Pinsk"
                                               }
                                           };
    
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult DataTransportByViewData()
    {
        ViewData["Users"] = Users;
        return View();
    }

    public IActionResult DataTransportByViewBag()
    {
        ViewBag.Users = Users;
        return View();
    }

    public IActionResult DataTransportByModel()
    {
        return View(Users);
    }

    public IActionResult ViewWithSeparateLayout()
    {
        return View(Users);
    }

    //RABOTA S MODELS:
    public IActionResult GetUsers()
    {
        var users = new List<UserViewModel>()
        {
            new UserViewModel
            {
                Name = "Sasha",
                Age = 23,
                Email = "sasha@yandex.ru"
            },
            new UserViewModel
            {
                Name = "Dmitriy",
                Age = 21,
                Email = "DIMA@yandex.ru"
            },
            new UserViewModel
            {
                Name = "VOLODYA",
                Age = 23,
                Email = "SHOFERVOLODYA@yandex.ru"
            },
        };
         return View(users);

    }

    public IActionResult GetUser()
    {   
            var user = new UserViewModel
        {
            Name = "Sasha",
            Age = 23,
            Email = "sasha@yandex.ru"
        };
        return View(user);  
    }

    [HttpPost]
    public IActionResult GetUser(UserViewModel model)
    {
        return View(model);
    }
    
}