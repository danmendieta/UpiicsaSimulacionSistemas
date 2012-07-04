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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnColas_Click(object sender, EventArgs e)
        {
            Colas formColas = new Colas();
            formColas.Show();
        }

        private void btnJuguetes_Click(object sender, EventArgs e)
        {
            Juguetes formJuguete = new Juguetes();
            formJuguete.Show();
        }

        private void btnJiCuadrada_Click(object sender, EventArgs e)
        {
            JiCuadrada formJi = new JiCuadrada();
            formJi.Show();
        }
    }
}
