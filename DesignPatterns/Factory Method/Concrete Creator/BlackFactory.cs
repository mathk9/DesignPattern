using DesignPatterns.Creator;
using DesignPatterns.Product;
using DesignPatterns.Concrete_Product;


namespace DesignPatterns.Concrete_Creator
{
    public class BlackFactory : CartaoFactory
    {
        private int limiteCredito;
        private int cobrancaAnual;

        public BlackFactory(int limiteCredito, int cobrancaAnual)
        {
            this.limiteCredito = limiteCredito;
            this.cobrancaAnual = cobrancaAnual;
        }

        public override CartaodeCredito BuscarCartaoCredito()
        {
            return new CartaoBlack(limiteCredito, cobrancaAnual);
        }
    }
}
