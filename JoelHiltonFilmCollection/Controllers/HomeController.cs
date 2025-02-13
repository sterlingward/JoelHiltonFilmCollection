using System.Diagnostics; // Provides access to diagnostic information
using Microsoft.AspNetCore.Mvc; // Required for MVC controllers and actions
using JoelHiltonFilmCollection.Models; // Imports the models used in the application

namespace JoelHiltonFilmCollection.Controllers; // Defines the namespace for this controller

// HomeController handles requests for the home and privacy pages
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger; // Logger instance for tracking errors and information

    // Constructor that initializes the logger when the controller is created
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    // Handles requests to the homepage
    public IActionResult Index()
    {
        return View(); // Returns the corresponding view for the Index action
    }

    // Handles requests to the Privacy page
    public IActionResult Privacy()
    {
        return View(); // Returns the corresponding view for the Privacy action
    }

    // Handles errors and logs details for debugging
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        // Creates an ErrorViewModel with the current request ID for error tracking
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}