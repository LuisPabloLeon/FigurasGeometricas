using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiguraGeometricas
{
    public partial class Form1 : Form
    {
    //Luis Pablo Leon Capitan DI22114
    //Figuras Geometricas 1.0
        public Form1()
        {
            InitializeComponent();
        }


        private void Guardar_Click(object sender, EventArgs e)
        {
            if (Cuadrado.Checked)
            {
                MessageBox.Show("Los datos de la figura cuadrado estan guardados");
            }
            if (Triangulo.Checked)
            {
                MessageBox.Show("Los datos de la figura triangulo estan guardados");
            }
            if (Circulo.Checked)
            {
                MessageBox.Show("Los datos de la figura circulo estan guardados");
            }
            if (Cubo.Checked)
            {
                MessageBox.Show("Los datos de la figura cubo estan guardados");
            }
            if (Esfera.Checked)
            {
                MessageBox.Show("Los datos de la figura esfera estan guardados");
            }
            if (PoligonoI.Checked)
            {
                MessageBox.Show("Los datos del poligono irregular estan guardados");
            }
            if (PoligonoR.Checked)
            {
                MessageBox.Show("Los datos del poligono regular estan guardados");
            }
            if (Prisma.Checked)
            {
                MessageBox.Show("Los datos de la figura prisma estan guardados");
            }
            if (Rectangulo.Checked)
            {
                MessageBox.Show("Los datos del rectangulo estan guardados");
            }
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            Datos.Clear();
            Rectangulo.Checked = false;
            Prisma.Checked = false;
            Cuadrado.Checked = false;
            PoligonoI.Checked = false;
            PoligonoR.Checked = false;
            Esfera.Checked = false;
            Cubo.Checked = false;
            Circulo.Checked = false;
            Triangulo.Checked = false;
        }

        private void Dibujo_Click(object sender, EventArgs e)
        {
            if (Cuadrado.Checked)
            {
                string rutaImagen = "E:\\POO2\\FiguraGeometricas\\Imagenes\\images.png";
                Imagen.BackgroundImage = Image.FromFile(rutaImagen);
            }
            if (Triangulo.Checked)
            {
                string rutaImagen = "E:\\POO2\\FiguraGeometricas\\Imagenes\\Triángulo_equilátero.svg.png";
                Imagen.BackgroundImage = Image.FromFile(rutaImagen);
            }
            if (Circulo.Checked)
            {
                string rutaImagen = "E:\\POO2\\FiguraGeometricas\\Imagenes\\Circle_(transparent).svg.png";
                Imagen.BackgroundImage = Image.FromFile(rutaImagen);
            }
            if (Cubo.Checked)
            {
                string rutaImagen = "E:\\POO2\\FiguraGeometricas\\Imagenes\\blue-cube-icon-isometric-style-vector.jpg";
                Imagen.BackgroundImage = Image.FromFile(rutaImagen);
            }
            if (Esfera.Checked)
            {
                string rutaImagen = "E:\\POO2\\FiguraGeometricas\\Imagenes\\1200px-Sphere_-_Esfera.svg.png";
                Imagen.BackgroundImage = Image.FromFile(rutaImagen);
            }
            if (PoligonoI.Checked)
            {
                string rutaImagen = "E:\\POO2\\FiguraGeometricas\\Imagenes\\Figura-1-Poligono-irregular.png";
                Imagen.BackgroundImage = Image.FromFile(rutaImagen);
            }
            if (PoligonoR.Checked)
            {
                string rutaImagen = "E:\\POO2\\FiguraGeometricas\\Imagenes\\Polig_07a.svg.png";
                Imagen.BackgroundImage = Image.FromFile(rutaImagen);
            }
            if (Prisma.Checked)
            {
                string rutaImagen = "E:\\POO2\\FiguraGeometricas\\Imagenes\\optica360.png";
                Imagen.BackgroundImage = Image.FromFile(rutaImagen);
            }
            if (Rectangulo.Checked)
            {
                string rutaImagen = "E:\\POO2\\FiguraGeometricas\\Imagenes\\images (1).png";
                Imagen.BackgroundImage = Image.FromFile(rutaImagen);
            }
        }
    }
}
