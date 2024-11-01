using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALProject.Models
{
	internal class Publisher : ModelBase
	{
		public string Name { get; set; } = null!;
		public string Addresss { get; set; } = null!;
		public string  Email { get; set; } = null!;
		public string ContactNumber { get; set; } = null!;

		#region Many to Many With book 
		public virtual ICollection<Book> Books { get; set; } = new HashSet<Book>();
		#endregion
	}
}
