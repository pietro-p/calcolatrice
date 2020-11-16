using System;

namespace calc1._0
{
    public class Operazioni
    {
        public static double NumeroDouble()
        {
            Console.WriteLine("inserisci un numero: ");
            double a = double.Parse(Console.ReadLine());
            return a;
        }
        public static double Scelta(double a, double b)
        {
            Console.WriteLine("inserisci + per la somma \ninserisci - per la differenza \n" +
                "inserisci * per la moltiplicazione \ninserisci / per la divisione");
            string scelta = Console.ReadLine();
            double risultato = 0;
            switch (scelta)
            {
                case "+":


                    risultato = a + b;
                    break;
                case "-":
                    risultato = a - b;
                    break;
                case "*":
                    risultato = a * b;
                    break;
                case "/":

                    risultato = a / b;
                    break;
                   

            }
            return risultato;
            
        }
        public static void Stampa(double a)
        {
            Console.WriteLine($"Il risultato è {a}");
        }
    }
}
