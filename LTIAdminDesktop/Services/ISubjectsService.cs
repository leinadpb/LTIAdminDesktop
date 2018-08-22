using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LTIAdminDesktop.Models;

namespace LTIAdminDesktop.Services
{
    public interface ISubjectsService
    {
        Task<List<Subjects>> GetAll(bool ordered);
        Task<Subjects> GetById(int id);
    }
}
