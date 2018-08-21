﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenHtmlToPdf;
using OpenHtmlToPdf.WkHtmlToPdf;
using RawPrint;

namespace LTIAdminDesktop.Services
{
    public class PrintService : IPrintService
    {

        private string LocalPath;

        public PrintService()
        {
            LocalPath = Directory.GetCurrentDirectory();
        }

        public Task<bool> Print(string html, string PrinterName)
        {
            return Task.Run(() => {

                try
                {
                    var pdf = Pdf.From(html)
                                .OfSize(PaperSize.A4)
                              //  .WithTitle("LABORATORIO DE TECNOLOGIA DE LA INFORMACION")
                             //   .WithoutOutline()
                                .WithMargins(1.25.Centimeters())
                              //  .Portrait()
                              //  .Comressed()
                                .Content();
                    

                    // Save it in local
                    var fileName = "tempPdf.pdf";
                    var rootPath = LocalPath;
                    var filePath = Path.Combine(rootPath, fileName);

                    try
                    {
                        File.WriteAllBytes(filePath, pdf);
                    }
                    catch(IOException exp)
                    {
                        MessageBox.Show($"Error: {exp}");
                    }

                    IPrinter printer = new Printer();
                    printer.PrintRawFile(PrinterName, filePath, paused: false);

                    return true;

                }catch(Exception exp)
                {
                    Console.WriteLine($"Error: {exp}");
                    return false;
                }

            });
        }
    }
}
