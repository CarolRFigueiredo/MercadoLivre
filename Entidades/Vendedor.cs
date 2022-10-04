using System;

namespace Entidades
{
    public class Vendedor
    {
        public string Nome { get; set; }
        public Guid Id { get; private set; }
        public bool Ativo { get; private set; }

        public void StartVendedor()
        {
            Id = Guid.NewGuid();
            Ativo = true;
        }
    }
}
