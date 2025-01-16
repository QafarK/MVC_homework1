using Microsoft.AspNetCore.Mvc;
using MVC_homework1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MVC_homework1.Controllers
{
	public class FastFoodController : Controller
	{
		List<FastFood> _fastFoods;
		public FastFoodController()
		{
			_fastFoods = new List<FastFood>()
			{
				new FastFood()
				{
					Name = "BigMac",
				},
				new FastFood()
				{
					Id = 2,
					Name = string.Empty
				},
				new FastFood()
				{
					Id = 3,
					Name = "Free"
				}
			};
		}

		public string Index()
		{
			return "FastFood controller";
		}
		public ViewResult FastFoods() => View(_fastFoods);

		public ViewResult QueryParam(string key, int id = -1)
		{
			IEnumerable<FastFood> fastFoods = Enumerable.Empty<FastFood>();

			if (id == -1)
				fastFoods = _fastFoods.Where(e => e.Name.ToLower().Contains(key));
			else 
				fastFoods = _fastFoods.Where(e=> e.Id == id || e.Name.ToLower().Contains(key));

			return View("QueryParam", fastFoods);
		}

		public JsonResult QueryParamJson(string key, int id = -1) 
		{
			IEnumerable<FastFood> fastFoods = Enumerable.Empty<FastFood>();

			if (id == -1)
				fastFoods = _fastFoods.Where(e => e.Name.ToLower().Contains(key));
			else
				fastFoods = _fastFoods.Where(e => e.Id == id || e.Name.ToLower().Contains(key));

			return Json(fastFoods);
		}
	}
}
