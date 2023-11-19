using ForumWebsite.Models;
using Microsoft.EntityFrameworkCore;

namespace ForumWebsite.Data
{
	public class ArticleDataContext : DbContext
	{
		public DbSet<Article> Articles { get; set; }

		public ArticleDataContext(DbContextOptions<ArticleDataContext> options) : base(options)
		{
		}
	}
}
