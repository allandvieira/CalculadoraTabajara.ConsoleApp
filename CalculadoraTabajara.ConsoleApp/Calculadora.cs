using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTabajara.ConsoleApp
{
    internal class Calculadora
    {
        public static double DoOperation(double num1, double num2, string op)
        {
            double resultado = double.NaN; // O valor padrão é um "não-número", caso o resultado da divisão seja um erro

            // Instrução switch para as contas
            switch (op)
            {
                case "1":
                    resultado = num1 + num2;
                    break;
                case "2":
                    resultado = num1 - num2;
                    break;
                case "3":
                    resultado = num1 * num2;
                    break;
                case "4":
                    // Peça ao usuário para inserir um divisor diferente de zero
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    break;
                // Retorna o texto para uma entrada com opção incorreta
                default:
                    break;
            }
            return resultado;
        }
    }
}
