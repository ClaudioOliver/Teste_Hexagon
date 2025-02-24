using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using Teste_Hexagon.Context;
using Teste_Hexagon.Model;

namespace Teste_Hexagon.Controllers
{
    [Route("api/pessoas")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly Teste_HexagonContext _context;
        public PessoaController(Teste_HexagonContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Pessoa>> GetPessoas(int page = 1, int pageSize = 10)
        {
            var pessoas = _context.Pessoas.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            return Ok(pessoas);
        }

        [HttpPost]
        public ActionResult<Pessoa> AddPessoa(Pessoa pessoa)
        {
            _context.Pessoas.Add(pessoa);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetPessoas), new { id = pessoa.Id }, pessoa);
        }

        [HttpPut("{id}")]
        public IActionResult UpdatePessoa(int id, Pessoa pessoa)
        {
            var existingPessoa = _context.Pessoas.Find(id);
            if (existingPessoa == null) return NotFound();
            existingPessoa.Nome = pessoa.Nome;
            existingPessoa.Idade = pessoa.Idade;
            existingPessoa.EstadoCivil = pessoa.EstadoCivil;
            existingPessoa.CPF = pessoa.CPF;
            existingPessoa.Cidade = pessoa.Cidade;
            existingPessoa.Estado = pessoa.Estado;
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePessoa(int id)
        {
            var pessoa = _context.Pessoas.Find(id);
            if (pessoa == null) return NotFound();
            _context.Pessoas.Remove(pessoa);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
