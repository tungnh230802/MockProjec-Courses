﻿using MOCK_Course.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOCK_Course.DAL.Repositories.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public UnitOfWork(AppDbContext context)
        {
            _context = context;

            //Posts = postRepository;
            //Categories = categoryRepository;
        }

        #region IUnitOfWork Members
        /// <summary>
        /// Save all changes
        /// </summary>
        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        /// <summary>
        /// Dispose
        /// </summary>
        public void Dispose()
        {
            GC.SuppressFinalize(this);
            _context.Dispose();
        }

        /// <summary>
        /// Save all changes async
        /// </summary>
        /// <returns></returns>
        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
        #endregion
    }
}
