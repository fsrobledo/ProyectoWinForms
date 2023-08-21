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
    public partial class frmArticulo : Form
    {
        private Articulo articulo = null;
        private OpenFileDialog archivo = null;
        public frmArticulo()
        {
            InitializeComponent();
        }
        public frmArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Artículo";
        }
        private void frmArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio catNegocio = new CategoriaNegocio();
            try
            {
                cbxMarca.DataSource = marcaNegocio.listar();
                cbxMarca.ValueMember = "Id";
                cbxMarca.DisplayMember = "Descripcion";
                cbxMarca.SelectedIndex = -1;
                cbxCategoria.DataSource = catNegocio.listar();
                cbxCategoria.ValueMember = "Id";
                cbxCategoria.DisplayMember = "Descripcion";
                cbxCategoria.SelectedIndex = -1;

                if (articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtPrecio.Text = articulo.Precio.ToString();
                    txtImagenUrl.Text = articulo.ImagenUrl;
                    cargarImagen(articulo.ImagenUrl);
                    cbxMarca.SelectedValue = articulo.NombreMarca.Id;
                    cbxCategoria.SelectedValue = articulo.TipoCategoria.Id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void cargarImagen(string imagen)
        {
            try
            {
                pbxImagen.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxImagen.Load("https://www.pulsecarshalton.co.uk/wp-content/uploads/2016/08/jk-placeholder-image-300x203.jpg");
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (articulo == null)
                    articulo = new Articulo();
                if (validarCampos())
                    return;
                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                articulo.ImagenUrl = txtImagenUrl.Text;
                articulo.NombreMarca = (Marca)cbxMarca.SelectedItem;
                articulo.TipoCategoria = (Categoria)cbxCategoria.SelectedItem;

                if (articulo.Id != 0)
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("El artículo se ha modificado con éxito");
                }
                else
                {
                negocio.agregar(articulo);
                MessageBox.Show("El artículo se ha agregado con éxito");
                }
                
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor rellene el formulario correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtImagenUrl_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtImagenUrl.Text);
        }

        private bool validarCampos()
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("El campo 'Código' es obligatorio");
                return true;
            }
            if (txtNombre.Text == "")
            {
                MessageBox.Show("El campo 'Nombre' es obligatorio");
                return true;
            }
            if (!(campoPrecio(txtPrecio.Text)))
            {
                MessageBox.Show("El campo 'Precio' debe ser en números");
                return true;
            }
            if (cbxMarca.SelectedItem == null)
            {
                MessageBox.Show("Por favor seleccione la marca");
                return true;
            }
            if (cbxCategoria.SelectedItem == null)
            {
                MessageBox.Show("Por favor seleccione la categoría");
                return true;
            }

            return false;
        }

        public bool campoPrecio(string campo)
        {
            foreach (char item in campo)
            {
                if (!(char.IsNumber(item)))
                    return false;
            }
            return true;
        }
    }
}
