using Borders.Repositories;
using Borders.UseCases;
using Entidades;
using System;

namespace UseCases
{
    public class CriarVendedorUseCase : ICriarVendedorUseCase
    {
        private readonly IVendedorRepositories _vendedorRepositories;

        public CriarVendedorUseCase(IVendedorRepositories vendedorRepositories)
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
