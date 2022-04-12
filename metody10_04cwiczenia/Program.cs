using System;

namespace metody10_04cwiczenia
{
    
    class Program
    {
        static readonly double fraction = 2.0 / 3.0;
        static double epsilon = 0;
        static void Main()
        {
            while (epsilon <= 0)
            {
                Console.WriteLine("Podaj dokładność. Liczba musi być większa od 0!");
                epsilon = double.Parse(Console.ReadLine());
            }
            double valueOfLog = Calculate(0, 0);
            
            Console.WriteLine($"Wynik: {valueOfLog}");
            Console.ReadKey();
        }
        static double Calculate(double counter, double value)
        {
            if (fraction*(value + (1 / ((2 * counter) + 1)) * (1 / Math.Pow(9, counter)))-fraction*value < epsilon) return fraction*value;
            value+=(1.0/(2*counter+1))*(1.0/Math.Pow(9,counter));
            Console.WriteLine($"Wartość licznika rekurencji: {counter}");
            counter++;
            return Calculate(counter, value);
            
               
        }
    }
}
