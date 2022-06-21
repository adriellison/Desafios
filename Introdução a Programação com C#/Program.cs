using System;

//TODO: Complete os espaços em branco com uma possível solução para o problema.
class Desafio {
    static void Main() {
        int limit = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < limit; i++) 
        {
            string[] line = Console.ReadLine().Split(" ");

            double X = double.Parse(line[0]);
            double Y = double.Parse(line[1]);
            double div = X / Y;
            if (div == 0) {
                Console.WriteLine($"{div:f1}");
            } else {
                Console.WriteLine("divisao impossivel");
            }
        }
        
    }
}