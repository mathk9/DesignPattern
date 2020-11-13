using DesignPatterns.Creator;
using DesignPatterns.Product;
using DesignPatterns.Concrete_Product;

namespace DesignPatterns.Concrete_Creator
{
    public class PlatinumFactory : CartaoFactory
    {
        private int limiteCredito;
        private int cobrancaAnual;

        public PlatinumFactory(int limiteCredito, int cobrancaAnual)
        {
            this.limiteCredito = limiteCredito;
            this.cobrancaAnual = cobrancaAnual;
        }

        public override CartaodeCredito BuscarCartaoCredito()
        {
            return new CartaoPlatinum(limiteCredito, cobrancaAnual);
        }
    }
}
