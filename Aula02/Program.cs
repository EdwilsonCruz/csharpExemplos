using System;

namespace Aula02
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Lyncas Cursos! ");
      
      foreach (var item in args)
      {
          Console.WriteLine(item);
      }
      
    }
  }
}
