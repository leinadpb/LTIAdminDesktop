using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTIAdminDesktop.Services
{
    public interface IPrintService
    {

        Task<bool> Print(string text, string printer);

    }
}
