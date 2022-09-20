using System;

class Aula27{

    static void Main(){

        Soma();

    }

    static void Soma(params int[]n){
        int res=0;
        if(n.Length<1){
            Console.WriteLine("Não existem valores a serem somados");
        }
        else if(n.Length<2){
            Console.WriteLine("Valores insuficientes para soma: {0}", n[0]);
        }
        else{
            for(int h=0;h<n.Length;h++){
                res += n[h];
            }    
        }
        if(n.Length>1){  
        Console.WriteLine("Soma = {0}", res);
        }
        
    }
}