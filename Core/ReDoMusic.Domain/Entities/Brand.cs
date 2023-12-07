﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReDoMusic.Common;

namespace ReDoMusic.Domain.Entities
{
    public class Brand : EntityBase<Guid>
    {
        public string Name { get; set; }
        public string DisplayingText { get; set; }
        public string Address { get; set; }
    }
}
