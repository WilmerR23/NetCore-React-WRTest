using DGII.BOL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGII.BLL.Contracts
{
    public interface IUnitOfWork
    {
        IGenericService<Contribuyente> Contribuyentes { get; set; }
        IGenericService<Comprobante> Comprobantes { get; set; }

    }
}
