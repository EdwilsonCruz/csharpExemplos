using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            string opcaoUsuario = MenuUsuario();
            var indiceAluno = 0;
            while (opcaoUsuario != "0")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        //TODO: adicionar aluno
                        System.Console.WriteLine(".: Cad. Aluno :.");
                        System.Console.WriteLine("Informe o nome do Aluno:");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();
                        Console.WriteLine("informe a nota:");
                        
                        
                        if (decimal.TryParse(Console.ReadLine(), out decimal nota1))
                        {
                            aluno.Nota = nota1;    
                        }else
                        {
                            throw new ArgumentException("Valor da nota de ser decimal");
                        }       
                        alunos[indiceAluno] = aluno;
                        indiceAluno++;
                        Console.WriteLine("");                 
                        break;
                    case "2":
                        //TODO: listar alunos
                        foreach (var al in alunos)
                        {
                            if (al != null)
                            {
                                Console.WriteLine($"ALUNO:{al.Nome} - NOTA:{al.Nota}");    
                            }                            
                        }
                        break;
                    case "3":
                        //TODO: calcular a media geral
                        decimal media = 0;
                        var nrAlunos = 0;

                        for (int i=0; i < alunos.Length; i++)
                        {
                            if (alunos[i] != null)
                            {
                                media = media + alunos[i].Nota;
                                nrAlunos++;    
                            }                            
                        }                        
                        var mediaGeral = media / nrAlunos;
                        //Console.WriteLine($"Media: {mediaGeral}");
                        
                        if (mediaGeral < 4)
                        {
                            Console.WriteLine($"Media: {mediaGeral} - Conceito: {Conceito.I}");
                        }else if (mediaGeral < 6)
                        {
                            Console.WriteLine($"Media: {mediaGeral} - Conceito: {Conceito.R}");
                        }else if (mediaGeral < 8)
                        {
                            Console.WriteLine($"Media: {mediaGeral} - Conceito: {Conceito.B}");
                        }else if (mediaGeral < 10)
                        {
                            Console.WriteLine($"Media: {mediaGeral} - Conceito: {Conceito.MB}");
                        }else
                        {
                            Console.WriteLine($"Media: {mediaGeral} - Conceito: {Conceito.O}");
                        }

                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                
                opcaoUsuario = MenuUsuario();
            }
        }

        private static String MenuUsuario()
            {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Informne a opção desejada:");
            System.Console.WriteLine("1- Inserir novo Aluno");
            System.Console.WriteLine("2- Listar Alunos");
            System.Console.WriteLine("3- Calcular média geral");
            System.Console.WriteLine("0- Sair");
            Console.WriteLine("-------------------------\n");
            String opcaoUsuario = Console.ReadLine();
            //Console.WriteLine("opcaoUsuario: " + opcaoUsuario);
            return opcaoUsuario;
        }
    }
}
