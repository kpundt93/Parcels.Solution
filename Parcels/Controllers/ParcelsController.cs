using Microsoft.AspNetCore.Mvc;
using Shipping.Models;

namespace Shipping.Controllers
{
  public class ParcelsController : Controller
  {
    [HttpGet("/parcels")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/parcels/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/parcels")]
    public ActionResult Create(double width, double height, double weight)
    {
      Parcel myParcel = new Parcel(width, height, weight);
      return RedirectToAction("Index");
    }
  }
}