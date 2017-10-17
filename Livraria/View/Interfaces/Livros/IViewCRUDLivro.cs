using System.Collections.Generic;

namespace Livraria.View
{
	public interface IViewCRUDLivro : IViewBase
	{
		string Identificador { get; set; }
		string Titulo { get; set; }
		string Autor { get; set; }
		string Editora { get; set; }
		string Edicao { get; set; }
		string Sinopse { get; set; }
		string Estoque { get; set; }

		bool HabilitaDeletar { get; set; }
		bool HabilitaCancelar { get; set; }
		bool HabilitaSalvar { get; set; }
		
		void fechar();
	}
}
