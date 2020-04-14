using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Interfaces
{
    public interface IOperations<T> where T :class
    {
        T Create(T Data);
        Task<T> CreateAsync(T Data);
        IEnumerable<T> AddRange(IEnumerable<T> Data);
        Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> Data);

        T Read(T Data);
        T Find(Expression<Func<T, bool>> matchitem);
        T FindInclude(Expression<Func<T, bool>> matchitem, Expression<Func<T, object>> criteria);
        Task<T> FindIncludeAsync(Expression<Func<T, bool>> matchitem, Expression<Func<T, object>> criteria);
        IEnumerable<T> FindAllWhere(Expression<System.Func<T, bool>> matchitem);
        IEnumerable<T> FindAllWhereTake(Expression<System.Func<T, bool>> matchitem, int count);
        IEnumerable<T> FindAllTake(int count);
        Task<T> ReadAsync(T Data);
        Task<T> FindAsync(Expression<Func<T, bool>> matchitem);
        IEnumerable<T> FindAll(Expression<Func<T, bool>> matchitem);
        Task<IEnumerable<T>> FindAllTakeAsync(int count);
        Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> matchitem);
        IEnumerable<T> FindAllInclude(Expression<Func<T, bool>> matchitem, Expression<Func<T, object>> criteria);
        Task<IEnumerable<T>> FindAllIncludeAsync(Expression<Func<T, bool>> matchitem, Expression<Func<T, object>> criteria);
        T Update(T Data);
        Task<T> UpdateAsync(T Data);

        T Delete(T Data);
        Task<T> DeleteAsync(T Data);
        IEnumerable<T> DeleteRange(IEnumerable<T> Data);
        Task<IEnumerable<T>> DeleteRangeAsync(IEnumerable<T> Data);

        int Count();
        Task<int> CountAsync();

        Task<bool> ExistsAsync(Expression<Func<T, bool>> matchitem);
        bool Exists(Expression<Func<T, bool>> matchitem);
    }
}
