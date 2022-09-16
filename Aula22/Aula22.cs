using System;

class Aula22{

    static void Main() {
        
        int[] num = new int[5]{11,22,33,44,55};

        /*
        for(int i=0; i<num.Length; i++){

            Console.WriteLine("{0}º: {1}", i+1, num[i]);
        }
        */

        var i = 0;
        foreach(int n in num){
            i++;
            Console.WriteLine("{0}º: {1}", i, n);
        }

    }
}