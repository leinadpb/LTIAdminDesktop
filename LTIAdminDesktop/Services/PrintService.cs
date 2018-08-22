using System;
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
        private readonly IFileService FileService;
        private readonly IPdfService PdfService;

        public PrintService()
        {
            LocalPath = Directory.GetCurrentDirectory();
            FileService = new FileService();
            PdfService = new PdfService();
        }

        public Task<bool> Print(string html, string PrinterName)
        {
            return Task.Run(async () => {

                try
                {
                    byte[] pdf = PdfService.GetPdfStrem(html);
                    
                    // Save it in local
                    var fileName = "tempPdf.pdf";
                    var rootPath = LocalPath;
                    var filePath = Path.Combine(rootPath, fileName);
                    await FileService.SaveFileAsync(pdf, filePath);

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
