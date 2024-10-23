using API.Context;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;


[ApiController]
[Route("Controler")]
public class ContatoController : ControllerBase
{
    private readonly AgendaContext _context;
    
    public ContatoController(AgendaContext context)
    {
        _context = context;
    }
    
    [HttpPost("CriarContato")]
    public IActionResult Create(Contato contato)
    {
        _context.Add(contato);
        _context.SaveChanges();
        return Ok(contato);
    }
    
    [HttpGet("ObterContatosPorNome/{nome}")]
    public IActionResult ObterPorNome(string nome)
    {
        var contatos = _context.Contatos.Where(c => c.Nome == nome);
        return Ok(contatos);
    }
    
    [HttpGet("{id}")]
    public IActionResult ObterPorId(int id)
    {
        var contato = _context.Contatos.Find(id);

        if (contato == null)
        {
            return NotFound();
        }
        return Ok(contato);
    }
    
    [HttpPut("AtualizarContato/{id}")]
    public IActionResult AtualizarContato(int id, Contato contato)
    {
        var contatoBanco = _context.Contatos.Find(contato.Id);

        if (contatoBanco == null)
        {
            return NotFound();
        }
        contatoBanco.Nome = contato.Nome;
        contatoBanco.Telefone = contato.Telefone;
        contatoBanco.Ativo = contato.Ativo;
        
        _context.Contatos.Update(contatoBanco);
        _context.SaveChanges();
        
        return Ok(contatoBanco);
    }
    
    [HttpDelete("DeletarContato/{id}")]
    public IActionResult Deletar(int id)
    {
        var contatoBanco = _context.Contatos.Find(id);

        if (contatoBanco == null)
        {
            return NotFound();
        }
        
        _context.Contatos.Remove(contatoBanco);
        _context.SaveChanges();
        return NoContent();
    }
}