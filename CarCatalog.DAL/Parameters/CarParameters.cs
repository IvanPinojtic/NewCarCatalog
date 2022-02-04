﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarCatalog.DAL.Parameters
{
    public class CarParameters : QueryParameters
    {
        public bool OrderByProductionYear { get; set; } = false;
        public bool OrderByName { get; set; } = false;

    }
}
