using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturasDeDados
{
    internal class Lista
    {
        //Lista
        /*
         Representa uma lista fortemente tipada de objetos que podem ser acessados por índice.
        Fornece métodos para pesquisar, classificar e manipular listas.

         */

        //Métodos

        /*
         Add(T): Adiciona um objeto ao final do List<T>.
        Remove(T): Remove a primeira ocorrência de um objeto especifico do lis<T>.
        Sort(): Organiza a lista.
         */

        private List<string> _customers = new List<string>();

        public Lista(string customerName)
        {
            _customers = new List<string>();
        }

        public Lista()
        {
            _customers = new List<string>();
        }

        public void AdicionarCliente(string customerName)
        {
            _customers.Add(customerName);
            if(customerName == null)
            {
                throw new ArgumentNullException();
            }
        }

        public void RemoverCliente(string customerName)
        {
            _customers.Remove(customerName);
            if (customerName == null)
            {
                throw new ArgumentNullException();
            }
        }

        public void RetornarClientes()
        {
            _customers.Sort();
            foreach(string nome in _customers)
            {
                Console.WriteLine(nome);
            }
        }
       



    }
}
