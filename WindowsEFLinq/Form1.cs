using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEFLinq.Data;

namespace WindowsEFLinq
{
    public partial class Form1 : Form
    {
        // Crear una instancia del dbContext
        NorthwindContext context = new NorthwindContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void txtTraerProductos_Click(object sender, EventArgs e)
        {
            // traer todos
            var lista = (from p in context.Products
                         select p).ToList();
            gridProductos.DataSource = lista;
        }

        private void btnTraerPorCategoria_Click(object sender, EventArgs e)
        {
            int categoriaId = 2;
            var lista = (from p in context.Products
                         where p.CategoryID == categoriaId
                         select p).ToList();
            gridProductos.DataSource = lista;
        }

        private void btnTraerPorNombre_Click(object sender, EventArgs e)
        {
            string nombreProducto = "Queso Cabrales";
            var producto = (from p in context.Products
                            where p.ProductName == nombreProducto
                            select p).SingleOrDefault();
            MessageBox.Show(producto.ProductName + " " + producto.UnitPrice.ToString());
        }

        private void btnTraerId_Click(object sender, EventArgs e)
        {
            int ID = 2;
            var producto = (from p in context.Products
                            where p.ProductID == ID
                            select p).SingleOrDefault();
            MessageBox.Show(producto.ProductName + " " + producto.UnitPrice.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var lista = (
                from 
                c in context.Categories
                join
                p in context.Products
                on c.CategoryID equals p.CategoryID
                select new
                {
                    c.CategoryID,
                    Category = c.CategoryName,
                    Product = p.ProductName,
                    p.UnitPrice
                }
                ).ToList();
            gridProductos.DataSource = lista;
        }
    }
}
