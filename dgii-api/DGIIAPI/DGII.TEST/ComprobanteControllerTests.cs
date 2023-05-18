using Azure;
using DGII.API.Controllers;
using DGII.API.Helpers;
using DGII.BOL.Dtos;
using DGII.BOL.Models;
using DGII.TEST.Mocks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGII.TEST
{
    public class ComprobanteControllerTests
    {
        [Fact]
        public async Task GetComprobantes_ShouldReturnValues()
        {
            var UnitOfWorkMock = MockIUnitOfWork.GetMock();
            var mapper = MockIMapper.GetMapper();
            var comprobantesController = new ComprobantesController(UnitOfWorkMock.Object, mapper);

            var result = await comprobantesController.Get("98754321012", new QueryParams()) as ObjectResult;

            Assert.NotNull(result);
            var items = (result.Value as BOL.Models.Response<ComprobanteDto>).Items;
            Assert.Equal(StatusCodes.Status200OK, result.StatusCode);
            Assert.IsAssignableFrom<BOL.Models.Response<ComprobanteDto>>(result.Value);
            Assert.NotEmpty(items);
        }

        [Fact]
        public async Task GetComprobantes_ShouldReturnValuesPaginated()
        {
            var UnitOfWorkMock = MockIUnitOfWork.GetMock();
            var mapper = MockIMapper.GetMapper();
            var comprobantesController = new ComprobantesController(UnitOfWorkMock.Object, mapper);

            QueryParams queryParams = new QueryParams();
            queryParams.rowsPerPage = 5;

            var result = await comprobantesController.Get("98754321012", queryParams) as ObjectResult;

            Assert.NotNull(result);
            var items = (result.Value as BOL.Models.Response<ComprobanteDto>).Items;
            Assert.Equal(StatusCodes.Status200OK, result.StatusCode);
            Assert.Equal(queryParams.rowsPerPage, items.Count());
        }

        [Fact]
        public async Task GetComprobantes_ShouldNotReturnValues()
        {
            var UnitOfWorkMock = MockIUnitOfWork.GetMock();
            var mapper = MockIMapper.GetMapper();
            var comprobantesController = new ComprobantesController(UnitOfWorkMock.Object, mapper);

            var result = await comprobantesController.Get("00000000000", new API.Helpers.QueryParams()) as ObjectResult; //00000000000 No existe en SeedData
            Assert.NotNull(result);
            Assert.Equal("Comprobantes no encontrados en la base de datos", result.Value);
            Assert.Equal(StatusCodes.Status404NotFound, result.StatusCode);
        }
    }
}
