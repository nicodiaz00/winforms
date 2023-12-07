using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hola mundo");
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            lblNombre.Text="hola tu nombre es " + nombre + " y tu apellido es " + apellido;
        }
    }
}
