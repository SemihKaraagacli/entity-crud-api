﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Data.Entities
{
    public class User:BaseEntity
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
