namespace WinFormsPIM
{
    partial class CadastroProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroProdutos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fazendaDataSet = new WinFormsPIM.FazendaDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richtxtDesc = new System.Windows.Forms.RichTextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dataGridViewProdutos = new System.Windows.Forms.DataGridView();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtosTableAdapter = new WinFormsPIM.FazendaDataSetTableAdapters.ProdutosTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.comboCat = new System.Windows.Forms.ComboBox();
            this.tableAdapterManager = new WinFormsPIM.FazendaDataSetTableAdapters.TableAdapterManager();
            this.categoriaTableAdapter = new WinFormsPIM.FazendaDataSetTableAdapters.CategoriaTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazendaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionar.BackColor = System.Drawing.Color.Chocolate;
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdicionar.Location = new System.Drawing.Point(155, 324);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(102, 32);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "&Novo";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.BackColor = System.Drawing.Color.White;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExcluir.Location = new System.Drawing.Point(487, 324);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(102, 32);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "E&xcluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGravar.BackColor = System.Drawing.Color.Chocolate;
            this.btnGravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGravar.ImageKey = "floppy-disk_17413370.png";
            this.btnGravar.ImageList = this.imageList1;
            this.btnGravar.Location = new System.Drawing.Point(267, 324);
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
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.MidnightBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(98, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(550, 45);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cadastro de Produtos";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.MidnightBlue;
            this.listView1.ForeColor = System.Drawing.SystemColors.Window;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(26, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(668, 53);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // txtProduto
            // 
            this.txtProduto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "Nome", true));
            this.txtProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtProduto.Location = new System.Drawing.Point(258, 93);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(240, 24);
            this.txtProduto.TabIndex = 0;
            this.txtProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProduto_KeyPress);
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "Produtos";
            this.produtosBindingSource.DataSource = this.fazendaDataSet;
            // 
            // fazendaDataSet
            // 
            this.fazendaDataSet.DataSetName = "FazendaDataSet";
            this.fazendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(191, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(195, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Preço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(171, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descrição:";
            // 
            // richtxtDesc
            // 
            this.richtxtDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "Descricao", true));
            this.richtxtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.richtxtDesc.Location = new System.Drawing.Point(258, 227);
            this.richtxtDesc.Name = "richtxtDesc";
            this.richtxtDesc.Size = new System.Drawing.Size(240, 71);
            this.richtxtDesc.TabIndex = 3;
            this.richtxtDesc.Text = "";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancelar.Location = new System.Drawing.Point(377, 324);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 32);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Ca&ncelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dataGridViewProdutos
            // 
            this.dataGridViewProdutos.AllowUserToAddRows = false;
            this.dataGridViewProdutos.AllowUserToDeleteRows = false;
            this.dataGridViewProdutos.AutoGenerateColumns = false;
            this.dataGridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.precoDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn});
            this.dataGridViewProdutos.DataSource = this.produtosBindingSource;
            this.dataGridViewProdutos.Location = new System.Drawing.Point(11, 376);
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.ReadOnly = true;
            this.dataGridViewProdutos.Size = new System.Drawing.Size(704, 173);
            this.dataGridViewProdutos.TabIndex = 11;
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "Categoria";
            this.categoriaBindingSource.DataSource = this.fazendaDataSet;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(171, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Categoria:";
            // 
            // txtPreco
            // 
            this.txtPreco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "Preco", true));
            this.txtPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtPreco.Location = new System.Drawing.Point(258, 136);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(92, 24);
            this.txtPreco.TabIndex = 1;
            this.txtPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPreco_KeyPress);
            // 
            // comboCat
            // 
            this.comboCat.BackColor = System.Drawing.Color.White;
            this.comboCat.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.produtosBindingSource, "Categoria", true));
            this.comboCat.DataSource = this.categoriaBindingSource;
            this.comboCat.DisplayMember = "Categoria";
            this.comboCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboCat.FormattingEnabled = true;
            this.comboCat.Location = new System.Drawing.Point(258, 180);
            this.comboCat.Name = "comboCat";
            this.comboCat.Size = new System.Drawing.Size(240, 26);
            this.comboCat.TabIndex = 13;
            this.comboCat.ValueMember = "Categoria";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = null;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.FornecedorTableAdapter = null;
            this.tableAdapterManager.ProdutosTableAdapter = this.produtosTableAdapter;
            this.tableAdapterManager.UpdateOrder = WinFormsPIM.FazendaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Produto";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 165;
            // 
            // precoDataGridViewTextBoxColumn
            // 
            this.precoDataGridViewTextBoxColumn.DataPropertyName = "Preco";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.precoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.precoDataGridViewTextBoxColumn.HeaderText = "Preço";
            this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            this.precoDataGridViewTextBoxColumn.ReadOnly = true;
            this.precoDataGridViewTextBoxColumn.Width = 111;
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            this.categoriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoriaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.categoriaDataGridViewTextBoxColumn.Width = 135;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoDataGridViewTextBoxColumn.Width = 183;
            // 
            // CadastroProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(727, 561);
            this.Controls.Add(this.comboCat);
            this.Controls.Add(this.dataGridViewProdutos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.richtxtDesc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroProdutos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.CadastroProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazendaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richtxtDesc;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dataGridViewProdutos;
        private FazendaDataSet fazendaDataSet;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private FazendaDataSetTableAdapters.ProdutosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.ComboBox comboCat;
        private FazendaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private FazendaDataSetTableAdapters.CategoriaTableAdapter categoriaTableAdapter;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
    }
}