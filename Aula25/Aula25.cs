using System;

class Aula25{

    static void Main(){
        int num=50;
        num = dobrar(ref num);
        Console.WriteLine(num);


    }

    static int dobrar(ref int valor){
        valor*=2;
        return valor;
        
    }

}