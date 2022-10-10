using System;

delegate int Op(params int []n);

class Aula50{
    static void Main(){
        int res;
        Op d1 = new Op(Math.soma);
        res = d1(10,50,10);
        Console.WriteLine("Soma : {0}", res);
        d1 = new Op(Math.multiplicacao);
        res = d1(10,50,10);
        Console.WriteLine("Multiplicação : {0}", res);
        
    }
}
class Math{
    public static int soma(params int []n){
        int res = 0;
        foreach (int numero in n){
            res += numero;
        }
        return res;
    }
    public static int multiplicacao(params int []n){
        int res = 1;
        foreach (int numero in n){
            res *= numero;
        }   
        return res;
    }
}
    