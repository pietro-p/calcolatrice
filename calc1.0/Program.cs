using System;

namespace calc1._0
{
    class Program
    {
        static void Main(string[] args)
        {            
            double a = Operazioni.NumeroDouble();
            double b = Operazioni.NumeroDouble();
            double operazione = Operazioni.Scelta(a,b);
            Operazioni.Stampa(operazione);

        }
    }
}
