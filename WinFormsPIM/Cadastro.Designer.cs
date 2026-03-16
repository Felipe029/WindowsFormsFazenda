namespace WinFormsPIM
{
    partial class Cadastro
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
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSenha2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVoltaLogin = new System.Windows.Forms.Button();
            this.radioNao = new System.Windows.Forms.RadioButton();
            this.radioSim = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.BackColor = System.Drawing.Color.Chocolate;
            this.BtnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnCadastrar.Location = new System.Drawing.Point(60, 277);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(86, 29);
            this.BtnCadastrar.TabIndex = 5;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = false;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click_1);
            // 
            // tbSenha
            // 
            this.tbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbSenha.Location = new System.Drawing.Point(198, 127);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PasswordChar = '*';
            this.tbSenha.Size = new System.Drawing.Size(111, 23);
            this.tbSenha.TabIndex = 1;
            // 
            // tbUsuario
            // 
            this.tbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbUsuario.Location = new System.Drawing.Point(198, 84);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(111, 23);
            this.tbUsuario.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(136, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(139, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Login:";
            // 
            // tbSenha2
            // 
            this.tbSenha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbSenha2.Location = new System.Drawing.Point(198, 170);
            this.tbSenha2.Name = "tbSenha2";
            this.tbSenha2.PasswordChar = '*';
            this.tbSenha2.Size = new System.Drawing.Size(111, 23);
            this.tbSenha2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(65, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Confirme a Senha:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLimpar.Location = new System.Drawing.Point(159, 277);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 29);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Chocolate;
            this.label4.Location = new System.Drawing.Point(123, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 30);
            this.label4.TabIndex = 19;
            this.label4.Text = "Crie sua conta";
            // 
            // btnVoltaLogin
            // 
            this.btnVoltaLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltaLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnVoltaLogin.Location = new System.Drawing.Point(246, 277);
            this.btnVoltaLogin.Name = "btnVoltaLogin";
            this.btnVoltaLogin.Size = new System.Drawing.Size(119, 29);
            this.btnVoltaLogin.TabIndex = 7;
            this.btnVoltaLogin.Text = "Voltar ao Login";
            this.btnVoltaLogin.UseVisualStyleBackColor = true;
            this.btnVoltaLogin.Click += new System.EventHandler(this.btnVoltaLogin_Click);
            // 
            // radioNao
            // 
            this.radioNao.AutoSize = true;
            this.radioNao.BackColor = System.Drawing.SystemColors.Control;
            this.radioNao.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.radioNao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioNao.ForeColor = System.Drawing.Color.Black;
            this.radioNao.Location = new System.Drawing.Point(270, 223);
            this.radioNao.Name = "radioNao";
            this.radioNao.Size = new System.Drawing.Size(52, 21);
            this.radioNao.TabIndex = 4;
            this.radioNao.Text = "&Não";
            this.radioNao.UseVisualStyleBackColor = false;
            // 
            // radioSim
            // 
            this.radioSim.AutoSize = true;
            this.radioSim.BackColor = System.Drawing.SystemColors.Control;
            this.radioSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioSim.ForeColor = System.Drawing.Color.Black;
            this.radioSim.Location = new System.Drawing.Point(200, 222);
            this.radioSim.Name = "radioSim";
            this.radioSim.Size = new System.Drawing.Size(49, 21);
            this.radioSim.TabIndex = 3;
            this.radioSim.Text = "Si&m";
            this.radioSim.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(96, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Funcionário?";
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 347);
            this.Controls.Add(this.radioNao);
            this.Controls.Add(this.radioSim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnVoltaLogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSenha2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSenha2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVoltaLogin;
        private System.Windows.Forms.RadioButton radioNao;
        private System.Windows.Forms.RadioButton radioSim;
        private System.Windows.Forms.Label label6;
    }
}