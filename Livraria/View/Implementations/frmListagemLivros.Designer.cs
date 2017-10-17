namespace Livraria.View
{
	partial class frmListagemLivros
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
			this.dgvListagem = new System.Windows.Forms.DataGridView();
			this.txtFiltro = new System.Windows.Forms.TextBox();
			this.lblFiltro = new System.Windows.Forms.Label();
			this.lblListagem = new System.Windows.Forms.Label();
			this.btnAdicionar = new System.Windows.Forms.Button();
			this.lblInfoEdicao = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvListagem)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvListagem
			// 
			this.dgvListagem.AllowUserToAddRows = false;
			this.dgvListagem.AllowUserToDeleteRows = false;
			this.dgvListagem.AllowUserToOrderColumns = true;
			this.dgvListagem.AllowUserToResizeRows = false;
			this.dgvListagem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvListagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvListagem.Location = new System.Drawing.Point(12, 74);
			this.dgvListagem.MultiSelect = false;
			this.dgvListagem.Name = "dgvListagem";
			this.dgvListagem.ReadOnly = true;
			this.dgvListagem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dgvListagem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvListagem.Size = new System.Drawing.Size(577, 384);
			this.dgvListagem.TabIndex = 0;
			this.dgvListagem.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListagem_CellMouseDoubleClick);
			// 
			// txtFiltro
			// 
			this.txtFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtFiltro.Location = new System.Drawing.Point(15, 25);
			this.txtFiltro.Name = "txtFiltro";
			this.txtFiltro.Size = new System.Drawing.Size(542, 20);
			this.txtFiltro.TabIndex = 1;
			this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
			// 
			// lblFiltro
			// 
			this.lblFiltro.AutoSize = true;
			this.lblFiltro.Location = new System.Drawing.Point(12, 9);
			this.lblFiltro.Name = "lblFiltro";
			this.lblFiltro.Size = new System.Drawing.Size(74, 13);
			this.lblFiltro.TabIndex = 2;
			this.lblFiltro.Text = "Filtro por título";
			// 
			// lblListagem
			// 
			this.lblListagem.AutoSize = true;
			this.lblListagem.Location = new System.Drawing.Point(12, 58);
			this.lblListagem.Name = "lblListagem";
			this.lblListagem.Size = new System.Drawing.Size(44, 13);
			this.lblListagem.TabIndex = 3;
			this.lblListagem.Text = "Litagem";
			// 
			// btnAdicionar
			// 
			this.btnAdicionar.AccessibleDescription = "xxxx";
			this.btnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnAdicionar.Location = new System.Drawing.Point(564, 25);
			this.btnAdicionar.Name = "btnAdicionar";
			this.btnAdicionar.Size = new System.Drawing.Size(25, 23);
			this.btnAdicionar.TabIndex = 4;
			this.btnAdicionar.Text = "+";
			this.btnAdicionar.UseVisualStyleBackColor = true;
			this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
			// 
			// lblInfoEdicao
			// 
			this.lblInfoEdicao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblInfoEdicao.AutoSize = true;
			this.lblInfoEdicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInfoEdicao.Location = new System.Drawing.Point(380, 461);
			this.lblInfoEdicao.Name = "lblInfoEdicao";
			this.lblInfoEdicao.Size = new System.Drawing.Size(209, 13);
			this.lblInfoEdicao.TabIndex = 5;
			this.lblInfoEdicao.Text = "(duplo clique na grade para edição)";
			// 
			// frmListagemLivros
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(610, 487);
			this.Controls.Add(this.lblInfoEdicao);
			this.Controls.Add(this.btnAdicionar);
			this.Controls.Add(this.lblListagem);
			this.Controls.Add(this.lblFiltro);
			this.Controls.Add(this.txtFiltro);
			this.Controls.Add(this.dgvListagem);
			this.Name = "frmListagemLivros";
			this.Text = "Livros";
			this.Load += new System.EventHandler(this.frmListagemLivros_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvListagem)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvListagem;
		private System.Windows.Forms.TextBox txtFiltro;
		private System.Windows.Forms.Label lblFiltro;
		private System.Windows.Forms.Label lblListagem;
		private System.Windows.Forms.Button btnAdicionar;
		private System.Windows.Forms.Label lblInfoEdicao;
	}
}

