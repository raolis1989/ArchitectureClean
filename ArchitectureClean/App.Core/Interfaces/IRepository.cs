using App.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {


        Task<T> CreateAsync(T obj);

        Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> Data);
        Task<IEnumerable<T>> ReadAsync();
        Task<T> ReadAsync(T Data);

        Task<Boolean> ExistAsync(Expression<Func<T, bool>> matchitem);
        Task<T> FindAsync(Expression<Func<T, bool>> matchitem);
        Task<T> FindIncludeAsync(Expression<Func<T, bool>> matchitem, Expression<Func<T, object>> criteria);
        Task<IEnumerable<T>> FindAllIncludeAsync(Expression<Func<T, bool>> matchitem, Expression<Func<T, object>> criteria); /*Include Relationship of T*/
        Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> matchitem);
        Task<IEnumerable<T>> FindAllWhereAsync(Expression<Func<T, bool>> matchitem);
        Task<IEnumerable<T>> FindAllWhereTakeAsync(Expression<Func<T, bool>> matchitem, int count);
        Task<IEnumerable<T>> FindAllTakeAsync(int count);
        Task<T> GetAsync(int id);


        Task<T> UpdateAsync(T obj);


        Task<T> DeleteAsync(T obj);
        Task<IEnumerable<T>> DeleteRangeAsync(IEnumerable<T> obj);


        Task<int> CountAsync();

        Task<Boolean> ExistsAsync(Expression<Func<T, bool>> matchitem);

    }
}
