using System;
using System.Collections.Generic;

class Aula55{
    static void Main(){

        Dictionary <int,string> veiculos = new Dictionary<int, string>();
        
        veiculos.Add(10,"Carro");
        veiculos.Add(5,"Avião");
        veiculos.Add(0,"Navio");
        veiculos.Add(20,"Moto");
        veiculos.Add(15,"Patinete");
        
        Console.WriteLine("Tamanho do Dictionary: {0}", veiculos.Count);
        // veiculos.Clear();
        // Console.WriteLine("Tamanho do Dictionary: {0}", veiculos.Count);
        
        int chave = 20;
        if(veiculos.ContainsKey(chave)){
            Console.WriteLine("A chave {0} está na coleção!", chave);
        }else{
        Console.WriteLine("A chave {0} não esta na coleção!", chave);
        }

        int chave2 = 12;
        if(veiculos.ContainsKey(chave2)){
            Console.WriteLine("A chave {0} está na coleção!", chave2);
        }else{
        Console.WriteLine("A chave {0} não esta na coleção!", chave2);
        }

        string chave3 = "Moto";
        if(veiculos.ContainsValue(chave3)){
            Console.WriteLine("O valor {0} está na coleção!", chave3);
        }else{
        Console.WriteLine("O valor {0} não esta na coleção!", chave3);
        }
        veiculos.Remove(20);
        string chave4 = "Moto";
        if(veiculos.ContainsValue(chave4)){
            Console.WriteLine("O valor {0} está na coleção!", chave4);
        }else{
        Console.WriteLine("O valor {0} não esta na coleção!", chave4);
        }

        int chave5 = 5;
        Console.WriteLine("A chave {0} corresponte ao valor: {1}", chave5, veiculos[chave5]);

        foreach(KeyValuePair<int,string> v in veiculos){
            Console.WriteLine("{0}. {1}", v.Key, v.Value);
        }



    }
    }

    

