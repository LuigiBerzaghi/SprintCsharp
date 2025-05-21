using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sprint1CSharp.Data;
using Sprint1CSharp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sprint1CSharp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ClientesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/clientes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cliente>>> GetClientes([FromQuery] string? nome)
        {
            var query = _context.Clientes.Include(c => c.Veiculos).AsQueryable();

            if (!string.IsNullOrEmpty(nome))
                query = query.Where(c => c.Nome != null && c.Nome.Contains(nome));

            return Ok(await query.ToListAsync());
        }

        // GET: api/clientes/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Cliente>> GetCliente(int id)
        {
            var cliente = await _context.Clientes
                .Include(c => c.Veiculos)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (cliente == null)
                return NotFound();

            return Ok(cliente);
        }

        // GET: api/clientes/{id}/veiculos
        [HttpGet("{id}/veiculos")]
        public async Task<ActionResult<IEnumerable<Veiculo>>> GetVeiculosDoCliente(int id)
        {
            var cliente = await _context.Clientes
                .Include(c => c.Veiculos)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (cliente == null)
                return NotFound();

            return Ok(cliente.Veiculos);
        }

        // GET: api/clientes/email/{email}
        [HttpGet("email/{email}")]
        public async Task<ActionResult<Cliente>> GetClientePorEmail(string email)
        {
            var cliente = await _context.Clientes
                .Include(c => c.Veiculos)
                .FirstOrDefaultAsync(c => c.Email != null && c.Email.ToLower() == email.ToLower());

            if (cliente == null)
                return NotFound();

            return Ok(cliente);
        }

        // POST: api/clientes
        [HttpPost]
        public async Task<ActionResult<Cliente>> PostCliente(Cliente cliente)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _context.Clientes.Add(cliente);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCliente), new { id = cliente.Id }, cliente);
        }

        // PUT: api/clientes/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCliente(int id, Cliente cliente)
        {
            if (id != cliente.Id)
                return BadRequest("ID da URL diferente do corpo da requisição");

            _context.Entry(cliente).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Clientes.Any(e => e.Id == id))
                    return NotFound();
                else
                    throw;
            }

            return NoContent();
        }

        // DELETE: api/clientes/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCliente(int id)
        {
            var cliente = await _context.Clientes
                .Include(c => c.Veiculos)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (cliente == null)
                return NotFound();

            _context.Clientes.Remove(cliente);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
