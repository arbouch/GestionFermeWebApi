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
    public class VETERINAIREsController : ControllerBase
    {
        private readonly GestionFermeConetxt _context;

        public VETERINAIREsController(GestionFermeConetxt context)
        {
            _context = context;
        }

        // GET: api/VETERINAIREs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VETERINAIRE>>> GetVETERINAIRE()
        {
            return await _context.VETERINAIRE.ToListAsync();
        }

        // GET: api/VETERINAIREs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VETERINAIRE>> GetVETERINAIRE(int id)
        {
            var vETERINAIRE = await _context.VETERINAIRE.FindAsync(id);

            if (vETERINAIRE == null)
            {
                return NotFound();
            }

            return vETERINAIRE;
        }

        // PUT: api/VETERINAIREs/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVETERINAIRE(int id, VETERINAIRE vETERINAIRE)
        {
            if (id != vETERINAIRE.IDVet)
            {
                return BadRequest();
            }

            _context.Entry(vETERINAIRE).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VETERINAIREExists(id))
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

        // POST: api/VETERINAIREs
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<VETERINAIRE>> PostVETERINAIRE(VETERINAIRE vETERINAIRE)
        {
            _context.VETERINAIRE.Add(vETERINAIRE);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVETERINAIRE", new { id = vETERINAIRE.IDVet }, vETERINAIRE);
        }

        // DELETE: api/VETERINAIREs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<VETERINAIRE>> DeleteVETERINAIRE(int id)
        {
            var vETERINAIRE = await _context.VETERINAIRE.FindAsync(id);
            if (vETERINAIRE == null)
            {
                return NotFound();
            }

            _context.VETERINAIRE.Remove(vETERINAIRE);
            await _context.SaveChangesAsync();

            return vETERINAIRE;
        }

        private bool VETERINAIREExists(int id)
        {
            return _context.VETERINAIRE.Any(e => e.IDVet == id);
        }
    }
}
