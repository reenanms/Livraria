using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Livraria.View
{
	public partial class frmListagemLivros : Form, IViewListagemLivros
	{
		private Control.ListagemLivros control;

		public frmListagemLivros()
		{
			InitializeComponent();
		}

		public List<ViewLivros> Livros => dgvListagem.DataSource as List<ViewLivros>;

		public string PesquisaTitulo => txtFiltro.Text;

		public void carregaListagem(List<ViewLivros> listagem)
		{
			dgvListagem.DataSource = listagem;
		}

		public void setControl(Control.ControlBase c)
		{
			control = c as Control.ListagemLivros;
		}

		private void frmListagemLivros_Load(object sender, EventArgs e)
		{
			control.iniciarView();
			txtFiltro.Focus();
		}

		private void txtFiltro_TextChanged(object sender, EventArgs e)
		{
			control.fitraListagem();
		}

		private void btnAdicionar_Click(object sender, EventArgs e)
		{
			control.adicionarLivro();
		}

		private void dgvListagem_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.RowIndex > -1)
			{
				var identificador = dgvListagem.Rows[e.RowIndex]?.Cells["Identificador"]?.Value;
				if (identificador is int)
				{
					control.visualizarLivro((int)identificador);
				}
			}
		}
	}
}
