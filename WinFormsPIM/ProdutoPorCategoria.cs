using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.Sql;
using System.Data.SqlClient;
using Info.DAL;

namespace WinFormsPIM
{
    public partial class ProdutosPorCategoria : Form
    {
        public ProdutosPorCategoria()
        {
            InitializeComponent();
        }

        private void ProdutoPorCategoria_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'fazendaDataSet.Categoria'. Você pode movê-la ou removê-la conforme necessário.
            this.categoriaTableAdapter.Fill(this.fazendaDataSet.Categoria);
            // TODO: esta linha de código carrega dados na tabela 'fazendaDataSet.Produtos'. Você pode movê-la ou removê-la conforme necessário.
            //this.produtosTableAdapter.Fill(this.fazendaDataSet.Produtos);

        }
        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            this.Pesquisar((string)comboCat.SelectedValue);
        }
        public void Pesquisar(string codigoCategoria)
        {
            this.produtosBindingSource.DataSource =
                DataContextFactory.DataContext.Produtos.Where(x => x.Categoria == codigoCategoria);
        }
    }
}
  
        

