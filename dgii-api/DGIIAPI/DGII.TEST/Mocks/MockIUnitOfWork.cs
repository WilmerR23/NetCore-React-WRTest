using DGII.BLL.Contracts;
using DGII.BLL.Services;
using DGII.BOL.Models;
using DGII.UTL;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGII.TEST.Mocks
{
    internal class MockIUnitOfWork
    {
        public static Mock<IUnitOfWork> GetMock()
        {
            var mock = new Mock<IUnitOfWork>(); // Mock servicios con SeedData
            var comprobantesMock = MockIGenericService.GetMock(SeedData.GetComprobantes());
            var contribuyentesMock = MockIGenericService.GetMock(SeedData.GetContribuyentes());
            mock.Setup(m => m.Comprobantes).Returns(() => comprobantesMock.Object);
            mock.Setup(m => m.Contribuyentes).Returns(() => contribuyentesMock.Object);

            return mock;
        }
    }
}
