using Borders.Repositories;
using Entidades;
using System.Collections.Generic;

namespace Repositories
{
    public class VendedorRepositories : IVendedorRepositories
    {
        private readonly List<Vendedor> _vendedores;

        public VendedorRepositories()
        {
            _vendedores = new List<Vendedor>();  
        }

        public List<Vendedor> BuscarVendedores()
        {
            return _vendedores;
        }

        public void Criar(Vendedor vendedor)
        {
            _vendedores.Add(vendedor);
        }
    }
}
