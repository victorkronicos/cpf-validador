using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class EXERCICIO2
    {
        class ValidaCPF
        {
            public string CPF;

            public ValidaCPF(string cpf)
            {
                CPF = cpf;
            }

            public string Validador(string cpf)
            {
                CPF = cpf;
                int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                string tempCpf;
                string digito;
                int soma;
                int resto;

                if (CPF.Length != 11)
                {
                return cpf = "CPF Inválido.";
                }

                tempCpf = CPF.Substring(0, 9);
                soma = 0;

                for (int i = 0; i < 9; i++)
                {
                    soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
                }
                resto = soma % 11;
                if (resto < 2)
                {
                    resto = 0;
                }
                else
                {
                    resto = 11 - resto;
                }
                digito = resto.ToString();
                tempCpf = tempCpf + digito;
                soma = 0;
                for (int i = 0; i < 10; i++)
                {
                    soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
                }
                resto = soma % 11;
                if (resto < 2)
                {
                    resto = 0;
                }
                else
                {
                    resto = 11 - resto;
                }
                digito += resto.ToString();
                return cpf = "CPF Válido.";
            }
        }

        static void Main(string[] args)
        {
            string cpf = "";
            Console.Write("Digite o CPF: ");
            cpf = Console.ReadLine();
            ValidaCPF valida = new ValidaCPF(cpf);
            Console.WriteLine(valida.Validador(cpf));
            Console.ReadKey();
        }
    }
}
