using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace pokeApp
{
    public partial class frmAltaPokemon : Form
    {
        public List<Elemento> listaDeElemento;
        public frmAltaPokemon()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Pokemon nuevoPokemon = new Pokemon();
            PokemonNegocio varPokemonNegocio = new PokemonNegocio();
            try
            {
                nuevoPokemon.Numero = int.Parse(txtNumero.Text);
                nuevoPokemon.Nombre = txtNombre.Text;
                nuevoPokemon.Descripcion = txtDescripcion.Text;
                nuevoPokemon.Tipo = (Elemento)cboTipo.SelectedItem;
                nuevoPokemon.Debilidad = (Elemento)cboTipo.SelectedItem;

                varPokemonNegocio.agregarPokemon(nuevoPokemon);
                MessageBox.Show("add");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void frmAltaPokemon_Load(object sender, EventArgs e)
        {
            ElementoNegocio variableElemento = new ElementoNegocio();
            try
            {

                cboTipo.DataSource = variableElemento.listarElemento();
                cboDebilidad.DataSource = variableElemento.listarElemento();

            }
            catch (Exception ex)
            {

                 MessageBox.Show(ex.ToString());
            }
            
        }
    }
}
