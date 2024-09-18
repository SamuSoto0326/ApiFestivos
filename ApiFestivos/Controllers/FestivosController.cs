using ApiFestivos.Data;
using ApiFestivos.Modelos; 
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiFestivos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FestivosController : ControllerBase
    {
        private readonly FestivosDbContext _context;

        public FestivosController(FestivosDbContext context)
        {
            _context = context;
        }

        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Festivo>>> GetFestivos()
        {
            return await _context.Festivos.ToListAsync();
        }

       
        [HttpGet("{id}")]
        public async Task<ActionResult<Festivo>> GetFestivo(int id)
        {
            var festivo = await _context.Festivos.FindAsync(id);

            if (festivo == null)
            {
                return NotFound();
            }

            return festivo;
        }

        
        [HttpPost]
        public async Task<ActionResult<Festivo>> PostFestivo(Festivo festivo)
        {
            _context.Festivos.Add(festivo);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetFestivo), new { id = festivo.Id }, festivo);
        }

        
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFestivo(int id, Festivo festivo)
        {
            if (id != festivo.Id)
            {
                return BadRequest();
            }

            _context.Entry(festivo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FestivoExists(id))
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
        public async Task<IActionResult> DeleteFestivo(int id)
        {
            var festivo = await _context.Festivos.FindAsync(id);
            if (festivo == null)
            {
                return NotFound();
            }

            _context.Festivos.Remove(festivo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FestivoExists(int id)
        {
            return _context.Festivos.Any(e => e.Id == id);
        }
    }
}

