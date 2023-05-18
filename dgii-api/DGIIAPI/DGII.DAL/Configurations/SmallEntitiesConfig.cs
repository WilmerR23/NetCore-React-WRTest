using DGII.BOL.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DGII.DAL.Configurations
{
    public class SmallEntitiesConfig<T> : IEntityTypeConfiguration<T> where T : SmallEntities
    {
        private readonly IEnumerable<T> _smallEntities;
        public SmallEntitiesConfig(IEnumerable<T> smallEntities) {
            _smallEntities = smallEntities;
        }
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(v => v.Nombre)
                .IsRequired();
            builder.HasData(_smallEntities);
        }
    }
}
