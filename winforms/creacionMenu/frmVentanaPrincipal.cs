using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace creacionMenu
{
    public partial class frmVentanaPrincipal : Form
    {
        public frmVentanaPrincipal()
        {
            InitializeComponent();
        }

        private void frmVentanaPrincipal_Load(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;
            toolStripLabelMenu.Text = fecha.ToString();
        }

        private void verPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(var item  in Application.OpenForms)
            {
                if(item.GetType()== typeof(Form1)) {
                    return;
                }
            }
            Form1 ventanPerfil = new Form1();
            ventanPerfil.MdiParent = this;
            ventanPerfil.Show();
        }
    }
}
