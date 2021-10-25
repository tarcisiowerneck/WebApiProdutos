using System;
using WebApiProdutos.Domain.Enums;
using WebApiProdutos.Shared.Extensions;

namespace WebApiProdutos.Domain.DTO
{
    public struct Tipo
    {
        private readonly TipoProdutos _value;

        private Tipo(TipoProdutos value)
        {
            _value = value;
            Validate((int)value);
        }

        public override string ToString() => _value.ToDescription();
        public int ToInt() => (int)_value;
        public TipoProdutos ToEnum() => _value;

        public static implicit operator Tipo(TipoProdutos value) => new Tipo(value);
        public static implicit operator Tipo(int value) => new Tipo((TipoProdutos)value);
        public static implicit operator int(Tipo value) => value.ToInt();
        public static implicit operator TipoProdutos(Tipo value) => value.ToEnum();

        private bool Validate(int value)
        {
            if (!Enum.IsDefined(typeof(TipoProdutos), value))
                throw new Exception("Tipo inválido");

            return true;
        }
    }
}
