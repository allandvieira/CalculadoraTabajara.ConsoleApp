namespace CalculadoraTabajara.ConsoleApp
{
    internal class Programa
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            // Titulo da calculadora
            Console.WriteLine("Calculadora Tabajara em C#\r");
            Console.WriteLine("--------------------------\n");

            while (!endApp)
            {
                // Declaração das variáveis
                string numeroEntrada1 = "";
                string numeroEntrada2 = "";
                double result = 0;

                // Entrada do primeiro numero
                Console.Write("Digite um número e pressione Enter: ");
                numeroEntrada1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(numeroEntrada1, out cleanNum1))
                {
                    Console.Write("Esta entrada não é válida. Por favor insira um valor inteiro: ");
                    numeroEntrada1 = Console.ReadLine();
                }

                // Entrada do segundo numero
                Console.Write("Digite outro número e pressione Enter: ");
                numeroEntrada2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numeroEntrada2, out cleanNum2))
                {
                    Console.Write("Esta entrada não é válida. Por favor insira um valor inteiro: ");
                    numeroEntrada2 = Console.ReadLine();
                }

                // Menu
                Console.WriteLine("Escolha um operador na lista a seguir:");
                Console.WriteLine("\t1 - Adicionar");
                Console.WriteLine("\t2 - Subtrair");
                Console.WriteLine("\t3 - Multiplicar");
                Console.WriteLine("\t4 - Dividir");
                Console.Write("Qual a sua opção? ");

                string op = Console.ReadLine();

                try
                {
                    result = Calculadora.DoOperation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("Esta operação resultará em um erro matemático.\n");
                    }
                    else Console.WriteLine("\r\nSeu resultado: {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ocorreu uma exceção ao tentar fazer as contas.\n - Detalhes: " + e.Message);
                }

                Console.WriteLine("------------------------\n");

                // Resposta do usuário antes de fechar
                Console.Write("Pressione 'S' e Enter para fechar o aplicativo ou pressione qualquer outra tecla e Enter para continuar: ");
                if (Console.ReadLine() == "S") endApp = true;

                Console.WriteLine("\n"); // Espaçamento de linha amigável
            }
            return;
        }
    }
}
