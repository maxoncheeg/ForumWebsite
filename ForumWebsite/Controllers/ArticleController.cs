using ForumWebsite.Data;
using ForumWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ForumWebsite.Controllers
{
	public class ArticleController : Controller
	{
		private ArticleDataContext _context { get; set; }
		public ArticleController(ArticleDataContext context) { _context = context; }

		public IActionResult Index()
		{
			List<Article> list = _context.Articles.ToList();
			return View(list);
		}

		[HttpGet]
		public IActionResult ReadArticle(Guid id)
		{
			return View(_context.Articles.FirstOrDefault(x => x.Guid == id));
		}
	}
}
