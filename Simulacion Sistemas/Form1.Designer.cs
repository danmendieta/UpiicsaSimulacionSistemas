namespace Simulacion_Sistemas
{
    partial class Form1
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
            this.btnJiCuadrada = new System.Windows.Forms.Button();
            this.btnJuguetes = new System.Windows.Forms.Button();
            this.btnColas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnJiCuadrada
            // 
            this.btnJiCuadrada.Location = new System.Drawing.Point(98, 23);
            this.btnJiCuadrada.Name = "btnJiCuadrada";
            this.btnJiCuadrada.Size = new System.Drawing.Size(125, 39);
            this.btnJiCuadrada.TabIndex = 0;
            this.btnJiCuadrada.Text = "Ji - Cuadrada";
            this.btnJiCuadrada.UseVisualStyleBackColor = true;
            this.btnJiCuadrada.Click += new System.EventHandler(this.btnJiCuadrada_Click);
            // 
            // btnJuguetes
            // 
            this.btnJuguetes.Location = new System.Drawing.Point(98, 99);
            this.btnJuguetes.Name = "btnJuguetes";
            this.btnJuguetes.Size = new System.Drawing.Size(125, 39);
            this.btnJuguetes.TabIndex = 0;
            this.btnJuguetes.Text = "Fabrica de Juguetes";
            this.btnJuguetes.UseVisualStyleBackColor = true;
            this.btnJuguetes.Click += new System.EventHandler(this.btnJuguetes_Click);
            // 
            // btnColas
            // 
            this.btnColas.Location = new System.Drawing.Point(98, 181);
            this.btnColas.Name = "btnColas";
            this.btnColas.Size = new System.Drawing.Size(125, 39);
            this.btnColas.TabIndex = 0;
            this.btnColas.Text = "Sistema de colas";
            this.btnColas.UseVisualStyleBackColor = true;
            this.btnColas.Click += new System.EventHandler(this.btnColas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 262);
            this.Controls.Add(this.btnColas);
            this.Controls.Add(this.btnJuguetes);
            this.Controls.Add(this.btnJiCuadrada);
            this.Name = "Form1";
            this.Text = "UPIICSA - Simulación de Sistemas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJiCuadrada;
        private System.Windows.Forms.Button btnJuguetes;
        private System.Windows.Forms.Button btnColas;
    }
}

