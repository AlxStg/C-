using System;

class Aula43{
    static void Main(){
        Carro c1 = new Carro();
        c1.disparar();

    }
}

public interface Veiculo{
    void ligar();
    void desligar();
    void info();
}

public interface Combate{
    void disparar();
}

class Carro:Veiculo,Combate{
    public bool ligado;
    public Carro(){

    }
    public void ligar(){
        this.ligado = true;
    }
    public void desligar(){
        this.ligado = false;
    }
    public void info(){

    }
    public void disparar(){
        Console.WriteLine("====");
        Console.WriteLine("BANG");
        Console.WriteLine("====");
    }

}