using System;

class Aula12{

    static void Main(){
                
        int n1, n2, n3, n4, media;
        n1=n2=n3=n4=media=0;

        Console.WriteLine("Digite a primeira nota: ");
        n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a segunda nota: ");
        n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a terceira nota: ");
        n3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a quarta nota: ");
        n4 = int.Parse(Console.ReadLine());

        media = (n1+n2+n3+n4)/4;

        if(media >= 7){
            Console.WriteLine("Sua média é {0} e você está Aprovado!", media);
        }else if(media >= 5){         
            Console.WriteLine("Sua média é {0} e você está Em Recuperação!", media);
        }else{       
            Console.WriteLine("Sua média é {0} e você está Reprovado!", media); 



        }

    }
}
