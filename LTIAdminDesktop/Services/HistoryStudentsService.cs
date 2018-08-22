using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LTIAdminDesktop.Models;

namespace LTIAdminDesktop.Services
{
    public class HistoryStudentsService : IHistoryStudentService
    {
        private LTIContext _context;
        public HistoryStudentsService()
        {
            _context = new LTIContext();

        }

        public IQueryable<HistoryStudents> GetAllQueryable()
        {
            return _context.HistoryStudents.Select(hs => hs);
        }
    }
}
