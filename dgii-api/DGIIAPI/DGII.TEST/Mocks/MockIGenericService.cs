using DGII.BLL.Contracts;
using DGII.BOL.Models;
using DGII.UTL;
using Microsoft.EntityFrameworkCore;
using Moq;
using NLog.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DGII.TEST.Mocks
{
    internal class MockIGenericService
    {
        public static Mock<IGenericService<T>> GetMock<T>(IEnumerable<T> results) where T : class
        {
            var mock = new Mock<IGenericService<T>>();
            
            //Mock GetAllAsync method del GenericService para que utilice la data dummy de la clase SeedData
            mock.Setup(m => m.GetAllAsync(It.IsAny<Expression<Func<T, bool>>>(), It.IsAny<string>(), It.IsAny<int>(), It.IsAny<int>()))
                .ReturnsAsync(new Func<Expression<Func<T, bool>>, string, int, int, QueryResponseObject<T>>((filter, includeProperties, rowsPerPage, pageNumber) => {
                    IQueryable<T> query = results.AsQueryable();
                    if (filter != null) // Si se necesita buscar por una condicion
                    {
                        query = query.Where(filter).Skip((pageNumber - 1) * rowsPerPage).Take(rowsPerPage);
                    }
                    else
                    {
                        query = query.Skip((pageNumber - 1) * rowsPerPage).Take(rowsPerPage);
                    }
                    if (includeProperties != null)
                    {
                        foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                        {
                            query = query.Include(includeProperty);
                        }
                    }
                    QueryResponseObject<T> responseObj = new QueryResponseObject<T>(results.Count(), query.ToList());
                    return responseObj;
                }));

            return mock;
        }
    }
}
