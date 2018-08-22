using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LTIAdminDesktop.Services
{
    public class FileService : IFileService
    {
        public Task<bool> SaveFileAsync(byte[] file, string location)
        {
            return Task.Run(() => {
                try
                {
                    File.WriteAllBytes(location, file);
                    return true;
                }
                catch (IOException exp)
                {
                    Console.WriteLine($"Error: {exp}");
                    return false;
                }
            });
        }
    }
}
