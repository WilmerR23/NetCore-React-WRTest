using DGII.BOL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGII.DAL.Configurations
{
    public class BaseConfig<T> : IEntityTypeConfiguration<T> where T : Base
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(v => v.fechaRegistro)
                .HasDefaultValueSql("GetDate()");
            builder.Property(v => v.rncCedula)
                .IsRequired()
                .HasMaxLength(11);
        }
    }
}
