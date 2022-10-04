using Borders.Repositories;
using Borders.UseCases;
using Entidades;
using System.Collections.Generic;

namespace UseCases
{
    public class BuscarVendedoresUseCase : IBuscarVendedoresUseCase
    {
        private readonly IVendedorRepositories _vendedorRepositories;

        public BuscarVendedoresUseCase(IVendedorRepositories vendedorRepositories)
        {
            _vendedorRepositories = vendedorRepositories;
        }

        public List<Vendedor> Executar()
        {
            return _vendedorRepositories.BuscarVendedores();
        }
    }
}
