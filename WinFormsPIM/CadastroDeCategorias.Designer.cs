namespace WinFormsPIM
{
    partial class CadastroDeCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroDeCategorias));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCat = new System.Windows.Forms.TextBox();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fazendaDataSet = new WinFormsPIM.FazendaDataSet();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnNovo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.categoriaTableAdapter = new WinFormsPIM.FazendaDataSetTableAdapters.CategoriaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazendaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(162, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categoria:";
            // 
            // txtCat
            // 
            this.txtCat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource, "Categoria", true));
            this.txtCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtCat.Location = new System.Drawing.Point(243, 122);
            this.txtCat.Name = "txtCat";
            this.txtCat.Size = new System.Drawing.Size(270, 24);
            this.txtCat.TabIndex = 0;
            this.txtCat.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtCat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCat_KeyPress);
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancelar.Location = new System.Drawing.Point(340, 190);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 32);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Ca&ncelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.White;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExcluir.Location = new System.Drawing.Point(450, 190);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(102, 32);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "E&xcluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.Chocolate;
            this.btnGravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGravar.ImageKey = "floppy-disk_17413370.png";
            this.btnGravar.ImageList = this.imageList1;
            this.btnGravar.Location = new System.Drawing.Point(230, 190);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnGravar.Size = new System.Drawing.Size(102, 32);
            this.btnGravar.TabIndex = 2;
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
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.Chocolate;
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnNovo.Location = new System.Drawing.Point(118, 190);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(102, 32);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.categoriaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 257);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(624, 223);
            this.dataGridView1.TabIndex = 18;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            this.categoriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoriaDataGridViewTextBoxColumn.Width = 200;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.MidnightBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(110, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(500, 45);
            this.label5.TabIndex = 19;
            this.label5.Text = "Cadastro de Categorias";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.MidnightBlue;
            this.listView1.ForeColor = System.Drawing.SystemColors.Window;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(29, 20);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(589, 53);
            this.listView1.TabIndex = 21;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // CadastroDeCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(650, 492);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.txtCat);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroDeCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Cadastro de Categorias";
            this.Load += new System.EventHandler(this.CadastroDeCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazendaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCat;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listView1;
        private FazendaDataSet fazendaDataSet;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private FazendaDataSetTableAdapters.CategoriaTableAdapter categoriaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.ImageList imageList1;
    }
}