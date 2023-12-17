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

        private void Form1_Load(object sender, EventArgs e)
        {
            PokemonNegocio varPokemonNegocio = new PokemonNegocio();
            listaPokemon = varPokemonNegocio.listarPokemon();
            dgvPokemon.DataSource = listaPokemon;
            imgLoad(listaPokemon[0].UrlImagen);
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
        }
    }
}
