using ForumWebsite.Data;
using ForumWebsite.Models;
using Microsoft.AspNetCore.Mvc;

namespace ForumWebsite.Controllers
{
	public class ArticleCreatorController : Controller
	{
		private readonly ArticleDataContext _context;
		public ArticleCreatorController(ArticleDataContext context)
		{
			_context = context;
		}

		[HttpPost]
		public IActionResult CreateArticle(Article article)
		{
			_context.Articles.Add(article);
			_context.SaveChanges();

			return View("Index");
		}

		public IActionResult Index()
		{
			return View();
		}
	}
}
