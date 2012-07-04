using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Simulacion_Sistemas
{
    public partial class Colas : Form
    {
        public Colas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Factor de utilización
            double tasa=Convert.ToDouble(txtTasa.Text) ;
            double media=Convert.ToDouble(txtMedia.Text); 
            double a = Math.Abs(tasa/media);

            txtFactor.Text = a.ToString();
            //Promedio cola
            double b = Math.Abs(Math.Pow(tasa,2) / (media * (media-tasa)));
            txtPromedioCola.Text = b.ToString();
            //Promedio sistema
            double c = Math.Abs(tasa / (media - tasa));
            txtPromedioSistema.Text = c.ToString();
            //Tiempo espera Cola
            double d = Math.Abs(tasa / (media * (media - tasa)));
            txtTiempoEsperaCola.Text = d.ToString();
            //Tiempo espera Sistema
            double f =Math.Abs( 1 / (media - tasa));
            txtTiempoEsperaSistema.Text = f.ToString();
        }

    }
}
