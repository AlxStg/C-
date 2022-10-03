using System;

class Veiculo{ //Classe Base

    public int velMax;
    private bool ligado = false;
    public int rodas;

    public void ligar(){
        ligado = true;
    }
    public void desligar(){
        ligado = false;
    }

}

class Carro:Veiculo{ // CLASSE DERIVADA
    public string nome;
    public string cor;
    public Carro(string nome, string cor){
        desligar();
        rodas=4;
        velMax=120;
        this.nome = nome;
        this.cor = cor; 
        
    }

}


class Aula34{

    static void Main(){
        Carro c1=new Carro("Civic","Azul");
        Console.WriteLine("\nModelo: {0},\nCor: {1},\nVelocidade Máxima: {2},\nRodas: {3}.\n", c1.nome, c1.cor, c1.velMax, c1.rodas);
    }
}