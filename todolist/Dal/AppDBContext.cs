using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using todolist.Models;

namespace todolist.Dal
{
    
        public class AppDBContext : DbContext
        {
            public AppDBContext(DbContextOptions<AppDBContext> options)
              : base(options)
            {
                Database.Migrate();
            }


            public virtual DbSet<Todo> Todos { get; set; }

        }
    
}
