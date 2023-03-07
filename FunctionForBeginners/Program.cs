using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionForBeginners
{
    internal class Program
    {
        // Sakir Ardil Acar
        static void Main(string[] args)
        {
            decimal TL = Amount("TL amount");
            decimal USD = Amount("USD amount");
            decimal Exc = Amount("Exchange Rate");
            decimal Bal = Balance(TL, USD, Exc);
            Console.WriteLine("Balance = " + Bal);
            Console.ReadLine();
        }
        static decimal Amount(string str)
        {
            Console.WriteLine(str);
            try
            {
                return Convert.ToDecimal(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Enter the decimal value");
                return Amount(str);
            }

        }
        static decimal Balance(decimal TLF, decimal USDF, decimal EXCF)
        {
            decimal Bl = TLF + (USDF * EXCF);
            decimal roundBl = Math.Round(Bl, 2);
            return roundBl;
        }
    }

}

