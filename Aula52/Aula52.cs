using System;

class Aula52{
    static void Main(){
        int n1,n2,res;
        res=n1=n2=0;

        n1=10;
        n2=0;

        try{
            res=n1/n2;
        }catch(Exception e){
            Console.WriteLine("ERRO : {0}", e.Message);
        }

        Console.WriteLine(res);
    }
}