﻿using Repository.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IUnitIOfWork
    {
        public ICustomerRepository CustomerRepository { get; }
        Task<int> SaveChangesAsync();
    }
}
