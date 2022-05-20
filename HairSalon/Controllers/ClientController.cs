using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;

namespace HairSalon.Controllers
{
	public class ClientController : Controller
	{
		[HttpGet("<insert route here>")]
		public ActionResult Index()
		{
			return View();
		}
	}
}
