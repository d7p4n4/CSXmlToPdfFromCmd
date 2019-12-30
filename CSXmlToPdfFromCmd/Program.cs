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
            // For complete examples and data files, please go to https://github.com/aspose-pdf/Aspose.PDF-for-.NET
            // The path to the documents directory.
            //string dataDir = RunExamples.GetDataDir_AsposePdf_WorkingDocuments();
            //Create pdf document

            string time = string.Format("{0:HH:mm:ss tt}", DateTime.Now);

            for (int i = 0; i < 1; i++)
            {
                try
                {
                    Aspose.Pdf.Document pdf = new Aspose.Pdf.Document();
                    //Bind XML and XSLT files to the document
                    try
                    {
                        pdf.BindXml("c:\\evesAlakulas1.xml", "c:\\evesAlakulas1.xslt");
                    }
                    catch (System.Exception)
                    {

                        throw;
                    }

                    //Save the document
                    pdf.Save("d:\\HelloWorldUsingXmlAndXslt.pdf");
                    //OpenCommandLine("" + i);
                    
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
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {

            }
        }
        
    }
}
