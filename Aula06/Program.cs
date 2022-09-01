using System;
class Aula06 {
    static void Main() {

        double valorCompra=5.50, lucro=0.1, valorVenda=valorCompra+(valorCompra*lucro);
        
        string produto="Pastel";

        Console.WriteLine("Produto.....: {0,10}", produto);
        Console.WriteLine("Custo.......: {0,10:c}", valorCompra);
        Console.WriteLine("Lucro % ....: {0,10:p}", lucro);
        Console.WriteLine("Venda.......: {0,10:c}", valorVenda);
        Console.WriteLine("Lucro $ ....: {0,10:c}", valorVenda-valorCompra);
    }
}