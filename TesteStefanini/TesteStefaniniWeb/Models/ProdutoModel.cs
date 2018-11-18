using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TesteStefaniniWeb.Models
{
    public class ProdutoModel
    {
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }

        public List<ProdutoModel> produtoModels { get; set; }
    }
}