using System;

class Aula44{
    static void Main(){
        Carro c1 = new Carro("volks","Gol","Vermelho");
        Console.WriteLine("Marca: {0}", c1.marca);
        Console.WriteLine("Marca: {0}", c1.modelo);
        Console.WriteLine("Marca: {0}", c1.cor);
        Console.WriteLine("--------------------");
        
        Carro c2;
        c2.marca="Audi";
        c2.modelo="A3";
        c2.cor="Azul";

        Console.WriteLine("Marca: {0}", c2.marca);
        Console.WriteLine("Marca: {0}", c2.modelo);
        Console.WriteLine("Marca: {0}", c2.cor);
        


    }
}

struct Carro{
    public string marca;
    public string modelo;
    public string cor;
    public Carro(string marca,string modelo, string cor){
        this.marca = marca;
        this.modelo = modelo;
        this.cor = cor;  
    }
}