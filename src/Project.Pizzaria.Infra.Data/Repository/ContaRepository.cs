﻿using Project.Pizzaria.Domain.Interfaces.Repository;
using Project.Pizzaria.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Pizzaria.Infra.Data.Repository
{
   public class ContaRepository : Repository<Conta>, IContaRepository
    {
    }
}