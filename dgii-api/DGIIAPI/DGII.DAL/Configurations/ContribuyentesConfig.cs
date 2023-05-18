using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DGII.BOL.Models;
using System.Reflection.Emit;
using DGII.UTL;

namespace DGII.DAL.Configurations
{
    public class ContribuyentesConfig : BaseConfig<Contribuyente>
    {
        public override void Configure(EntityTypeBuilder<Contribuyente> builder)
        {
            base.Configure(builder);
            builder.HasKey(x => new { x.Id, x.rncCedula });
            builder.Property(v => v.Nombre)
                .IsRequired();
            builder.HasData(SeedData.GetContribuyentes());
        }
    }
}
