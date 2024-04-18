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
    public class ServicosController : ControllerBase
    {
        private readonly MyContext _context;

        public ServicosController(MyContext context)
        {
            _context = context;
        }

        // GET: api/Servicos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Servicos>>> GetServicos()
        {
            if (_context.Servicos == null)
            {
                return NotFound();
            }
            return await _context.Servicos.ToListAsync();
        }

        // GET: api/Servicos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Servicos>> GetServicos(int id)
        {
            if (_context.Servicos == null)
            {
                return NotFound();
            }
            var servicos = await _context.Servicos.FindAsync(id);

            if (servicos == null)
            {
                return NotFound();
            }

            return servicos;
        }

        // PUT: api/Servicos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutServicos(int id, Servicos servicos)
        {
            if (id != servicos.ServicosId)
            {
                return BadRequest();
            }

            _context.Entry(servicos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ServicosExists(id))
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

        // POST: api/Servicos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Servicos>> PostServicos(Servicos servicos)
        {
            if (_context.Servicos == null)
            {
                return Problem("Favor cadastrar todos os campos");
            }
            _context.Servicos.Add(servicos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetServicos", new { id = servicos.ServicosId }, servicos);
        }

        // DELETE: api/Servicos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteServicos(int id)
        {
            if (_context.Servicos == null)
            {
                return NotFound();
            }
            var servicos = await _context.Servicos.FindAsync(id);
            if (servicos == null)
            {
                return NotFound();
            }

            _context.Servicos.Remove(servicos);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ServicosExists(int id)
        {
            return (_context.Servicos?.Any(e => e.ServicosId == id)).GetValueOrDefault();
        }
    }
}
