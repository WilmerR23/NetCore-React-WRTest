using AutoMapper;
using DGII.BLL.Contracts;
using DGII.BOL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGII.BLL.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(IDbContext dbContext, IMapper mapper)
        {
            Contribuyentes = new GenericService<Contribuyente>(dbContext);
            Comprobantes = new GenericService<Comprobante>(dbContext);
        }
        public IGenericService<Contribuyente> Contribuyentes { get; set; }
        public IGenericService<Comprobante> Comprobantes { get; set; }
    }
}
