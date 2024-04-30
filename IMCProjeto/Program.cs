using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMCProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] nome = new string[5];
            double[] peso = new double[5];
            double[] altura = new double[5];

            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Informe o nome: ");
                nome[i] = Console.ReadLine();

                Console.WriteLine("Informe a altura: ");
                altura[i] = double.Parse(Console.ReadLine());

                Console.WriteLine("Informe o peso: ");
                peso[i] = double.Parse(Console.ReadLine());

                double imc = peso[i] * (altura[i] * altura[i]);

                if (imc <= 18.5)
                {
                    Console.Write(nome[i] + "está abaixo do peso.");
                }
                else if (imc <= 24.9)
                {
                    Console.Write(nome[i] + "está no peso ideal.");
                }
                else if (imc <= 29.9)
                {
                    Console.Write(nome[i] + "está levemente acima do peso.");
                }
                else if (imc <= 34.9)
                {
                    Console.Write(nome[i] + "está com obesidade grau I");
                }
                else if (imc <= 39.9)
                {
                    Console.Write(nome[i] + "está com obesidade grau II");
                }
                else
                {
                    Console.Write(nome[i] + "está com obesidade grau III");
                }
                   
            }
            for (int j = 0; j <= 4; j++)
            {
                Console.WriteLine("Nome: " + nome[j]);
                Console.WriteLine("Altura: "+ altura[j]);
                Console.WriteLine("Peso: "+ peso[j]);
            }
        }
    }
}
