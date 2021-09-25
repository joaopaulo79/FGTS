using System;

namespace FGTS
{
    class Program
    {
        static void Main(string[] args)
        {
           double salario, fgts;
           
           Console.ForegroundColor = ConsoleColor.DarkYellow;
           Console.WriteLine("\n============= FGTS =============\n");
           Console.ResetColor();

           Console.WriteLine("Insira o valor total do sálario,\npara que seja calculada a parcela\ndo FGTS.\n");

           Console.Write("Salário (R$)...: ");
           salario = Convert.ToDouble(Console.ReadLine());

           fgts = salario * 8 / 100;

           Console.ForegroundColor = ConsoleColor.DarkYellow;
           Console.WriteLine("\n=== Parcela do FGTS ===\n");
           Console.ResetColor();

           Console.WriteLine($"FGTS...........: {fgts:C}\n");
        }
    }
}
