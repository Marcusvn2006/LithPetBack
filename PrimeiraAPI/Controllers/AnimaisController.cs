using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PrimeiraAPI.Data;
using PrimeiraAPI.Models;

namespace PrimeiraAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimaisController : ControllerBase
    {
        private readonly MyContext _context;

        public AnimaisController(MyContext context)
        {
            _context = context;
        }

        // GET: api/Animais
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Animais>>> GetAnimais()
        {
            if (_context.Animais == null)
            {
                return NotFound();
            }
            return await _context.Animais.ToListAsync();
        }

        // GET: api/Animais/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Animais>> GetAnimais(int id)
        {
            if (_context.Animais == null)
            {
                return NotFound();
            }
            var animais = await _context.Animais.FindAsync(id);

            if (animais == null)
            {
                return NotFound();
            }

            return animais;
        }

        // PUT: api/Animais/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAnimais(int id, Animais animais)
        {
            if (id != animais.AnimaisId)
            {
                return BadRequest();
            }

            _context.Entry(animais).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AnimaisExists(id))
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

        // POST: api/Animais
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Animais>> PostAnimais(Animais animais)
        {
            if (_context.Animais == null)
            {
                return Problem("Favor cadastrar todos os campos");
            }

            if (animais.AnimaisIdade < 0)
            {
                return BadRequest("A idade do animal não pode ser negativa!");
            }

            _context.Animais.Add(animais);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAnimais", new { id = animais.AnimaisId }, animais);
        }

        // DELETE: api/Animais/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAnimais(int id)
        {
            if (_context.Animais == null)
            {
                return NotFound();
            }
            var animais = await _context.Animais.FindAsync(id);
            if (animais == null)
            {
                return NotFound();
            }

            _context.Animais.Remove(animais);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AnimaisExists(int id)
        {
            return (_context.Animais?.Any(e => e.AnimaisId == id)).GetValueOrDefault();
        }
    }
}
