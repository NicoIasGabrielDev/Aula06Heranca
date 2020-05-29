using System;

namespace Aula06Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            CNPJ cnpj = new CNPJ();
            cnpj.nome = Console.ReadLine();
            Console.WriteLine( cnpj.Saudacao());
        }
    }
}
