using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturasDeDados
{
    internal class Fila
    {
        //Fila
        /*
         Uma fila implementa uma ordenação de tipo FIFO (First-In, First-Out), 
        onde o primeiro nomeProduto adicionado será o primeiro a ser removido. 
        Basicamente, é a mesma coisa que no mundo real! Os primeiros que chegam para serem atendidos, 
        serão atendidos primeiro, por exemplo. 
        Em .NET, a classe que implementa essa estrutura de dados é a Queue e Queue<T>.
         */

        //Métodos
        /*
         As principais operações de uma fila são:
        Enqueue: realiza a inserção de um nomeProduto.
        Peek: retorna o próximo nomeProduto, mas não remove.
        Dequeue: retorna o próximo nomeProduto, e remove.
         */

        private Queue<int> _filaAtendimento;
        private int _proximoNumeroParaGerar = 1;

        public Fila()
        {
            _filaAtendimento = new Queue<int>();
        }

        public int GerarSenha()
        {
            _filaAtendimento.Enqueue(_proximoNumeroParaGerar);

            Console.WriteLine("Senha gerada.");

            return _proximoNumeroParaGerar++;
        }

        public void ChamarProximo()
        {
            var proximoNumeroDaFila = _filaAtendimento.Dequeue();

            Console.WriteLine($"Próxima senha: {proximoNumeroDaFila}");
        }

        public void MostrarFila()
        {
            Console.Write("Senhas da Fila: ");

            foreach (var senha in _filaAtendimento)
            {
                Console.Write(senha + " ");
            }

            Console.WriteLine();
        }

        public void ReiniciarFila()
        {
            _filaAtendimento.Clear();
        }
        
    }
}
