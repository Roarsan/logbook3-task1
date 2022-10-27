using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using logbook3_task1;

namespace logbook3_task1.Data
{
    public class logbook3_task1Context : DbContext
    {
        public logbook3_task1Context (DbContextOptions<logbook3_task1Context> options)
            : base(options)
        {
        }

        public DbSet<logbook3_task1.Movie> Movie { get; set; } = default!;
    }
}
