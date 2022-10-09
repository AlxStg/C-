using System;

class Aula47{
    static void Main(){
        Calc calc = new Calc();
        var res = calc.somar(2.8,3,43,100.6,5);
        Console.WriteLine(res);
        Console.WriteLine("==============");

    } 
}
class Calc{
    public int somar(params int[]n){
        int res=0;
        foreach(int num in n){
            res+=num;
        }
        return res;
    }
    public double somar(params double[]n){
        double res=0;
        foreach(double num in n){
            res+=num;
        }
        return res;
    }
}
