using App.Core.Entities;
using App.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.UseCases
{
    public class Operations<T> : IOperations<T> where T : BaseEntity
    {
        private readonly IRepository<T> _repository;

        public Operations(IRepository<T> Repository)
        {
            _repository = Repository;
        }

        public Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> Data)
        {
            return _repository.AddRangeAsync(Data);
        }

        public Task<int> CountAsync()
        {
            return _repository.CountAsync();
        }

        public Task<T> CreateAsync(T Data)
        {
            return _repository.CreateAsync(Data);
        }

        public Task<T> DeleteAsync(T Data)
        {
            return _repository.DeleteAsync(Data);
        }

        public Task<IEnumerable<T>> DeleteRangeAsync(IEnumerable<T> Data)
        {
            return _repository.DeleteRangeAsync(Data);
        }

        public Task<bool> ExistsAsync(Expression<Func<T, bool>> matchitem)
        {
            return _repository.ExistAsync(matchitem);
        }

        public Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> matchitem)
        {
            return _repository.FindAllAsync(matchitem);
        }

        public Task<IEnumerable<T>> FindAllIncludeAsync(Expression<Func<T, bool>> matchitem, Expression<Func<T, object>> criteria)
        {
            return _repository.FindAllIncludeAsync(matchitem, criteria);
        }

        public Task<IEnumerable<T>> FindAllTakeAsync(int count)
        {
            return _repository.FindAllTakeAsync(count);
        }

        public Task<T> FindAsync(Expression<Func<T, bool>> matchitem)
        {
            return _repository.FindAsync(matchitem);
        }

        public Task<T> FindIncludeAsync(Expression<Func<T, bool>> matchitem, Expression<Func<T, object>> criteria)
        {
            return _repository.FindIncludeAsync(matchitem, criteria);
        }

        public Task<T> ReadAsync(T Data)
        {
            return _repository.ReadAsync(Data);
        }

        public Task<T> UpdateAsync(T Data)
        {
            return _repository.UpdateAsync(Data);
        }
    }
}
