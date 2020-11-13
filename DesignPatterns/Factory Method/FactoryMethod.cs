using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DesignPatterns.Concrete_Creator;
using DesignPatterns.Concrete_Product;
using DesignPatterns.Creator;
using DesignPatterns.Product;

namespace DesignPatterns
{
    public partial class FactoryMethod : Form
    {
        public FactoryMethod()
        {
            InitializeComponent();
        }

        private void btnOpcao_Click(object sender, EventArgs e)
        {
            CartaoFactory cartaoFactory = null;

            switch (cmbOpcoes.Text.ToLower())
            {
                case "black":
                    cartaoFactory = new BlackFactory(50000, 0);
                    break;
                case "titanium":
                    cartaoFactory = new TitaniumFactory(100000, 500);
                    break;
                case "platinum":
                    cartaoFactory = new PlatinumFactory(500000, 1000);
                    break;
            }

            CartaodeCredito cartaoCredito = cartaoFactory.BuscarCartaoCredito();
            textBox1.Text = cartaoCredito.LimiteCredito.ToString();
            textBox2.Text = cartaoCredito.CobrancaAnual.ToString();
        }
    }
}
