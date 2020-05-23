using System;

namespace milhasparakm
{
    class Program
    {
        static void Main(string[] args)
        {
            string primeirovalor;
            int milhas;
            int km=1609;
            int total;

            Console.Write("Digite o valor da milha:");
            primeirovalor=Console.ReadLine();
            milhas = Int32.Parse (primeirovalor);
            km=1609;
            total=milhas*km;
            Console.WriteLine("o valor de km é " + total+"km");
            
        }
    }
}
