using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using prakticeMVC1.Models;

namespace prakticeMVC1.Data
{
    public class StoreContext : DbContext
    {
        public DbSet<Album> Album { get; set; }
        public DbSet<Artist> Artist { get; set; }
        public DbSet<Genre> Genre { get; set; }

       
    }
}
