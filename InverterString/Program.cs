using System;

namespace InverterString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma string para inverter seus caracteres:");
            string input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input))
            {
                string stringInvertida = InverterString(input);
                Console.WriteLine($"A string invertida é: {stringInvertida}");
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, insira uma string válida.");
            }
        }

        static string InverterString(string str)
        {
            char[] caracteres = str.ToCharArray();
            int inicio = 0;
            int fim = caracteres.Length - 1;

            while (inicio < fim)
            {
                (caracteres[fim], caracteres[inicio]) = (caracteres[inicio], caracteres[fim]);

                inicio++;
                fim--;
            }

            return new string(caracteres);
        }
    }
}
