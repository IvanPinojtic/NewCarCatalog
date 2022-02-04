using CarCatalog.DAL.Models;
using CarCatalog.DAL.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCatalog.DAL
{
    public static class Exensions
    {
        public static IQueryable<T> ApplyParameters<T>(this IQueryable<T> query, QueryParameters parameters)
        {
            return query.Skip((parameters.PageNumber - 1) * parameters.PageSize)
                .Take(parameters.PageSize);
        }
    }
}
