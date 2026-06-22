using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SWAGAPI.Data;
using SWAGAPI.Models;

namespace SWAGAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly AppDbContext context;

        public ServiceController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetServices()
        {
            var services = await context.Services.OrderBy(s => s.serviceId).Take(20).ToListAsync();
            return Ok(services);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetService(int id)
        {
            var service = await context.Services.FindAsync(id);

            if (service == null)
            {
                return NotFound();
            }

            return Ok(service);
        }

        [HttpPost]
        public async Task<IActionResult> AddService(Service service)
        {
            context.Services.Add(service);
            await context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetService), new { id = service.serviceId }, service);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateService(int id, Service service)
        {
            if (id != service.serviceId)
            {
                return BadRequest();
            }

            context.Entry(service).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                var serviceExists = context.Services.Any(e => e.serviceId == id);

                if (!serviceExists)
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

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteService(int id)
        {
            var service = await context.Services.FindAsync(id);

            if (service == null)
            {
                return NotFound();
            }

            context.Services.Remove(service);
            await context.SaveChangesAsync();

            return NoContent();
        }
    }
}
