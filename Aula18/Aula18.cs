using System;

class Aula18 {
    static void Main() {
   
        int[,] n=new int[2,3]{{11,22,33},{44,55,66}};

        for(int i=0;i<2;i++){
            for(int j=0;j<3;j++){
                Console.WriteLine(n[i,j]);
            }
        }

    }
}