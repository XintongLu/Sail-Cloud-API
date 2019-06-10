using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BateauxController : ControllerBase
    {
        private readonly APIContext _context;

        public BateauxController(APIContext context)
        {
            _context = context;
        }

        // GET: api/Bateaux
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bateau>>> GetBateau()
        {
            return await _context.Bateau.ToListAsync();
        }

        // GET: api/Bateaux/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Bateau>> GetBateau(int id)
        {
            var bateau = await _context.Bateau.FindAsync(id);

            if (bateau == null)
            {
                return NotFound();
            }

            return bateau;
        }

        // PUT: api/Bateaux/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBateau(int id, Bateau bateau)
        {
            if (id != bateau.BateauId)
            {
                return BadRequest();
            }

            _context.Entry(bateau).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BateauExists(id))
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

        // POST: api/Bateaux
        [HttpPost]
        public async Task<ActionResult<Bateau>> PostBateau(Bateau bateau)
        {
            _context.Bateau.Add(bateau);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBateau", new { id = bateau.BateauId }, bateau);
        }

        // DELETE: api/Bateaux/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Bateau>> DeleteBateau(int id)
        {
            var bateau = await _context.Bateau.FindAsync(id);
            if (bateau == null)
            {
                return NotFound();
            }

            _context.Bateau.Remove(bateau);
            await _context.SaveChangesAsync();

            return bateau;
        }

        private bool BateauExists(int id)
        {
            return _context.Bateau.Any(e => e.BateauId == id);
        }

        [HttpGet("{id}/Liste_Position_Bateau")]
        public async Task<ActionResult<IEnumerable<Position_Bateau>>> GetPosition_bateau(int id)

        {
           
            return await _context.Position_bateau.Where(p => p.BateauId == id).ToListAsync();
        }
        //Get api/Positions/{id_bateau}/Bateaux


        [HttpGet("{id}/Derniere_Position_Bateau")]
        public async Task<ActionResult<Position_Bateau>> GetDerniereDatePosition_Bateau(int id)

        {
            return await _context.Position_bateau.Where(p => p.BateauId == id).OrderByDescending(p => p.t).FirstOrDefaultAsync();

        }


    }
}
