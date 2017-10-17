using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Livraria.Model
{
	public class Tabela
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[DefaultValue(-1)]
		public int Id { get; protected set; }
	}
}
