using System;
using System.Collections.Generic;

namespace Prova2
{
    class Program1
    {
        static void Main(string[] args)
        {
            // MENU PRINCIPAL DA PROVA 2

            var exercises = new List<Action>()
            {
                exercicio1,
                exercicio2,
                exercicio3,
                exercicio4,
            };

            Console.Write("Escolha entre os exercícios 1 a 4: ");
            
            var input = Int32.Parse(Console.ReadLine());
            exercises[input-1]();


            static void exercicio1()
            {
                System.Console.WriteLine("1. Solicite ao usuário que informe 5 números e armazene em um array. Toda vez que o usuário digitar um valor inválido, a aplicação deverá armazenas “null” no índice correspondente. Ao final, imprimir apenas os números válidos.(1p)");

                var list = new object[5];
                var input = "";
        
                for (int i = 0; i < 5; i++) 
                {
                    Console.Write($"Digite o número {i+1}/5: ");
                    input = Console.ReadLine();
                    try
                    {
                        list[i] = double.Parse(input);
                    }
                    catch (System.Exception)
                    {
                        list[i] = null;
                    }
                }

                foreach (var item in list)
                {
                   if (item != null)
                   {
                       System.Console.WriteLine(item);
                   }
                }
            }



            static void exercicio2()
            {
                System.Console.WriteLine("2. Calcule e apresente a média salarial dos funcionários de uma empresa qualquer. A aplicação será encerrada quando o usuário digitar a palavra 'calcular'. Caso o usuário digite um valor negativo então a aplicação deve pedir seu salário novamente.");
                var input = "";
                double wage = 0;
                double totalWage = 0;
                double averageWage = 0;
                int counter = 0;

                while (true)
                {
                    Console.Write("Insira o valor do salário do funcionário. Digite 'CALCULAR' para finalizar: ");
                    input = Console.ReadLine().ToUpper();

                    if (input == "CALCULAR")
                    {
                        break;
                    }
                    else
                    {
                        try
                        {
                            wage = double.Parse(input);
                            if (wage < 0)
                            {
                                System.Console.WriteLine("Valor negativo. Insira novamente o salário.");
                            }
                            else
                            {
                                totalWage += wage;
                                counter++;
                            }
                        }
                        catch (System.Exception)
                        {
                            System.Console.WriteLine("Erro. Um item inválido foi inserido. Insira um valor de salário válido.");
                        }
                    }
                }
                averageWage = totalWage/counter;
                System.Console.WriteLine($"Media salarial = {averageWage.ToString("0.00")}");
            }



            static void exercicio3()
            {
                System.Console.WriteLine("3. Pergunte para 5 usuários a UF que representa o estado onde ele nasceu. A aplicação deverá mostrar uma lista com todas as opções para o usuário, e cada uma deve conter um ID numérico, o usuário digitará o número que representa sua UF. Ao final a aplicação deverá mostrar a porcentagem de usuários que nasceram em Santa Catarina.");
                var input = "";
                double counter = 0;
                double percent = 0;

                System.Console.WriteLine($"Digite o número referente ao estado onde você nasceu, conforme abaixo: \n(42, SC), \n(11, RO), \n(12, AC), \n(13, AM), \n(14, RR), \n(15, PA), \n(16, AP), \n(17, TO), \n(21, MA), \n(22, PI), \n(23, CE), \n(24, RN), \n(25, PB), \n(26, PE), \n(27, AL), \n(28, SE), \n(29, BA), \n(31, MG), \n(32, ES), \n(33, RJ), \n(35, SP), \n(41, PR), \n(43, RS), \n(50, MS), \n(51, MT), \n(52, GO), \n(53, DF).");
                for (int i = 0; i < 5; i++) 
                {
                    Console.Write("Informe o código: ");
                    input = Console.ReadLine();

                    if (input == "42")
                    {
                        counter++;
                    }
                }

                percent = (counter/5) * 100;
                System.Console.WriteLine($"A porcentagem de pessoas que nasceram em SC é {percent}%");
            }



            static void exercicio4()
            {
                System.Console.WriteLine("4. Solicite ao usuário que digite o nome dos alunos das turmas Matutino e Vespertino. Cada turma possui 5 alunos. Armazene os nomes em dois arrays distintos de forma alternada, ou seja, o primeiro nome deve ser armazenado no array da Matutino, o segundo nome deve ser armazenado no array da Turma Vespertino, assim por diante. Ao final imprima apenas os nomes dos alunos que estão estudando em período integral. Caso nenhum aluno esteja cadastrado em ambas as turmas, imprimir a mensagem “todos os alunos estudam em meio período");

                var morningClass = new string[5];
                var eveningClass = new string[5];
                var allDayClass = new string[5];

                for (int i = 0; i < 5; i++)
                {
                    Console.Write($"Digite o {i+1}º aluno da turma da manhã: ");
                    morningClass[i] = Console.ReadLine();
                    Console.Write($"Digite o {i+1}º aluno da turma da tarde: ");
                    eveningClass[i] = Console.ReadLine();                  
                }

                foreach (var item in morningClass)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        if (item == eveningClass[i])
                        {
                            allDayClass[i] = item;
                        }
                    }
                }

                var counter = 0;
                foreach (var item in allDayClass)
                {
                    if (item != null)
                    {
                        System.Console.WriteLine($"{item} estuda em período integral.");
                    }
                    else if (item == null)
                    {
                        counter++;
                    }
                }
                if (counter == 5)
                {
                    System.Console.WriteLine("Todos os alunos estudam em meio período.");
                }
            }
        }
    }
}
