using Borjomi.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Borjomi.Data
{
    public class AppDBContent : DbContext
    {
       
        public AppDBContent(DbContextOptions<AppDBContent> options): base(options)
        {

            Database.EnsureCreated();

        }

        public DbSet<Staff> Staff { get; set; }
    
    }
}
