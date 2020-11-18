using System;

namespace Projeto2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Deseja ver a tabuada de qual número? ");
            int resposta = int.Parse(Console.ReadLine());

            int resultado;

            for (int contador = 10; contador >= 1; contador--)
            {
                resultado = resposta * contador;
                Console.WriteLine($"{resposta} * {contador} = {resultado}");

            }
        }
    }
}
