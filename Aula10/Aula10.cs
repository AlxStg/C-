using System;

class Aula10{

    enum DiasSemana{Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sabado};
    static void Main(){

      DiasSemana ds = (DiasSemana) 0;

      int ds2 = ((int) DiasSemana.DiaSemana.ds)+1;

      Console.WriteLine(ds + " é o " +ds2+ "º dia da semana");
      

    }
}