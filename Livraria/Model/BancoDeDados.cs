using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Livraria.Model
{
	public static class BancoDeDados
	{
		public static List<Livro> SelecionaTodosLivros()
		{
			using (var bd = new Contexto())
			{
				var query = bd.Livros.Include(l => l.Editora)
									 .Include(l => l.Autor)
									 .OrderBy(l => l.Titulo);

				return query.ToList();
			}
		}

		public static List<Estoque> SelecionaTodosEstoques()
		{
			using (var bd = new Contexto())
			{
				var query = bd.Estoques.Include(e => e.Livro);

				return query.ToList();
			}
		}

		public static Estoque SelecionaEstoque(Livro livro)
		{
			if (livro != null)
			{
				using (var bd = new Contexto())
				{
					var query = bd.Estoques.Include(e => e.Livro)
										    .Where(e => e.Livro.Id == livro.Id);

					if (query.Count() > 0)
						return query.First();
				}
			}

			return null;
		}

		public static Livro SelecionaLivro(int id)
		{
			using (var bd = new Contexto())
			{
				var query = bd.Livros.Include(l => l.Editora)
									 .Include(l => l.Autor)
									 .Where(l => l.Id == id);

				if (query.Count() > 0)
					return query.First();
			}

			return null;
		}

		public static Autor SelecionaAutor(string nome)
		{
			using (var bd = new Contexto())
			{
				var query = bd.Autores.Where(a => a.Nome.Equals(nome, StringComparison.CurrentCultureIgnoreCase));

				if (query.Count() > 0)
					return query.First();
			}

			return null;
		}

		public static Editora SelecionaEditora(string nome)
		{
			using (var bd = new Contexto())
			{
				var query = bd.Editoras.Where(e => e.Nome.Equals(nome, StringComparison.CurrentCultureIgnoreCase));

				if (query.Count() > 0)
					return query.First();
			}

			return null;
		}

		public static void Insere(Livro livro)
		{
			if (livro != null)
			{
				using (var bd = new Contexto())
				{
					bd.Livros.Add(livro);
					bd.SaveChanges();
				}
			}
		}

		public static void Insere(Autor autor)
		{
			if (autor != null)
			{
				using (var bd = new Contexto())
				{
					bd.Autores.Add(autor);
					bd.SaveChanges();
				}
			}
		}

		public static void Insere(Editora editora)
		{
			if (editora != null)
			{
				using (var bd = new Contexto())
				{
					bd.Editoras.Add(editora);
					bd.SaveChanges();
				}
			}
		}

		public static void Insere(Estoque estoque)
		{
			if (estoque != null)
			{
				using (var bd = new Contexto())
				{
					var e = new Estoque
					{
						Livro = bd.Livros.Where(l => l.Id == estoque.Livro.Id).FirstOrDefault(),
						Quantidade = estoque.Quantidade
					};

					bd.Estoques.Add(e);
					bd.SaveChanges();
				}
			}
		}

		public static void Atualiza(Livro livro)
		{
			if (livro != null)
			{
				using (var bd = new Contexto())
				{
					var query = bd.Livros.Include(l => l.Editora)
										 .Include(l => l.Autor)
										 .Where(l => l.Id == livro.Id);

					if (query.Count() > 0)
					{
						var livroContexto = query.First();

						livroContexto.Titulo = livro.Titulo;
						livroContexto.Sinopse = livro.Sinopse;
						livroContexto.Edicao = livro.Edicao;

						var autorContexto = bd.Autores.Where(a => a.Id == livro.Autor.Id).FirstOrDefault();
						if (autorContexto != null)
							livroContexto.Autor = autorContexto;
						else
							livroContexto.Autor = livro.Autor;


						var editoraContexto = bd.Editoras.Where(e => e.Id == livro.Editora.Id).FirstOrDefault();
						if (editoraContexto != null)
							livroContexto.Editora = editoraContexto;
						else
							livroContexto.Editora = livro.Editora;
						
						bd.SaveChanges();
					}
				}
			}
		}

		public static void Atualiza(Estoque estoque)
		{
			if (estoque?.Livro != null)
			{
				using (var bd = new Contexto())
				{
					var query = bd.Estoques.Include(e => e.Livro)
											.Where(e => e.Livro.Id == estoque.Livro.Id);

					if (query.Count() > 0)
					{
						var estoqueContexto = query.First();
						estoqueContexto.Quantidade = estoque.Quantidade;

						bd.SaveChanges();
					}
				}
			}
		}

		public static void Deleta(Livro livro)
		{
			if (livro != null)
			{
				using (var bd = new Contexto())
				{
					bd.Livros.RemoveRange(bd.Livros.Where(l => l.Id == livro.Id));
					bd.SaveChanges();
				}
			}
		}
		
		public static void Deleta(Autor autor)
		{
			if (autor != null)
			{
				using (var bd = new Contexto())
				{
					bd.Autores.RemoveRange(bd.Autores.Where(l => l.Id == autor.Id));
					bd.SaveChanges();
				}
			}
		}

		public static void Deleta(Editora editora)
		{
			if (editora != null)
			{
				using (var bd = new Contexto())
				{
					bd.Editoras.RemoveRange(bd.Editoras.Where(l => l.Id == editora.Id));
					bd.SaveChanges();
				}
			}
		}
	}
}
