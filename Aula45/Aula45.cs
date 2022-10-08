using System;

class Aula44{
    static void Main(){
        Carro[] carros = new Carro[3];
        
        carros[0].modelo="Civic";
        carros[0].cor="Azul";

        carros[1].modelo="Veloster";
        carros[1].cor="Vermelho";

        carros[2].modelo="Lamborghini";
        carros[2].cor="Branca";

        Console.WriteLine("------------------------"); 
        int contador = 1;
        foreach (var carro in carros)
        {
            Console.WriteLine("CARRO {0}", contador);
            carro.info();
            contador+=1;
            
        }
        



    }
}

struct Carro{
    public string modelo;
    public string cor;
       public void info(){
        Console.WriteLine("  Modelo: {0}", modelo);
        Console.WriteLine("  Cor: {0}", cor);
        Console.WriteLine("------------------------");
    }
}