using System;
using System.Collections.Generic;

class Aula56{
    static void Main(){

        LinkedList<string> transp = new LinkedList<string>();

        transp.AddFirst("Carro");
        transp.AddFirst("Avião");
        transp.AddFirst("Navio");
        transp.AddFirst("Moto");

        transp.AddLast("Bicicleta");

        // LinkedListNode<string> no;
        LinkedListNode<string> no = transp.Find("Navio");
        transp.AddAfter(no, "Patinete");
        transp.AddBefore(transp.Find("Carro"), "Patins");

        int i = 1;
        foreach(string v in transp){
            Console.WriteLine("{0}. {1}", i, v);
            i++;
        }


    }
}
