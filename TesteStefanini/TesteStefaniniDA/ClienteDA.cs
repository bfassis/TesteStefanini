using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteStefaniniDA
{
    public class ClienteDA
    {
        public Cliente Selecionar(int codigo)
        {
            try
            {
                using (var context = new TesteStefaniniEntities1())
                {
                    var cliente = context.Cliente
                        .Where(x => x.Codigo == codigo).FirstOrDefault();

                    return cliente;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


        private void Inserir(Cliente cliente)
        {
            try
            {
                

                using (var context = new TesteStefaniniEntities1())
                {
                    context.Entry(cliente).State = EntityState.Added;
                    context.Cliente.Add(cliente);

                    context.SaveChanges();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void InserirCliente(Cliente cliente)
        {
            try
            {
                var retCliente = Selecionar(cliente.Codigo);

                if (retCliente == null)
                {
                    Inserir(cliente);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

    }
}
