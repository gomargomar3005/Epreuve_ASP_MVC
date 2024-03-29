﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared_Epreuve.Repositories
{
    public interface IProduitRepository<TEntity> :
        ICRUDRepository<TEntity, int> where TEntity : class
    {
    }
}
