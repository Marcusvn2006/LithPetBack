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
    public class FornecedorProdutosController : ControllerBase
    {
        private readonly MyContext _context;

        public FornecedorProdutosController(MyContext context)
        {
            _context = context;
        }

        // GET: api/FornecedorProdutos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FornecedorProduto>>> GetFornecedorProduto()
        {
            if (_context.FornecedorProduto == null)
            {
                return NotFound();
            }
            return await _context.FornecedorProduto.ToListAsync();
        }

        // GET: api/FornecedorProdutos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FornecedorProduto>> GetFornecedorProduto(int id)
        {
            if (_context.FornecedorProduto == null)
            {
                return NotFound();
            }
            var fornecedorProduto = await _context.FornecedorProduto.FindAsync(id);

            if (fornecedorProduto == null)
            {
                return NotFound();
            }

            return fornecedorProduto;
        }

        // PUT: api/FornecedorProdutos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFornecedorProduto(int id, FornecedorProduto fornecedorProduto)
        {
            if (id != fornecedorProduto.FornecedorProdutoId)
            {
                return BadRequest();
            }

            _context.Entry(fornecedorProduto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FornecedorProdutoExists(id))
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

        // POST: api/FornecedorProdutos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<FornecedorProduto>> PostFornecedorProduto(FornecedorProduto fornecedorProduto)
        {
            if (_context.FornecedorProduto == null)
            {
                return Problem("Favor cadastrar todos os campos");
            }
            _context.FornecedorProduto.Add(fornecedorProduto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFornecedorProduto", new { id = fornecedorProduto.FornecedorProdutoId }, fornecedorProduto);
        }

        // DELETE: api/FornecedorProdutos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFornecedorProduto(int id)
        {
            if (_context.FornecedorProduto == null)
            {
                return NotFound();
            }
            var fornecedorProduto = await _context.FornecedorProduto.FindAsync(id);
            if (fornecedorProduto == null)
            {
                return NotFound();
            }

            _context.FornecedorProduto.Remove(fornecedorProduto);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FornecedorProdutoExists(int id)
        {
            return (_context.FornecedorProduto?.Any(e => e.FornecedorProdutoId == id)).GetValueOrDefault();
        }
    }
}
