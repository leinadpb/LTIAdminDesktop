using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenHtmlToPdf;
using OpenHtmlToPdf.WkHtmlToPdf;
using RawPrint;

namespace LTIAdminDesktop.Services
{
    public class PdfService : IPdfService
    {
        private string LocalPath;
        public PdfService()
        {
            LocalPath = Directory.GetCurrentDirectory();
        }
        public byte[] GetPdfStrem(string html)
        {
            var pdf = Pdf.From(html)
                        .OfSize(PaperSize.A4)
                        .WithTitle("LABORATORIO DE TECNOLOGIA DE LA INFORMACION")
                        .WithoutOutline()
                        .WithMargins(1.75.Centimeters())
                        .Portrait()
                        .Comressed()
                        .Content();

            return pdf;
        }
    }
}
