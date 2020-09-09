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
    public class categoriesController : ControllerBase
    {
        private readonly GestionFermeConetxt _context;

        public categoriesController(GestionFermeConetxt context)
        {
            _context = context;
        }

        // GET: api/categories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<categorie>>> Getcategorie()
        {
            return await _context.categorie.ToListAsync();
        }

        // GET: api/categories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<categorie>> Getcategorie(int id)
        {
            var categorie = await _context.categorie.FindAsync(id);

            if (categorie == null)
            {
                return NotFound();
            }

            return categorie;
        }

        // PUT: api/categories/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> Putcategorie(int id, categorie categorie)
        {
            if (id != categorie.categorieId)
            {
                return BadRequest();
            }

            _context.Entry(categorie).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!categorieExists(id))
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

        // POST: api/categories
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<categorie>> Postcategorie(categorie categorie)
        {
            _context.categorie.Add(categorie);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getcategorie", new { id = categorie.categorieId }, categorie);
        }

        // DELETE: api/categories/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<categorie>> Deletecategorie(int id)
        {
            var categorie = await _context.categorie.FindAsync(id);
            if (categorie == null)
            {
                return NotFound();
            }

            _context.categorie.Remove(categorie);
            await _context.SaveChangesAsync();

            return categorie;
        }

        private bool categorieExists(int id)
        {
            return _context.categorie.Any(e => e.categorieId == id);
        }
    }
}
