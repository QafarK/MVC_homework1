using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace MVC_homework1.Controllers
{
	public class HomeController : Controller
	{
		public string Index()
		{
			return "home controller";
		}

		public IActionResult Drinks()
		{
			return Redirect("/drink/drinks");
		}

		public IActionResult FastFoods()
		{
			//return Redirect("/fastfood/fastfoods");

			var routeValue = new RouteValueDictionary(
			new { action = "fastfoods", controller = "fastfood" });

			return RedirectToRoute(routeValue);
		}

		public IActionResult HotMeals()
		{
			return Redirect("/hotmeal/hotmeals");
		}
	}
}
