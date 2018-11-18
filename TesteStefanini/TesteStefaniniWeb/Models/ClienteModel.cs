using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TesteStefaniniWeb.Models
{
    public class ClienteModel
    {

        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }

        public List<ClienteModel> clienteModels { get; set; }
    }
}