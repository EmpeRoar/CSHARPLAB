using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSHARP.Controllers
{
    public static class Helper
    {
        public static IQueryable<T> Wherex<T>(this IQueryable<T> q) where T : class
        {
            return q;
        }
    }
}
