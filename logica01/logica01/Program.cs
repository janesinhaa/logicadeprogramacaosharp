using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello word!");
            Console.ReadLine();

            //variavéis

            char letra = 'b';
            string nome = "maria";
            float temperatura = 36.5f;
            double salario = 0.65;
            bool choveu = false;

            Console.WriteLine("Valores originais: ");
            Console.WriteLine("Letra: {letra}");
            Console.WriteLine("Nome: {nome}");
            Console.WriteLine($"Temperatura: {temperatura}");
            Console.WriteLine($"Salário: {salario}");
            Console.WriteLine($"Está chovendo: {choveu}");
            Console.ReadLine();

            //constantes
            const char simbolo = '@';
            const string saudacao = "olá";
            const float pi = 3.14159f;
            const double altura = 1.65;
            const bool eVerdade = false;

            Console.WriteLine("Valores originais: ");
            Console.WriteLine("Letra: {letra}");
            Console.WriteLine("Nome: {nome}");
            Console.WriteLine($"Temperatura: {temperatura}");
            Console.WriteLine($"Salário: {salario}");
            Console.WriteLine($"Está chovendo: {choveu}");
            Console.WriteLine($"Simbolo: {simbolo}");
            Console.WriteLine($"Saudação: {saudacao}");
            Console.WriteLine($"PI: {pi}");
            Console.WriteLine($"Altura: {altura}");
            Console.WriteLine($"É verdade? {eVerdade}");
            Console.ReadLine();

        }
    }
}
