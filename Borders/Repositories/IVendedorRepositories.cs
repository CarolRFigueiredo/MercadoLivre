using Entidades;
using System.Collections.Generic;

namespace Borders.Repositories
{
    public interface IVendedorRepositories
    {
        public void Criar(Vendedor vendedor);
        public List<Vendedor> BuscarVendedores();
    }
}
