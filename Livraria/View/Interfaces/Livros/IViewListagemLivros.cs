using System.Collections.Generic;

namespace Livraria.View
{
	public interface IViewListagemLivros : IViewBase
	{
		string PesquisaTitulo { get; }
		List<ViewLivros> Livros { get; }
		void carregaListagem(List<ViewLivros> listagem);
	}
}
