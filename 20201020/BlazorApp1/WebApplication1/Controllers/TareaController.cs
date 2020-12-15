using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TareaController : ControllerBase
    {
        private readonly DataContext _context;

        public TareaController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tarea>>> Get()
        {
            return await _context.Tareas.Include(i => i.Responsable).AsNoTracking().ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Tarea>> GetTask(int id)
        {
            return await _context.Tareas.Where(i => i.id == id).AsNoTracking().SingleAsync();
        }

        

        [HttpPost]
        public async Task<ActionResult<Tarea>> Post(Tarea valor)
        {
            if (valor.id == 0)
            {
                _context.Entry(valor).State = EntityState.Added;
            }
            else
            {
                _context.Entry(valor).State = EntityState.Modified;
            }


            await _context.SaveChangesAsync();
            return valor;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var task = _context.Tareas.Where(i => i.id == id).Single();

            _context.Tareas.Remove(task);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
