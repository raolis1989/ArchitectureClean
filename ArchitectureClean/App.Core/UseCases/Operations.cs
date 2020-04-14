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


        public IEnumerable<T> AddRange(IEnumerable<T> Data)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> Data)
        {
            throw new NotImplementedException();
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync()
        {
            throw new NotImplementedException();
        }

        public T Create(T Data)
        {
            return _repository.Create(Data);
        }

        public Task<T> CreateAsync(T Data)
        {
            return _repository.CreateAsync(Data);
        }

        public T Delete(T Data)
        {
            throw new NotImplementedException();
        }

        public Task<T> DeleteAsync(T Data)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> DeleteRange(IEnumerable<T> Data)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> DeleteRangeAsync(IEnumerable<T> Data)
        {
            throw new NotImplementedException();
        }

        public bool Exists(Expression<Func<T, bool>> matchitem)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsAsync(Expression<Func<T, bool>> matchitem)
        {
            throw new NotImplementedException();
        }

        public T Find(Expression<Func<T, bool>> matchitem)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> FindAll(Expression<Func<T, bool>> matchitem)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> matchitem)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> FindAllInclude(Expression<Func<T, bool>> matchitem, Expression<Func<T, object>> criteria)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> FindAllIncludeAsync(Expression<Func<T, bool>> matchitem, Expression<Func<T, object>> criteria)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> FindAllTake(int count)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> FindAllTakeAsync(int count)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> FindAllWhere(Expression<Func<T, bool>> matchitem)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> FindAllWhereTake(Expression<Func<T, bool>> matchitem, int count)
        {
            throw new NotImplementedException();
        }

        public Task<T> FindAsync(Expression<Func<T, bool>> matchitem)
        {
            throw new NotImplementedException();
        }

        public T FindInclude(Expression<Func<T, bool>> matchitem, Expression<Func<T, object>> criteria)
        {
            throw new NotImplementedException();
        }

        public Task<T> FindIncludeAsync(Expression<Func<T, bool>> matchitem, Expression<Func<T, object>> criteria)
        {
            throw new NotImplementedException();
        }

        public T Read(T Data)
        {
            throw new NotImplementedException();
        }

        public Task<T> ReadAsync(T Data)
        {
            throw new NotImplementedException();
        }

        public T Update(T Data)
        {
            throw new NotImplementedException();
        }

        public Task<T> UpdateAsync(T Data)
        {
            throw new NotImplementedException();
        }
    }
}
