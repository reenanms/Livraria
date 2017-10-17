using System;
using System.Windows.Forms;

namespace Livraria.View
{
	public partial class frmCRUDLivro : Form, IViewCRUDLivro
	{
		private Control.CRUDLivro control;

		public string Identificador { get => txtId.Text; set => txtId.Text = value; }
		public string Titulo { get => txtTitulo.Text; set => txtTitulo.Text = value; }
		public string Autor { get => txtAutor.Text; set => txtAutor.Text = value; }
		public string Editora { get => txtEditora.Text; set => txtEditora.Text = value; }
		public string Edicao { get => txtEdicao.Text; set => txtEdicao.Text = value; }
		public string Sinopse { get => txtSinopse.Text; set => txtSinopse.Text = value; }
		public string Estoque { get => txtEstoque.Text; set => txtEstoque.Text = value; }

		public bool HabilitaDeletar { get => btnDeletar.Enabled; set => btnDeletar.Enabled = value; }
		public bool HabilitaCancelar { get => btnCancelar.Enabled; set => btnCancelar.Enabled = value; }
		public bool HabilitaSalvar { get => btnSalvar.Enabled; set => btnSalvar.Enabled = value; }

		public frmCRUDLivro()
		{
			InitializeComponent();
		}

		private void btnDeletar_Click(object sender, EventArgs e)
		{
			control.deletar();
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			control.cancelar();
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			control.salvar();
		}

		public void fechar()
		{
			Close();
		}

		public void setControl(Control.ControlBase c)
		{
			control = c as Control.CRUDLivro;
		}

		private void frmCRUDLivro_Load(object sender, EventArgs e)
		{
			control.iniciarView();
		}
	}
}
