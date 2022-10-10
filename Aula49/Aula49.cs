using System;

class Aula49{
    static void Main(){
        double vpi = Math.pi;
        int num = 22222;

        Console.WriteLine(Math.dobro(num));
        Console.WriteLine(vpi);
    }
}

class Math{
    public static double pi = 3.14;

    public static int dobro(int n){
        return n * 2;
    } 
}