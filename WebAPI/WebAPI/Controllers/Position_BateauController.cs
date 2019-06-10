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
    public class Position_BateauController : ControllerBase
    {
        private readonly APIContext _context;

        public Position_BateauController(APIContext context)
        {
            _context = context;
        }

        // GET: api/Position_Bateau
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Position_Bateau>>> GetPosition_bateau()
        {
            return await _context.Position_bateau.ToListAsync();
        }
/*
        // GET: api/Position_Bateau/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Position_Bateau>> GetPosition_Bateau(int id)
        {
            var position_Bateau = await _context.Position_bateau.FindAsync(id);

            if (position_Bateau == null)
            {
                return NotFound();
            }

            return position_Bateau;
        }

        // PUT: api/Position_Bateau/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPosition_Bateau(int id, Position_Bateau position_Bateau)
        {
            if (id != position_Bateau.Position_BateauId)
            {
                return BadRequest();
            }

            _context.Entry(position_Bateau).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Position_BateauExists(id))
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
*/
        // POST: api/Position_Bateau
        [HttpPost]
        public async Task<ActionResult<Position_Bateau>> PostPosition_Bateau(Position_Bateau position_Bateau)
        {
            _context.Position_bateau.Add(position_Bateau);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPosition_Bateau", new { id = position_Bateau.Position_BateauId }, position_Bateau);
        }

        // DELETE: api/Position_Bateau/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Position_Bateau>> DeletePosition_Bateau(int id)
        {
            var position_Bateau = await _context.Position_bateau.FindAsync(id);
            if (position_Bateau == null)
            {
                return NotFound();
            }

            _context.Position_bateau.Remove(position_Bateau);
            await _context.SaveChangesAsync();

            return position_Bateau;
        }

        private bool Position_BateauExists(int id)
        {
            return _context.Position_bateau.Any(e => e.Position_BateauId == id);
        }
    }
}
