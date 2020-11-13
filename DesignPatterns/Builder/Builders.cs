using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesignPatterns.Builder
{
    public partial class Builders : Form
    {
        public Builders()
        {
            InitializeComponent();
        }

        private void btnMontar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(448, 450);

            var director = new Director();
            var builder = new ConcreteBuilder();
            string aux = "";
            builder.BuildPartA();
            builder.BuildPartB();
            builder.BuildPartC();

            var decide = new EscreveStr();
            Product resultado = new Product();

            string str = decide.Texto(ckbA.Checked, ckbB.Checked, ckbC.Checked);
            picCarro.Image = imageList1.Images[resultado.EscolheImagem(str)];
                       
            
        }
    }
}
