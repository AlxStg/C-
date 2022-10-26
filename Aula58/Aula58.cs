using System;
using System.Collections.Generic;

class Aula57{
    static void Main(){
         
        List<string>carros=new List<string>();
        List<string>carros2=new List<string>();

        carros.Add("Agile");
        carros.Add("Gol");
        carros.Add("Civic");
        carros.Add("Fox");
        carros.Add("Sandero");

        carros2.AddRange(carros) ;

        carros2.Insert(2,"Cruze");

        foreach(string c in carros2){
            Console.WriteLine(c);
        }

    

    }
}