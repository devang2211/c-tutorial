using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCsharp
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    string strNumber = "100TH";

        //    int Result = 0;

        //    bool IsconversionSucessfully = int.TryParse(strNumber, out Result);

        //    if (IsconversionSucessfully)
        //    {
        //        Console.WriteLine(Result);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Please Enter valid number");
        //    }
        //}

        public static void main()
        {
            int Total = 0;
            int Product = 0;
            Calculate(10, 20, out Total, out Product);
            Console.WriteLine("Sum = {0} && Product = {1}", Total, Product);
        }

        public static void Calculate(int FN, int SN, out int Sum, out int Product)
        {
            Sum = FN + SN;
            Product = FN * SN;
        }
    }
}
