using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNA.Poligonos;

namespace CalculadoraPoligono
{
    public partial class Form1 : Form
    {
        private Poligono figuraSelecionada;
        public Form1()
        {
            InitializeComponent();
            figuraSelecionada = new Triangulo();
            lblFigura.Text = figuraSelecionada.Nombre;
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 0)
            {
                figuraSelecionada = new Triangulo();
            }
            if (tabControl.SelectedIndex == 1)
            {
                figuraSelecionada = new Cuadrado();
            }
            if (tabControl.SelectedIndex == 2)
            {
                figuraSelecionada = new Circulo();
            }
            if (tabControl.SelectedIndex == 3)
            {
                figuraSelecionada = new Rectangulo();
            }
            if (tabControl.SelectedIndex == 4)
            {
                figuraSelecionada = new Pentagono();
            }

        }

       
        private void btnArea_Click(object sender, EventArgs e)
        {

        }
    }
}
