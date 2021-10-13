using DatoApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatoApi.Data
{
    public class AppDbContext: DbContext
    {
        public DbSet<Dato> Datos { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

        }
    }
}
