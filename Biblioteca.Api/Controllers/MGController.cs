#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Biblioteca.Api.Data;
using Biblioteca.Api.Modelo;

namespace Biblioteca.Api.Controllers
{
    [Route("[controller]/[action]")]
    public class MGController : ControllerBase
    {
        private readonly BibliotecaApiContext _context;


        public MGController(BibliotecaApiContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> ConsultaMG()
        {
            return Ok(await _context.MG.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> AgregarMG(MG mg)
        {
            _context.MG.Add(mg);
            await _context.SaveChangesAsync();
            return Ok(mg);
        }
        [HttpPut]
        public async Task<IActionResult> ActualizarMG(MG mg)
        {
            _context.Update(mg);
            await _context.SaveChangesAsync();
            return Ok(mg);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteMG(MG mg)
        {
            _context.Remove(mg);
            await _context.SaveChangesAsync();
            return Ok(mg);
        }

       
        
    }
}
