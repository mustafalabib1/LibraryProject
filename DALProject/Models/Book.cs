using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALProject.Models
{
	internal class Book : ModelBase
	{
		public string Title { get; set; } = null!;
		public string ISBN { get; set; } = null!;
		public string Edition { get; set; } = null!;
		public string Volume { get; set; } = null!;
		public string Issue { get; set; } = null!;
		public virtual string? PublisherId { get; set; } =null!;
		public string Cover { get; set; } = null!;

		#region Many to Many With Author 
		public virtual ICollection<Author> Authors { get; set; }=new HashSet<Author>();
		#endregion

		#region Mnay to Many wiht categorie
		public virtual ICollection<Categorie> Categories { get; set; } = new HashSet<Categorie>();
		#endregion

		#region Many to Many With Borrow
		public virtual ICollection<Borrow> Borrows { get; set; }= new HashSet<Borrow>();
		#endregion

		#region Many to Many With Publisher 
		public virtual ICollection<Publisher> Publishers { get; set; } = new HashSet<Publisher>();
		#endregion

		#region Mnay to One With BookCount
		public virtual ICollection<BookCount> BookCounts { get; set; } = new HashSet<BookCount>();
		#endregion
	}
}
