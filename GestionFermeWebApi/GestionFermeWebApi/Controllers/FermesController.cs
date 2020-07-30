using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GestionFermeWebApi.Models;

namespace GestionFermeWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FermesController : ControllerBase
    {
        private readonly GestionFermeConetxt _context;

        public FermesController(GestionFermeConetxt context)
        {
            _context = context;
        }

        // GET: api/Fermes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ferme>>> GetFerme()
        {
            return await _context.Ferme.ToListAsync();
        }

        // GET: api/Fermes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ferme>> GetFerme(int id)
        {
            var ferme = await _context.Ferme.FindAsync(id);

            if (ferme == null)
            {
                return NotFound();
            }

            return ferme;
        }

 

        // PUT: api/Fermes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFerme(int id, Ferme ferme)
        {
            if (id != ferme.FermeId)
            {
                return BadRequest();
            }

            _context.Entry(ferme).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FermeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Fermes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Ferme>> PostFerme(Ferme ferme)
        {
            _context.Ferme.Add(ferme);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFerme", new { id = ferme.FermeId }, ferme);
        }

        // DELETE: api/Fermes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Ferme>> DeleteFerme(int id)
        {
            var ferme = await _context.Ferme.FindAsync(id);
            if (ferme == null)
            {
                return NotFound();
            }

            _context.Ferme.Remove(ferme);
            await _context.SaveChangesAsync();

            return ferme;
        }

        private bool FermeExists(int id)
        {
            return _context.Ferme.Any(e => e.FermeId == id);
        }




        [Route("ferme/[controller]")]
      
        // GET: api/Fermes/arbi
        [HttpGet("{nom}")]
        public async Task<ActionResult<Ferme>> GetFermeParNom(string nom)
        {
            var ferme = await _context.Ferme.FindAsync(nom);


            return  ferme;
        }

    }
}
