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
		}
	}
}
