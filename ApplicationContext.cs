﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp30
{
    class ApplicationContext
    {
        public DBSet<User> Users { get, set }
        }
        public ApplicationContext() : base("DefaultConnection") { }
    }
