using Microsoft.AspNetCore.Mvc;

namespace api_consulta_viagens.Controllers;


[ApiController]
[Route("api/[controller]")]
public class MotoristaController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public MotoristaController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetMetas()
    {
        var metas = _context.Motorista.Take(10).ToList();
        return Ok(metas);
    }

    [HttpPost]
    public IActionResult CriarMotorista([FromBody] Motorista motorista)
    {
        _context.Motorista.Add(motorista);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetMetas), new { id = motorista.Id }, motorista);
    }
      [HttpPut("{id}")]
    public IActionResult AtualizarMotorista(int id, [FromBody] Motorista motoristaAtualizado)
    {
        var motoristaExistente = _context.Motorista.FirstOrDefault(m => m.Id == id);

        if (motoristaExistente == null)
        {
            return NotFound();
        }

        motoristaExistente.COD_GEMOT = motoristaAtualizado.COD_GEMOT;
        motoristaExistente.NOME = motoristaAtualizado.NOME;
        motoristaExistente.MATRICULA = motoristaAtualizado.MATRICULA;
        motoristaExistente.CPF = motoristaAtualizado.CPF;

        _context.SaveChanges();

        return NoContent();
    }   
}
