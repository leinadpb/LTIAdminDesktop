using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LTIAdminDesktop.Models;

namespace LTIAdminDesktop.Services
{
    public interface IHistoryStudentService
    {
        IQueryable<HistoryStudents> GetAllQueryable();
    }
}
