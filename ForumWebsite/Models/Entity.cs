using System.ComponentModel.DataAnnotations;

namespace ForumWebsite.Models
{
	public class Entity
	{
		[Key]
		public Guid Guid { get; set; } = Guid.NewGuid();
	}
}
