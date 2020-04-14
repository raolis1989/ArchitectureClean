﻿using App.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {

        T Create(T obj);
        Task<T> CreateAsync(T obj);
        IEnumerable<T> AddRangeAsync(IEnumerable<T> obj);


        IEnumerable<T> Read();
        Task<IEnumerable<T>> ReadAsync();
        Boolean Exist(Expression<Func<T, bool>> matchitem);
        Task<Boolean> ExistAsync(Expression<Func<T, bool>> matchitem);
        T Find(Expression<Func<T, bool>> matchitem); /*Single Item*/
        Task<T> FindAsync(Expression<Func<T, bool>> matchitem);
        T FindInclude(Expression<Func<T, bool>> matchitem, Expression<Func<T, object>> criteria);
        Task<T> FindIncludeAsync(Expression<Func<T, bool>> matchitem, Expression<Func<T, object>> criteria);
        IEnumerable<T> FindAll(Expression<Func<T, bool>> matchitem); /*Many Items*/
        IEnumerable<T> FindAllInclude(Expression<Func<T, bool>> matchitem, Expression<Func<T, object>> criteria);/*Include Relationship of T*/
        Task<IEnumerable<T>> FindAllIncludeAsync(Expression<Func<T, bool>> matchitem, Expression<Func<T, object>> criteria); /*Include Relationship of T*/
        Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> matchitem);
        IEnumerable<T> FindAllWhere(Expression<Func<T, bool>> matchitem);
        Task<IEnumerable<T>> FindAllWhereAsync(Expression<Func<T, bool>> matchitem);
        IEnumerable<T> FindAllWhereTake(Expression<Func<T, bool>> matchitem, int count);
        Task<IEnumerable<T>> FindAllWhereTakeAsync(Expression<Func<T, bool>> matchitem, int count);
        IEnumerable<T> FindAllTake(int count);
        Task<IEnumerable<T>> FindAllTakeAsync(int count);
        T Get(int id);
        Task<T> GetAsync(int id);


        T Update(T obj);
        Task<T> UpdateAsync(T obj);


        T Delete(T obj);
        Task<T> DeleteAsync(T obj);
        IEnumerable<T> DeleteRange(IEnumerable<T> obj);
        Task<IEnumerable<T>> DeleteRangeAsync(IEnumerable<T> obj);


        int Count();
        Task<int> CountAsync();

        Boolean Exists(Expression<Func<T, bool>> matchitem);
        Task<Boolean> ExistsAsync(Expression<Func<T, bool>> matchitem);

    }
}
