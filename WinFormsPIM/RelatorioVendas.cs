using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;


namespace WinFormsPIM
{
    public partial class RelatorioVendas : Form
    {
        public RelatorioVendas()
        {
            InitializeComponent();
        }

        public void RelatorioVendas_Load(object sender, EventArgs e)
        {
            ReportDocument rd = new ReportDocument();
            rd.Load(@"C:\Users\felip\source\repos\WinFormsPIM\WinFormsPIM\RelatórioVendas\Vendas.rpt");
            CrvVendas.ReportSource = rd;
            CrvVendas.RefreshReport();
            }
    }
    }

