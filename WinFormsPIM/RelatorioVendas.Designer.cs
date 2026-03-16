namespace WinFormsPIM
{
    partial class RelatorioVendas
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
            this.CrvVendas = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CrvVendas
            // 
            this.CrvVendas.ActiveViewIndex = -1;
            this.CrvVendas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrvVendas.Cursor = System.Windows.Forms.Cursors.Default;
            this.CrvVendas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CrvVendas.Location = new System.Drawing.Point(0, 0);
            this.CrvVendas.Name = "CrvVendas";
            this.CrvVendas.Size = new System.Drawing.Size(1024, 579);
            this.CrvVendas.TabIndex = 0;
            this.CrvVendas.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // RelatorioVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 579);
            this.Controls.Add(this.CrvVendas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RelatorioVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Vendas";
            this.Load += new System.EventHandler(this.RelatorioVendas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CrvVendas;
    }
}