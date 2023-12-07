using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace navegacionVentanas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboColor.Items.Add("Rojo");
            cboColor.Items.Add("Verde");
            cboColor.Items.Add("Azul");

        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fechaNacimiento = dtpFechaNacimiento.Value;
            //operador ternario (if en una sola linea)
            string chocolate = cbChocolate.Checked == true ? " Le gusta " : " No le gusta ";
            
            /*
            if(rbtMuggle.Checked) {
                tipo = "Muggle";
                    }
                else if(rbtWizard.Checked) 
                {
                    tipo = "Wizard";
                 }
            else {
                tipo = "Squibs";
                 }
            
            */
            string colorFavorito = cboColor.SelectedItem.ToString();
            string numeroFavorito = numericUpDown.Value.ToString();
            string tipo = queTipoEs();

            MessageBox.Show(" Nombre: " + nombre + "Fecha: " + fechaNacimiento + " Le gusta el chocolate? " + chocolate + "tipo: " + tipo + " color y numero favorito: " + colorFavorito + numeroFavorito);
        }
        /*
        cree una funcion para comprobar que tipo de mago es, para practicar
         */
        private string queTipoEs()
        {
            string tipoMago;
            if (rbtMuggle.Checked)
            {
                tipoMago = "Muggle";
            }
            else if (rbtWizard.Checked)
            {
                tipoMago = "wizard";
            }
            else
            {
                tipoMago = "Squibs";
            }
            return tipoMago;
        }
        
    }
}
