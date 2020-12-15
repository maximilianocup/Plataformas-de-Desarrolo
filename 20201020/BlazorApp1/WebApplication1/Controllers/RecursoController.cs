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
    public class RecursoController : ControllerBase
    {
        private readonly DataContext _context;

        public RecursoController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Recurso>>> Get()
        {
            return await _context.Recursos.Include(i => i.Usuario).AsNoTracking().ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Recurso>> GetResource(int id)
        {
            return await _context.Recursos.Where(i => i.id == id).AsNoTracking().SingleAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Recurso>> Post(Recurso valor)
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

        public async Task<IActionResult> Delete(int id)
        {
            var resource = await _context.Recursos.Where(i => i.id == id).SingleAsync();

            _context.Recursos.Remove(resource);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}
    
