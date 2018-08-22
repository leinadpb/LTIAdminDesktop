using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LTIAdminDesktop.Models;

namespace LTIAdminDesktop.Services
{
    public interface IStudentsService
    {
        Task<Students> GetById(int id);
        Task<List<Students>> GetAll(bool ordered);
        IQueryable<Students> GetAllQueryable();
        Task<IQueryable<Students>> GetBetweenQueryable(DateTime startDate, DateTime endDate);
        Task<IQueryable<Students>> GetByTeacherId(int teacherId);
            
    }
}
