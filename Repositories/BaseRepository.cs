using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAsignment.Models.Base;
using TestAsignment.Repositories.Interfaces;

namespace TestAsignment.Repositories
{
    public class BaseRepository<TDBModel> : IBaseRepository<TDBModel> where TDBModel : BaseModel
    {
        private ApplicationContext Context { get; set; }
    }
}
