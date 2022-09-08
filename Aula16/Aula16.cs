using System;

class Aula16 {
    static void Main() {

        int tempo = 0;
        char escolha;
        var meio = "";

        inicio:
        Console.Clear();


        Console.WriteLine("Belo horizonte/MG a Vitória/ES");    
        Console.WriteLine("Escolha o transporte: [a]Avião | [c]Carro | [o]Ônibus");
        escolha = char.Parse(Console.ReadLine());


        switch (escolha) {
            case 'a':
            case 'A':
                tempo = 50;
                meio = "avião";
                break;
            case 'c':
            case 'C':
                tempo = 500;
                meio = "carro";
                break;
            case 'o':
            case 'O':
                tempo = 660;
                meio = "ônibus";
                break;
            default:
                Console.WriteLine("Opção inválida");
                break;
        }

        if (tempo > 59) {
            var tempo_h = (float)tempo;
            Console.WriteLine("\n>>>>> De {0} o tempo será de {1} horas \n ", meio, tempo_h/60);
        } else {
            Console.WriteLine("\n>>>>> De {0} o tempo será de {1} minutos \n ", meio, tempo);
        }
        
        var continuar = "";
        Console.WriteLine("Deseja continuar? [s]Sim | [n]Não");
        continuar = Console.ReadLine();
        
        if (continuar == "s" || continuar == "S") {
            goto inicio;
        } else {
            Console.Clear();    
            Console.WriteLine("\nFim do programa\n");
        }

    }            
}