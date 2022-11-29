using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Second.Models
{
    public class AppDbContaxt:DbContext
    {
        public AppDbContaxt(DbContextOptions<AppDbContaxt> option) :base(option)
        {
                
        }
        public DbSet<DataModel> DataModels { get; set; }
    }
}

