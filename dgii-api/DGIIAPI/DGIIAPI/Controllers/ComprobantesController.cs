using AutoMapper;
using DGII.API.Helpers;
using DGII.BLL.Contracts;
using DGII.BOL.Dtos;
using DGII.BOL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DGII.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComprobantesController : DGIIBaseController
    {
        public ComprobantesController(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        [HttpGet("{rncCedula}", Name = "GetComprobantes")]
        public async Task<IActionResult> Get(string rncCedula, [FromQuery] QueryParams queryParams)
        {
            QueryResponseObject<Comprobante> queryResponseObject = await _unitofWork.Comprobantes.GetAllAsync(x => 
                x.rncCedula == rncCedula, rowsPerPage: queryParams.rowsPerPage, pageNumber: queryParams.pageNumber);

            var comprobantesDto = _mapper.Map<IEnumerable<ComprobanteDto>>(queryResponseObject.Items);
            Response<ComprobanteDto> response = new Response<ComprobanteDto>(queryResponseObject.Count, comprobantesDto);

            if (response.Items.Any())  //En caso de que existan registros en la base de datos, retornar data
                return Ok(response);

            return NotFound("Comprobantes no encontrados en la base de datos"); 
            // En caso de que no existan, retornar NotFound error
        }
    }
}
