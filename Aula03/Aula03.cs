using System;

class Aula03
{
    static void Main()
    {
        int num = 0; // Inteiro com sinal
        byte n1 = 10; // pode armazenar até 255
        char letra = 'c'; // caracter único
        float valor = 5.3f;
        string nome = "João"; // Conjunto de caracteres

        var aux = nome; // var é uma variável que pode ser do tipo qualquer - definido na compilação.
        
        Console.WriteLine(aux);
    }
}