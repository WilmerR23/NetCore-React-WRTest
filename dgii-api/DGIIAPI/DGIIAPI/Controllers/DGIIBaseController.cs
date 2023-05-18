using AutoMapper;
using DGII.BLL.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DGII.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DGIIBaseController : ControllerBase
    {
        public readonly IUnitOfWork _unitofWork;
        public readonly IMapper _mapper;

        public DGIIBaseController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitofWork = unitOfWork;
            _mapper = mapper;
        }
    }
}
