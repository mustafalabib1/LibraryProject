using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALProject.Models
{
	internal class Shelf :ModelBase
	{
		public string Name { get; set; } = null!;

		#region Many to One With categorie 
		public virtual ICollection<Categorie> Categorias { get; set; } = new HashSet<Categorie>();	
		#endregion
	}
}
