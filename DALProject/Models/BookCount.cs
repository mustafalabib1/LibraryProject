using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALProject.Models
{
	internal class BookCount : ModelBase 
	{
		public int? Quantity { get; set; }

		#region Many To One With book 
		public Guid BookId { get; set; }
		#endregion
	}
}
