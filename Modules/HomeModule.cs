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
			Get["/"] = _ => {
				List<Cuisine> AllCuisine = Cuisine.GetAll();
				return View["index.cshtml"];
			};
			Get["/add-new-restaurant"] = _ => {
				return View["add-new-restaurant.cshtml"];
			};
			Get["/restaurants"] = _ => {
				List<Restaurant> AllRestaurants = Restaurant.GetAll();
				return View["restaurants.cshtml", AllRestaurants];
			};
			Get["/cuisines"] = _ => {
				List<Cuisine> AllCuisine = Cuisine.GetAll();
				return View["cuisines.cshtml", AllCuisine];
			};
			Get["/add-new-cuisine"] = _ => {
				return View["add-new-cuisine.cshtml"];
			};
			Post["/added-cuisine"] = _ => {
				Cuisine newCuisine = new Cuisine(Request.Form["cuisine-name"]);
				newCuisine.Save();
				return View["success.cshtml"];
			};
			Get["/add-new-restaurant"] = _ => {
				List<Cuisine> AllCuisine = Cuisine.GetAll();
				return View["add-new-restaurant.cshtml", AllCuisine];
			};
			Post["/added-restaurant"] = _ => {
				Restaurant newRestaurant = new Restaurant(Request.Form["new-restaurant"], Request.Form["new-description"], (Request.Form["cuisine-id"]));
				newRestaurant.Save();
				return View["added-restaurant.cshtml"];
			};
			Get["/cuisines/{id}"] = parameters => {
				Dictionary<string, object> model = new Dictionary<string, object>();
				var SelectedCuisine = Cuisine.Find(parameters.id);
				var CuisineRestaurants = SelectedCuisine.GetRestaurants();
				model.Add("cuisine", SelectedCuisine);
				model.Add("restaurants", CuisineRestaurants);
				return View["cuisine.cshtml", model];
			};
		}
	}
}
