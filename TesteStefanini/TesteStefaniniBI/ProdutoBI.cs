using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteStefaniniDA;

namespace TesteStefaniniBI
{
    public class ProdutoBI
    {

        public void InserirProduto(Produto produto)
        {
            TesteStefaniniDA.ProdutoDA produtoDA = new TesteStefaniniDA.ProdutoDA();

            try
            {
                var retProduto = produtoDA.Selecionar(produto.Codigo);
                var vinculo = produto.VinculoClienteProduto;

                if (retProduto == null)
                {
                    produto.VinculoClienteProduto = null;
                    produtoDA.Inserir(produto);
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
            TesteStefaniniDA.ProdutoDA produtoDA = new TesteStefaniniDA.ProdutoDA();

            try
            {
                var retVinculo = produtoDA.SelecionarVinculo(vinculo.CodigoProduto, vinculo.CodigoCliente);

                if (retVinculo == null)
                {
                    produtoDA.InserirVinculo(vinculo);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<Produto> SelecionarTodos()
        {
            TesteStefaniniDA.ProdutoDA produtoDA = new TesteStefaniniDA.ProdutoDA();

            try
            {
                var ret = produtoDA.SelecionarTodos();

                return ret;

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
