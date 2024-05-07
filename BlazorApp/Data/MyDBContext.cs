using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorApp.Model;

namespace BlazorApp.Data
{
    public class MyDBContext : DbContext
    {
        public MyDBContext (DbContextOptions<MyDBContext> options)
            : base(options)
        {
        }

        public DbSet<BlazorApp.Model.Car> Car { get; set; } = default!;
    }
}
