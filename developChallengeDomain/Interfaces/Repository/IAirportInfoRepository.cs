﻿using developChallenge.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace developChallenge.Domain.Interfaces.Repository
{
    public interface IAirportInfoRepository
    {
        IEnumerable<AirportInfo> GetByNameAsync(string name);
    }
}
