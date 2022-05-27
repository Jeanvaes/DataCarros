using DataCarros.Datos.Servicio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataCarros.Datos.Modelo;




namespace DataCarros.Controllers
{
    [Route("[controller]/[action]")]
    public class GarajeController : ControllerBase
    {
        private readonly RepositorioCarros _context;

        public GarajeController(RepositorioCarros context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> ConsultarGaraje()
        {
            return Ok(await _context.Garaje.ToListAsync());
        }



        [HttpPost]
        public async Task<IActionResult> AgregarGaraje(Garaje garaje)
        {
            _context.Garaje.Add(garaje);
            await _context.SaveChangesAsync();
            return Ok(garaje);
        }

        [HttpPut]
        public async Task<IActionResult> ActualizarGaraje(Garaje garaje)
        {
            _context.Update(garaje);
            await _context.SaveChangesAsync();
            return Ok(garaje);
        }

        [HttpDelete]
        public async Task<IActionResult> BorrarGaraje(Garaje garaje)
        {
            _context.Remove(garaje);
            await _context.SaveChangesAsync();
            return Ok();
        }



        //PROPIETARIO


    }
}
