using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using HairSalon.Models;

namespace HairSalon.Controllers
{
  public class ClientsController : Controller
  {
    private readonly HairSalonContext _db;

    public ClientsController(HairSalonContext db)
    {
      _db = db;
    }


    // /clients/create - GET
    public ActionResult Create()
    {
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name");
      return View();
    }

    // /clients/create - POST
    [HttpPost]
    public ActionResult Create(Client client)
    {
      if (client.StylistId == 0)
      {
        return RedirectToAction("Create");
      }
      _db.Clients.Add(client);
      _db.SaveChanges();

      return RedirectToAction("Details", "Stylists", new { id = client.StylistId });
    }

    // /clients/details/{id} - GET
    public ActionResult Details(int id)
    {
      Client selectedClient = _db.Clients.Include(client => client.Stylist).FirstOrDefault(client => client.ClientId == id);
      return View(selectedClient);
    }
  }
}