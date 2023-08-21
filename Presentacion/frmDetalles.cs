using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Presentacion
{
    public partial class frmDetalles : Form
    {
        private Articulo art;
        public frmDetalles()
        {
            InitializeComponent();
        }
        public frmDetalles(Articulo art)
        {
            InitializeComponent();
            this.art = art;
        }

        private void Detalles_Load(object sender, EventArgs e)
        {
            try
            {
                lblIdDetalles.Text = art.Id.ToString();
                lblCodigoDetalles.Text = art.Codigo;
                lblNombreDetalles.Text = art.Nombre;
                lblDescripcionDetalles.Text = art.Descripcion;
                lblPrecioDetalles.Text = art.Precio.ToString();
                lblMarcaDetalles.Text = art.NombreMarca.ToString();
                lblCategoriaDetalles.Text = art.TipoCategoria.ToString();
                lblImagenUrlDetalles.Text = art.ImagenUrl;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
