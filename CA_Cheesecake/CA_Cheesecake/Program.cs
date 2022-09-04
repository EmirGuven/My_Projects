using System;

namespace CA_Cheesecake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biskuvi biskuvi = new Biskuvi();
            Tereyagi tereyagi = new Tereyagi();

            Console.WriteLine(biskuvi.Al());
            Console.WriteLine(tereyagi.Al());
        }
    }
}
