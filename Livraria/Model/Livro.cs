namespace Livraria.Model
{
	public class Livro : Tabela
	{
		public string Titulo { get; set; }
		public virtual Autor Autor { get; set; }
		public int Edicao { get; set; }
		public virtual Editora Editora { get; set; }
		public string Sinopse { get; set; }
	}
}
