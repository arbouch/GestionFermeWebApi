using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionFermeWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GestionFermeWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FemeSpeccs : ControllerBase
    {
        private readonly GestionFermeConetxt _context;
        public FemeSpeccs(GestionFermeConetxt context)
        {
            _context = context;
        }

        [HttpGet("{nom}")]
        public Ferme GetFermeParNom(string nom)
        {
            var ferme = _context.Ferme.Where(s => s.nomFerme == nom).FirstOrDefault();
            return ferme;


        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ferme>>> GetFerme()
        {
            return await _context.Ferme.ToListAsync();
        }
    }
}
