namespace WinFormsPIM
{
    partial class ProdutosPorCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProdutosPorCategoria));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.txtCat = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboCat = new System.Windows.Forms.ComboBox();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fazendaDataSet = new WinFormsPIM.FazendaDataSet();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtosTableAdapter = new WinFormsPIM.FazendaDataSetTableAdapters.ProdutosTableAdapter();
            this.categoriaTableAdapter = new WinFormsPIM.FazendaDataSetTableAdapters.CategoriaTableAdapter();
            this.tableAdapterManager = new WinFormsPIM.FazendaDataSetTableAdapters.TableAdapterManager();
            this.produtosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazendaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.MidnightBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(111, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(500, 45);
            this.label5.TabIndex = 29;
            this.label5.Text = "Produtos por Categoria";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.MidnightBlue;
            this.listView1.ForeColor = System.Drawing.SystemColors.Window;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(33, 21);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(589, 53);
            this.listView1.TabIndex = 31;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.BackColor = System.Drawing.Color.Chocolate;
            this.BtnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnPesquisar.Location = new System.Drawing.Point(503, 109);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(102, 32);
            this.BtnPesquisar.TabIndex = 24;
            this.BtnPesquisar.Text = "P&esquisar";
            this.BtnPesquisar.UseVisualStyleBackColor = false;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // txtCat
            // 
            this.txtCat.AutoSize = true;
            this.txtCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtCat.ForeColor = System.Drawing.Color.White;
            this.txtCat.Location = new System.Drawing.Point(56, 114);
            this.txtCat.Name = "txtCat";
            this.txtCat.Size = new System.Drawing.Size(76, 18);
            this.txtCat.TabIndex = 23;
            this.txtCat.Text = "Categoria:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // comboCat
            // 
            this.comboCat.DataSource = this.categoriaBindingSource;
            this.comboCat.DisplayMember = "Categoria";
            this.comboCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboCat.FormattingEnabled = true;
            this.comboCat.Location = new System.Drawing.Point(137, 112);
            this.comboCat.Name = "comboCat";
            this.comboCat.Size = new System.Drawing.Size(343, 26);
            this.comboCat.TabIndex = 32;
            this.comboCat.ValueMember = "Categoria";
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "Categoria";
            this.categoriaBindingSource.DataSource = this.fazendaDataSet;
            // 
            // fazendaDataSet
            // 
            this.fazendaDataSet.DataSetName = "FazendaDataSet";
            this.fazendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "Produtos";
            this.produtosBindingSource.DataSource = this.fazendaDataSet;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = this.categoriaTableAdapter;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.FornecedorTableAdapter = null;
            this.tableAdapterManager.ProdutosTableAdapter = this.produtosTableAdapter;
            this.tableAdapterManager.UpdateOrder = WinFormsPIM.FazendaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // produtosDataGridView
            // 
            this.produtosDataGridView.AllowUserToAddRows = false;
            this.produtosDataGridView.AllowUserToDeleteRows = false;
            this.produtosDataGridView.AutoGenerateColumns = false;
            this.produtosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produtosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.produtosDataGridView.DataSource = this.produtosBindingSource;
            this.produtosDataGridView.Location = new System.Drawing.Point(13, 172);
            this.produtosDataGridView.Name = "produtosDataGridView";
            this.produtosDataGridView.ReadOnly = true;
            this.produtosDataGridView.Size = new System.Drawing.Size(624, 306);
            this.produtosDataGridView.TabIndex = 32;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Produtos";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Preco";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn3.HeaderText = "Preço";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // ProdutosPorCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(650, 494);
            this.Controls.Add(this.produtosDataGridView);
            this.Controls.Add(this.comboCat);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.txtCat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProdutosPorCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos Por Categoria";
            this.Load += new System.EventHandler(this.ProdutoPorCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazendaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.Label txtCat;
        private System.Windows.Forms.ComboBox comboCat;
        private FazendaDataSet fazendaDataSet;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private FazendaDataSetTableAdapters.ProdutosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private FazendaDataSetTableAdapters.CategoriaTableAdapter categoriaTableAdapter;
        private FazendaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView produtosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}