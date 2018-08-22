using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LTIAdminDesktop.Models;

namespace LTIAdminDesktop.Services
{
    public class StudentsService : IStudentsService
    {
        private LTIContext _context;

        public StudentsService()
        {
            _context = new LTIContext();
        }

        public Task<List<Students>> GetAll(bool ordered)
        {
            return Task.Run(() => {
                if (ordered)
                    return _context.Students.OrderBy(s => s.DisplayName).Select(s => s).ToList();
                else
                    return _context.Students.Select(s => s).ToList();
            });
        }

        public IQueryable<Students> GetAllQueryable()
        {
            return _context.Students.Select(s => s);
        }

        public Task<IQueryable<Students>> GetBetweenQueryable(DateTime startDate, DateTime endDate)
        {
            return Task.Run(() => {
                return _context.Students.Where(s => s.RegisteredDate >= startDate && s.RegisteredDate <= endDate).Select(s => s);
            });
        }

        public Task<Students> GetById(int id)
        {
            return Task.Run(() => {
                return _context.Students.Where(s => s.StudentId == id).FirstOrDefault();
            });
        }

        public Task<IQueryable<Students>> GetByTeacherId(int teacherId)
        {
            return Task.Run(() => {
                return _context.Students.Where(s => s.TeacherId == teacherId).Select(s => s);
            });
        }
    }
}
