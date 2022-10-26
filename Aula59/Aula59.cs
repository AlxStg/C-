using System;
using System.Collections.Generic;

class Aula59{
    static void Main(){
        string[] vs = {"Carro","Moto","Navio","Aviao"};
        Queue<string>veiculos=new Queue<string>(vs);
        
        string teste1 = "Carro";
        string teste2 = "Patins";

        //veiculos.Clear();
        Console.WriteLine("Saiu veiculo: {0}", veiculos.Dequeue());
        Console.WriteLine("Primeiro veiculo: {0}", veiculos.Peek());

        Console.WriteLine("---------------------------------");
        if (veiculos.Contains(teste1)){
            Console.WriteLine("A fila contem: {0}", teste1);
        }else{Console.WriteLine("A fila NÃO contem: {0}", teste1);}

        if (veiculos.Contains(teste2)){
            Console.WriteLine("A fila contem: {0}", teste2);
        }else{Console.WriteLine("A fila NÃO contem: {0}", teste2);}
        Console.WriteLine("---------------------------------");

        Console.WriteLine(">>>> Tamanho da Fila {0}", veiculos.Count);

        Console.WriteLine("---------------------------------");
        Console.WriteLine(">>>> Elementos Enfileirados");
        int contElem = 0;
        foreach(string vel in veiculos){
            contElem ++;
            Console.WriteLine("     {0}. {1}", contElem, vel);
        }
        Console.WriteLine("---------------------------------");

    }
}

