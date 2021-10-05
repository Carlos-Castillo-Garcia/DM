
namespace Calculadora
{
    partial class Pantalla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pantalla));
            this.resetear = new System.Windows.Forms.Button();
            this.igual = new System.Windows.Forms.Button();
            this.sumar = new System.Windows.Forms.Button();
            this.restar = new System.Windows.Forms.Button();
            this.multiplicar = new System.Windows.Forms.Button();
            this.dividir = new System.Windows.Forms.Button();
            this.cero = new System.Windows.Forms.Button();
            this.nueve = new System.Windows.Forms.Button();
            this.ocho = new System.Windows.Forms.Button();
            this.siete = new System.Windows.Forms.Button();
            this.seis = new System.Windows.Forms.Button();
            this.cinco = new System.Windows.Forms.Button();
            this.cuatro = new System.Windows.Forms.Button();
            this.tres = new System.Windows.Forms.Button();
            this.dos = new System.Windows.Forms.Button();
            this.uno = new System.Windows.Forms.Button();
            this.mostraresultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.historial = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // resetear
            // 
            this.resetear.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetear.Location = new System.Drawing.Point(426, 53);
            this.resetear.Margin = new System.Windows.Forms.Padding(2);
            this.resetear.MaximumSize = new System.Drawing.Size(112, 53);
            this.resetear.Name = "resetear";
            this.resetear.Size = new System.Drawing.Size(90, 53);
            this.resetear.TabIndex = 35;
            this.resetear.Text = "C";
            this.resetear.UseVisualStyleBackColor = true;
            this.resetear.Click += new System.EventHandler(this.resetear_Click);
            // 
            // igual
            // 
            this.igual.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igual.Location = new System.Drawing.Point(218, 169);
            this.igual.Margin = new System.Windows.Forms.Padding(2);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(298, 53);
            this.igual.TabIndex = 34;
            this.igual.Text = "=";
            this.igual.UseVisualStyleBackColor = true;
            this.igual.Click += new System.EventHandler(this.resultado_Click);
            // 
            // sumar
            // 
            this.sumar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumar.Location = new System.Drawing.Point(369, 111);
            this.sumar.Margin = new System.Windows.Forms.Padding(2);
            this.sumar.Name = "sumar";
            this.sumar.Size = new System.Drawing.Size(147, 53);
            this.sumar.TabIndex = 32;
            this.sumar.Text = "+";
            this.sumar.UseVisualStyleBackColor = true;
            this.sumar.Click += new System.EventHandler(this.sumar_Click);
            // 
            // restar
            // 
            this.restar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restar.Location = new System.Drawing.Point(218, 111);
            this.restar.Margin = new System.Windows.Forms.Padding(2);
            this.restar.Name = "restar";
            this.restar.Size = new System.Drawing.Size(147, 53);
            this.restar.TabIndex = 31;
            this.restar.Text = "-";
            this.restar.UseVisualStyleBackColor = true;
            this.restar.Click += new System.EventHandler(this.restar_Click);
            // 
            // multiplicar
            // 
            this.multiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicar.Location = new System.Drawing.Point(369, 515);
            this.multiplicar.Margin = new System.Windows.Forms.Padding(2);
            this.multiplicar.Name = "multiplicar";
            this.multiplicar.Size = new System.Drawing.Size(147, 53);
            this.multiplicar.TabIndex = 30;
            this.multiplicar.Text = "*";
            this.multiplicar.UseVisualStyleBackColor = true;
            this.multiplicar.Click += new System.EventHandler(this.multiplicar_Click);
            // 
            // dividir
            // 
            this.dividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividir.Location = new System.Drawing.Point(218, 515);
            this.dividir.Margin = new System.Windows.Forms.Padding(2);
            this.dividir.Name = "dividir";
            this.dividir.Size = new System.Drawing.Size(147, 53);
            this.dividir.TabIndex = 29;
            this.dividir.Text = "/";
            this.dividir.UseVisualStyleBackColor = true;
            this.dividir.Click += new System.EventHandler(this.dividir_Click);
            // 
            // cero
            // 
            this.cero.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cero.Location = new System.Drawing.Point(369, 457);
            this.cero.Margin = new System.Windows.Forms.Padding(2);
            this.cero.Name = "cero";
            this.cero.Size = new System.Drawing.Size(147, 53);
            this.cero.TabIndex = 28;
            this.cero.Text = "0";
            this.cero.UseVisualStyleBackColor = true;
            this.cero.Click += new System.EventHandler(this.cero_Click);
            // 
            // nueve
            // 
            this.nueve.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nueve.Location = new System.Drawing.Point(218, 457);
            this.nueve.Margin = new System.Windows.Forms.Padding(2);
            this.nueve.Name = "nueve";
            this.nueve.Size = new System.Drawing.Size(147, 53);
            this.nueve.TabIndex = 27;
            this.nueve.Text = "9";
            this.nueve.UseVisualStyleBackColor = true;
            this.nueve.Click += new System.EventHandler(this.nueve_Click);
            // 
            // ocho
            // 
            this.ocho.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ocho.Location = new System.Drawing.Point(369, 400);
            this.ocho.Margin = new System.Windows.Forms.Padding(2);
            this.ocho.Name = "ocho";
            this.ocho.Size = new System.Drawing.Size(147, 53);
            this.ocho.TabIndex = 26;
            this.ocho.Text = "8";
            this.ocho.UseVisualStyleBackColor = true;
            this.ocho.Click += new System.EventHandler(this.ocho_Click);
            // 
            // siete
            // 
            this.siete.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siete.Location = new System.Drawing.Point(218, 400);
            this.siete.Margin = new System.Windows.Forms.Padding(2);
            this.siete.Name = "siete";
            this.siete.Size = new System.Drawing.Size(147, 53);
            this.siete.TabIndex = 25;
            this.siete.Text = "7";
            this.siete.UseVisualStyleBackColor = true;
            this.siete.Click += new System.EventHandler(this.siete_Click);
            // 
            // seis
            // 
            this.seis.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seis.Location = new System.Drawing.Point(369, 342);
            this.seis.Margin = new System.Windows.Forms.Padding(2);
            this.seis.Name = "seis";
            this.seis.Size = new System.Drawing.Size(147, 53);
            this.seis.TabIndex = 24;
            this.seis.Text = "6";
            this.seis.UseVisualStyleBackColor = true;
            this.seis.Click += new System.EventHandler(this.seis_Click);
            // 
            // cinco
            // 
            this.cinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cinco.Location = new System.Drawing.Point(218, 342);
            this.cinco.Margin = new System.Windows.Forms.Padding(2);
            this.cinco.Name = "cinco";
            this.cinco.Size = new System.Drawing.Size(147, 53);
            this.cinco.TabIndex = 23;
            this.cinco.Text = "5";
            this.cinco.UseVisualStyleBackColor = true;
            this.cinco.Click += new System.EventHandler(this.cinco_Click);
            // 
            // cuatro
            // 
            this.cuatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuatro.Location = new System.Drawing.Point(369, 284);
            this.cuatro.Margin = new System.Windows.Forms.Padding(2);
            this.cuatro.Name = "cuatro";
            this.cuatro.Size = new System.Drawing.Size(147, 53);
            this.cuatro.TabIndex = 22;
            this.cuatro.Text = "4";
            this.cuatro.UseVisualStyleBackColor = true;
            this.cuatro.Click += new System.EventHandler(this.cuatro_Click);
            // 
            // tres
            // 
            this.tres.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tres.Location = new System.Drawing.Point(218, 284);
            this.tres.Margin = new System.Windows.Forms.Padding(2);
            this.tres.Name = "tres";
            this.tres.Size = new System.Drawing.Size(147, 53);
            this.tres.TabIndex = 21;
            this.tres.Text = "3";
            this.tres.UseVisualStyleBackColor = true;
            this.tres.Click += new System.EventHandler(this.tres_Click);
            // 
            // dos
            // 
            this.dos.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dos.Location = new System.Drawing.Point(369, 227);
            this.dos.Margin = new System.Windows.Forms.Padding(2);
            this.dos.Name = "dos";
            this.dos.Size = new System.Drawing.Size(147, 53);
            this.dos.TabIndex = 20;
            this.dos.Text = "2";
            this.dos.UseVisualStyleBackColor = true;
            this.dos.Click += new System.EventHandler(this.dos_Click);
            // 
            // uno
            // 
            this.uno.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uno.Location = new System.Drawing.Point(218, 227);
            this.uno.Margin = new System.Windows.Forms.Padding(2);
            this.uno.Name = "uno";
            this.uno.Size = new System.Drawing.Size(147, 53);
            this.uno.TabIndex = 19;
            this.uno.Text = "1";
            this.uno.UseVisualStyleBackColor = true;
            this.uno.Click += new System.EventHandler(this.uno_Click);
            // 
            // mostraresultado
            // 
            this.mostraresultado.Location = new System.Drawing.Point(218, 53);
            this.mostraresultado.MinimumSize = new System.Drawing.Size(90, 53);
            this.mostraresultado.Name = "mostraresultado";
            this.mostraresultado.Size = new System.Drawing.Size(203, 20);
            this.mostraresultado.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(522, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 29);
            this.label1.TabIndex = 37;
            this.label1.Text = "Historial";
            // 
            // historial
            // 
            this.historial.Location = new System.Drawing.Point(521, 86);
            this.historial.MinimumSize = new System.Drawing.Size(90, 53);
            this.historial.Name = "historial";
            this.historial.Size = new System.Drawing.Size(203, 20);
            this.historial.TabIndex = 38;
            // 
            // Pantalla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(828, 639);
            this.Controls.Add(this.historial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mostraresultado);
            this.Controls.Add(this.resetear);
            this.Controls.Add(this.igual);
            this.Controls.Add(this.sumar);
            this.Controls.Add(this.restar);
            this.Controls.Add(this.multiplicar);
            this.Controls.Add(this.dividir);
            this.Controls.Add(this.cero);
            this.Controls.Add(this.nueve);
            this.Controls.Add(this.ocho);
            this.Controls.Add(this.siete);
            this.Controls.Add(this.seis);
            this.Controls.Add(this.cinco);
            this.Controls.Add(this.cuatro);
            this.Controls.Add(this.tres);
            this.Controls.Add(this.dos);
            this.Controls.Add(this.uno);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Pantalla";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button resetear;
        private System.Windows.Forms.Button igual;
        private System.Windows.Forms.Button sumar;
        private System.Windows.Forms.Button restar;
        private System.Windows.Forms.Button multiplicar;
        private System.Windows.Forms.Button dividir;
        private System.Windows.Forms.Button cero;
        private System.Windows.Forms.Button nueve;
        private System.Windows.Forms.Button ocho;
        private System.Windows.Forms.Button siete;
        private System.Windows.Forms.Button seis;
        private System.Windows.Forms.Button cinco;
        private System.Windows.Forms.Button cuatro;
        private System.Windows.Forms.Button tres;
        private System.Windows.Forms.Button dos;
        private System.Windows.Forms.Button uno;
        private System.Windows.Forms.TextBox mostraresultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox historial;
    }
}

