using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LTIAdminDesktop.Models;

namespace LTIAdminDesktop.Services
{
    public class TrimestresService : ITrimestresService
    {
        private LTIContext _context;

        public TrimestresService()
        {
            _context = new LTIContext();
        }

        public Task<Trimestres> Get(int id)
        {
            return Task.Run( () => {
                return _context.Trimestres.Where(t => t.TrimestreId == id).FirstOrDefault();
            });
        }

        public Task<List<Trimestres>> GetAll(bool ordered)
        {
            return Task.Run(() => {
                if (ordered)
                    return _context.Trimestres.OrderBy(t => t.Name).Select(t => t).ToList();
                else
                    return _context.Trimestres.Select(t => t).ToList();
            });
        }
    }
}
