using System;

class aula46{
    static void Main(){
        Galinha g1=new Galinha("Concom");
        Galinha g2=new Galinha("Minerva");
        Galinha g3=new Galinha("Gertrudes");

        g2.botar();
        g1.botar();
        g2.botar();
        g1.botar();
        g1.botar();
        g2.botar();

    }
}

class Galinha{
    private string nomeGalinha;
    private int numOvo;
    public Galinha(string nomeGalinha){
        this.nomeGalinha=nomeGalinha;
        numOvo = 0;
    }
    public Ovo botar(){
        numOvo++;
        return new Ovo(numOvo,nomeGalinha);
    }
}

class Ovo{
    private int numOvo;
    private string minhaGalinha;
    public Ovo(int numOvo, string minhaGalinha){
        this.numOvo=numOvo;
        this.minhaGalinha=minhaGalinha;
        Console.WriteLine("{0} pôs um ovo! ---  Tem {1} ovo(s).", minhaGalinha, numOvo);
    }
}