namespace WinFormsPIM
{
    partial class CarrinhoDeCompras
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnFinalizarCompra = new System.Windows.Forms.Button();
            this.comboQtd = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.txtValorTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(306, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Preço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(529, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Quantidade";
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.Firebrick;
            this.btnRemover.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRemover.Location = new System.Drawing.Point(591, 128);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(78, 28);
            this.btnRemover.TabIndex = 1;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            // 
            // btnFinalizarCompra
            // 
            this.btnFinalizarCompra.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnFinalizarCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizarCompra.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.btnFinalizarCompra.FlatAppearance.BorderSize = 5;
            this.btnFinalizarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarCompra.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarCompra.ForeColor = System.Drawing.Color.White;
            this.btnFinalizarCompra.Location = new System.Drawing.Point(301, 383);
            this.btnFinalizarCompra.Name = "btnFinalizarCompra";
            this.btnFinalizarCompra.Size = new System.Drawing.Size(226, 51);
            this.btnFinalizarCompra.TabIndex = 2;
            this.btnFinalizarCompra.Text = "FINALIZAR COMPRA";
            this.btnFinalizarCompra.UseVisualStyleBackColor = false;
            this.btnFinalizarCompra.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // comboQtd
            // 
            this.comboQtd.BackColor = System.Drawing.Color.White;
            this.comboQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboQtd.FormattingEnabled = true;
            this.comboQtd.ItemHeight = 16;
            this.comboQtd.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboQtd.Location = new System.Drawing.Point(536, 130);
            this.comboQtd.Name = "comboQtd";
            this.comboQtd.Size = new System.Drawing.Size(40, 24);
            this.comboQtd.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(169, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(482, 45);
            this.label5.TabIndex = 9;
            this.label5.Text = "Carrinho de Compras";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Black;
            this.listView1.ForeColor = System.Drawing.SystemColors.Window;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(74, 339);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(668, 1);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(577, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Total:";
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.Color.Black;
            this.listView2.ForeColor = System.Drawing.SystemColors.Window;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(74, 112);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(668, 1);
            this.listView2.TabIndex = 14;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.AutoSize = true;
            this.txtValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.Location = new System.Drawing.Point(639, 351);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(69, 16);
            this.txtValorTotal.TabIndex = 15;
            this.txtValorTotal.Text = "Valor Aqui";
            // 
            // CarrinhoDeCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboQtd);
            this.Controls.Add(this.btnFinalizarCompra);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CarrinhoDeCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carrinho De Compras";
            this.Load += new System.EventHandler(this.CarrinhoDeCompras_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.ComboBox comboQtd;
        private System.Windows.Forms.Button btnFinalizarCompra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label txtValorTotal;
    }
}