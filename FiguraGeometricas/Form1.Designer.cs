
namespace FiguraGeometricas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Esfera = new System.Windows.Forms.RadioButton();
            this.Prisma = new System.Windows.Forms.RadioButton();
            this.Cubo = new System.Windows.Forms.RadioButton();
            this.Circulo = new System.Windows.Forms.RadioButton();
            this.PoligonoI = new System.Windows.Forms.RadioButton();
            this.PoligonoR = new System.Windows.Forms.RadioButton();
            this.Rectangulo = new System.Windows.Forms.RadioButton();
            this.Triangulo = new System.Windows.Forms.RadioButton();
            this.Cuadrado = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.RichTextBox();
            this.Datos = new System.Windows.Forms.TextBox();
            this.Guardar = new System.Windows.Forms.Button();
            this.Informacion = new System.Windows.Forms.Button();
            this.Dibujo = new System.Windows.Forms.Button();
            this.Exportar = new System.Windows.Forms.Button();
            this.Limpiar = new System.Windows.Forms.Button();
            this.Calcular = new System.Windows.Forms.Button();
            this.Imagen = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.Calcular);
            this.groupBox1.Controls.Add(this.Limpiar);
            this.groupBox1.Controls.Add(this.Exportar);
            this.groupBox1.Controls.Add(this.Dibujo);
            this.groupBox1.Controls.Add(this.Informacion);
            this.groupBox1.Controls.Add(this.Guardar);
            this.groupBox1.Controls.Add(this.Datos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Esfera);
            this.groupBox1.Controls.Add(this.Prisma);
            this.groupBox1.Controls.Add(this.Cubo);
            this.groupBox1.Controls.Add(this.Circulo);
            this.groupBox1.Controls.Add(this.PoligonoI);
            this.groupBox1.Controls.Add(this.PoligonoR);
            this.groupBox1.Controls.Add(this.Rectangulo);
            this.groupBox1.Controls.Add(this.Triangulo);
            this.groupBox1.Controls.Add(this.Cuadrado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ingresa medida del lado, arista, radio, etc";
            // 
            // Esfera
            // 
            this.Esfera.AutoSize = true;
            this.Esfera.Location = new System.Drawing.Point(412, 67);
            this.Esfera.Name = "Esfera";
            this.Esfera.Size = new System.Drawing.Size(55, 17);
            this.Esfera.TabIndex = 9;
            this.Esfera.TabStop = true;
            this.Esfera.Text = "Esfera";
            this.Esfera.UseVisualStyleBackColor = true;
            // 
            // Prisma
            // 
            this.Prisma.AutoSize = true;
            this.Prisma.Location = new System.Drawing.Point(331, 67);
            this.Prisma.Name = "Prisma";
            this.Prisma.Size = new System.Drawing.Size(56, 17);
            this.Prisma.TabIndex = 8;
            this.Prisma.TabStop = true;
            this.Prisma.Text = "Prisma";
            this.Prisma.UseVisualStyleBackColor = true;
            // 
            // Cubo
            // 
            this.Cubo.AutoSize = true;
            this.Cubo.Location = new System.Drawing.Point(236, 67);
            this.Cubo.Name = "Cubo";
            this.Cubo.Size = new System.Drawing.Size(50, 17);
            this.Cubo.TabIndex = 7;
            this.Cubo.TabStop = true;
            this.Cubo.Text = "Cubo";
            this.Cubo.UseVisualStyleBackColor = true;
            // 
            // Circulo
            // 
            this.Circulo.AutoSize = true;
            this.Circulo.Location = new System.Drawing.Point(146, 67);
            this.Circulo.Name = "Circulo";
            this.Circulo.Size = new System.Drawing.Size(57, 17);
            this.Circulo.TabIndex = 6;
            this.Circulo.TabStop = true;
            this.Circulo.Text = "Circulo";
            this.Circulo.UseVisualStyleBackColor = true;
            // 
            // PoligonoI
            // 
            this.PoligonoI.AutoSize = true;
            this.PoligonoI.Location = new System.Drawing.Point(11, 67);
            this.PoligonoI.Name = "PoligonoI";
            this.PoligonoI.Size = new System.Drawing.Size(107, 17);
            this.PoligonoI.TabIndex = 5;
            this.PoligonoI.TabStop = true;
            this.PoligonoI.Text = "Poligono Irregular";
            this.PoligonoI.UseVisualStyleBackColor = true;
            // 
            // PoligonoR
            // 
            this.PoligonoR.AutoSize = true;
            this.PoligonoR.Location = new System.Drawing.Point(393, 44);
            this.PoligonoR.Name = "PoligonoR";
            this.PoligonoR.Size = new System.Drawing.Size(106, 17);
            this.PoligonoR.TabIndex = 4;
            this.PoligonoR.TabStop = true;
            this.PoligonoR.Text = "Poligono Regular";
            this.PoligonoR.UseVisualStyleBackColor = true;
            // 
            // Rectangulo
            // 
            this.Rectangulo.AutoSize = true;
            this.Rectangulo.Location = new System.Drawing.Point(265, 44);
            this.Rectangulo.Name = "Rectangulo";
            this.Rectangulo.Size = new System.Drawing.Size(80, 17);
            this.Rectangulo.TabIndex = 3;
            this.Rectangulo.TabStop = true;
            this.Rectangulo.Text = "Rectangulo";
            this.Rectangulo.UseVisualStyleBackColor = true;
            // 
            // Triangulo
            // 
            this.Triangulo.AutoSize = true;
            this.Triangulo.Location = new System.Drawing.Point(134, 44);
            this.Triangulo.Name = "Triangulo";
            this.Triangulo.Size = new System.Drawing.Size(69, 17);
            this.Triangulo.TabIndex = 2;
            this.Triangulo.TabStop = true;
            this.Triangulo.Text = "Triangulo";
            this.Triangulo.UseVisualStyleBackColor = true;
            // 
            // Cuadrado
            // 
            this.Cuadrado.AutoSize = true;
            this.Cuadrado.Location = new System.Drawing.Point(11, 44);
            this.Cuadrado.Name = "Cuadrado";
            this.Cuadrado.Size = new System.Drawing.Size(71, 17);
            this.Cuadrado.TabIndex = 1;
            this.Cuadrado.TabStop = true;
            this.Cuadrado.Text = "Cuadrado";
            this.Cuadrado.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Constructor de figuras geometricas";
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(305, 176);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(227, 195);
            this.info.TabIndex = 2;
            this.info.Text = "";
            // 
            // Datos
            // 
            this.Datos.Location = new System.Drawing.Point(315, 90);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(112, 20);
            this.Datos.TabIndex = 11;
            // 
            // Guardar
            // 
            this.Guardar.BackColor = System.Drawing.SystemColors.Highlight;
            this.Guardar.ForeColor = System.Drawing.Color.Lime;
            this.Guardar.Location = new System.Drawing.Point(432, 89);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(79, 21);
            this.Guardar.TabIndex = 12;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = false;
            // 
            // Informacion
            // 
            this.Informacion.Location = new System.Drawing.Point(15, 114);
            this.Informacion.Name = "Informacion";
            this.Informacion.Size = new System.Drawing.Size(90, 21);
            this.Informacion.TabIndex = 13;
            this.Informacion.Text = "Informacion";
            this.Informacion.UseVisualStyleBackColor = true;
            // 
            // Dibujo
            // 
            this.Dibujo.Location = new System.Drawing.Point(113, 114);
            this.Dibujo.Name = "Dibujo";
            this.Dibujo.Size = new System.Drawing.Size(90, 21);
            this.Dibujo.TabIndex = 14;
            this.Dibujo.Text = "Dibujar";
            this.Dibujo.UseVisualStyleBackColor = true;
            // 
            // Exportar
            // 
            this.Exportar.Location = new System.Drawing.Point(219, 114);
            this.Exportar.Name = "Exportar";
            this.Exportar.Size = new System.Drawing.Size(90, 21);
            this.Exportar.TabIndex = 15;
            this.Exportar.Text = "Exportar";
            this.Exportar.UseVisualStyleBackColor = true;
            // 
            // Limpiar
            // 
            this.Limpiar.BackColor = System.Drawing.Color.Red;
            this.Limpiar.ForeColor = System.Drawing.Color.White;
            this.Limpiar.Location = new System.Drawing.Point(315, 114);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(90, 21);
            this.Limpiar.TabIndex = 16;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = false;
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(412, 114);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(90, 21);
            this.Calcular.TabIndex = 17;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            // 
            // Imagen
            // 
            this.Imagen.Location = new System.Drawing.Point(10, 176);
            this.Imagen.Name = "Imagen";
            this.Imagen.Size = new System.Drawing.Size(286, 195);
            this.Imagen.TabIndex = 3;
            this.Imagen.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(540, 388);
            this.Controls.Add(this.Imagen);
            this.Controls.Add(this.info);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Bienvenid@";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Esfera;
        private System.Windows.Forms.RadioButton Prisma;
        private System.Windows.Forms.RadioButton Cubo;
        private System.Windows.Forms.RadioButton Circulo;
        private System.Windows.Forms.RadioButton PoligonoI;
        private System.Windows.Forms.RadioButton PoligonoR;
        private System.Windows.Forms.RadioButton Rectangulo;
        private System.Windows.Forms.RadioButton Triangulo;
        private System.Windows.Forms.RadioButton Cuadrado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Button Exportar;
        private System.Windows.Forms.Button Dibujo;
        private System.Windows.Forms.Button Informacion;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.TextBox Datos;
        private System.Windows.Forms.RichTextBox info;
        private System.Windows.Forms.PictureBox Imagen;
    }
}

