using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TesteStefaniniWeb.Models;

namespace TesteStefaniniWeb.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Cliente()
        {
            TesteStefaniniBI.ClienteBI clienteBI = new TesteStefaniniBI.ClienteBI();
            Models.ClienteModel clienteModels = new Models.ClienteModel();
            clienteModels.clienteModels = new List<ClienteModel>();
            var res = clienteBI.SelecionarTodos();

            foreach (var item in res)
            {
                clienteModels.clienteModels.Add(new ClienteModel {
                    Codigo = item.Codigo,
                    Nome = item.Nome,
                    Sobrenome = item.Sobrenome,
                    Email = item.Email, 
                    DataNascimento = item.DataNascimento, 
                    Sexo = item.Sexo, 
                    Ativo = item.Ativo
                });
            }

            return View(clienteModels);
        }
    }
}