using System;
using System.Collections.Generic;
using System.IO;
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

        public ActionResult UploadProduto()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Upload(HttpPostedFileBase file)
        {
            TesteStefaniniBI.PrepararArquivoTxt prepararArquivoTxt = new TesteStefaniniBI.PrepararArquivoTxt();

            if (file != null && file.ContentLength > 0)
            {
                var fileName = Path.GetFileName(file.FileName);
                var path = Path.Combine(Server.MapPath("~/arquivos/"), fileName);
                file.SaveAs(path);

                prepararArquivoTxt.CarregarArquivoProduto(path);
            }

            return RedirectToAction("Produto");
        }
    }
}