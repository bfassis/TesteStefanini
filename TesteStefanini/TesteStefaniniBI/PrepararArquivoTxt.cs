using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteStefaniniDA;

namespace TesteStefaniniBI
{
    public class PrepararArquivoTxt
    {

        public Boolean CarregarArquivoCliente(string arquivo)
        {
            string text = string.Empty;
            string mensagem = string.Empty;
            ClienteBI clienteBI = new ClienteBI();
            try
            {
                if (!string.IsNullOrEmpty(arquivo))
                {
                    text = System.IO.File.ReadAllText(arquivo);

                    if (!string.IsNullOrEmpty(text))
                    {
                        var teste = text.Split(';').ToArray();


                        foreach (var item in teste)
                        {
                            var campos = item.Split(',').ToList();

                            Cliente cliente = new Cliente();
                            cliente.Codigo = Convert.ToInt32(campos[0]);
                            cliente.Nome = campos[1];
                            cliente.Sobrenome = campos[2];
                            cliente.DataNascimento = Convert.ToDateTime(campos[3]);
                            cliente.Sexo = campos[4];
                            cliente.Email = campos[5];
                            cliente.Ativo = Convert.ToBoolean(campos[6]);

                            clienteBI.InserirCliente(cliente);
                        }
                    }

                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public Boolean CarregarArquivoProduto(string arquivo)
        {
            string text = string.Empty;
            string mensagem = string.Empty;
            ProdutoBI produtoBI = new ProdutoBI();
            try
            {
                if (!string.IsNullOrEmpty(arquivo))
                {
                    text = System.IO.File.ReadAllText(arquivo);

                    if (!string.IsNullOrEmpty(text))
                    {
                        var teste = text.Split(';').ToArray();


                        foreach (var item in teste)
                        {
                            var campos = item.Split(',').ToList();

                            Produto produto = new Produto();
                            produto.Codigo = Convert.ToInt32(campos[0]);
                            produto.NomeProduto = campos[2];
                            produto.VinculoClienteProduto.Add(new VinculoClienteProduto()
                            {
                                CodigoCliente = Convert.ToInt32(campos[1]),
                                CodigoProduto = Convert.ToInt32(campos[0])
                            });

                            produtoBI.InserirProduto(produto);
                        }
                    }

                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                return false;
            }


        }

    }
}
