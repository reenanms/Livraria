using System.Windows.Forms;

namespace Livraria
{
	public static class Program
	{
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			
			var viewListagemLivros = new View.frmListagemLivros();
			var controlListagemLivros = new Control.ListagemLivros(viewListagemLivros);

			Application.Run(viewListagemLivros);
		}
	}
}
