using Nancy;
using System.Collections.Generic;
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
				return View["add-new-restaurant.cshtml"];
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
				return View["added-cuisine.cshtml"];
			};
		}
	}
}
