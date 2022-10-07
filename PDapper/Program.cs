using PDapper.Model;
using PDapper.Service;
using System;

namespace PDapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");

            Cliente cliente = new Cliente()
            {
                Nome = "Teste",
                Telefone = "16 992356741"
            };
            new ClienteService().Add(cliente);

            new ClienteService().GetAll().ForEach(x => Console.WriteLine(x));

            Console.WriteLine("Ufa!");
        }
    }
}
