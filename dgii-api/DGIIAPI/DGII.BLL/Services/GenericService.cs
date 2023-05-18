using DGII.BLL.Contracts;
using DGII.BOL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DGII.BLL.Services
{
    public class GenericService<T> : IGenericService<T> where T : class
    {
        private DbSet<T> _dbSet;
        public GenericService(IDbContext dbContext)
        {
            _dbSet = dbContext.Set<T>();
        }

        public async Task<QueryResponseObject<T>> GetAllAsync(Expression<Func<T, bool>> filter = null, 
            string includeProperties = null, int rowsPerPage = 10, int pageNumber = 1)
        {
            IQueryable<T> query = _dbSet;
            int count = _dbSet.Count();

            if (filter != null) // Si se necesita buscar por una condicion
            {
                query = query.Where(filter);
                count = query.Count();
            }

            if (rowsPerPage != -1) // Realizar la paginacion solamente si la opcion que se selecciono es diferente a "Todos"
            {
                query = query.Skip((pageNumber - 1) * rowsPerPage).Take(rowsPerPage);
            }

            if (includeProperties != null) // Si se necesita incluir propiedades
            {
                foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }

            QueryResponseObject<T> responseObj = new QueryResponseObject<T>(count, await query.ToListAsync());
            return responseObj;
        }
    }
}
