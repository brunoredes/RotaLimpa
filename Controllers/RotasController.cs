using Microsoft.AspNetCore.Mvc;
using RotaLimpa.Api.Data;
using RotaLimpa.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace RotaLimpa.Api.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("[Controller]")]
    public class RotasController : ControllerBase
    {
        private readonly DataContext _context;

        public RotasController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingle(int id)
        {
            try
            {
                Rota rota = await _context.Rotas
                    .FirstOrDefaultAsync(Busca => Busca.Id_Rota == id);

                return Ok(rota);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAsync()
        {
            try
            {
                List<Rota> lista = await _context.Rotas.ToListAsync();
                
                return Ok(lista);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                Rota rRota = await _context.Rotas
                    .FirstOrDefaultAsync(delete => delete.Id_Rota == id);

                _context.Rotas.Remove(rRota);
                int linhaAfetadas = await _context.SaveChangesAsync();

                //Criar regra de negócio para lidar com o OK

                return Ok(linhaAfetadas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}