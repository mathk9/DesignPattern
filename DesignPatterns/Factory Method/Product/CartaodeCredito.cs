namespace DesignPatterns.Product
{
    public abstract class CartaodeCredito
    {
        public abstract string TipoCartao { get; }
        public abstract int LimiteCredito { get; set; }
        public abstract int CobrancaAnual { get; set; }
    }
}
