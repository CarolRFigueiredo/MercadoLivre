using System;

namespace Entidades
{
    namespace MercadoLivre
    {
        public class Produtos
        {
            public Guid Id { get; private set; }
            public string Nome { get; set; }
            public string Marca { get; set; }
            public decimal Valor { get; set; }
        }
    }

}
