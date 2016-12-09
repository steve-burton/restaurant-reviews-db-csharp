using Nancy;
using System.Collections.Generic;
using Nancy.ViewEngines.Razor;
using Review.Objects;

namespace Review
{
	public class HomeModule : NancyModule
	{
		public HomeModule()
		{
			Get["/"] = _ =>
			{
				return View["index.cshtml"];
			};
			Get["/add-new-restaurant"] = _ => {
				List<Cuisine> AllCuisine = Cuisine.GetAll();
				return View["add-new-restaurant.cshtml", AllCuisine];
			};
			Get["/add-new-cuisine"] = _ => {
				return View["add-new-cuisine.cshtml"];
			};
			Post["/added-restaurant"] = _ => {
				Restaurant newRestaurant = new Restaurant(Request.Form["new-restaurant"], Request.Form["new-description"], int.Parse(Request.Form["new-cuisine"]));
				newRestaurant.Save();
				return View["added-restaurant.cshtml"];
			};
			Post["/added-cuisine"] = _ => {
				Cuisine newCuisine = new Cuisine(Request.Form["new-cuisine"]);
				newCuisine.Save();
				return View["success.cshtml"];
			};

		}
	}
}
