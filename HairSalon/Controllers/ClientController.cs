using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace HairSalon.Controllers
{
	public class ClientController : Controller
	{
		private readonly HairSalonContext _db;

		public ClientController(HairSalonContext db)
		{
			_db = db;
		}

		public ActionResult Index()
		{
			List<Client> model = _db.Clients.ToList();
			return View(model);
		}

		public ActionResult Create(int id)
		{
			ViewBag.StylistId = id;
			return View();
		}

		[HttpPost]
		public ActionResult Create(Client client)
		{
			_db.Clients.Add(client);
			_db.SaveChanges();
			return RedirectToAction("Details", "Stylist", new { id = client.StylistId });
		}
	}
}
