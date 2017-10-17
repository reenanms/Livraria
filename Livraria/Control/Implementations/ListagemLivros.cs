using System;
using System.Collections.Generic;
using System.Linq;

namespace Livraria.Control
{
	public class ListagemLivros : ControlBase
	{
		private View.IViewListagemLivros view;
		private List<View.ViewLivros> cacheViewLivros;

		public ListagemLivros(View.IViewListagemLivros v) : base(v)
		{
			view = v;
		}

		public override void iniciarView()
		{
			atualizarListagem();
		}

		public void fitraListagem()
		{
			List<View.ViewLivros> listagem = null;
			if (string.IsNullOrEmpty(view.PesquisaTitulo))
			{
				listagem = cacheViewLivros;
			}
			else
			{
				listagem = cacheViewLivros.Where(l => l.Titulo.IndexOf(view.PesquisaTitulo, StringComparison.CurrentCultureIgnoreCase) > -1).ToList();
			}

			view.carregaListagem(listagem);
		}

		public void adicionarLivro()
		{
			var viewCRUDLivro = new View.frmCRUDLivro();
			var controlCRUDLivro = new Control.CRUDLivro(viewCRUDLivro);

			viewCRUDLivro.ShowDialog();

			atualizarListagem();
		}

		public void visualizarLivro(int identificador)
		{
			var viewCRUDLivro = new View.frmCRUDLivro();
			var controlCRUDLivro = new Control.CRUDLivro(viewCRUDLivro, identificador);

			viewCRUDLivro.ShowDialog();

			atualizarListagem();
		}

		private void atualizarCache()
		{
			var estoques = Model.BancoDeDados.SelecionaTodosEstoques();
			cacheViewLivros = Model.BancoDeDados.SelecionaTodosLivros()
								.Select(l => new View.ViewLivros()
								{
									Identificador = l.Id,
									Titulo = l.Titulo,
									Autor = l.Autor?.Nome,
									Editora = l.Editora?.Nome,
									Estoque = estoques.Where(e => e.Livro.Id == l.Id).Sum(e => e.Quantidade)
								})
								.ToList();
		}

		private void atualizarListagem()
		{
			atualizarCache();
			fitraListagem();
		}
	}
}
