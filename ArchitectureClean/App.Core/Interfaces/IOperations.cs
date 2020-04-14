using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Interfaces
{
    public interface IOperations<T> where T :class
    {
   
        Task<T> CreateAsync(T Data);
        Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> Data);



        Task<T> FindIncludeAsync(Expression<Func<T, bool>> matchitem, Expression<Func<T, object>> criteria);

        Task<T> ReadAsync(T Data);
        Task<T> FindAsync(Expression<Func<T, bool>> matchitem);

        Task<IEnumerable<T>> FindAllTakeAsync(int count);
        Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> matchitem);

        Task<IEnumerable<T>> FindAllIncludeAsync(Expression<Func<T, bool>> matchitem, Expression<Func<T, object>> criteria);

        Task<T> UpdateAsync(T Data);


        Task<T> DeleteAsync(T Data);

        Task<IEnumerable<T>> DeleteRangeAsync(IEnumerable<T> Data);


        Task<int> CountAsync();

        Task<bool> ExistsAsync(Expression<Func<T, bool>> matchitem);

    }
}
