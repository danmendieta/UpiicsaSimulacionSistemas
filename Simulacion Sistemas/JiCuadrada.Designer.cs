namespace Simulacion_Sistemas
{
    partial class JiCuadrada
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgridJiCuadrada = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRecorrido = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblK = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblClases = new System.Windows.Forms.Label();
            this.dtGridResultado = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.lblxo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblV = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtChi = new System.Windows.Forms.TextBox();
            this.lblSentencia = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridJiCuadrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgridJiCuadrada
            // 
            this.dtgridJiCuadrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridJiCuadrada.Location = new System.Drawing.Point(12, 12);
            this.dtgridJiCuadrada.Name = "dtgridJiCuadrada";
            this.dtgridJiCuadrada.Size = new System.Drawing.Size(415, 153);
            this.dtgridJiCuadrada.TabIndex = 1;
            this.dtgridJiCuadrada.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaShell;
            this.button1.Location = new System.Drawing.Point(447, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Inicia";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(545, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Recorrido:";
            // 
            // lblRecorrido
            // 
            this.lblRecorrido.AutoSize = true;
            this.lblRecorrido.Location = new System.Drawing.Point(618, 40);
            this.lblRecorrido.Name = "lblRecorrido";
            this.lblRecorrido.Size = new System.Drawing.Size(22, 13);
            this.lblRecorrido.TabIndex = 4;
            this.lblRecorrido.Text = "0.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(545, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Promedio:";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(618, 68);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPromedio.Size = new System.Drawing.Size(22, 13);
            this.lblPromedio.TabIndex = 6;
            this.lblPromedio.Text = "0.0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(545, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "k:";
            // 
            // lblK
            // 
            this.lblK.AutoSize = true;
            this.lblK.Location = new System.Drawing.Point(618, 12);
            this.lblK.Name = "lblK";
            this.lblK.Size = new System.Drawing.Size(22, 13);
            this.lblK.TabIndex = 8;
            this.lblK.Text = "0.0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(545, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Clases:";
            // 
            // lblClases
            // 
            this.lblClases.AutoSize = true;
            this.lblClases.Location = new System.Drawing.Point(618, 95);
            this.lblClases.Name = "lblClases";
            this.lblClases.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblClases.Size = new System.Drawing.Size(22, 13);
            this.lblClases.TabIndex = 6;
            this.lblClases.Text = "0.0";
            // 
            // dtGridResultado
            // 
            this.dtGridResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridResultado.Location = new System.Drawing.Point(12, 191);
            this.dtGridResultado.Name = "dtGridResultado";
            this.dtGridResultado.Size = new System.Drawing.Size(415, 188);
            this.dtGridResultado.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(490, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Xo ^2   <   X^2";
            // 
            // lblxo
            // 
            this.lblxo.AutoSize = true;
            this.lblxo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblxo.Location = new System.Drawing.Point(509, 242);
            this.lblxo.Name = "lblxo";
            this.lblxo.Size = new System.Drawing.Size(31, 20);
            this.lblxo.TabIndex = 11;
            this.lblxo.Text = "0.0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(568, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "<";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(545, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "V:";
            // 
            // lblV
            // 
            this.lblV.AutoSize = true;
            this.lblV.Location = new System.Drawing.Point(618, 120);
            this.lblV.Name = "lblV";
            this.lblV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblV.Size = new System.Drawing.Size(22, 13);
            this.lblV.TabIndex = 6;
            this.lblV.Text = "0.0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(545, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "%:";
            // 
            // txtChi
            // 
            this.txtChi.Location = new System.Drawing.Point(598, 242);
            this.txtChi.Name = "txtChi";
            this.txtChi.Size = new System.Drawing.Size(42, 20);
            this.txtChi.TabIndex = 12;
            this.txtChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSentencia
            // 
            this.lblSentencia.AutoSize = true;
            this.lblSentencia.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSentencia.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSentencia.Location = new System.Drawing.Point(454, 312);
            this.lblSentencia.Name = "lblSentencia";
            this.lblSentencia.Size = new System.Drawing.Size(0, 16);
            this.lblSentencia.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Khaki;
            this.button2.Location = new System.Drawing.Point(548, 278);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Compara";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(618, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "?";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(602, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 5;
            this.label10.Text = "V + %";
            // 
            // JiCuadrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 391);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblSentencia);
            this.Controls.Add(this.txtChi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblxo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtGridResultado);
            this.Controls.Add(this.lblK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblV);
            this.Controls.Add(this.lblClases);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRecorrido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgridJiCuadrada);
            this.Name = "JiCuadrada";
            this.Text = "JiCuadrada";
            ((System.ComponentModel.ISupportInitialize)(this.dtgridJiCuadrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgridJiCuadrada;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRecorrido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblClases;
        private System.Windows.Forms.DataGridView dtGridResultado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblxo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtChi;
        private System.Windows.Forms.Label lblSentencia;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}