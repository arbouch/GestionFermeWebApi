using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionFermeWebApi.Models;

namespace GestionFermeWebApi.Models
{
    public class GestionFermeConetxt : DbContext
    {
        public GestionFermeConetxt(DbContextOptions<GestionFermeConetxt> options) : base(options)
        {

        }
        public DbSet<GestionFermeWebApi.Models.Ferme> Ferme { get; set; }
        public DbSet<GestionFermeWebApi.Models.VETERINAIRE> VETERINAIRE { get; set; }
        public DbSet<GestionFermeWebApi.Models.RACE> RACE { get; set; }
        public DbSet<GestionFermeWebApi.Models.categorie> categorie { get; set; }
     }
}
