﻿using Microsoft.EntityFrameworkCore;
using ReStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReStore.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<Product> Products { get; set; }
    }
}
