﻿namespace CalculadoraPoligono
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
            this.txtLadoTringulo3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLadoTringulo2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLadoTringulo1 = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.txtAlturaTriangulo = new System.Windows.Forms.TextBox();
            this.txtBaseTriangulo = new System.Windows.Forms.TextBox();
            this.LblLado = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.cuadradoTP = new System.Windows.Forms.TabPage();
            this.txtLadoCuadrado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.circuloTP = new System.Windows.Forms.TabPage();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.retenguloTP = new System.Windows.Forms.TabPage();
            this.txtLargoRectangulo = new System.Windows.Forms.TextBox();
            this.txtAnchoRectangulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pentagonoTP = new System.Windows.Forms.TabPage();
            this.txtLargoPentagono = new System.Windows.Forms.TextBox();
            this.txtApotemaPentagono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFigura = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.triangulTP.SuspendLayout();
            this.cuadradoTP.SuspendLayout();
            this.circuloTP.SuspendLayout();
            this.retenguloTP.SuspendLayout();
            this.pentagonoTP.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPerimetro
            // 
            this.btnPerimetro.Location = new System.Drawing.Point(531, 395);
            this.btnPerimetro.Name = "btnPerimetro";
            this.btnPerimetro.Size = new System.Drawing.Size(114, 39);
            this.btnPerimetro.TabIndex = 0;
            this.btnPerimetro.Text = "Calcular perimetro.";
            this.btnPerimetro.UseVisualStyleBackColor = true;
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(661, 395);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(106, 39);
            this.btnArea.TabIndex = 1;
            this.btnArea.Text = "Calcular area";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
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
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // triangulTP
            // 
            this.triangulTP.Controls.Add(this.txtLadoTringulo3);
            this.triangulTP.Controls.Add(this.label9);
            this.triangulTP.Controls.Add(this.txtLadoTringulo2);
            this.triangulTP.Controls.Add(this.label8);
            this.triangulTP.Controls.Add(this.txtLadoTringulo1);
            this.triangulTP.Controls.Add(this.lbl);
            this.triangulTP.Controls.Add(this.txtAlturaTriangulo);
            this.triangulTP.Controls.Add(this.txtBaseTriangulo);
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
            // txtLadoTringulo3
            // 
            this.txtLadoTringulo3.Location = new System.Drawing.Point(181, 154);
            this.txtLadoTringulo3.Name = "txtLadoTringulo3";
            this.txtLadoTringulo3.Size = new System.Drawing.Size(204, 20);
            this.txtLadoTringulo3.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(65, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Ingrese el lado 3:";
            // 
            // txtLadoTringulo2
            // 
            this.txtLadoTringulo2.Location = new System.Drawing.Point(181, 125);
            this.txtLadoTringulo2.Name = "txtLadoTringulo2";
            this.txtLadoTringulo2.Size = new System.Drawing.Size(204, 20);
            this.txtLadoTringulo2.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Ingrese el lado 2:";
            // 
            // txtLadoTringulo1
            // 
            this.txtLadoTringulo1.Location = new System.Drawing.Point(181, 95);
            this.txtLadoTringulo1.Name = "txtLadoTringulo1";
            this.txtLadoTringulo1.Size = new System.Drawing.Size(204, 20);
            this.txtLadoTringulo1.TabIndex = 5;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(65, 102);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(92, 13);
            this.lbl.TabIndex = 4;
            this.lbl.Text = "Ingrese el Lado 1:";
            this.lbl.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtAlturaTriangulo
            // 
            this.txtAlturaTriangulo.Location = new System.Drawing.Point(181, 37);
            this.txtAlturaTriangulo.Name = "txtAlturaTriangulo";
            this.txtAlturaTriangulo.Size = new System.Drawing.Size(204, 20);
            this.txtAlturaTriangulo.TabIndex = 3;
            // 
            // txtBaseTriangulo
            // 
            this.txtBaseTriangulo.Location = new System.Drawing.Point(181, 68);
            this.txtBaseTriangulo.Name = "txtBaseTriangulo";
            this.txtBaseTriangulo.Size = new System.Drawing.Size(204, 20);
            this.txtBaseTriangulo.TabIndex = 2;
            // 
            // LblLado
            // 
            this.LblLado.AutoSize = true;
            this.LblLado.Location = new System.Drawing.Point(65, 75);
            this.LblLado.Name = "LblLado";
            this.LblLado.Size = new System.Drawing.Size(82, 13);
            this.LblLado.TabIndex = 1;
            this.LblLado.Text = "Ingrese la base:";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(62, 44);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(85, 13);
            this.lblAltura.TabIndex = 0;
            this.lblAltura.Text = "Ingrese la altura:";
            // 
            // cuadradoTP
            // 
            this.cuadradoTP.Controls.Add(this.txtLadoCuadrado);
            this.cuadradoTP.Controls.Add(this.label1);
            this.cuadradoTP.Location = new System.Drawing.Point(4, 22);
            this.cuadradoTP.Name = "cuadradoTP";
            this.cuadradoTP.Padding = new System.Windows.Forms.Padding(3);
            this.cuadradoTP.Size = new System.Drawing.Size(728, 355);
            this.cuadradoTP.TabIndex = 1;
            this.cuadradoTP.Text = "Cuadrado";
            this.cuadradoTP.UseVisualStyleBackColor = true;
            // 
            // txtLadoCuadrado
            // 
            this.txtLadoCuadrado.Location = new System.Drawing.Point(162, 43);
            this.txtLadoCuadrado.Name = "txtLadoCuadrado";
            this.txtLadoCuadrado.Size = new System.Drawing.Size(100, 20);
            this.txtLadoCuadrado.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el lado";
            // 
            // circuloTP
            // 
            this.circuloTP.Controls.Add(this.txtRadio);
            this.circuloTP.Controls.Add(this.label2);
            this.circuloTP.Location = new System.Drawing.Point(4, 22);
            this.circuloTP.Name = "circuloTP";
            this.circuloTP.Padding = new System.Windows.Forms.Padding(3);
            this.circuloTP.Size = new System.Drawing.Size(728, 355);
            this.circuloTP.TabIndex = 2;
            this.circuloTP.Text = "Circulo";
            this.circuloTP.UseVisualStyleBackColor = true;
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(161, 42);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(100, 20);
            this.txtRadio.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese el radio";
            // 
            // retenguloTP
            // 
            this.retenguloTP.Controls.Add(this.txtLargoRectangulo);
            this.retenguloTP.Controls.Add(this.txtAnchoRectangulo);
            this.retenguloTP.Controls.Add(this.label3);
            this.retenguloTP.Controls.Add(this.label4);
            this.retenguloTP.Location = new System.Drawing.Point(4, 22);
            this.retenguloTP.Name = "retenguloTP";
            this.retenguloTP.Padding = new System.Windows.Forms.Padding(3);
            this.retenguloTP.Size = new System.Drawing.Size(728, 355);
            this.retenguloTP.TabIndex = 3;
            this.retenguloTP.Text = "Retangulo";
            this.retenguloTP.UseVisualStyleBackColor = true;
            // 
            // txtLargoRectangulo
            // 
            this.txtLargoRectangulo.Location = new System.Drawing.Point(153, 23);
            this.txtLargoRectangulo.Name = "txtLargoRectangulo";
            this.txtLargoRectangulo.Size = new System.Drawing.Size(204, 20);
            this.txtLargoRectangulo.TabIndex = 7;
            // 
            // txtAnchoRectangulo
            // 
            this.txtAnchoRectangulo.Location = new System.Drawing.Point(153, 54);
            this.txtAnchoRectangulo.Name = "txtAnchoRectangulo";
            this.txtAnchoRectangulo.Size = new System.Drawing.Size(204, 20);
            this.txtAnchoRectangulo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ingrese el ancho:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ingrese el largo:";
            // 
            // pentagonoTP
            // 
            this.pentagonoTP.Controls.Add(this.txtLargoPentagono);
            this.pentagonoTP.Controls.Add(this.txtApotemaPentagono);
            this.pentagonoTP.Controls.Add(this.label5);
            this.pentagonoTP.Controls.Add(this.label6);
            this.pentagonoTP.Location = new System.Drawing.Point(4, 22);
            this.pentagonoTP.Name = "pentagonoTP";
            this.pentagonoTP.Padding = new System.Windows.Forms.Padding(3);
            this.pentagonoTP.Size = new System.Drawing.Size(728, 355);
            this.pentagonoTP.TabIndex = 4;
            this.pentagonoTP.Text = "Pentagono";
            this.pentagonoTP.UseVisualStyleBackColor = true;
            // 
            // txtLargoPentagono
            // 
            this.txtLargoPentagono.Location = new System.Drawing.Point(182, 39);
            this.txtLargoPentagono.Name = "txtLargoPentagono";
            this.txtLargoPentagono.Size = new System.Drawing.Size(204, 20);
            this.txtLargoPentagono.TabIndex = 11;
            // 
            // txtApotemaPentagono
            // 
            this.txtApotemaPentagono.Location = new System.Drawing.Point(182, 70);
            this.txtApotemaPentagono.Name = "txtApotemaPentagono";
            this.txtApotemaPentagono.Size = new System.Drawing.Size(204, 20);
            this.txtApotemaPentagono.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ingrese la apotema:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ingrese el largo:";
            // 
            // lblFigura
            // 
            this.lblFigura.AutoSize = true;
            this.lblFigura.Location = new System.Drawing.Point(49, 410);
            this.lblFigura.Name = "lblFigura";
            this.lblFigura.Size = new System.Drawing.Size(104, 13);
            this.lblFigura.TabIndex = 3;
            this.lblFigura.Text = "Figura Seleccionada";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFigura);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.btnPerimetro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.triangulTP.ResumeLayout(false);
            this.triangulTP.PerformLayout();
            this.cuadradoTP.ResumeLayout(false);
            this.cuadradoTP.PerformLayout();
            this.circuloTP.ResumeLayout(false);
            this.circuloTP.PerformLayout();
            this.retenguloTP.ResumeLayout(false);
            this.retenguloTP.PerformLayout();
            this.pentagonoTP.ResumeLayout(false);
            this.pentagonoTP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox txtAlturaTriangulo;
        private System.Windows.Forms.TextBox txtBaseTriangulo;
        private System.Windows.Forms.TextBox txtLadoCuadrado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLargoRectangulo;
        private System.Windows.Forms.TextBox txtAnchoRectangulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLargoPentagono;
        private System.Windows.Forms.TextBox txtApotemaPentagono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblFigura;
        private System.Windows.Forms.TextBox txtLadoTringulo3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLadoTringulo2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLadoTringulo1;
        private System.Windows.Forms.Label lbl;
    }
}

