using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using c_sharp.Models;

namespace c_sharp.Data
{
    public class c_sharpContext : DbContext
    {
        public c_sharpContext (DbContextOptions<c_sharpContext> options)
            : base(options)
        {
        }

        public DbSet<c_sharp.Models.Movie> Movie { get; set; } = default!;
    }
}
