using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALProject.Models
{
	internal class Author : ModelBase
	{
		public string Name { get; set; } = null!;

		#region Many to Many With Book 
		public virtual ICollection<Book> Books { get; set; }= new HashSet<Book>();
		#endregion
	}
}
