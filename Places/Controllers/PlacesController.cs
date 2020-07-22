using Microsoft.AspNetCore.Mvc;
using Places.Models;
using System.Collections.Generic;

namespace Places.Controllers
{
  public class PlacesController : Controller
  {
    [HttpGet("/locations/{locationId}")]
    public ActionResult Show(int locationId)
    {
      Location location = Location.Find(locationId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("location", location);
      return View(model);
    }

    [HttpPost("/items/delete")]
    public ActionResult DeleteAll()
    {
      Location.ClearAll();
      return View();
    }
  }
}