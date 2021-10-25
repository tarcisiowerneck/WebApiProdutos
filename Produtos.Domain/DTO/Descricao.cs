using System;

namespace WebApiProdutos.Domain.DTO
{
    public struct Descricao
    {
        private readonly string _value;

        private Descricao(string value)
        {
            _value = value;
            Validate();
        }

        public override string ToString() => _value;

        public static implicit operator Descricao(string value) => new Descricao(value);

        private bool Validate()
        {
            if (string.IsNullOrWhiteSpace(_value))
                throw new Exception("Descrição inválida");

            return true;
        }
    }
}
