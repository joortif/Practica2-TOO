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
    public partial class FormConv : Form
    {
        private Conversor c;
        public FormConv()
        {
            InitializeComponent();
        }

        public FormConv(Conversor conv)
        {
            InitializeComponent();
            this.c = conv;
            foreach (string nom in conv.NombreDiv)
            {
                cbDivDest.Items.Add(nom);
                cbDivOrig.Items.Add(nom);
            }
            cbDivOrig.SelectedIndex = 0;
            cbDivDest.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            Divisa dOrig = new Divisa(cbDivOrig.Text, 0.0);
            Divisa dDest = new Divisa(cbDivDest.Text, 0.0);
            double cant;
            if (!Double.TryParse(tbCantidad.Text,out cant))
            {
                MessageBox.Show("El formato introducido no es válido.", "Error");
            } else
            {
                tbResultado.Text = this.c.Convertir(dOrig, dDest, Double.Parse(tbCantidad.Text)).ToString();
            }
            
        }

        private void cbDivOrig_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void tbResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbDivDest_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tbCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
