using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_Agile.Models;

namespace MVC_Agile.Data
{
    public class MVC_AgileContext : DbContext
    {
        public MVC_AgileContext (DbContextOptions<MVC_AgileContext> options)
            : base(options)
        {
        }

        public DbSet<MVC_Agile.Models.Movie> Movie { get; set; } = default!;
    }
}
