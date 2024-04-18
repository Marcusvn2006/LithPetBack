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
    public class DetalhesVendasController : ControllerBase
    {
        private readonly MyContext _context;

        public DetalhesVendasController(MyContext context)
        {
            _context = context;
        }

        // GET: api/DetalhesVendas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DetalhesVenda>>> GetDetalhesVenda()
        {
            if (_context.DetalhesVenda == null)
            {
                return NotFound();
            }
            return await _context.DetalhesVenda.ToListAsync();
        }

        // GET: api/DetalhesVendas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DetalhesVenda>> GetDetalhesVenda(int id)
        {
            if (_context.DetalhesVenda == null)
            {
                return NotFound();
            }
            var detalhesVenda = await _context.DetalhesVenda.FindAsync(id);

            if (detalhesVenda == null)
            {
                return NotFound();
            }

            return detalhesVenda;
        }

        // PUT: api/DetalhesVendas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDetalhesVenda(int id, DetalhesVenda detalhesVenda)
        {
            if (id != detalhesVenda.DetalhesVendaId)
            {
                return BadRequest();
            }

            _context.Entry(detalhesVenda).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DetalhesVendaExists(id))
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

        // POST: api/DetalhesVendas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("api/DetalhesVendas")]
        public async Task<ActionResult<DetalhesVenda>> PostDetalhesVenda(DetalhesVenda detalhesVenda)
        {
            if (_context.DetalhesVenda == null)
            {
                return Problem("Favor cadastrar todos os campos");
            }

            if (detalhesVenda.Quantidade < 0)
            {
                return BadRequest("A Quantidade de produtos não pode ser negativo!");
            }

            if (detalhesVenda.PrecoUnitario < 0)
            {
                return BadRequest("O Preço unitário do produto não pode ser negativo!");
            }

            _context.DetalhesVenda.Add(detalhesVenda);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDetalhesVenda", new { id = detalhesVenda.DetalhesVendaId }, detalhesVenda);
        }

        // DELETE: api/DetalhesVendas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDetalhesVenda(int id)
        {
            if (_context.DetalhesVenda == null)
            {
                return NotFound();
            }
            var detalhesVenda = await _context.DetalhesVenda.FindAsync(id);
            if (detalhesVenda == null)
            {
                return NotFound();
            }

            _context.DetalhesVenda.Remove(detalhesVenda);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DetalhesVendaExists(int id)
        {
            return (_context.DetalhesVenda?.Any(e => e.DetalhesVendaId == id)).GetValueOrDefault();
        }
    }
}
