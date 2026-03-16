namespace WinFormsPIM
{
    partial class CadastroFornecedores
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroFornecedores));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRazao = new System.Windows.Forms.TextBox();
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fazendaDataSet = new WinFormsPIM.FazendaDataSet();
            this.txtContato = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.maskedCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razaoSocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPJDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedorTableAdapter = new WinFormsPIM.FazendaDataSetTableAdapters.FornecedorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazendaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(174, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Razão Social:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(222, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "CNPJ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(208, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Contato:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(196, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Endereço:";
            // 
            // txtRazao
            // 
            this.txtRazao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "RazaoSocial", true));
            this.txtRazao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtRazao.Location = new System.Drawing.Point(292, 102);
            this.txtRazao.Name = "txtRazao";
            this.txtRazao.Size = new System.Drawing.Size(240, 24);
            this.txtRazao.TabIndex = 0;
            this.txtRazao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRazao_KeyPress);
            // 
            // fornecedorBindingSource
            // 
            this.fornecedorBindingSource.DataMember = "Fornecedor";
            this.fornecedorBindingSource.DataSource = this.fazendaDataSet;
            // 
            // fazendaDataSet
            // 
            this.fazendaDataSet.DataSetName = "FazendaDataSet";
            this.fazendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtContato
            // 
            this.txtContato.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "Contato", true));
            this.txtContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtContato.Location = new System.Drawing.Point(292, 208);
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(240, 24);
            this.txtContato.TabIndex = 2;
            // 
            // txtEndereco
            // 
            this.txtEndereco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "Endereco", true));
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtEndereco.Location = new System.Drawing.Point(292, 261);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(240, 24);
            this.txtEndereco.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancelar.Location = new System.Drawing.Point(376, 318);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 32);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Ca&ncelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.White;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExcluir.Location = new System.Drawing.Point(486, 318);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(102, 32);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "E&xcluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.Chocolate;
            this.btnGravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGravar.ImageKey = "floppy-disk_17413370.png";
            this.btnGravar.ImageList = this.imageList1;
            this.btnGravar.Location = new System.Drawing.Point(266, 318);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnGravar.Size = new System.Drawing.Size(102, 32);
            this.btnGravar.TabIndex = 5;
            this.btnGravar.Text = "G&ravar";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "floppy-disk_17413370.png");
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.Chocolate;
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdicionar.Location = new System.Drawing.Point(154, 318);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(102, 32);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "&Novo";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // maskedCNPJ
            // 
            this.maskedCNPJ.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "CNPJ", true));
            this.maskedCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.maskedCNPJ.Location = new System.Drawing.Point(292, 155);
            this.maskedCNPJ.Mask = "00,000,000/0000-00";
            this.maskedCNPJ.Name = "maskedCNPJ";
            this.maskedCNPJ.Size = new System.Drawing.Size(139, 24);
            this.maskedCNPJ.TabIndex = 1;
            this.maskedCNPJ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedCNPJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedCNPJ_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.MidnightBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(99, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(550, 45);
            this.label6.TabIndex = 19;
            this.label6.Text = "Cadastro de Fornecedores";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.MidnightBlue;
            this.listView1.ForeColor = System.Drawing.SystemColors.Window;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(27, 22);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(668, 53);
            this.listView1.TabIndex = 21;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.razaoSocialDataGridViewTextBoxColumn,
            this.cNPJDataGridViewTextBoxColumn,
            this.contatoDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fornecedorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(11, 376);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(704, 173);
            this.dataGridView1.TabIndex = 22;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // razaoSocialDataGridViewTextBoxColumn
            // 
            this.razaoSocialDataGridViewTextBoxColumn.DataPropertyName = "RazaoSocial";
            this.razaoSocialDataGridViewTextBoxColumn.HeaderText = "Razão Social";
            this.razaoSocialDataGridViewTextBoxColumn.Name = "razaoSocialDataGridViewTextBoxColumn";
            this.razaoSocialDataGridViewTextBoxColumn.ReadOnly = true;
            this.razaoSocialDataGridViewTextBoxColumn.Width = 175;
            // 
            // cNPJDataGridViewTextBoxColumn
            // 
            this.cNPJDataGridViewTextBoxColumn.DataPropertyName = "CNPJ";
            this.cNPJDataGridViewTextBoxColumn.HeaderText = "CNPJ";
            this.cNPJDataGridViewTextBoxColumn.Name = "cNPJDataGridViewTextBoxColumn";
            this.cNPJDataGridViewTextBoxColumn.ReadOnly = true;
            this.cNPJDataGridViewTextBoxColumn.Width = 120;
            // 
            // contatoDataGridViewTextBoxColumn
            // 
            this.contatoDataGridViewTextBoxColumn.DataPropertyName = "Contato";
            this.contatoDataGridViewTextBoxColumn.HeaderText = "Contato";
            this.contatoDataGridViewTextBoxColumn.Name = "contatoDataGridViewTextBoxColumn";
            this.contatoDataGridViewTextBoxColumn.ReadOnly = true;
            this.contatoDataGridViewTextBoxColumn.Width = 140;
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "Endereço";
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            this.enderecoDataGridViewTextBoxColumn.ReadOnly = true;
            this.enderecoDataGridViewTextBoxColumn.Width = 175;
            // 
            // fornecedorTableAdapter
            // 
            this.fornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // CadastroFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(727, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.maskedCNPJ);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtRazao);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtContato);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroFornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Fornecedores";
            this.Load += new System.EventHandler(this.CadastroFornecedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazendaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRazao;
        private System.Windows.Forms.TextBox txtContato;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.MaskedTextBox maskedCNPJ;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FazendaDataSet fazendaDataSet;
        private System.Windows.Forms.BindingSource fornecedorBindingSource;
        private FazendaDataSetTableAdapters.FornecedorTableAdapter fornecedorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razaoSocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPJDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.ImageList imageList1;
    }
}