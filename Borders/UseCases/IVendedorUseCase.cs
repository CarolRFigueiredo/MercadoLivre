using Entidades;
using System;

namespace Borders.UseCases
{
    public interface IVendedorUseCase
    {
        public Guid Executar(Vendedor vendedor);
    }
}
