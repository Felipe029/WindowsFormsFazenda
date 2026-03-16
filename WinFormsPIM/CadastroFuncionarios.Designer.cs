namespace WinFormsPIM
{
    partial class txtCargaHoraria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(txtCargaHoraria));
            this.label7 = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.funcionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.mskDataAdmissao = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDeAdmissaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargaHorariaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mskCargaHoraria = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.MidnightBlue;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(129, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(550, 45);
            this.label7.TabIndex = 30;
            this.label7.Text = "Cadastro de Funcionários";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.Chocolate;
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnNovo.ForeColor = System.Drawing.Color.Black;
            this.btnNovo.Location = new System.Drawing.Point(167, 273);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(102, 32);
            this.btnNovo.TabIndex = 6;
            this.btnNovo.Text = "N&ovo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(391, 273);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 32);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Ca&ncelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.White;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExcluir.ForeColor = System.Drawing.Color.Black;
            this.btnExcluir.Location = new System.Drawing.Point(500, 273);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(102, 32);
            this.btnExcluir.TabIndex = 9;
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
            this.btnGravar.ForeColor = System.Drawing.Color.Black;
            this.btnGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGravar.ImageKey = "floppy-disk_17413370.png";
            this.btnGravar.ImageList = this.imageList1;
            this.btnGravar.Location = new System.Drawing.Point(278, 273);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnGravar.Size = new System.Drawing.Size(102, 32);
            this.btnGravar.TabIndex = 7;
            this.btnGravar.Text = "G&ravar";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click_1);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "floppy-disk_17413370.png");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(333, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 18);
            this.label4.TabIndex = 29;
            this.label4.Text = "Data de Admissão:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(413, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 28;
            this.label5.Text = "Cargo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(76, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 27;
            this.label3.Text = "Telefone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(92, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nome:";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.MidnightBlue;
            this.listView1.ForeColor = System.Drawing.SystemColors.Window;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(38, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(668, 53);
            this.listView1.TabIndex = 26;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(101, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 31;
            this.label1.Text = "CPF:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(361, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 18);
            this.label6.TabIndex = 29;
            this.label6.Text = "Carga Horária:";
            // 
            // txtNome
            // 
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionariosBindingSource, "Nome", true));
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtNome.Location = new System.Drawing.Point(156, 114);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(240, 24);
            this.txtNome.TabIndex = 0;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // funcionariosBindingSource
            // 
            this.funcionariosBindingSource.DataSource = typeof(Info.DAL.Funcionarios);
            // 
            // mskCPF
            // 
            this.mskCPF.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionariosBindingSource, "CPF", true));
            this.mskCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.mskCPF.Location = new System.Drawing.Point(156, 161);
            this.mskCPF.Mask = "000,000,000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(111, 24);
            this.mskCPF.TabIndex = 1;
            // 
            // mskTel
            // 
            this.mskTel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionariosBindingSource, "Telefone", true));
            this.mskTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.mskTel.Location = new System.Drawing.Point(156, 206);
            this.mskTel.Mask = "(00)00000-0000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(111, 24);
            this.mskTel.TabIndex = 2;
            // 
            // txtCargo
            // 
            this.txtCargo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionariosBindingSource, "Cargo", true));
            this.txtCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtCargo.Location = new System.Drawing.Point(477, 114);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(179, 24);
            this.txtCargo.TabIndex = 3;
            this.txtCargo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCargo_KeyPress);
            // 
            // mskDataAdmissao
            // 
            this.mskDataAdmissao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionariosBindingSource, "DataDeAdmissao", true));
            this.mskDataAdmissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.mskDataAdmissao.Location = new System.Drawing.Point(477, 161);
            this.mskDataAdmissao.Mask = "00/00/0000";
            this.mskDataAdmissao.Name = "mskDataAdmissao";
            this.mskDataAdmissao.Size = new System.Drawing.Size(82, 24);
            this.mskDataAdmissao.TabIndex = 4;
            this.mskDataAdmissao.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskDataAdmissao_MaskInputRejected);
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
            this.cPFDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.cargoDataGridViewTextBoxColumn,
            this.dataDeAdmissaoDataGridViewTextBoxColumn,
            this.cargaHorariaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.funcionariosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 332);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(734, 217);
            this.dataGridView1.TabIndex = 40;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
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
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            this.cPFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cargoDataGridViewTextBoxColumn
            // 
            this.cargoDataGridViewTextBoxColumn.DataPropertyName = "Cargo";
            this.cargoDataGridViewTextBoxColumn.HeaderText = "Cargo";
            this.cargoDataGridViewTextBoxColumn.Name = "cargoDataGridViewTextBoxColumn";
            this.cargoDataGridViewTextBoxColumn.ReadOnly = true;
            this.cargoDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataDeAdmissaoDataGridViewTextBoxColumn
            // 
            this.dataDeAdmissaoDataGridViewTextBoxColumn.DataPropertyName = "DataDeAdmissao";
            this.dataDeAdmissaoDataGridViewTextBoxColumn.HeaderText = "Data De Admissão";
            this.dataDeAdmissaoDataGridViewTextBoxColumn.Name = "dataDeAdmissaoDataGridViewTextBoxColumn";
            this.dataDeAdmissaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataDeAdmissaoDataGridViewTextBoxColumn.Width = 125;
            // 
            // cargaHorariaDataGridViewTextBoxColumn
            // 
            this.cargaHorariaDataGridViewTextBoxColumn.DataPropertyName = "CargaHoraria";
            this.cargaHorariaDataGridViewTextBoxColumn.HeaderText = "Carga Horária (h)";
            this.cargaHorariaDataGridViewTextBoxColumn.Name = "cargaHorariaDataGridViewTextBoxColumn";
            this.cargaHorariaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cargaHorariaDataGridViewTextBoxColumn.Width = 110;
            // 
            // mskCargaHoraria
            // 
            this.mskCargaHoraria.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionariosBindingSource, "CargaHoraria", true));
            this.mskCargaHoraria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.mskCargaHoraria.Location = new System.Drawing.Point(477, 206);
            this.mskCargaHoraria.Mask = "00";
            this.mskCargaHoraria.Name = "mskCargaHoraria";
            this.mskCargaHoraria.Size = new System.Drawing.Size(37, 24);
            this.mskCargaHoraria.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(498, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 18);
            this.label8.TabIndex = 31;
            this.label8.Text = "h";
            // 
            // txtCargaHoraria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(755, 561);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mskCargaHoraria);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.mskDataAdmissao);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.mskTel);
            this.Controls.Add(this.mskCPF);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "txtCargaHoraria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Funcionários";
            this.Load += new System.EventHandler(this.CadastroFuncionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.MaskedTextBox mskDataAdmissao;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox mskCargaHoraria;
        private System.Windows.Forms.BindingSource funcionariosBindingSource;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDeAdmissaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargaHorariaDataGridViewTextBoxColumn;
    }
}