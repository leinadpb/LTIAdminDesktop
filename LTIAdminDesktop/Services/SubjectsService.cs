using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LTIAdminDesktop.Models;

namespace LTIAdminDesktop.Services
{
    public class SubjectsService : ISubjectsService
    {
        private LTIContext _context;

        public SubjectsService()
        {
            _context = new LTIContext();
        }

        public Task<List<Subjects>> GetAll(bool ordered)
        {
            return Task.Run(() => {
                if (ordered)
                    return _context.Subjects.OrderBy(s => s.SubjectName).Select(s => s).ToList();
                else
                    return _context.Subjects.Select(s => s).ToList();
            });
        }

        public Task<Subjects> GetById(int id)
        {
            return Task.Run(() => {

               return _context.Subjects.Where(s => s.SubjectId == id).FirstOrDefault();
            });
        }
    }
}
