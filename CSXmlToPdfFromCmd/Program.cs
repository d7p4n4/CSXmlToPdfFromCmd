using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CSXmlToPdfFromCmd
{
    class Program
    {
        static void Main(string[] args)
        {
            string time = string.Format("{0:HH:mm:ss tt}", DateTime.Now);

            for (int i = 0; i < 100; i++)
            {
                try
                {
                    OpenCommandLine("" + i);
                    
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
            string time2 = string.Format("{0:HH:mm:ss tt}", DateTime.Now);

            Console.WriteLine("Start: " + time);
            Console.WriteLine("End: " + time2);
        }
                private static void OpenCommandLine(string output)
        {
            try
            {
                string MyBatchFile = @"D:\transform.bat";
                Process process = new Process { StartInfo = { Arguments = string.Format("{0}", output) } };
                process.StartInfo.FileName = MyBatchFile;
                process.Start();
            }
            catch (Exception e)
            {

            }
            finally
            {

            }
        }
        
    }
}
