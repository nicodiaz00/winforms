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
    public partial class Form1 : Form
    {
        private List<Pokemon> listaPokemon;
        public Form1()
        {
            InitializeComponent();
        }
        private void cargarLista()
        {
            PokemonNegocio varPokemonNegocio = new PokemonNegocio();
            try
            {
                listaPokemon = varPokemonNegocio.listarPokemon();
                dgvPokemon.DataSource = listaPokemon;
                imgLoad(listaPokemon[0].UrlImagen);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarLista();
            
        }

        private void dgvPokemon_SelectionChanged(object sender, EventArgs e)
        {
            Pokemon imgPokemon = (Pokemon)dgvPokemon.CurrentRow.DataBoundItem;
            imgLoad(imgPokemon.UrlImagen);
        }
        private void imgLoad(string img)
        {
            try
            {
                pbxPokemon.Load(img);
            }

            catch (Exception ex)
            {

                pbxPokemon.Load("https://static.thenounproject.com/png/504708-200.png");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAltaPokemon ventanaAltaPokemon = new frmAltaPokemon();
            ventanaAltaPokemon.ShowDialog();
            cargarLista();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Pokemon objetoPokemonSeleccionado;
            objetoPokemonSeleccionado = (Pokemon) dgvPokemon.CurrentRow.DataBoundItem;
            frmAltaPokemon ventanaModificarPokemon = new frmAltaPokemon(objetoPokemonSeleccionado);
            ventanaModificarPokemon.ShowDialog();
            cargarLista();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            PokemonNegocio variableNegocio = new PokemonNegocio();  
            Pokemon pokSeleccionado =new Pokemon();
            try
            {   
                
                DialogResult respuesta = MessageBox.Show("vas a eliminar un elemento !","eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
                if(respuesta == DialogResult.Yes)
                {
                    pokSeleccionado = (Pokemon)dgvPokemon.CurrentRow.DataBoundItem;
                    variableNegocio.eliminarPokemon(pokSeleccionado.Id);
                    cargarLista();

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
