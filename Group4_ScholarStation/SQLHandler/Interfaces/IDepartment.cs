﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLHandler
{
    public interface IDepartment
    {
        IDataReader GetDepartment();

    }
}
