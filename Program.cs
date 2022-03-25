namespace EstruturasDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chamando a classe Fila.
            /*
            var Fila = new Fila();

            Fila.GerarSenha();
            Fila.GerarSenha();
            Fila.GerarSenha();

            Fila.MostrarFila();

            Fila.ChamarProximo();
            Fila.ChamarProximo();

            Fila.MostrarFila();

            Fila.GerarSenha();

            Fila.ChamarProximo();

            Fila.MostrarFila();

            Console.ReadLine();
            */


            //Chamando a classe Pilha
            /*
            var Pilha = new Pilha("TestDev");

            Pilha.Adicionar("Iniciou um artigo.");
            Pilha.Adicionar("Escreveu - Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.");
            Pilha.Adicionar("Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.");

            Pilha.Desfazer();

            Pilha.RetornarUltimaOperacao();

            Console.ReadLine();
            */

            //Chamando a classe Dicionario
            /*
            Dicionario loja = new Dicionario();

            loja.AdicionarProduto(1, "Computador");
            loja.AdicionarProduto(2, "Notebook");
            loja.AdicionarProduto(3, "Televisão");

            loja.RetornarProdutos();

            loja.RemoverProduto(3);
            Console.WriteLine("Atualizando a lista.................");
            loja.RetornarProdutos();
            Console.WriteLine("------------------");
            loja.VerificarCodigoProduto(2);
            loja.VerificarCodigoProduto(3);
            */

            //Chamando a classe Lista
            Lista clientes = new Lista();

            clientes.AdicionarCliente("Marcos");
            clientes.AdicionarCliente("Arthur");
            clientes.AdicionarCliente("Natália");

            clientes.RetornarClientes();
            Console.WriteLine("-------------");
            clientes.RemoverCliente("Natália");
            Console.WriteLine("Atualizando a lista............");
            clientes.RetornarClientes();
        }
    }
}

