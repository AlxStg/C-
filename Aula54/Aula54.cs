using System;

namespace Calc1{
    class Area{
    public static float Quadrado(float bas, float alt){
        if (bas == 0 || alt == 0){
            throw new Exception("Base e/ou altura igual a zero");
        }
        return bas*alt;
    }
}
}
class Aula54{
    static void Main(){
        float area=0;

        try{
            area= Calc1.Area.Quadrado(2f,30f);
            Console.WriteLine("Area do quadrado: {0}", area);
            
        }catch(Exception e){
            Console.WriteLine("Erro: {0}",e.Message);
        }finally{
            Console.WriteLine("Fim!");
        }

        
    }
}

