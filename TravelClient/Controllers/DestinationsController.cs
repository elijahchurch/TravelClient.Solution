


using Microsoft.AspNetCore.Mvc;
using TravelClient.Models;

namespace TravelClient.Controllers;
public class DestinationsController : Controller
{
    public IActionResult Index()
    {
        List<Destination> destinations = Destination.GetDestinations();
        return View(destinations);
    }
}