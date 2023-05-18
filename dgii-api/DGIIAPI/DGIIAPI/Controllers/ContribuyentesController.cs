using AutoMapper;
using DGII.API.Helpers;
using DGII.BLL.Contracts;
using DGII.BOL.Dtos;
using DGII.BOL.Models;
using Microsoft.AspNetCore.Mvc;

namespace DGII.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContribuyentesController : DGIIBaseController
    {
        public ContribuyentesController(IUnitOfWork unitOfWork, IMapper mapper) : base (unitOfWork, mapper)
        {
        }

        [HttpGet(Name = "GetContribuyentes")]
        public async Task<IActionResult> Get([FromQuery] QueryParams queryParams)
        {
            //Incluir propiedades foraneas para realizar el mapeo con automapper
            QueryResponseObject<Contribuyente> queryResponseObject = await _unitofWork.Contribuyentes.GetAllAsync(includeProperties: "Estado,Tipo,Comprobantes", rowsPerPage: queryParams.rowsPerPage, pageNumber: queryParams.pageNumber);
            var contribuyentesDto = _mapper.Map<IEnumerable<ContribuyenteDto>>(queryResponseObject.Items);
            Response<ContribuyenteDto> response = new Response<ContribuyenteDto>(queryResponseObject.Count, contribuyentesDto);

            if (response.Items.Any())
            return Ok(response);

            return NotFound("Contribuyentes no encontrados en la base de datos");
        }
    }
}
