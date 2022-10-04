using Entidades;
using System.Collections.Generic;

namespace Borders.UseCases
{
    public interface IBuscarVendedoresUseCase
    {
        public List<Vendedor> Executar();
    }
}
