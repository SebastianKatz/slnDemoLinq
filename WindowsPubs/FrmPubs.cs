using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsPubs.Data;

namespace WindowsPubs
{
    public partial class FrmPubs : Form
    {
        // Crear una instancia del dbContext
        PubsContext context = new PubsContext();
        public FrmPubs()
        {
            InitializeComponent();
        }

        private void btnTraerAutores_Click(object sender, EventArgs e)
        {
            var lista = (from a in context.authors
                         select a).ToList();
            grid.DataSource = lista;
        }

        private void btnTraerPublicadores_Click(object sender, EventArgs e)
        {
            var lista = (from p in context.publishers
                         select p).ToList();
            grid.DataSource = lista;
        }

        private void btnAutoresCiudad_Click(object sender, EventArgs e)
        {
            String city = "Oakland";
            var lista = (from a in context.authors
                         where a.city == city
                         select a).ToList();
            grid.DataSource = lista;
        }

        private void btnAutorId_Click(object sender, EventArgs e)
        {
            string id = "893-72-1158";
            var autor = (from a in context.authors
                         where a.au_id == id
                         select a).SingleOrDefault();
            MessageBox.Show(autor.au_fname + " " + autor.au_lname);
        }

        private void btnPublicadorNombre_Click(object sender, EventArgs e)
        {
            string pubNombre = "Ramona Publishers";
            var lista = (from p in context.publishers
                         where p.pub_name == pubNombre
                         select p).ToList();
            grid.DataSource = lista;
        }

        private void btnLista1_Click(object sender, EventArgs e)
        {
            var lista = (from st in context.stores
                         join sa in context.sales
                         on st.stor_id equals sa.stor_id
                         select new
                         {
                             ID = st.stor_id,
                             Nombre = st.stor_name,
                             NroOrden = sa.ord_num,
                             Cantidad = sa.qty,
                             IdTitulo = sa.title_id
                         }).ToList();
            grid.DataSource = lista;

        }

        private void btnLista2_Click(object sender, EventArgs e)
        {
            var lista = (from em in context.employees
                         join p in context.publishers
                         on em.pub_id equals p.pub_id
                         select new
                         {
                             Nombre = em.fname,
                             Apellido = em.lname,
                             NombrePublicador = p.pub_name
                         }).ToList();
            grid.DataSource = lista;

        }

        private void btnLista3_Click(object sender, EventArgs e)
        {
            string p = "USA";
            var lista = (from em in context.employees
                         join pu in context.publishers
                         on em.pub_id equals pu.pub_id
                         where pu.country == p
                         select new
                         {
                             Nombre = em.fname,
                             Apellido = em.lname,
                             NombrePublicador = pu.pub_name
                         }).ToList();
            grid.DataSource = lista;
        }

    }
}
