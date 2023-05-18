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
    internal class ContribuyentesService : GenericService<Contribuyente>
    {
        public ContribuyentesService(IDbContext db) : base(db)
        {
        }
    }
}
