using Borders.Repositories;
using Borders.UseCases;
using Entidades.MercadoLivre;
using System;

namespace UseCases
{
    public class CriarProdutoUseCase : ICriarProdutoUseCase
    {
        private readonly IProdutosRepositories _produtosRepositories;

        public CriarProdutoUseCase(IProdutosRepositories produtosRepositories) 
        {
            _produtosRepositories = produtosRepositories;
        }

        public Guid Executar(Produtos produto)
        {
            _produtosRepositories.Criar(produto);

            return Guid.NewGuid();
        }
    }
}
