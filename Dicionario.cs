using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturasDeDados
{
   internal class Dicionario
   {
        //Dicionário
        /*
         O Dicionário é uma estrutura de dados que armazena pares de codigoProduto-nomeProduto. 
        O nomeProduto armazenado não está restrito a um tipo único,
        permitindo armazenar nomeProdutoes mais complexos como outros objetos ou coleções.
         */

        //Métodos
        /*
          Add(Key, Value): adiciona a codigoProduto e o nomeProduto especificados;
          ContainsKey(Key): verifica se o dicionário contém a codigoProduto especificada;
          Remove(Key): remove o registro que contenha a codigoProduto especificada;
          TryGetValue(Key, out Value): tenta obter o nomeProduto da codigoProduto especificada, retornando false caso a codigoProduto não exista no dicionário.

         */
        private Dictionary<short, string> _catalogoLoja = new Dictionary<short, string>();

        public Dicionario(short codigoProduto, string nomeProduto)
        {
            _catalogoLoja = new Dictionary<short, string>();
        }
        public Dicionario()
        {

        }

        public void AdicionarProduto(short codigoProduto, string nomeProduto)
        {
            _catalogoLoja.Add(codigoProduto, nomeProduto);
        }

        public void VerificarCodigoProduto(short codigoProduto)
        {
            if (_catalogoLoja.ContainsKey(codigoProduto))
            {
                Console.WriteLine($"Produto com o código {codigoProduto} encontrado");
            }     
            else
            {
                Console.WriteLine($"Produto com o código {codigoProduto} não encontrado");
            }
   
        }

        public void VerificarNomeProduto(string nomeProduto)
        {
            if (_catalogoLoja.ContainsValue(nomeProduto))
            {
                Console.WriteLine($"Produto com o nome {nomeProduto} encontrado");
            }
            else
            {
                Console.WriteLine($"Produto com o nome {nomeProduto} não encontrado");
            }
        }

        public void RetornarProdutos()
        {
            foreach (KeyValuePair<short, string> kvp in _catalogoLoja)
            {
                Console.WriteLine("codigoProduto = {0}, nomeProduto = {1}", kvp.Key, kvp.Value);
            }

        }

        public void RemoverProduto(short codigoProduto)
        {
            _catalogoLoja.Remove(codigoProduto);
        }
       
        


    }
}
