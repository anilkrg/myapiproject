using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myapiproject.Models
{
    public class AppDBContext:DbContext

    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

        public DbSet<Products> Products { get; set; }
        public DbSet<Tbl_Users> Tbl_Users { get; set; }
    }
}
