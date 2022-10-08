using System;

class Aula43{
    static void Main(){
        Carro c1 = new Carro();
        c1.info();
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
    Console.WriteLine("O veiculo está ligado: {0}", motorLigado());
    }
    public void disparar(){
        Console.WriteLine("====");
        Console.WriteLine("BANG");
        Console.WriteLine("====");
    }
    public string motorLigado(){
        if (ligado){
            return  "Sim";
        }else{
            return "Não";
        }
    }

}