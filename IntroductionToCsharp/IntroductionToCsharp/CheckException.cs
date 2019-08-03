using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class CheckException
{
    public static void Main()
    {
        StreamReader streamReader = null; 
        try
        {
            streamReader = new StreamReader(@"C:\code\Sample File");
            Console.WriteLine(streamReader.ReadToEnd());

        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("Please check if the File {0} exites", ex.FileName);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.StackTrace);
        }
        finally {
            streamReader.Close();
        }
    }
}

//namespace IntroductionToCsharp
//{
//    class CheckException
//    {
//    }
//}
