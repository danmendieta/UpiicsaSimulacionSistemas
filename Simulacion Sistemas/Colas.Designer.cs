namespace Simulacion_Sistemas
{
    partial class Colas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTasa = new System.Windows.Forms.TextBox();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFactor = new System.Windows.Forms.TextBox();
            this.txtPromedioCola = new System.Windows.Forms.TextBox();
            this.txtPromedioSistema = new System.Windows.Forms.TextBox();
            this.txtTiempoEsperaCola = new System.Windows.Forms.TextBox();
            this.txtTiempoEsperaSistema = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "µ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ƛ";
            // 
            // txtTasa
            // 
            this.txtTasa.BackColor = System.Drawing.SystemColors.Info;
            this.txtTasa.Location = new System.Drawing.Point(72, 22);
            this.txtTasa.Name = "txtTasa";
            this.txtTasa.Size = new System.Drawing.Size(100, 20);
            this.txtTasa.TabIndex = 2;
            this.txtTasa.Text = "15";
            this.txtTasa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMedia
            // 
            this.txtMedia.BackColor = System.Drawing.SystemColors.Info;
            this.txtMedia.Location = new System.Drawing.Point(72, 48);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(100, 20);
            this.txtMedia.TabIndex = 2;
            this.txtMedia.Text = "10";
            this.txtMedia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(212, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 55);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calcular Colas de Población Infinita";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Factor de utilización:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "El número promedio de los clientes en la cola:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "El número promedio de los clientes en el sistema:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "El tiempo esperado en la cola:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "El tiempo promedio en el sistema:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(35, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 23);
            this.label8.TabIndex = 5;
            this.label8.Text = "p=    ƛ / µ         =";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(35, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 23);
            this.label9.TabIndex = 5;
            this.label9.Text = "L .=    ƛ ^2 / µ(µ-ƛ)         =";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(35, 246);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 23);
            this.label10.TabIndex = 5;
            this.label10.Text = "L =    ƛ / µ-ƛ         =";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(35, 318);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(178, 23);
            this.label11.TabIndex = 5;
            this.label11.Text = "W.=    ƛ  / µ(µ-ƛ)         =";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(35, 385);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 23);
            this.label12.TabIndex = 5;
            this.label12.Text = "W =    1 / µ-ƛ         =";
            // 
            // txtFactor
            // 
            this.txtFactor.BackColor = System.Drawing.Color.SeaShell;
            this.txtFactor.Location = new System.Drawing.Point(257, 126);
            this.txtFactor.Name = "txtFactor";
            this.txtFactor.Size = new System.Drawing.Size(100, 20);
            this.txtFactor.TabIndex = 6;
            // 
            // txtPromedioCola
            // 
            this.txtPromedioCola.BackColor = System.Drawing.Color.SeaShell;
            this.txtPromedioCola.Location = new System.Drawing.Point(257, 185);
            this.txtPromedioCola.Name = "txtPromedioCola";
            this.txtPromedioCola.Size = new System.Drawing.Size(100, 20);
            this.txtPromedioCola.TabIndex = 6;
            // 
            // txtPromedioSistema
            // 
            this.txtPromedioSistema.BackColor = System.Drawing.Color.SeaShell;
            this.txtPromedioSistema.Location = new System.Drawing.Point(257, 246);
            this.txtPromedioSistema.Name = "txtPromedioSistema";
            this.txtPromedioSistema.Size = new System.Drawing.Size(100, 20);
            this.txtPromedioSistema.TabIndex = 6;
            // 
            // txtTiempoEsperaCola
            // 
            this.txtTiempoEsperaCola.BackColor = System.Drawing.Color.SeaShell;
            this.txtTiempoEsperaCola.Location = new System.Drawing.Point(257, 321);
            this.txtTiempoEsperaCola.Name = "txtTiempoEsperaCola";
            this.txtTiempoEsperaCola.Size = new System.Drawing.Size(100, 20);
            this.txtTiempoEsperaCola.TabIndex = 6;
            // 
            // txtTiempoEsperaSistema
            // 
            this.txtTiempoEsperaSistema.BackColor = System.Drawing.Color.SeaShell;
            this.txtTiempoEsperaSistema.Location = new System.Drawing.Point(257, 385);
            this.txtTiempoEsperaSistema.Name = "txtTiempoEsperaSistema";
            this.txtTiempoEsperaSistema.Size = new System.Drawing.Size(100, 20);
            this.txtTiempoEsperaSistema.TabIndex = 6;
            // 
            // Colas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(369, 439);
            this.Controls.Add(this.txtTiempoEsperaSistema);
            this.Controls.Add(this.txtTiempoEsperaCola);
            this.Controls.Add(this.txtPromedioSistema);
            this.Controls.Add(this.txtPromedioCola);
            this.Controls.Add(this.txtFactor);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.txtTasa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Colas";
            this.Text = "Colas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTasa;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtFactor;
        private System.Windows.Forms.TextBox txtPromedioCola;
        private System.Windows.Forms.TextBox txtPromedioSistema;
        private System.Windows.Forms.TextBox txtTiempoEsperaCola;
        private System.Windows.Forms.TextBox txtTiempoEsperaSistema;

    }
}