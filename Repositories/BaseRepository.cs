using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAsignment.Database;
using TestAsignment.Models.Base;
using TestAsignment.Repositories.Interfaces;

namespace TestAsignment.Repositories
{
    public class BaseRepository<TDBModel> : IBaseRepository<TDBModel> where TDBModel : BaseModel
    {
        private ApplicationContext Context { get; set; }
        public BaseRepository(ApplicationContext context)
        {
            Context = context;
        }

        public TDBModel Create(TDBModel model) 
        {
            Context.Set<TDBModel>().Add(model);
            Context.SaveChanges();
            return model;
        }

        public void Delete(Guid id) 
        {
            var toDelete = Context.Set<TDBModel>().FirstOrDefault(m => m.Id == id);
            Context.Set<TDBModel>().Remove(toDelete);
            Context.SaveChanges(); 
        }

        public List<TDBModel> GetAll() 
        {
            return Context.Set<TDBModel>().ToList();
        }

        public TDBModel Update(TDBModel model) 
        {
            var toUpdate = Context.Set<TDBModel>().FirstOrDefault(m=> m.Id == model.Id);
            if (toUpdate != null) 
            {
                toUpdate = model;
            }
            Context.Update(toUpdate);
            Context.SaveChanges();
            return toUpdate;
        }

        public TDBModel Get(Guid id) 
        {
            return Context.Set<TDBModel>().FirstOrDefault(m => m.Id == id);
        }
    }
}
