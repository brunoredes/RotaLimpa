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
    public class RuasController : ControllerBase
    {
        private readonly DataContext _context;

        public RuasController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingle(int id)
        {
            try
            {
                Rua rua = await _context.Ruas
                    .FirstOrDefaultAsync(Busca => Busca.Id_Ruas == id);

                return Ok(rua);
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
                List<Rua> lista = await _context.Ruas.ToListAsync();
                
                return Ok(lista);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("RegistrarRua")]
         public async Task<IActionResult> RegistrarRuaAsync([FromBody] Rua rua)
        {
            try
            {
                // Aqui você pode adicionar lógica para salvar a rua no seu banco de dados.
                // Você pode usar Entity Framework Core ou qualquer outra tecnologia de acesso a dados.
                
                // Exemplo de lógica de salvamento fictícia:
                // _dbContext.Ruas.Add(rua);
                // await _dbContext.SaveChangesAsync();

                await _context.Ruas.AddAsync(rua);
                await _context.SaveChangesAsync();

                // Retorna um sucesso HTTP 201 (Created) com a rua criada.
                return CreatedAtAction(nameof(ObterRuaPorId), new { id = rua.Id }, rua);
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
                Rua rRua = await _context.Ruas
                    .FirstOrDefaultAsync(delete => delete.Id_Rota == id);

                _context.Ruas.Remove(rRua);
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