using System;

class Aula15 {
    static void Main() {

        int tempo = 0;
        char escolha;
        var meio = "";

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
            Console.WriteLine("De {0} o tempo será de {1} horas", meio, tempo_h/60);
        } else {
            Console.WriteLine("De {0} o tempo será de {1} minutos", meio, tempo);
        }
        

    }            
}