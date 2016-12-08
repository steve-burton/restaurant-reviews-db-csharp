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
			Get["add-new-restaurant"] = _ => 
			{
				return View["index.cshtml"];
			};
		}
	}
}
