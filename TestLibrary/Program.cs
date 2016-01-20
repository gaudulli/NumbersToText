using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumbersToText;

namespace TestLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = NumToText.ConvertToText((decimal).125, false, 3, false);
            //string text = NumToText.ConvertToCurrency((decimal).353, false, 3);
            string text = NumToText.ConvertToLegalDollarText((decimal)45.22,2,false);
            Console.WriteLine(text);
            Console.ReadKey();
        }
    }
}
