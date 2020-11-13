using DesignPatterns.Product;

namespace DesignPatterns.Concrete_Product
{
    public class CartaoTitanium : CartaodeCredito
    {
        private readonly string tipoCartao;
        private int limiteCredito;
        private int cobrancaAnual;

        public CartaoTitanium(int limiteCredito, int cobrancaAnual)
        {
            this.tipoCartao = "Titanium";
            this.limiteCredito = limiteCredito;
            this.cobrancaAnual = cobrancaAnual;
        }



        public override string TipoCartao
        {
            get { return tipoCartao; }
        }

        public override int LimiteCredito
        {
            get
            {
                return limiteCredito;
            }
            set
            {
                limiteCredito = value;
            }
        }

        public override int CobrancaAnual
        {
            get
            {
                return cobrancaAnual;
            }
            set
            {
                cobrancaAnual = value;
            }
        }
    }
}