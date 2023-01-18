using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAsignment.Models.Base;

namespace TestAsignment.Repositories.Interfaces
{
    public interface IBaseRepository<TDBModel> where TDBModel : BaseModel
    {
        public List<TDBModel> GetAll();
        public TDBModel Get(Guid id);
        public TDBModel Create(TDBModel model);
        public TDBModel Update(TDBModel model);
        public void Delete(Guid id);
    }
}
