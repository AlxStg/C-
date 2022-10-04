using System;

class Aula39{
    static void Main(){
        Carro c1 = new Carro();
        c1.aceleracao(13);
        c1.aceleracao(13);
        c1.aceleracao(-5);
        c1.aceleracao(-5);
        Console.WriteLine("Velocidade atual: {0}", c1.getVelAtual());
    }
}

abstract class Veiculo{
    protected int velMaxima;
    protected int velAtual;
    protected bool ligado;
    public Veiculo(){
        ligado = false;
        velAtual = 0;
    }
    public void setLigar(bool ligado){
        this.ligado = ligado;
    }
    public int getVelAtual(){
        return velAtual;
    }
    abstract public void aceleracao(int mult);
}

class Carro:Veiculo{
    public Carro(){
        velMaxima=120;
    }
    override public void aceleracao(int mult){
        velAtual+=10*mult;
    }
}