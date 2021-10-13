using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DatoApi.Data;
using DatoApi.Models;

namespace DatoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DatosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public DatosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Datos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Dato>>> GetDatos()
        {
            return await _context.Datos.ToListAsync();
        }

        // GET: api/Datos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Dato>> GetDato(string id)
        {
            var dato = await _context.Datos.FindAsync(id);

            if (dato == null)
            {
                return NotFound();
            }

            return dato;
        }

        // PUT: api/Datos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDato(string id, Dato dato)
        {
            if (id != dato.Nombre)
            {
                return BadRequest();
            }

            _context.Entry(dato).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DatoExists(id))
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

        // POST: api/Datos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Dato>> PostDato(Dato dato)
        {
            _context.Datos.Add(dato);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (DatoExists(dato.Nombre))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetDato", new { id = dato.Nombre }, dato);
        }

        // DELETE: api/Datos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDato(string id)
        {
            var dato = await _context.Datos.FindAsync(id);
            if (dato == null)
            {
                return NotFound();
            }

            _context.Datos.Remove(dato);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DatoExists(string id)
        {
            return _context.Datos.Any(e => e.Nombre == id);
        }
    }
}
