using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAsignment.Models.Base;

namespace TestAsignment.Models
{
    public class Worker : BaseModel
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public string PhoneNumber { get; set; }
    }
}
