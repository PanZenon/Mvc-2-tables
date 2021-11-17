using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebMVC_DB2_sp.Models;

namespace WebMVC_DB2_sp.Data
{
    public class WebMVC_DB2_spContext : DbContext
    {
        public WebMVC_DB2_spContext (DbContextOptions<WebMVC_DB2_spContext> options)
            : base(options)
        {
        }

        public DbSet<WebMVC_DB2_sp.Models.Animal> Animal { get; set; }
        public DbSet<WebMVC_DB2_sp.Models.Type> Type { get; set; }
    }
}
