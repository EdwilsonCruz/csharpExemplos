using System;

namespace _01_Estrutura
{
    class Program
    {

        static void Main(string[] args)
        {
            var fila = new Pilha();
            Random randObj = new Random();
            fila.Empilhar(1);
            fila.Empilhar(100);
            fila.Empilhar(1000);
            fila.Empilhar(randObj.Next());
            fila.Empilhar(randObj.Next());
            for (int i = 0; i < 6; i++){

                Console.WriteLine(fila.Desempilhar());
            }

        }
    }
}
