


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

    public IActionResult Details(int id)
    {
        Destination model = Destination.GetDetails(id);
        return View(model);
    }

    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public ActionResult Create(Destination destination)
    {
        Destination.Post(destination);
        return RedirectToAction("Index");
    }

    public IActionResult Edit(int id)
    {
        Destination destination = Destination.GetDetails(id);
        return View(destination);
    }

    [HttpPost]
    public ActionResult Edit(Destination destination)
    {
        Destination.Put(destination);
        return RedirectToAction("Details", new { id = destination.DestinationId});
    }
}