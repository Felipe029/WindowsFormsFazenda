namespace WinFormsPIM
{
    partial class CadastroPessoas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroPessoas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtNome = new System.Windows.Forms.TextBox();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fazendaDataSet = new WinFormsPIM.FazendaDataSet();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.clientesTableAdapter = new WinFormsPIM.FazendaDataSetTableAdapters.ClientesTableAdapter();
            this.tableAdapterManager = new WinFormsPIM.FazendaDataSetTableAdapters.TableAdapterManager();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazendaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.MidnightBlue;
            this.listView1.ForeColor = System.Drawing.SystemColors.Window;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(28, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(668, 53);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(220, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(201, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Telefone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(196, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Endereço:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(223, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Email:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Chocolate;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSalvar.ForeColor = System.Drawing.Color.Black;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.ImageKey = "floppy-disk_17413370.png";
            this.btnSalvar.ImageList = this.imageList1;
            this.btnSalvar.Location = new System.Drawing.Point(266, 307);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnSalvar.Size = new System.Drawing.Size(102, 32);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "G&ravar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "floppy-disk_17413370.png");
            // 
            // txtNome
            // 
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Nome", true));
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtNome.Location = new System.Drawing.Point(284, 105);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(240, 24);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.fazendaDataSet;
            // 
            // fazendaDataSet
            // 
            this.fazendaDataSet.DataSetName = "FazendaDataSet";
            this.fazendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Email", true));
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtEmail.Location = new System.Drawing.Point(284, 201);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(240, 24);
            this.txtEmail.TabIndex = 3;
            // 
            // txtEndereco
            // 
            this.txtEndereco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Endereco", true));
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtEndereco.Location = new System.Drawing.Point(284, 252);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(240, 24);
            this.txtEndereco.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // mskTel
            // 
            this.mskTel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Telefone", true));
            this.mskTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.mskTel.Location = new System.Drawing.Point(284, 150);
            this.mskTel.Mask = "(00)00000-0000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(111, 24);
            this.mskTel.TabIndex = 2;
            this.mskTel.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = null;
            this.tableAdapterManager.ClientesTableAdapter = this.clientesTableAdapter;
            this.tableAdapterManager.FornecedorTableAdapter = null;
            this.tableAdapterManager.ProdutosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WinFormsPIM.FazendaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.Chocolate;
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnNovo.ForeColor = System.Drawing.Color.Black;
            this.btnNovo.Location = new System.Drawing.Point(155, 307);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(102, 32);
            this.btnNovo.TabIndex = 7;
            this.btnNovo.Text = "N&ovo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.White;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExcluir.ForeColor = System.Drawing.Color.Black;
            this.btnExcluir.Location = new System.Drawing.Point(488, 307);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(102, 32);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "E&xcluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(379, 307);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 32);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Ca&ncelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.MidnightBlue;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(114, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(550, 45);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cadastro de Clientes";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 376);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(704, 173);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
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
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 155;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            dataGridViewCellStyle1.Format = "(DD) DDDDD-DDDD";
            dataGridViewCellStyle1.NullValue = null;
            this.telefoneDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefoneDataGridViewTextBoxColumn.Width = 110;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "Endereço";
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            this.enderecoDataGridViewTextBoxColumn.ReadOnly = true;
            this.enderecoDataGridViewTextBoxColumn.Width = 196;
            // 
            // CadastroPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(727, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mskTel);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listView1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroPessoas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Pessoas";
            this.Load += new System.EventHandler(this.CadastroPessoas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazendaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private FazendaDataSet fazendaDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private FazendaDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private FazendaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.ImageList imageList1;
    }
}