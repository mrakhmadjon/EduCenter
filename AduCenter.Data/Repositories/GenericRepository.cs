﻿using AduCenter.Data.Contexts;
using AduCenter.Data.IRepositories;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AduCenter.Data.Repositories
{
    internal class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        internal EduCenterDbContext eduCenterDbContext;
        internal DbSet<T> dbSet;
        private readonly ILogger logger;
        public GenericRepository(EduCenterDbContext eduCenterDbContext,ILogger logger)
        {
            this.eduCenterDbContext = eduCenterDbContext;
            this.dbSet = eduCenterDbContext.Set<T>();
            this.logger = logger;
        }


        public async Task<T> CreateAsync(T entity)
        {
            try
            {
                var entry = await dbSet.AddAsync(entity);

                return entry.Entity;
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                throw;
            }
        }

        public async Task<bool> DeleteAsync(Expression<Func<T, bool>> expression)
        {
            try
            {
                var entity = await dbSet.FirstOrDefaultAsync(expression);

                if (entity is null)
                    return false;

                dbSet.Remove(entity);

                return true;
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                throw;
            }
        }

        public async Task<IQueryable<T>> GetAllAsync(Expression<Func<T, bool>> expression = null)
        {
            return expression is null ? dbSet : dbSet.Where(expression);
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> expression)
        {
            try
            {
                var entity = await dbSet.FirstOrDefaultAsync(expression);
                return entity;
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                throw;
            }
        }

        public async Task<T> UpdateAsync(T entity)
        {
            try
            {
                var entry = dbSet.Update(entity);

                return entry.Entity;
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                throw;
            }
        }



      }
}