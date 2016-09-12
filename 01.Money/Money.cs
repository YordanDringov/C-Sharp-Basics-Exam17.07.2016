using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Money
{
    class Money
    {
        static void Main(string[] args)
        {
            int bitcoins = int.Parse(Console.ReadLine());
            double yuans = double.Parse(Console.ReadLine());
            double comission = double.Parse(Console.ReadLine());

            double levasFromBitcoins = bitcoins * 1168;
            double dollarsFromYuans = yuans * 0.15;
            double levasFromDollars = dollarsFromYuans * 1.76;
            double totalEuros = (levasFromBitcoins + levasFromDollars) / 1.95;

            double result = totalEuros - (comission/100 * totalEuros);

            Console.WriteLine(result);
        }
    }
}
