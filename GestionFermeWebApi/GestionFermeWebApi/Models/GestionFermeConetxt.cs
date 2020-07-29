using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionFermeWebApi.Models
{
    public class GestionFermeConetxt : DbContext
    {
        public GestionFermeConetxt(DbContextOptions<GestionFermeConetxt> options) : base(options)
        {

        }
     }
}
