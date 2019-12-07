namespace CalculadoraPoligono
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
            this.btnPerimetro = new System.Windows.Forms.Button();
            this.btnArea = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.triangulTP = new System.Windows.Forms.TabPage();
            this.lblAltura = new System.Windows.Forms.Label();
            this.cuadradoTP = new System.Windows.Forms.TabPage();
            this.circuloTP = new System.Windows.Forms.TabPage();
            this.retenguloTP = new System.Windows.Forms.TabPage();
            this.pentagonoTP = new System.Windows.Forms.TabPage();
            this.LblLado = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.triangulTP.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPerimetro
            // 
            this.btnPerimetro.Location = new System.Drawing.Point(539, 399);
            this.btnPerimetro.Name = "btnPerimetro";
            this.btnPerimetro.Size = new System.Drawing.Size(114, 39);
            this.btnPerimetro.TabIndex = 0;
            this.btnPerimetro.Text = "Calcular perimetro.";
            this.btnPerimetro.UseVisualStyleBackColor = true;
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(672, 399);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(106, 39);
            this.btnArea.TabIndex = 1;
            this.btnArea.Text = "Calcular area";
            this.btnArea.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.triangulTP);
            this.tabControl.Controls.Add(this.cuadradoTP);
            this.tabControl.Controls.Add(this.circuloTP);
            this.tabControl.Controls.Add(this.retenguloTP);
            this.tabControl.Controls.Add(this.pentagonoTP);
            this.tabControl.Location = new System.Drawing.Point(31, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(736, 381);
            this.tabControl.TabIndex = 2;
            // 
            // triangulTP
            // 
            this.triangulTP.Controls.Add(this.LblLado);
            this.triangulTP.Controls.Add(this.lblAltura);
            this.triangulTP.Location = new System.Drawing.Point(4, 22);
            this.triangulTP.Name = "triangulTP";
            this.triangulTP.Padding = new System.Windows.Forms.Padding(3);
            this.triangulTP.Size = new System.Drawing.Size(728, 355);
            this.triangulTP.TabIndex = 0;
            this.triangulTP.Text = "Triangulo";
            this.triangulTP.UseVisualStyleBackColor = true;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(68, 44);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(85, 13);
            this.lblAltura.TabIndex = 0;
            this.lblAltura.Text = "Ingrese la altura:";
            // 
            // cuadradoTP
            // 
            this.cuadradoTP.Location = new System.Drawing.Point(4, 22);
            this.cuadradoTP.Name = "cuadradoTP";
            this.cuadradoTP.Padding = new System.Windows.Forms.Padding(3);
            this.cuadradoTP.Size = new System.Drawing.Size(728, 355);
            this.cuadradoTP.TabIndex = 1;
            this.cuadradoTP.Text = "Cuadrado";
            this.cuadradoTP.UseVisualStyleBackColor = true;
            // 
            // circuloTP
            // 
            this.circuloTP.Location = new System.Drawing.Point(4, 22);
            this.circuloTP.Name = "circuloTP";
            this.circuloTP.Padding = new System.Windows.Forms.Padding(3);
            this.circuloTP.Size = new System.Drawing.Size(728, 355);
            this.circuloTP.TabIndex = 2;
            this.circuloTP.Text = "Circulo";
            this.circuloTP.UseVisualStyleBackColor = true;
            // 
            // retenguloTP
            // 
            this.retenguloTP.Location = new System.Drawing.Point(4, 22);
            this.retenguloTP.Name = "retenguloTP";
            this.retenguloTP.Padding = new System.Windows.Forms.Padding(3);
            this.retenguloTP.Size = new System.Drawing.Size(728, 355);
            this.retenguloTP.TabIndex = 3;
            this.retenguloTP.Text = "Retangulo";
            this.retenguloTP.UseVisualStyleBackColor = true;
            // 
            // pentagonoTP
            // 
            this.pentagonoTP.Location = new System.Drawing.Point(4, 22);
            this.pentagonoTP.Name = "pentagonoTP";
            this.pentagonoTP.Padding = new System.Windows.Forms.Padding(3);
            this.pentagonoTP.Size = new System.Drawing.Size(728, 355);
            this.pentagonoTP.TabIndex = 4;
            this.pentagonoTP.Text = "Pentagono";
            this.pentagonoTP.UseVisualStyleBackColor = true;
            // 
            // LblLado
            // 
            this.LblLado.AutoSize = true;
            this.LblLado.Location = new System.Drawing.Point(68, 75);
            this.LblLado.Name = "LblLado";
            this.LblLado.Size = new System.Drawing.Size(82, 13);
            this.LblLado.TabIndex = 1;
            this.LblLado.Text = "Ingrese la base:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.btnPerimetro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.triangulTP.ResumeLayout(false);
            this.triangulTP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPerimetro;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage triangulTP;
        private System.Windows.Forms.TabPage cuadradoTP;
        private System.Windows.Forms.TabPage circuloTP;
        private System.Windows.Forms.TabPage retenguloTP;
        private System.Windows.Forms.TabPage pentagonoTP;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label LblLado;
    }
}

