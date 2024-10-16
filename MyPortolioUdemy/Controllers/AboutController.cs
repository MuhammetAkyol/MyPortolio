using Microsoft.AspNetCore.Mvc;
using MyPortolioUdemy.DAL.Context;

namespace MyPortolioUdemy.Controllers
{
	public class AboutController : Controller
	{
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
		{
			var values = context.Abouts.ToList();
			return View(values);
		}
	}
}
