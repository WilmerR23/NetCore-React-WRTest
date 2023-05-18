using DGII.BOL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DGII.BLL.Contracts
{
    public interface IGenericService<T> where T : class
    {
        Task<QueryResponseObject<T>> GetAllAsync(Expression<Func<T, bool>> filter = null, string includeProperties = null, int rowsPerPage = 10, int pageNumber = 1);
    }
}
