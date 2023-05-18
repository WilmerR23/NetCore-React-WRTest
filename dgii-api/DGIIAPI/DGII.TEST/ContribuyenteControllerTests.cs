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
    public class ContribuyenteControllerTests
    {
        [Fact]
        public async Task GetContribuyentes_ShouldReturnValues()
        {
            var UnitOfWorkMock = MockIUnitOfWork.GetMock();
            var mapper = MockIMapper.GetMapper();
            var contribuyentesController = new ContribuyentesController(UnitOfWorkMock.Object, mapper);

            var result = await contribuyentesController.Get(new API.Helpers.QueryParams()) as ObjectResult;

            Assert.NotNull(result);
            var items = (result.Value as Response<ContribuyenteDto>).Items;
            Assert.Equal(StatusCodes.Status200OK, result.StatusCode);
            Assert.IsAssignableFrom<Response<ContribuyenteDto>>(result.Value);
            Assert.NotEmpty(items);
        }


        [Fact]
        public async Task GetContribuyentes_ShouldReturnValuesPaginated()
        {
            var UnitOfWorkMock = MockIUnitOfWork.GetMock();
            var mapper = MockIMapper.GetMapper();
            var contribuyentesController = new ContribuyentesController(UnitOfWorkMock.Object, mapper);

            QueryParams queryParams = new QueryParams();
            queryParams.rowsPerPage = 10;

            var result = await contribuyentesController.Get(queryParams) as ObjectResult;

            Assert.NotNull(result);
            var items = (result.Value as Response<ContribuyenteDto>).Items;
            Assert.Equal(StatusCodes.Status200OK, result.StatusCode);
            Assert.Equal(queryParams.rowsPerPage, items.Count());
        }

    }
}
