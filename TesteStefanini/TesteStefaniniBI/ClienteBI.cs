using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteStefaniniDA;

namespace TesteStefaniniBI
{
    public class ClienteBI
    {
        public void InserirCliente(Cliente cliente)
        {
            TesteStefaniniDA.ClienteDA clienteDA = new TesteStefaniniDA.ClienteDA();
            try
            {
                var retCliente = clienteDA.Selecionar(cliente.Codigo);

                if (retCliente == null)
                {
                    clienteDA.Inserir(cliente);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public Cliente Selecionar(int codigo)
        {
            TesteStefaniniDA.ClienteDA clienteDA = new TesteStefaniniDA.ClienteDA();

            try
            {
              var ret=   clienteDA.Selecionar(codigo);

                return ret;

            }
            catch (Exception)
            {

                throw;
            }

        }

        public List<Cliente> SelecionarTodos()
        {
            TesteStefaniniDA.ClienteDA clienteDA = new TesteStefaniniDA.ClienteDA();

            try
            {
                var ret = clienteDA.SelecionarTodos();

                return ret;

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
