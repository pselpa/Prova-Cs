using System;
using System.Collections.Generic;

namespace Prova1
{
    class Program
    {
        static void Main(string[] args)
        {
            // MENU PRINCIPAL DA PROVA

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
                System.Console.WriteLine("1. Informe quantas horas e minutos um funcionário trabalha por dia e qual o valor/hora de seu serviço. Imprima quanto dinheiro ele ganha ao longo de um dia trabalhado. A mensagem impressa ao usuário deve ter, no máximo, duas casas após a vírgula.");

                double hoursWork = 0;
                double minutesWork = 0;
                double wagePerHour = 0;
                double dailyWage = 0;


                System.Console.Write("Informe quantas horas você trabalha por dia (se houver minutos adicionais, serão questionados em seguida): ");
                hoursWork = double.Parse(Console.ReadLine());
                System.Console.Write("Caso não seja um período 'redondo', informe quantos minutos você trabalha por dia: ");
                minutesWork = double.Parse(Console.ReadLine());
                System.Console.Write("Informe o valor recebido por hora: ");
                wagePerHour = double.Parse(Console.ReadLine());

                dailyWage = wagePerHour * (hoursWork + (minutesWork/60));

                System.Console.WriteLine($"O valor recebido por dia é R$ {dailyWage.ToString("0.00")}");
            }



            static void exercicio2()
            {
                System.Console.WriteLine("2. Solicite ao usuário que informe uma palavra qualquer, porém ele deve digitar uma letra por vez. Quando o usuário informar a palavra “Finalizar”, a aplicação deve apresentar a palavra inteira.");

                var word = "";
                var input = "";

                while (true)
                {
                    System.Console.Write("Forme uma palavra, inserindo uma letra do alfabeto por vez. Para concluir, digite 'FINALIZAR': ");
                    input = Console.ReadLine().ToUpper();
                    
                    if (input == "FINALIZAR")
                    {
                        break;
                    }
                    else if (input != "A" && input != "B" && input != "C" && input != "D" && input != "E" && input != "F" && input != "G" && input != "H" && input != "I" && input != "J" && input != "K" && input != "L" && input != "M" && input != "N" && input != "O" && input != "P" && input != "Q" && input != "R" && input != "S" && input != "T" && input != "U" && input != "V" && input != "W" && input != "X" && input != "Y" && input != "Z")
                    {
                        System.Console.WriteLine("Erro. Insira apenas letras do alfabeto, uma por vez.");
                    }
                    else
                    {
                        word += input;
                    }
                }

                System.Console.WriteLine($"A palavra formada é {word}");
            }



            static void exercicio3()
            {
                System.Console.WriteLine("3. Solicite para 5 usuários que informem seus nomes e se são solteiros. Ao final apresente o nome de todos os usuários solteiros. ");

                var research = new (string name, string status)[5];
                var inputName = "";
                var inputStatus = "";

                for (int i = 0; i < 5; i++)
                {                   

                    Console.Write($"{i+1}/5 - Informe o seu nome: ");
                    inputName = Console.ReadLine().ToUpper();
                    research[i].name = inputName;

                    while (true)
                    {
                        Console.Write($"{i+1}/5 - Você é solteiro(a) (S ou N): ");
                        inputStatus = Console.ReadLine().ToUpper();

                        if (inputStatus == "S" || inputStatus == "N")
                        {
                            research[i].status = inputStatus;
                            break;
                        }
                        else
                        {
                            System.Console.WriteLine("Informe um status válido (S ou N).");
                        }
                    }
                }
                    
                foreach (var item in research)
                {
                    if (item.status == "S")
                    {
                        System.Console.WriteLine($"{item.name} é solteiro(a).");
                    }
                }
            }



            static void exercicio4()
            {
                System.Console.WriteLine("4. Solicite ao usuário seu ano de nascimento e imprima se ele é ou não maior de idade. Caso o usuário digite um valor inválido, a aplicação deve pedir que ele digite novamente");

                var input = "";
                int answer = 0;
                int year = 0;

                System.Console.WriteLine("Informe o ano em que ano você nasceu.");
                input = Console.ReadLine();
                try
                {
                    year = Int32.Parse(input);
                }
                catch (System.Exception)
                {
                    System.Console.Write("Erro. Um item inválido foi inserido. Insira um número inteiro.");
                }

                answer = 2020 - year;

                if (answer >= 18)
                {
                    System.Console.WriteLine("Usuário é Maior de idade");
                }
                else
                {
                    System.Console.WriteLine("Usuário é Menor de idade");
                }

            }

        }
    }
}

