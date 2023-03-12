namespace PRACTICA_4._7_REPASO___AlquilerCoche
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.numKmInicio = new System.Windows.Forms.NumericUpDown();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.numKmFin = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numKmInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKmFin)).BeginInit();
            this.SuspendLayout();
            // 
            // numKmInicio
            // 
            this.numKmInicio.Location = new System.Drawing.Point(358, 89);
            this.numKmInicio.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numKmInicio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numKmInicio.Name = "numKmInicio";
            this.numKmInicio.Size = new System.Drawing.Size(178, 26);
            this.numKmInicio.TabIndex = 0;
            this.numKmInicio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.ForeColor = System.Drawing.Color.Red;
            this.lblPrecio.Location = new System.Drawing.Point(485, 292);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(162, 30);
            this.lblPrecio.TabIndex = 1;
            this.lblPrecio.Text = "RESULTADO";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(318, 367);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(120, 35);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // numKmFin
            // 
            this.numKmFin.Location = new System.Drawing.Point(358, 178);
            this.numKmFin.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numKmFin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numKmFin.Name = "numKmFin";
            this.numKmFin.Size = new System.Drawing.Size(178, 26);
            this.numKmFin.TabIndex = 3;
            this.numKmFin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kilometraje de inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kilometraje de fin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "CANTIDAD OBTENIDA (€):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numKmFin);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.numKmInicio);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numKmInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKmFin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numKmInicio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.NumericUpDown numKmFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

