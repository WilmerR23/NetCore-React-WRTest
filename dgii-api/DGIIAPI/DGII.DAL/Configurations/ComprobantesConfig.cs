using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DGII.BOL.Models;
using System.Reflection.Emit;
using System.ComponentModel.DataAnnotations.Schema;
using DGII.UTL;

namespace DGII.DAL.Configurations
{
    public class ComprobantesConfig : BaseConfig<Comprobante>
    {
        public override void Configure(EntityTypeBuilder<Comprobante> builder)
        {
            base.Configure(builder);
            builder.HasIndex(t => t.Ncf) // Colocar Ncf como valor unico
                .IsUnique();
            builder.HasOne(x => x.Contribuyente)
                .WithMany(v => v.Comprobantes)
                .HasForeignKey(x => new { x.ContribuyenteId, x.rncCedula });
            builder.Property(v => v.Ncf)
                .IsRequired()
                .HasMaxLength(13);
            builder.Property(v => v.Monto)
                .IsRequired();
            builder.Property(v => v.Itbis18)
                .IsRequired();
            builder.HasData(SeedData.GetComprobantes());
        }
    }
}
