using ModeloDominio;
using ModeloNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionWindows
{
    public partial class FormDivNueva : Form
    {
        private Conversor c;
        public FormDivNueva(Conversor c)
        {
            InitializeComponent();
            this.c = c;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAñadir_Click(object sender, EventArgs e)
        {
            double valor;
            string valorString;
            if (tbNombre.Text.Length == 0)
            {
                MessageBox.Show("Introduzca un nombre para la nueva divisa.", "Error");
            } else
            {
                if (!Double.TryParse(tbValor.Text, out valor))
                {
                    MessageBox.Show("El formato introducido no es válido.", "Error");
                }
                else
                {
                    valorString = tbValor.Text;
                    if (valorString.Contains("."))
                    {
                        valorString = tbValor.Text.Replace('.', ',');
                    }
                    valor = Double.Parse(valorString);
                    Divisa divNueva = new Divisa(tbNombre.Text, valor);
                    if (this.c.Divisas.Contains(divNueva))
                    {
                        MessageBox.Show("Ya existe una divisa con ese nombre.", "Error");
                    } else
                    {
                        this.c.Divisas.Add(divNueva);
                        this.Close();
                    }
                }
            }
            

        }
    }
}
