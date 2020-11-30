using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model.Entidades;
using WebApplication1.Data;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetalleController : ControllerBase
    {
        private readonly DataContext _context;

        public DetalleController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Detalle>>> Get()
        {
            return await _context.Detalles.Include(i => i.Recurso).Include(i => i.Tarea).AsNoTracking().ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Detalle>> GetDetail(int id)
        {
            return await _context.Detalles.Where(i => i.id == id).AsNoTracking().SingleAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Detalle>> Post(Detalle valor)
        {
            if (valor.id == 0)
            {
                await _context.Detalles.AddAsync(valor);
            }
            else
            {
                _context.Entry(valor).State = EntityState.Modified;
                //_context.Detalles.Attach(valor);
                //_context.Detalles.Update(valor);
            }
            await _context.SaveChangesAsync();
            return valor;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var detail = _context.Detalles.Where(i => i.id == id).Single();

            _context.Detalles.Remove(detail);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
