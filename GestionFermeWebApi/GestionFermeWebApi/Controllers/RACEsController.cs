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
    public class RACEsController : ControllerBase
    {
        private readonly GestionFermeConetxt _context;

        public RACEsController(GestionFermeConetxt context)
        {
            _context = context;
        }

        // GET: api/RACEs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RACE>>> GetRACE()
        {
            return await _context.RACE.ToListAsync();
        }

        // GET: api/RACEs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RACE>> GetRACE(int id)
        {
            var rACE = await _context.RACE.FindAsync(id);

            if (rACE == null)
            {
                return NotFound();
            }

            return rACE;
        }

        // PUT: api/RACEs/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRACE(int id, RACE rACE)
        {
            if (id != rACE.idRace)
            {
                return BadRequest();
            }

            _context.Entry(rACE).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RACEExists(id))
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

        // POST: api/RACEs
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<RACE>> PostRACE(RACE rACE)
        {
            _context.RACE.Add(rACE);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRACE", new { id = rACE.idRace }, rACE);
        }

        // DELETE: api/RACEs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<RACE>> DeleteRACE(int id)
        {
            var rACE = await _context.RACE.FindAsync(id);
            if (rACE == null)
            {
                return NotFound();
            }

            _context.RACE.Remove(rACE);
            await _context.SaveChangesAsync();

            return rACE;
        }

        private bool RACEExists(int id)
        {
            return _context.RACE.Any(e => e.idRace == id);
        }
    }
}
