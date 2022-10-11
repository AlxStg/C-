using System;

class Aula53{
    static void Main(){
        float area=0;

        try{
            area= Area.Quadrado(2f,0f);
            Console.WriteLine("Area do quadrado: {0}", area);
            
        }catch(Exception e){
            Console.WriteLine("Erro: {0}",e.Message);
        }finally{
            Console.WriteLine("Fim!");
        }

        
    }
}

class Area{
    public static float Quadrado(float bas, float alt){
        if (bas == 0 || alt == 0){
            throw new Exception("Base e/ou altura igual a zero");
        }
        return bas*alt;
    }
}