﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFlooringCorp.Models.Interfaces
{
    public interface IStateTaxRepository
    {
        List<StateTax> ListAll();
    }
}
