﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purchase.Domain.Interface
{
    public interface IUnitOfWork
    {
        void Commit();
        Task CommitAsync();
    }
}
