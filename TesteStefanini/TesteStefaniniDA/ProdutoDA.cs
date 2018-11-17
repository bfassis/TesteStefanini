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
                        .Where(x => x.Codigo == codigo).Include(x => x.VinculoClienteProduto).FirstOrDefault();

                    return produto;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public VinculoClienteProduto SelecionarVinculo(int codigo, int cliente)
        {
            try
            {
                using (var context = new TesteStefaniniEntities1())
                {
                    var vinculo = context.VinculoClienteProduto
                        .Where(x => x.CodigoProduto == codigo && x.CodigoCliente == cliente).FirstOrDefault();

                    return vinculo;
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

        public void InserirProduto(Produto produto)
        {
            try
            {
                var retProduto = Selecionar(produto.Codigo);
                var vinculo = produto.VinculoClienteProduto;

                if (retProduto == null)
                {
                    produto.VinculoClienteProduto = null;
                    Inserir(produto);
                }

                InserirVinculoProduto(vinculo.FirstOrDefault());

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void InserirVinculoProduto(VinculoClienteProduto vinculo)
        {
            try
            {
                var retVinculo = SelecionarVinculo(vinculo.CodigoProduto, vinculo.CodigoCliente);

                if (retVinculo == null)
                {
                    InserirVinculo(vinculo);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

    }
}
