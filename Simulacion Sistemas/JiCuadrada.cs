using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Simulacion_Sistemas
{
    public partial class JiCuadrada : Form
    {
        public static DataTable tablaJi;
        public static DataTable tablaResultado;
        public int recorrido=0;
        public double valmaxarry;
        public float promedio = 0;
        public double numk = 0;
        public double clases = 0;
        public double h = 0;
        public int[] array;
        public JiCuadrada()
        {
            InitializeComponent();
            initJi();
        }

        public void initJi(){
            tablaJi = new DataTable();
            tablaResultado = new DataTable();
            tablaJi.Columns.Add(new DataColumn("a", typeof(float)));
            tablaJi.Columns.Add(new DataColumn("b", typeof(float)));
            tablaJi.Columns.Add(new DataColumn("c", typeof(float)));
            tablaJi.Columns.Add(new DataColumn("d", typeof(float)));
            tablaJi.Columns.Add(new DataColumn("e", typeof(float)));
            tablaJi.Rows.Add(947, 872, 638, 666, 307);
            tablaJi.Rows.Add(082, 859, 140, 547, 585);
            tablaJi.Rows.Add(356, 132, 185, 467, 057);
            tablaJi.Rows.Add(248, 893, 116, 619, 231);
            tablaJi.Rows.Add(883, 748, 969, 302, 866);
            tablaResultado.Columns.Add(new DataColumn("K"));
            tablaResultado.Columns.Add(new DataColumn("Clase"));
            tablaResultado.Columns.Add(new DataColumn("FE"));
            tablaResultado.Columns.Add(new DataColumn("FO"));
            tablaResultado.Columns.Add(new DataColumn("(FE-FO)^2 /FE"));
            dtgridJiCuadrada.DataSource = tablaJi;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            array = new int[tablaJi.Rows.Count * tablaJi.Columns.Count];
            int cont = 0;
            for (int a = 0; a < tablaJi.Rows.Count; a++){
                for (int b = 0; b < tablaJi.Columns.Count; b++ ){
                    array[cont] = Convert.ToInt32(dtgridJiCuadrada[b, a].Value);
                    cont++;
                }
            }//end for
            Array.Sort(array);//ordena menor a mayor
            //Calcula recorrido
            recorrido = array[array.Length - 1] - array[0];
            valmaxarry = array[array.Length - 1];
            lblRecorrido.Text = ""+recorrido.ToString();
            //Calcula promedio            
            foreach (float dato in array){
                promedio += dato;
            }
            promedio /= array.Length;
            lblPromedio.Text = promedio.ToString();
            //Calcula k
            numk = Math.Round((1) + (3.22*Math.Log10(array.Length)));
            lblK.Text = numk.ToString();
            lblV.Text = (numk - 1).ToString();
            //Calcula clases
            clases = Math.Round(valmaxarry / numk, 1);
            lblClases.Text = clases.ToString();
            //Genera siguiente tabla 
            int i = 0;
            double t = 0;
            double p = clases;
            for ( i = 0; i < numk;i++){                
                double z = buscaValor(t,p) ;
                tablaResultado.Rows.Add(i+1, calculaRango(t,p),numk, z, calcula(z));
                t = p;
                p = p +clases;
            }
            dtGridResultado.DataSource = tablaResultado;
            
            for (i = 0; i < tablaResultado.Rows.Count; i++) {
                 h = h+ Convert.ToDouble(dtGridResultado[4, i].Value);                
            }
            lblxo.Text = h.ToString();
            tablaResultado.Rows.Add(null, null, null, null, h);
            dtGridResultado.DataSource = tablaResultado;
        }//end Click

        public double calcula(double s) {
            return Math.Round( Math.Pow(numk - s, 2) / numk,2);            
        }
        public String calculaRango(double a, double b){
            return a +" - "+ b;
        }

        public double buscaValor(double a, double b)
        {
            double count=0;
            for (int x = 0; x < array.Length; x++ )
            {
                if((a<=array[x]) && (array[x]<=b)){
                    count++;
                }
            }
            return count;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (h < Convert.ToDouble(txtChi.Text))
            {
                lblSentencia.Text = "No se rechaza la hipótesis de uniformidad";
            }else{
                lblSentencia.Text = "Se rechaza la hipótesis de uniformidad";
            }

        }
    }
}
