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
        private Pokemon variablePokemon = null;
        public List<Elemento> listaDeElemento;
        public frmAltaPokemon()
        {
            InitializeComponent();
        }
        public frmAltaPokemon(Pokemon parametroPokemon)
        {
            InitializeComponent();
            this.variablePokemon = parametroPokemon;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Pokemon nuevoPokemon = new Pokemon();
            PokemonNegocio varPokemonNegocio = new PokemonNegocio();
            try
            {
                if(variablePokemon == null)
                {
                    variablePokemon = new Pokemon();

                    variablePokemon.Numero = int.Parse(txtNumero.Text);
                    variablePokemon.Nombre = txtNombre.Text;
                    variablePokemon.Descripcion = txtDescripcion.Text;
                    variablePokemon.UrlImagen = txtUrlImagen.Text;
                    variablePokemon.Tipo = (Elemento)cboTipo.SelectedItem;
                    variablePokemon.Debilidad = (Elemento)cboTipo.SelectedItem;
                    if (variablePokemon.Id != 0)
                    {
                        varPokemonNegocio.modificarPokemon(variablePokemon);
                        MessageBox.Show("Modificado");
                    }
                    else
                    {
                        varPokemonNegocio.agregarPokemon(variablePokemon);
                        MessageBox.Show("add");
                    }
                    

                    
                    Close();
                }
                
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
                cboTipo.ValueMember = "Id";
                cboTipo.DisplayMember = "Descripcion";

                cboDebilidad.DataSource = variableElemento.listarElemento();
                cboDebilidad.ValueMember= "Id";
                cboDebilidad.DisplayMember = "Descripcion";

                if(variablePokemon != null)
                {
                    txtNumero.Text = variablePokemon.Numero.ToString();
                    txtNombre.Text = variablePokemon.Nombre;
                    txtDescripcion.Text = variablePokemon.Descripcion;
                    txtUrlImagen.Text = variablePokemon.UrlImagen;
                    imgLoad(variablePokemon.UrlImagen);
                    cboTipo.SelectedValue=variablePokemon.Tipo.Id;
                    cboDebilidad.SelectedValue =variablePokemon.Debilidad.Id;
                }

            }
            catch (Exception ex)
            {

                 MessageBox.Show(ex.ToString());
            }
            
        }

        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            imgLoad(txtUrlImagen.Text);
        }
        private void imgLoad(string img)
        {
            try
            {
                pbxUrlImagen.Load(img);
            }

            catch (Exception ex)
            {

                pbxUrlImagen.Load("https://static.thenounproject.com/png/504708-200.png");
            }
        }
    }
}
