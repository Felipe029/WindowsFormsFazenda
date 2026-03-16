using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsPIM
{
    public partial class RelatorioProdutos : Form
    {
        public RelatorioProdutos()
        {
            InitializeComponent();
        }

        private void RelatorioProdutos_Load(object sender, EventArgs e)
        {
            ReportDocument rd = new ReportDocument();
            rd.Load(@"C:\Users\felip\source\repos\WinFormsPIM\WinFormsPIM\RelatórioProdutos\Produtos.rpt");
            CrvProdutos.ReportSource = rd;
            CrvProdutos.RefreshReport();
        
        }
    }
}
