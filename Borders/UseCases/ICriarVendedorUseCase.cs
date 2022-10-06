using Entidades;
using System;

namespace Borders.UseCases
{
    public interface ICriarVendedorUseCase
    {
        public Guid Executar(Vendedor vendedor);
    }
}
