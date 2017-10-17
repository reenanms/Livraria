using System.Data.Entity;

namespace Livraria.Model
{
	internal class Contexto : DbContext
	{
		public Contexto() : base()
		{
			Configuration.LazyLoadingEnabled = false;
		}

		public DbSet<Livro> Livros { get; set; }
		public DbSet<Autor> Autores { get; set; }
		public DbSet<Editora> Editoras { get; set; }
		public DbSet<Estoque> Estoques { get; set; }
	}
}
