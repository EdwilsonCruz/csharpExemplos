using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informne a opção desejada:");
            System.Console.WriteLine("1- Inserir novo Aluno");
            System.Console.WriteLine("2- Listar Alunos");
            System.Console.WriteLine("3- Calcular média geral");
            System.Console.WriteLine("0- Sair");
            
            String opcaoUsuario = Console.ReadLine();
            Console.WriteLine("opcaoUsuario: " + opcaoUsuario);
            while (opcaoUsuario != "0")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        //TODO: adicionar aluno
                        System.Console.WriteLine("TESTE 1");
                        break;
                    case "2":
                        //TODO: listar alunos
                        break;
                    case "3":
                    //TODO: calcular a media geral
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                Console.WriteLine("Informne a opção desejada:");
                System.Console.WriteLine("1- Inserir novo Aluno");
                System.Console.WriteLine("2- Listar Alunos");
                System.Console.WriteLine("3- Calcular média geral");
                System.Console.WriteLine("0- Sair");
                System.Console.WriteLine("");

                opcaoUsuario = System.Console.ReadLine();
            }
        }
    }
}
