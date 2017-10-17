namespace Livraria.View
{
	partial class frmCRUDLivro
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnSalvar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.txtId = new System.Windows.Forms.TextBox();
			this.txtTitulo = new System.Windows.Forms.TextBox();
			this.txtAutor = new System.Windows.Forms.TextBox();
			this.txtEditora = new System.Windows.Forms.TextBox();
			this.lblId = new System.Windows.Forms.Label();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.lblAutor = new System.Windows.Forms.Label();
			this.lblEditora = new System.Windows.Forms.Label();
			this.lblEdicao = new System.Windows.Forms.Label();
			this.lblSinopse = new System.Windows.Forms.Label();
			this.txtEdicao = new System.Windows.Forms.TextBox();
			this.txtSinopse = new System.Windows.Forms.TextBox();
			this.btnDeletar = new System.Windows.Forms.Button();
			this.txtEstoque = new System.Windows.Forms.TextBox();
			this.lblEstoque = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnSalvar
			// 
			this.btnSalvar.Location = new System.Drawing.Point(383, 248);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(75, 23);
			this.btnSalvar.TabIndex = 16;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(302, 248);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 17;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// txtId
			// 
			this.txtId.Enabled = false;
			this.txtId.Location = new System.Drawing.Point(134, 6);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(100, 20);
			this.txtId.TabIndex = 3;
			// 
			// txtTitulo
			// 
			this.txtTitulo.Location = new System.Drawing.Point(134, 32);
			this.txtTitulo.Name = "txtTitulo";
			this.txtTitulo.Size = new System.Drawing.Size(324, 20);
			this.txtTitulo.TabIndex = 4;
			// 
			// txtAutor
			// 
			this.txtAutor.Location = new System.Drawing.Point(134, 58);
			this.txtAutor.Name = "txtAutor";
			this.txtAutor.Size = new System.Drawing.Size(232, 20);
			this.txtAutor.TabIndex = 5;
			// 
			// txtEditora
			// 
			this.txtEditora.Location = new System.Drawing.Point(134, 84);
			this.txtEditora.Name = "txtEditora";
			this.txtEditora.Size = new System.Drawing.Size(232, 20);
			this.txtEditora.TabIndex = 6;
			// 
			// lblId
			// 
			this.lblId.AutoSize = true;
			this.lblId.Location = new System.Drawing.Point(12, 9);
			this.lblId.Name = "lblId";
			this.lblId.Size = new System.Drawing.Size(65, 13);
			this.lblId.TabIndex = 7;
			this.lblId.Text = "Identificador";
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Location = new System.Drawing.Point(12, 35);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(35, 13);
			this.lblTitulo.TabIndex = 8;
			this.lblTitulo.Text = "Título";
			// 
			// lblAutor
			// 
			this.lblAutor.AutoSize = true;
			this.lblAutor.Location = new System.Drawing.Point(12, 61);
			this.lblAutor.Name = "lblAutor";
			this.lblAutor.Size = new System.Drawing.Size(32, 13);
			this.lblAutor.TabIndex = 9;
			this.lblAutor.Text = "Autor";
			// 
			// lblEditora
			// 
			this.lblEditora.AutoSize = true;
			this.lblEditora.Location = new System.Drawing.Point(12, 87);
			this.lblEditora.Name = "lblEditora";
			this.lblEditora.Size = new System.Drawing.Size(40, 13);
			this.lblEditora.TabIndex = 10;
			this.lblEditora.Text = "Editora";
			// 
			// lblEdicao
			// 
			this.lblEdicao.AutoSize = true;
			this.lblEdicao.Location = new System.Drawing.Point(12, 113);
			this.lblEdicao.Name = "lblEdicao";
			this.lblEdicao.Size = new System.Drawing.Size(40, 13);
			this.lblEdicao.TabIndex = 11;
			this.lblEdicao.Text = "Edição";
			// 
			// lblSinopse
			// 
			this.lblSinopse.AutoSize = true;
			this.lblSinopse.Location = new System.Drawing.Point(12, 165);
			this.lblSinopse.Name = "lblSinopse";
			this.lblSinopse.Size = new System.Drawing.Size(45, 13);
			this.lblSinopse.TabIndex = 12;
			this.lblSinopse.Text = "Sinopse";
			// 
			// txtEdicao
			// 
			this.txtEdicao.Location = new System.Drawing.Point(134, 110);
			this.txtEdicao.Name = "txtEdicao";
			this.txtEdicao.Size = new System.Drawing.Size(100, 20);
			this.txtEdicao.TabIndex = 13;
			// 
			// txtSinopse
			// 
			this.txtSinopse.Location = new System.Drawing.Point(134, 162);
			this.txtSinopse.Multiline = true;
			this.txtSinopse.Name = "txtSinopse";
			this.txtSinopse.Size = new System.Drawing.Size(324, 80);
			this.txtSinopse.TabIndex = 15;
			// 
			// btnDeletar
			// 
			this.btnDeletar.Location = new System.Drawing.Point(191, 248);
			this.btnDeletar.Name = "btnDeletar";
			this.btnDeletar.Size = new System.Drawing.Size(75, 23);
			this.btnDeletar.TabIndex = 18;
			this.btnDeletar.Text = "Deletar";
			this.btnDeletar.UseVisualStyleBackColor = true;
			this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
			// 
			// txtEstoque
			// 
			this.txtEstoque.Location = new System.Drawing.Point(134, 136);
			this.txtEstoque.Name = "txtEstoque";
			this.txtEstoque.Size = new System.Drawing.Size(100, 20);
			this.txtEstoque.TabIndex = 14;
			// 
			// lblEstoque
			// 
			this.lblEstoque.AutoSize = true;
			this.lblEstoque.Location = new System.Drawing.Point(12, 139);
			this.lblEstoque.Name = "lblEstoque";
			this.lblEstoque.Size = new System.Drawing.Size(120, 13);
			this.lblEstoque.TabIndex = 16;
			this.lblEstoque.Text = "Quantidade em estoque";
			// 
			// frmCRUDLivro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(470, 282);
			this.Controls.Add(this.txtEstoque);
			this.Controls.Add(this.lblEstoque);
			this.Controls.Add(this.btnDeletar);
			this.Controls.Add(this.txtSinopse);
			this.Controls.Add(this.txtEdicao);
			this.Controls.Add(this.lblSinopse);
			this.Controls.Add(this.lblEdicao);
			this.Controls.Add(this.lblEditora);
			this.Controls.Add(this.lblAutor);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.lblId);
			this.Controls.Add(this.txtEditora);
			this.Controls.Add(this.txtAutor);
			this.Controls.Add(this.txtTitulo);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnSalvar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmCRUDLivro";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Livro";
			this.Load += new System.EventHandler(this.frmCRUDLivro_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.TextBox txtTitulo;
		private System.Windows.Forms.TextBox txtAutor;
		private System.Windows.Forms.TextBox txtEditora;
		private System.Windows.Forms.Label lblId;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblAutor;
		private System.Windows.Forms.Label lblEditora;
		private System.Windows.Forms.Label lblEdicao;
		private System.Windows.Forms.Label lblSinopse;
		private System.Windows.Forms.TextBox txtEdicao;
		private System.Windows.Forms.TextBox txtSinopse;
		private System.Windows.Forms.Button btnDeletar;
		private System.Windows.Forms.TextBox txtEstoque;
		private System.Windows.Forms.Label lblEstoque;
	}
}