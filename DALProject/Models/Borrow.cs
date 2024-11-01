using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALProject.Models
{
	public enum BorrowStatus
	{
		Returned = 0,
		Unreturned = 1,
	}
	internal class Borrow : ModelBase
	{
		public string UserId { get; set; } = null!;
		public DateOnly ReturnDate { get; set; }
		public BorrowStatus Status { get; set; }
		public DateTime? DateReturned { get; set; }

		#region Many to Many With book 
		public virtual ICollection<Book> Books { get; set; } = new HashSet<Book>();
		#endregion

		#region Many to Many With User 
		public virtual ICollection<User> Users { get; set; } = new HashSet<User>();
		#endregion
	}
}
