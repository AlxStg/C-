using System;

class Aula48{
    static void Main(){
        Calc calc = new Calc();
        var res = calc.fat(5);
        Console.WriteLine(res);
        

    } 
}
class Calc{
    
    public int fat(int n){
        int res;
        if(n<=1){
            res = 1;
        }else{
            res = n*fat(n-1);
        }
        return res;
    }
}
