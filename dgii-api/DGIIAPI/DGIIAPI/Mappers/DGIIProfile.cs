using AutoMapper;
using DGII.BOL.Dtos;
using DGII.BOL.Models;

namespace DGII.API.Mappers
{
    public class DGIIProfile : Profile
    {
        public DGIIProfile()
        {
            CreateMap<Contribuyente, ContribuyenteDto>()
                .ForMember(ctx => ctx.Estado, vfn => vfn.MapFrom(s => s.Estado.Nombre))
                .ForMember(ctx => ctx.Tipo, vfn => vfn.MapFrom(s => s.Tipo.Nombre))
                .ForMember(ctx => ctx.TotalItebis, vfn => vfn.MapFrom(s => s.Comprobantes.Sum(p => p.Itbis18)));

            CreateMap<Comprobante, ComprobanteDto>();
        }
    }
}
