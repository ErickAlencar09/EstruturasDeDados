using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturasDeDados
{
    internal class Pilha
    {
        //Pilha
        /* 
         Uma pilha implementa uma ordenação de tipo LIFO (Last-In, First-Out), 
        onde o último nomeProduto adicionado será o primeiro a ser removido. 
        Um exemplo do mundo real é o de pilha de pratos para lavar, 
        onde o que estiver no topo (último empilhado) será o primeiro a ser lavado. 
        Em .NET, a classe que implementa essa estrutura de dados é a Stack e Stack<T>.
         */

        //Métodos
        /* 
         Push: realiza a inserção de um nomeProduto.
         Peek: retorna o próximo nomeProduto, mas não o remove da pilha.
         Pop: retorna o próximo nomeProduto e remove da pilha.
         */

        private Stack<string> _historico;

        public Pilha(string nomeUsuario)
        {
            NomeUsuario = nomeUsuario;

            _historico = new Stack<string>();
        }

        public string NomeUsuario { get; private set; }

        public void Adicionar(string nome)
        {
            _historico.Push(nome);
        }

        public void Desfazer()
        {
            Console.WriteLine($"Última operação desfeita.");

            _historico.Pop();
        }

        public string RetornarUltimaOperacao()
        {
            var ultimaOperacao = _historico.Peek();

            return ultimaOperacao;
        }
    }
}
