using DGII.BOL.Models;
using DGII.UTL;

namespace DGII.DAL.Configurations
{
    public class TiposConfig : SmallEntitiesConfig<TipoContribuyente>
    {
         public TiposConfig() : base(SeedData.GetTipos())
        { }
    }

}
