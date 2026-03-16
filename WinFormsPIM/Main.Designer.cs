namespace WinFormsPIM
{
    partial class Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosPorCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.escolherProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produçãoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(140)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.produtosToolStripMenuItem2,
            this.relatóriosToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(600, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pessoasToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.fornecedoresToolStripMenuItem1,
            this.categoriasToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.cadastroToolStripMenuItem.Text = "&Cadastro";
            // 
            // pessoasToolStripMenuItem
            // 
            this.pessoasToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(193)))), ((int)(((byte)(98)))));
            this.pessoasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.funcionáriosToolStripMenuItem});
            this.pessoasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pessoasToolStripMenuItem.Image")));
            this.pessoasToolStripMenuItem.Name = "pessoasToolStripMenuItem";
            this.pessoasToolStripMenuItem.Size = new System.Drawing.Size(181, 36);
            this.pessoasToolStripMenuItem.Text = "Pessoas";
            this.pessoasToolStripMenuItem.Click += new System.EventHandler(this.pessoasToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(193)))), ((int)(((byte)(98)))));
            this.clientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clientesToolStripMenuItem.Image")));
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(175, 36);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(193)))), ((int)(((byte)(98)))));
            this.funcionáriosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("funcionáriosToolStripMenuItem.Image")));
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(175, 36);
            this.funcionáriosToolStripMenuItem.Text = "Funcionários";
            this.funcionáriosToolStripMenuItem.Click += new System.EventHandler(this.funcionáriosToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(193)))), ((int)(((byte)(98)))));
            this.produtosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("produtosToolStripMenuItem.Image")));
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(181, 36);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // fornecedoresToolStripMenuItem1
            // 
            this.fornecedoresToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(193)))), ((int)(((byte)(98)))));
            this.fornecedoresToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("fornecedoresToolStripMenuItem1.Image")));
            this.fornecedoresToolStripMenuItem1.Name = "fornecedoresToolStripMenuItem1";
            this.fornecedoresToolStripMenuItem1.Size = new System.Drawing.Size(181, 36);
            this.fornecedoresToolStripMenuItem1.Text = "Fornecedores";
            this.fornecedoresToolStripMenuItem1.Click += new System.EventHandler(this.fornecedoresToolStripMenuItem1_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(193)))), ((int)(((byte)(98)))));
            this.categoriasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("categoriasToolStripMenuItem.Image")));
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(181, 36);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosPorCategoriaToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // produtosPorCategoriaToolStripMenuItem
            // 
            this.produtosPorCategoriaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(193)))), ((int)(((byte)(98)))));
            this.produtosPorCategoriaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("produtosPorCategoriaToolStripMenuItem.Image")));
            this.produtosPorCategoriaToolStripMenuItem.Name = "produtosPorCategoriaToolStripMenuItem";
            this.produtosPorCategoriaToolStripMenuItem.Size = new System.Drawing.Size(247, 36);
            this.produtosPorCategoriaToolStripMenuItem.Text = "Produtos por Categoria";
            this.produtosPorCategoriaToolStripMenuItem.Click += new System.EventHandler(this.produtosPorCategoriaToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem2
            // 
            this.produtosToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.escolherProdutosToolStripMenuItem});
            this.produtosToolStripMenuItem2.Name = "produtosToolStripMenuItem2";
            this.produtosToolStripMenuItem2.Size = new System.Drawing.Size(161, 24);
            this.produtosToolStripMenuItem2.Text = "C&arrinho de Compras";
            // 
            // escolherProdutosToolStripMenuItem
            // 
            this.escolherProdutosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(193)))), ((int)(((byte)(98)))));
            this.escolherProdutosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("escolherProdutosToolStripMenuItem.Image")));
            this.escolherProdutosToolStripMenuItem.Name = "escolherProdutosToolStripMenuItem";
            this.escolherProdutosToolStripMenuItem.Size = new System.Drawing.Size(210, 36);
            this.escolherProdutosToolStripMenuItem.Text = "Escolher Produtos";
            this.escolherProdutosToolStripMenuItem.Click += new System.EventHandler(this.escolherProdutosToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendasToolStripMenuItem,
            this.produçãoToolStripMenuItem1});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.relatóriosToolStripMenuItem.Text = "Re&latórios";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(193)))), ((int)(((byte)(98)))));
            this.vendasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("vendasToolStripMenuItem.Image")));
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(155, 36);
            this.vendasToolStripMenuItem.Text = "Vendas";
            this.vendasToolStripMenuItem.Click += new System.EventHandler(this.vendasToolStripMenuItem_Click);
            // 
            // produçãoToolStripMenuItem1
            // 
            this.produçãoToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(193)))), ((int)(((byte)(98)))));
            this.produçãoToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("produçãoToolStripMenuItem1.Image")));
            this.produçãoToolStripMenuItem1.Name = "produçãoToolStripMenuItem1";
            this.produçãoToolStripMenuItem1.Size = new System.Drawing.Size(155, 36);
            this.produçãoToolStripMenuItem1.Text = "Produção";
            this.produçãoToolStripMenuItem1.Click += new System.EventHandler(this.produçãoToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(68, 24);
            this.toolStripMenuItem1.Text = "Logout";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.sairToolStripMenuItem.Text = "&Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(112, 56);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(386, 277);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(219, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 44);
            this.label1.TabIndex = 8;
            this.label1.Text = "Growasis";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.label2.Location = new System.Drawing.Point(240, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "FAZENDA URBANA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(600, 380);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produçãoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pessoasToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem escolherProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosPorCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

