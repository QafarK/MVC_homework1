using Microsoft.AspNetCore.Mvc;
using MVC_homework1.Entities;
using System.Collections.Generic;
using System.Linq;
namespace MVC_homework1.Controllers
{
	public class DrinkController : Controller
	{
		List<Drink> _drinks;
		public DrinkController()
		{
			_drinks = new List<Drink>()
			{
				new Drink()
				{
					Id = 1,
					Name = "Water",
				},
				new Drink()
				{
					Id = 2,
					Name = "Cola"
				},
				new Drink()
				{
					Id = 3,
					Name = "Fanta"
				}
			};
		}


		public string Index()
		{
			return "Drink controller";
		}

		public ViewResult Drinks() => View(_drinks);
		//{
		// return View(_drinks);
		//}

		public ViewResult RootParam(int id = -1)
		{
			if (id == -1)
				return View("Drinks", _drinks);
			else
			{
				var drink = _drinks.FirstOrDefault(dr => dr.Id == id);
				return View("RootParam", drink);
			}
		}

		public JsonResult RootParamJson(int id = -1)
		{
			if (id == -1)
				return Json(_drinks);
			else
			{
				var drink = _drinks.FirstOrDefault(dr => dr.Id == id);
				return Json(drink);
			}
		}
	}
}
