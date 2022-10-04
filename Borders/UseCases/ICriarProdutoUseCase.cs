using Entidades.MercadoLivre;
using System;

namespace Borders.UseCases
{
    public interface ICriarProdutoUseCase
    {
        public Guid Executar(Produtos produto);
    }
}
