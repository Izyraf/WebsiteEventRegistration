using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebsiteEventRegistration.Server.Data;
using WebsiteEventRegistration.Shared.Domain;

namespace WebsiteEventRegistration.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HostsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public HostsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Hosts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Host>>> GetHost()
        {
            return await _context.Host.ToListAsync();
        }

        // GET: api/Hosts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Host>> GetHost(int id)
        {
            var host = await _context.Host.FindAsync(id);

            if (host == null)
            {
                return NotFound();
            }

            return host;
        }

        // PUT: api/Hosts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHost(int id, Host host)
        {
            if (id != host.ID)
            {
                return BadRequest();
            }

            _context.Entry(host).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HostExists(id))
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

        // POST: api/Hosts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Host>> PostHost(Host host)
        {
            _context.Host.Add(host);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHost", new { id = host.ID }, host);
        }

        // DELETE: api/Hosts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHost(int id)
        {
            var host = await _context.Host.FindAsync(id);
            if (host == null)
            {
                return NotFound();
            }

            _context.Host.Remove(host);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HostExists(int id)
        {
            return _context.Host.Any(e => e.ID == id);
        }
    }
}
