using GenSci.FamilyBudget.DataContext.Models;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace GenSci.FamilyBudget.DataContext.Repository
{
    /// <summary>
    /// Repository for User table operations.
    /// </summary>
    public class UserRepository : IRepository<User>
    {
        /// <summary>
        /// Database application context.
        /// </summary>
        private readonly AppContext _appContext;

        public UserRepository(AppContext appContext)
        {
            _appContext = appContext;
        }

        IEnumerable<User> IRepository<User>.All => _appContext.Users;

        User IRepository<User>.FindById(int id) => _appContext.Users.Find(id);

        void IRepository<User>.Add(User entity)
        {
            _appContext.Users.Add(entity);
        }

        void IRepository<User>.Delete(User entity)
        {
            _appContext.Users.Remove(entity);
        }

        void IRepository<User>.Update(User entity)
        {
            _appContext.Entry(entity).State = EntityState.Modified;
        }

        void IRepository<User>.Save()
        {
            _appContext.SaveChanges();
        }
    }
}
