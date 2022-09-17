using System;

class Aula24{

    static void Main(){
        for(int i=0;i<2;i++)
            Ola();

        int v1,v2;
        Console.WriteLine("Digite o Primeiro Valor: ");
        v2=int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o Segundo Valor: ");
        v1=int.Parse(Console.ReadLine());
        Soma(v1,v2);
        Soma2(v1,v2);
        Console.WriteLine ("2. A soma de {0} + {1} é igual á: {2}", v1, v2, Soma2(v1,v2));



    }

    static void Ola(){
        Console.WriteLine("Alex");
        Console.WriteLine("Curso de C#");
    }
    static void Soma(int a, int b){ //Sem retorno de dados
        int resultado = a + b;
        Console.WriteLine ("A soma de {0} + {1} é igual á: {2}", a, b, resultado); 
    }
    static int Soma2(int a, int b){ //Com retorno de dados
        int resultado = a + b;
        return resultado; 
    }
}