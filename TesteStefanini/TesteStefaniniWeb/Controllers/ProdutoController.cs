using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TesteStefaniniWeb.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult Produto()
        {
            TesteStefaniniBI.ProdutoBI produtoBI = new TesteStefaniniBI.ProdutoBI();
            Models.ProdutoModel produtoModel = new Models.ProdutoModel();
            produtoModel.produtoModels = new List<Models.ProdutoModel>();
            var res = produtoBI.SelecionarTodos();

            foreach (var item in res)
            {
                produtoModel.produtoModels.Add(new Models.ProdutoModel
                {
                    Codigo = item.Codigo,
                    NomeProduto = item.NomeProduto

                });
            }

            return View(produtoModel);
        }
    }
}