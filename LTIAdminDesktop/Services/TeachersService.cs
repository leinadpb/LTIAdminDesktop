using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LTIAdminDesktop.Models;

namespace LTIAdminDesktop.Services
{
    public class TeachersService : ITeachersService
    {
        private LTIContext _context;

        public TeachersService()
        {
            _context = new LTIContext();
        }

        public Task<List<Teachers>> GetAll(bool ordered)
        {
            return Task.Run(() => {
                if(ordered)
                    return _context.Teachers.OrderBy(t => t.DisplayName).Select(t => t).ToList();
                else
                    return _context.Teachers.Select(t => t).ToList();
            });
        }
    }
}
