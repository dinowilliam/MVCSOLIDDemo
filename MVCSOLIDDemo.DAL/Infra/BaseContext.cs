using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Web;

namespace MVCSOLIDDemo.DAL.Infra
{
    public class BaseContext<T> : DbContext where T : class
    {
        public DbSet<T> DbSet {
            get;
            set;
        }

        public BaseContext() : base("name=ContextDBO"){            
            
        }
        
        public virtual void ChangeObjectState(object model, EntityState state){          
            ((IObjectContextAdapter)this)
                            .ObjectContext
                            .ObjectStateManager
                            .ChangeObjectState(model, state);
        }

        public virtual int Save(T model)
        {
            this.DbSet.Add(model);
            return this.SaveChanges();
        }

        public virtual int Update(T model)
        {
            var entry = this.Entry(model);

            if (entry.State == EntityState.Detached)
                this.DbSet.Attach(model);

            this.ChangeObjectState(model, EntityState.Modified);
            return this.SaveChanges();
        }

        public virtual void Delete(T model)
        {
            var entry = this.Entry(model);

            if (entry.State == EntityState.Detached)
                this.DbSet.Attach(model);

            this.ChangeObjectState(model, EntityState.Deleted);
            this.SaveChanges();
        }

        public virtual IEnumerable<T> GetAll()
        {
            return this.DbSet.ToList();
        }

        public virtual T GetById(object id)
        {
            return this.DbSet.Find(id);
        }

        public virtual IEnumerable<T> Where(Expression<Func<T, bool>> expression)
        {
            return this.DbSet.Where(expression);
        }

        public IEnumerable<T> OrderBy(Expression<Func<T, bool>> expression)
        {
            return this.DbSet.OrderBy(expression);
        }
    }
}