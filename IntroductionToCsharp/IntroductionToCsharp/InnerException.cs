using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class InnerException
{
    public static void main()
    {
        try
        {
            Console.WriteLine("Enter First Number");
            int FN = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            int SN = Convert.ToInt32(Console.ReadLine());

            int Result = FN / SN;

            Console.WriteLine("Result = {0}", Result);
        }
        catch (Exception ex)
        {
            string FilePath = @"C:\code\Sample File\Log.txt";

            if (File.Exists(FilePath))
            {
                StreamWriter SW = new StreamWriter(FilePath);
                SW.Write(ex.GetType().Name);
                SW.WriteLine();
                SW.Write(ex.Message);
                SW.Close();
                Console.WriteLine("There is Problem , Please try Again");
            }
            else
            {
                throw new FileNotFoundException(FilePath + "is not present", ex);
            }
        }


        catch (Exception exception)
        {
            Console.WriteLine("current Exception = {0}", exception.GetType().Name);
            if (exception.InnerException != null)
            {
                Console.WriteLine("Inner Exception = {0}", exception.InnerException.GetType().Name);
            }
        }
    }
}

