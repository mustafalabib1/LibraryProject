using DALProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DALProject.Data
{
	internal class AppContext : DbContext
	{
		public AppContext(DbContextOptions<AppContext> options): base(options)
		{ }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
		}
		public virtual DbSet<Author> Authors { get; set; }
		public virtual DbSet<Book> Books { get; set; }	
		public virtual DbSet<Borrow> Borrows { get; set; }
		public virtual DbSet<Categorie> Categorias { get; set; }	
		public virtual DbSet<Publisher> Publishers { get; set; }
		public virtual DbSet<Shelf> Shelf { get; set; }
		public virtual DbSet<User> Users { get; set; }	
	}
}
