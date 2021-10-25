using System.ComponentModel;

namespace WebApiProdutos.Domain.Enums
{
    public enum TipoProdutos : int
    {
        [Description("Alimento")]
        Alimento = 1,
        [Description("Limpeza")]
        Limpeza = 2,
        [Description("Eletrodoméstico")]
        Eletrodomestico = 3,
        [Description("Outros")]
        Outros = 4,
    }
}
