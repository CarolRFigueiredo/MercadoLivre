using Borders.UseCases;
using Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VendedorController : ControllerBase
    {
        private readonly IVendedorUseCase _criarVendedorUseCase;
        private readonly IBuscarVendedoresUseCase _buscarVendedoresUseCase;

        public VendedorController(IVendedorUseCase criarVendedorUseCase, IBuscarVendedoresUseCase buscarVendedoresUseCase)
        {
            _criarVendedorUseCase = criarVendedorUseCase;
            _buscarVendedoresUseCase = buscarVendedoresUseCase;
        }

        [HttpPost]
        public Guid Post(Vendedor vendedor)
        {
            return _criarVendedorUseCase.Executar(vendedor);
        }

        [HttpGet]
        public List<Vendedor> BuscarVendedores()
        {
            return _buscarVendedoresUseCase.Executar();
        }
    }
}
