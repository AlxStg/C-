using System;

class Veiculo{ //Classe Base

    public int velMax;
    private bool ligado = false;
    private int rodas=4;

    public Veiculo(int rodas){
        this.rodas = rodas;
    }
    public void ligar(){
        ligado = true;
    }
    public void desligar(){
        ligado = false;
    }
    public string getLigado(){
        return (ligado?"sim":"não");
    }
    public int getRodas(){
        return rodas;
    }
    public void setRodas(int rodas){
        if(rodas<0){
            this.rodas=0;
        }
        else if(rodas>40){
            this.rodas = 40;
        }else{
            this.rodas = rodas;
        }
    }
    

}

class Carro:Veiculo{ // CLASSE DERIVADA
    public string nome;
    public string cor;
    public Carro(string nome, string cor):base(4){
        desligar();
        velMax=120;
        this.nome = nome;
        this.cor = cor;
    }
    public void setNome(string nome){
        this.nome = nome;
    }

    public void setCor(string cor){
        this.cor = cor;
    }

}

class CarroCombate:Carro{
    public int munição;
    
    public CarroCombate():base("Tanque", "verde"){
        munição = 100;
        setRodas(8);
        setCor("Camuflado Verde");
        setNome("Tanque de Guerra");
    }
}

class Aula35{

    static void Main(){
        Carro c1=new Carro("Civic","Azul");
        Console.WriteLine("\nModelo: {0},\nCor: {1},\nVelocidade Máxima: {2},\nRodas: {3}.\nLigado: {4}\n", c1.nome, c1.cor, c1.velMax, c1.getRodas(),c1.getLigado());

        c1.ligar();
        Console.WriteLine("\nModelo: {0},\nCor: {1},\nVelocidade Máxima: {2},\nRodas: {3}.\nLigado: {4}\n", c1.nome, c1.cor, c1.velMax, c1.getRodas(),c1.getLigado());

        CarroCombate c2=new CarroCombate();
        Console.WriteLine("\nModelo: {0},\nCor: {1},\nVelocidade Máxima: {2},\nRodas: {3}.\nLigado: {4}\n", c2.nome, c2.cor, c2.velMax, c2.getRodas(),c2.getLigado());
    }
}