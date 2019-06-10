using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Models
{
    public class APIContext : DbContext
    {

        public APIContext(DbContextOptions<APIContext> options) : base(options)
        {
            
        }
        public DbSet<Bateau> Bateau { get; set; }
        public DbSet<Utilisateur> Utilisateur { get; set; }
        public DbSet<Position_Bateau> Position_bateau { get; set; }

    }

}
