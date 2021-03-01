using System;

namespace Aula02
{
  class Program
  {
    //variavel static , pra poder usar junto aos metodos static.
    static int num = 10;
    static void Main(string[] args)
    {
      Console.WriteLine("Lyncas Cursos! ");

      foreach (var item in args)
      {
        Console.WriteLine(item);
      }
      Aula03();
    }

    private static void Aula03()
    {
      Console.WriteLine(num);
      bool res = 10 > 5;
      Console.WriteLine(res);
      //Aula 04,05,06
      double valorCompra = 5.60;
      double valorVenda = 7.00;
      double lucro = 0.2;
      string produto = "Muda de Cacto";

      Console.WriteLine("Produto....:{0,15}",produto);
      Console.WriteLine("Vl.Compra..:{0,15:c}",valorCompra);
      Console.WriteLine("Lucro......:{0,15:p}",lucro);
      Console.WriteLine("Produto....:{0,15:c}",valorVenda);
      Console.WriteLine("...........................");
      var valorReal =  (valorVenda - valorCompra);
      Console.WriteLine("Lucro Real.:{0,15:c}",valorReal);

    }
  }
}
