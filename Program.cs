using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Interface_calculo_de_salarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0, salario;
            double imposto, novoSalario;

            while (opcao != 4)
            {
                Console.WriteLine("Menu de opções:");
                Console.WriteLine("1 - Imposto");
                Console.WriteLine("2 - Novo salário");
                Console.WriteLine("3 - Classificação");
                Console.WriteLine("4 - Finalizar programa");
                Console.Write("Digite a opção desejada: ");
                opcao = Int32.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        {
                            Console.WriteLine("Informe o valor do seu salário");
                            salario = Int32.Parse(Console.ReadLine());
                            if (salario < 500)
                            {
                                imposto = salario * 0.05;
                                novoSalario = salario - imposto;
                                Console.WriteLine("Seu salario, com o desconto de R$" + imposto + ", será de: R$" + novoSalario);
                            }
                            else if (salario >= 500 && salario <= 850)
                            {
                                imposto = salario * 0.10;
                                novoSalario = salario - imposto;
                                Console.WriteLine("Seu salario, com o desconto de R$" + imposto + ", será de: R$" + novoSalario);
                            }
                            else if (salario > 850)
                            {
                                imposto = salario * 0.15;
                                novoSalario = salario - imposto;
                                Console.WriteLine("Seu salario, com o desconto de R$" + imposto + ", será de: R$" + novoSalario);
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Informe o valor do seu salário");
                            salario = Int32.Parse(Console.ReadLine());

                            if (salario > 1500)
                            {
                                novoSalario = salario + 25;
                                Console.WriteLine("Seu salario, com aumento de R$25, será de: R$" + novoSalario);
                            }
                            else if (salario >= 750 && salario <= 1500)
                            {
                                novoSalario = salario + 50;
                                Console.WriteLine("Seu salario, com aumento de R$50, será de: R$" + novoSalario);
                            }
                            else if (salario >= 450 && salario < 750)
                            {
                                novoSalario = salario + 75;
                                Console.WriteLine("Seu salario, com aumento de R$75, será de: R$" + novoSalario);
                            }
                            else if (salario < 450)
                            {
                                novoSalario = salario + 100;
                                Console.WriteLine("Seu salario, com aumento de R$100, será de: R$" + novoSalario);
                            }
                        break;
                        }
                        case 3:
                        {
                            Console.WriteLine("Informe o valor do seu salário");
                            salario = Int32.Parse(Console.ReadLine());

                            if (salario <= 700)
                            {
                                Console.WriteLine("Por conta do seu salário,você está classificado como: Mal remunerado");
                            }
                            else if (salario > 700)
                            {
                                Console.WriteLine("Por conta do seu salário, você está classificado como: Bem remunerado");
                            }
                            break;
                        }
                    case 4:
                        break;
                    default:
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
