using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewModel.Models;

namespace ViewModel.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    [HttpGet]
    [Route("")]
    public IActionResult Index()
    {   
        string mensaje = "Hola desde el controlador.";
        return View("Index", mensaje);
    }
    [HttpGet]
    [Route("/numero")]
    public IActionResult Number()
    {   
        int[] numeros = { 1, 2, 3, 4, 5,6,7,8,9,10 };
        return View("Numeros", numeros);
    }
    [HttpGet]
    [Route("/user")]
    public IActionResult Privacy()
    {   
        User user = new User(1, "Lucio", "Sandoval");
        return View("Privacy", user);
    }

    [HttpGet]
    [Route("/users")]
    public IActionResult Users()
    {   
        User user1 = new User(1, "Lucio", "Sandoval");
        User user2 = new User(2, "Luciano", "Sandoval");
        User user3 = new User(3, "Luciana", "Sandoval");
        List<User> usuarios = new List<User>();
        usuarios.Add(user1);
        usuarios.Add(user2);
        usuarios.Add(user3);

        return View("Users", usuarios);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
