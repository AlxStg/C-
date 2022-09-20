using System;

class Aula25{

    static void Main(){
        int dividendo, divisor, rest, quociente;

        dividendo = 1005447;
        divisor = 0;
        quociente = Divide(dividendo,divisor,out rest);
        Console.WriteLine("{0} dividido por {1} é igual a {2} e o resto é {3}", dividendo, divisor, quociente, rest);

        
    }

    static int Divide(int dividendo, int divisor, out int resto){

        int quociente = dividendo / divisor;
        resto =  dividendo % divisor;
        return quociente;
        
    }

}