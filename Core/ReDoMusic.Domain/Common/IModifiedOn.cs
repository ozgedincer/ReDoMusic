﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReDoMusic.Common
{
    public interface IModifiedOn
    {
        public string? ModifiedByUserId { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
