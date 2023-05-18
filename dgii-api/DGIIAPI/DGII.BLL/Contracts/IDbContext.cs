using DGII.BOL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGII.BLL.Contracts
{
    public interface IDbContext
    {
        public DbSet<Contribuyente> Contribuyentes { get; set; }
        public DbSet<Comprobante> Comprobantes { get; set; }
        public DbSet<T> Set<T>() where T: class;
    }
}
