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
                        .Where(x => x.Codigo == codigo).Include(x=> x.VinculoClienteProduto).FirstOrDefault();

                    return cliente;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<Cliente> SelecionarTodos()
        {
            try
            {
                using (var context = new TesteStefaniniEntities1())
                {
                    var cliente = context.Cliente.Include(x => x.VinculoClienteProduto).ToList();

                    return cliente;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void Inserir(Cliente cliente)
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

       
    }
}
