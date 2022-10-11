using System;

class Aula51{
    static void Main(string[] args){
        Console.WriteLine("-----------------");
        Console.WriteLine("   Curso de C#");
        Console.WriteLine("-----------------");

        if(args.Length > 0){
            Console.WriteLine("Qtd de args: {0}", args.Length);
            for (int i=0; i < args.Length; i++){
                Console.Write ("|  Arg {0}: {1}  |", i+1, args[i]);

            }
        }else{
            Console.WriteLine(" Não foram introduzidos argumentos!");
        }
    }
}
