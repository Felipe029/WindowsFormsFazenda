using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace clmodel
{
    public class Produto
    {

        private string _categoria;
        public string Categorias
        {
            get { return _categoria; }
            set { _categoria = value; }
        }

    }
}