using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALProject.Models
{
	internal class Categorie :ModelBase
	{
		public string Name { get; set; } = null!;
		public string Slug { get; set; } = null!;

		#region Many to One With Shelf
		public string? ShelfId { get; set; } = null!;
		public virtual Shelf? Shelf { get; set; }
		#endregion

		#region Many to Many With Books 
		public virtual ICollection<Book> Books { get; set; } = new HashSet<Book>();
		#endregion
	}
}
