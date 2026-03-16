namespace WinFormsPIM
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(395, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(391, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha:";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbUsuario.Location = new System.Drawing.Point(449, 116);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(100, 23);
            this.tbUsuario.TabIndex = 0;
            // 
            // tbSenha
            // 
            this.tbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbSenha.Location = new System.Drawing.Point(449, 157);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PasswordChar = '*';
            this.tbSenha.Size = new System.Drawing.Size(100, 23);
            this.tbSenha.TabIndex = 1;
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnLogin.Location = new System.Drawing.Point(392, 217);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(75, 29);
            this.BtnLogin.TabIndex = 2;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnCadastrar.Location = new System.Drawing.Point(479, 216);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(80, 30);
            this.BtnCadastrar.TabIndex = 3;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(15, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(314, 244);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 347);
            this.panel1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(435, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 31);
            this.label4.TabIndex = 20;
            this.label4.Text = "Login";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 8F);
            this.label3.Location = new System.Drawing.Point(108, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "FAZENDA URBANA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 23F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(88, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 40);
            this.label5.TabIndex = 10;
            this.label5.Text = "Growasis";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 344);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}