using DGII.BOL.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DGII.UTL;

namespace DGII.DAL.Configurations
{
    public class EstadosConfig : SmallEntitiesConfig<EstadoContribuyente>
    {
        public EstadosConfig() : base(SeedData.GetEstados())
        { }
    }
}
