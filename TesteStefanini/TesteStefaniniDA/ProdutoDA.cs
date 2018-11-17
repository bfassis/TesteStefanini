using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteStefaniniDA
{
    public class ProdutoDA
    {
        public Produto Selecionar(int codigo)
        {
            try
            {
                using (var context = new TesteStefaniniEntities1())
                {
                    var produto = context.Produto
                        .Where(x => x.Codigo == codigo).FirstOrDefault();

                    return produto;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


        public void Inserir(Produto produto)
        {
            try
            {


                using (var context = new TesteStefaniniEntities1())
                {
                    context.Entry(produto).State = EntityState.Added;
                    context.Produto.Add(produto);

                    context.SaveChanges();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


        public void InserirVinculo(VinculoClienteProduto vinculo)
        {
            try
            {


                using (var context = new TesteStefaniniEntities1())
                {
                    context.Entry(vinculo).State = EntityState.Added;
                    context.VinculoClienteProduto.Add(vinculo);

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
