using System;

class Teste{
    static void Main(){
        Sensor Temp1 = new Sensor("Temperatura1", 2.1);
        Temp1.infoSensor();
        Temp1.AtivarSensor();
        Temp1.infoSensor();


    }
}

public class Sensor{
    string tipo;
    bool ativo;
    double leitura;

    public Sensor(string tipo,double leitura){
        this.tipo=tipo;
        ativo = false;
        this.leitura=leitura;
    }

    public void AtivarSensor(){
        ativo = true;
        Console.WriteLine("Ativando sensor");
    }

    public void DesativarSensor(){
        ativo = false;
        Console.WriteLine("Desativando sensor");
    }

    public void infoSensor(){
        string estaAtivo;
        if(ativo){
            estaAtivo = "Sim";
        }else{
            estaAtivo = "Não";
        }
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Tipo de Sensor: {0}", tipo);
        Console.WriteLine("Está ativo? {0}", estaAtivo);
        if(ativo){
            Console.WriteLine("Leitura: {0}", leitura);
        }
        Console.WriteLine("---------------------------------");

    }


}

