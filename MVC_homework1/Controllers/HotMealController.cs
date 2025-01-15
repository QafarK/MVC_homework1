using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MVC_homework1.Entities;

namespace MVC_homework1.Controllers
{
	public class HotMealController : Controller
    {
		public string Index()
		{
			return "HotMeal controller";
		}

		public ViewResult HotMeals()
		{
			List<HotMeal> hotMeals = new List<HotMeal>()
			{
				new HotMeal()
				{
					Id = 1,
					Name = "Tea",
				},
				new HotMeal()
				{
					Id = 2,
					Name = "Coffee"
				},
				new HotMeal()
				{
					Id = 3,
					Name = "Capucino"
				}
			};

			return View(hotMeals);
		}
	}
}
