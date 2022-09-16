using System;

class Aula21{

    static void Main() {
        
        string senha = "123";    
        string senhaUser;
        do{
            Console.WriteLine("Digite a senha: ");
            senhaUser = Console.ReadLine();
        }while(senha != senhaUser);

    }
}