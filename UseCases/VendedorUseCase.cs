using Borders.Repositories;
using Borders.UseCases;
using Entidades;
using System;

namespace UseCases
{
    public class VendedorUseCase : IVendedorUseCase
    {
        private readonly IVendedorRepositories _vendedorRepositories;

        public VendedorUseCase(IVendedorRepositories vendedorRepositories)
        {
            _vendedorRepositories = vendedorRepositories;
        }

        public Guid Executar(Vendedor vendedor)
        {
            vendedor.StartVendedor();

            _vendedorRepositories.Criar(vendedor);

            return vendedor.Id;
        }
    }
}
