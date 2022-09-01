using System;

class Aula08 {
    static void Main() {
        int v1, v2, soma;

        Console.WriteLine("Digite um numero: ");
        v1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite outro numero: ");
        v2 = int.Parse(Console.ReadLine());
        soma = v1 + v2;
        Console.WriteLine("A soma de {0} + {1} = {2}", v1, v2, soma);

        
    }
}