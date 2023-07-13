using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web_Api_CRUD.Models.Livraria;
using Web_Api_CRUD.Repository.Interfaces.Livraria;


namespace Web_Api_CRUD.Controllers
{
    [Route("api/[controller]")]
    public class LivroController : ControllerBase
    {
        private readonly ILivroRepository _livroRepositorio;

        public LivroController(ILivroRepository livroRepositorio)
        {
            _livroRepositorio = livroRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<Livro>>> ObterTodos()
        {
            
            return await _livroRepositorio.ObterTodos();
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<Livro>> ObterPorId(Guid id)
        {
            var livro = await _livroRepositorio.ObterPorId(id);

            if (livro == null) {
                return NotFound();
            }
            
            return livro;
        }

        [HttpGet("{localizacaoId:guid}")]
        public async Task<ActionResult<List<Livro>>> ObterPorLocalizacao(Guid localizacaoId)
        {
            var livroObtido = await _livroRepositorio.ObterPorLocalizacao(localizacaoId);

            if (livroObtido == null)
            {
                return NotFound();
            }

            return livroObtido;
        }

        [HttpPost]
        public async Task<ActionResult<Livro>> Adicionar(Livro livro)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            await _livroRepositorio.Adicionar(livro);
            
            return livro;
        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult<Livro>> Atualizar(Guid id, Livro livro)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            if(id != livro.Id) return BadRequest();

            try 
            {
                await _livroRepositorio.Atualizar(livro);
            }
            catch(DbUpdateConcurrencyException)
            {
                return BadRequest("Erro ao atualizar Livro!");
            }
    
            return livro;
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<Livro>> Excluir(Guid id)
        {
            var livro = await _livroRepositorio.ObterPorId(id);
            
            if (livro != null) 
            {
                return BadRequest("Id não encontrado!");
            }
            else {
                await _livroRepositorio.Remover(livro);
            }

            return livro;
        }



    }
}