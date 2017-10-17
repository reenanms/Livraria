using System;
using System.Collections.Generic;
using System.Linq;

namespace Livraria.Control
{
	public class CRUDLivro : ControlBase
	{
		private View.IViewCRUDLivro view;
		private int id;
		private Model.Livro livro;

		public CRUDLivro(View.IViewCRUDLivro v) : this(v, -1) { }

		public CRUDLivro(View.IViewCRUDLivro v, int idLivro) : base(v)
		{
			view = v;
			id = idLivro;
		}

		public override void iniciarView()
		{
			livro = Model.BancoDeDados.SelecionaLivro(id);
			var estoque = Model.BancoDeDados.SelecionaEstoque(livro);

			view.Identificador = livro?.Id.ToString() ?? "(Indefinido)";
			view.Titulo = livro?.Titulo ?? string.Empty;
			view.Autor = livro?.Autor?.Nome ?? string.Empty;
			view.Editora = livro?.Editora?.Nome ?? string.Empty;
			view.Edicao = livro?.Edicao.ToString() ?? string.Empty;
			view.Sinopse = livro?.Sinopse ?? string.Empty;
			view.Estoque = estoque?.Quantidade.ToString() ?? "0";

			habilitaFuncoes();
		}

		public void deletar()
		{
			view.HabilitaDeletar = false;
			
			Model.BancoDeDados.Deleta(livro);
			view.fechar();

			view.HabilitaDeletar = true;
		}

		public void cancelar()
		{
			view.fechar();
		}

		public void salvar()
		{
			view.HabilitaSalvar = false;

			var insercao = (livro == null);

			if (insercao)
				livro = new Model.Livro();

			livro.Titulo = view.Titulo;
			livro.Sinopse = view.Sinopse;

			if (int.TryParse(view.Edicao, out var edicao))
				livro.Edicao = edicao;

			var autor = Model.BancoDeDados.SelecionaAutor(view.Autor);
			if (autor == null)
			{
				autor = new Model.Autor()
				{
					Nome = view.Autor
				};
			}
			livro.Autor = autor;

			var editora = Model.BancoDeDados.SelecionaEditora(view.Editora);
			if (editora == null)
			{
				editora = new Model.Editora()
				{
					Nome = view.Editora
				};
			}
			livro.Editora = editora;

			if (insercao)
				Model.BancoDeDados.Insere(livro);
			else
				Model.BancoDeDados.Atualiza(livro);

			if (int.TryParse(view.Estoque, out var quantidadeEstoque))
			{
				if (quantidadeEstoque > 0)
				{
					var estoque = Model.BancoDeDados.SelecionaEstoque(livro);
					if (estoque != null)
					{
						estoque.Quantidade = quantidadeEstoque;
						Model.BancoDeDados.Atualiza(estoque);
					}
					else
					{
						Model.BancoDeDados.Insere(new Model.Estoque
													{
														Livro = livro,
														Quantidade = quantidadeEstoque
													}
												  );
					}
				}
			}

			view.fechar();

			view.HabilitaSalvar = true;
		}

		private void habilitaFuncoes()
		{
			view.HabilitaDeletar = livro != null;
			view.HabilitaCancelar = true;
			view.HabilitaSalvar = true;
		}
	}
}
