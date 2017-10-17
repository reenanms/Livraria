using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Livraria.Model
{
	public class Estoque : Tabela
	{
		[Required]
		[Index("IX_Unique", IsUnique = true)]
		public Livro Livro { get; set; }
		public int Quantidade { get; set; }
	}
}
