using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTIAdminDesktop.Services
{
    public interface IPdfService
    {
        byte[] GetPdfStrem(string html);
    }
}
