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
    public class OcorrenciasController : ControllerBase
    {
        private readonly DataContext _context;

        public OcorrenciasController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingle(int id)
        {
            try
            {
                Ocorrencia ocorrencia = await _context.Ocorrencias
                    .FirstOrDefaultAsync(Busca => Busca.Id_Ocorrencia == id);

                return Ok(ocorrencia);
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
                List<Ocorrencia> lista = await _context.Ocorrencias.ToListAsync();
                
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
                Ocorrencia rOcorrencia = await _context.Ocorrencias
                    .FirstOrDefaultAsync(delete => delete.Id_Ocorrencia == id);

                _context.Ocorrencias.Remove(rOcorrencia);
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