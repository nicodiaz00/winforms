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


namespace adoNet
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
            PokemonNegocio varNegocio = new PokemonNegocio();
            listaPokemon= varNegocio.listar();
            dgvPokemons.DataSource = listaPokemon;
            dgvPokemons.Columns[3].Visible = false;
            cargarImg(listaPokemon[0].urlImagen);
        }

        private void dgvPokemons_SelectionChanged(object sender, EventArgs e)
        {
            Pokemon PokeSeleccionado =(Pokemon)dgvPokemons.CurrentRow.DataBoundItem;
            cargarImg(PokeSeleccionado.urlImagen);
        }
        private void cargarImg(string imagen)
        {
            try
            {
                pbPokemon.Load(imagen);
            }
            catch (Exception ex)
            {

                pbPokemon.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSUcmLCO117IJOgKFUCKJHArA7qTYPUllDEV5FgEkyI_6VCragpyFcfkoWdazWv-Adg2aQ&usqp=CAU");
            }
        }

    }
}
