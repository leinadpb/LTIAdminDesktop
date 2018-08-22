using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTIAdminDesktop.Services
{
    public interface IFileService
    {
        Task<bool> SaveFileAsync(byte[] file, string location);                                           
    }
}
