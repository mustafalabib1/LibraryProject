using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALProject.Models
{
	internal class User :ModelBase
	{
		public string FullName { get; set; } = null!;
		public string Email { get; set; } = null!;
		public string Password { get; set; } = null!;
		public string Addresss { get; set; } = null!;
		public string ContactNumber { get; set; } = null!;

		#region Many to Mnay With Borrows 
		public virtual ICollection<Borrow> Borrows { get; set; } = new HashSet<Borrow>();
		#endregion
	}
}
