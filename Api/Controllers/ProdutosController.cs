using Borders.UseCases;
using Entidades.MercadoLivre;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutosController : ControllerBase
    {
        private readonly ICriarProdutoUseCase _criarProdutoUseCase;

        public ProdutosController(ICriarProdutoUseCase criarProdutoUseCase)
        {
            _criarProdutoUseCase = criarProdutoUseCase;
        }

        [HttpPost]
        public Guid Post(Produtos produto)
        {
            return _criarProdutoUseCase.Executar(produto);
        }

        [HttpGet("{Id}")]
        public Produtos Get(Guid Id)
        {
            return new Produtos();
        }

        [HttpDelete("{Id}")]
        public Produtos Delete(Guid Id)
        {
            return new Produtos();
        }

        [HttpPut("{Id}")]
        public Produtos Delete(Guid Id, Produtos produto)
        {
            return new Produtos();
        }

        [HttpPatch("{Id}")]
        public Produtos Delete(Guid Id, string nomeNovo)
        {
            return new Produtos();
        }
    }
}
