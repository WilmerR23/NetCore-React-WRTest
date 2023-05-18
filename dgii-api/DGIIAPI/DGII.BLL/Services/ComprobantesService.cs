using DGII.BLL.Contracts;
using DGII.BOL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DGII.BLL.Services
{
    public class ComprobantesService : GenericService<Comprobante>
    {
        public ComprobantesService(IDbContext db) : base(db)
        {
        }
    }
}
