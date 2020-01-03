using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

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
            string batchFile = "@echo off \ncd d:\\fop-1.0\\ \n";

            try
            {/*
                for (int i = 0; i < 1000; i++)
                {
                    batchFile = batchFile + "CALL fop.bat -c d:\\fop-1.0\\conf\\fop.xconf -xml d:\\Server\\bizalmas\\OXAKPDF\\XMLs\\egyeni.xml -xsl " +
                        "d:\\Server\\bizalmas\\OXAKPDF\\XSLTs\\EgeszDokumentum2.xsl -pdf d:\\Server\\Visual_studio\\AK\\PDFs\\out" + i + ".pdf \n\n";

                }

                writeOut(batchFile, "d:\\Server\\bizalmas\\OXAKPDF\\");*/
                OpenCommandLine();
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            string time2 = string.Format("{0:HH:mm:ss tt}", DateTime.Now);

            Console.WriteLine("Start: " + time);
            Console.WriteLine("End: " + time2);
        }

        public static void writeOut(string text, string outputPath)
        {
            File.WriteAllText(outputPath + "transform.bat", text);

        }

        private static void OpenCommandLine()
        {
            try
            {
                string MyBatchFile = @"D:\Server\bizalmas\OXAKPDF\transform.bat";
                Process process = new Process();
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
