//Abaixo segue um exemplo de código que você pode ou não utilizar
using System;

namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C;
            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            C = double.Parse(Console.ReadLine());
//TODO: Complete os espaços em branco com uma possível solução para o desafio
            Console.WriteLine($"MEDIA = {(((A * 2) + (B * 3) + (C * 5))/10):f1}");
            Console.ReadKey();
        }
    }
}