using System;

class Aula36{
    static void Main(){
    Carro carro=new Carro("RAM", 120);

    Console.WriteLine("Nome: {0}",carro.nome);
    Console.WriteLine("Velocidade máxima: {0}", carro.getVelMax());
    Console.WriteLine("Ligado: {0}", carro.getLigado());

    }
}
class Veiculo{
    public int velAtual;
    private int velMax;
    protected bool ligado;
    public Veiculo(int velMax){
        velAtual=0;
        this.velMax = velMax;
        ligado = false;
    }
    public int getVelMax(){
        return velMax;
    }
}

class Carro:Veiculo{
    public string nome;

    public Carro(string nome, int velocidadeMax):base(velocidadeMax){
        this.nome = nome;
        ligado = true;
    }
    public bool getLigado(){
        return ligado;
    }
}