﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAsignment.Models
{
    public class Document
    {
        public Guid CarId { get; set; }
        public Guid WorkerId { get; set; }
        public virtual Car Car { get; set; }
        public virtual Worker Worker { get; set; }
    }
}
