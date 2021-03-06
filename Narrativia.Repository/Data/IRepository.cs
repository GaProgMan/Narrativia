﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Narrativia.Data.Entities;

namespace Narrativia.Repository.Data
{
    public interface IRepository<T> where T : BaseAuditClass  
    {  
        IEnumerable<T> GetAll();  
        T Get(UInt64 id);
        void Insert(T entity);  
        void Update(T entity);  
        void Delete(T entity);  
        void Remove(T entity);  
        int SaveChanges();
        Task<int> SaveChangesAsync();
    }
}