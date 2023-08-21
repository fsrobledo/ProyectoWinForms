using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Presentacion
{
    public partial class frmPrincipal : Form
    {
        private List<Articulo> listaArticulo;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            cargarFiltros();
            cargar();
        }

        private void cargarFiltros()
        {
            tslEstado.Text = "1 Artículo Seleccionado";
            cbxFiltroMarca.Items.Add("");
            cbxFiltroMarca.Items.Add("Samsung");
            cbxFiltroMarca.Items.Add("Apple");
            cbxFiltroMarca.Items.Add("Sony");
            cbxFiltroMarca.Items.Add("Huawei");
            cbxFiltroMarca.Items.Add("Motorola");

            cbxFiltroCategoria.Items.Add("");
            cbxFiltroCategoria.Items.Add("Celulares");
            cbxFiltroCategoria.Items.Add("Televisores");
            cbxFiltroCategoria.Items.Add("Media");
            cbxFiltroCategoria.Items.Add("Audio");
        }

        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulo = negocio.listar();
                dgvArticulos.DataSource = listaArticulo;
                ocultarColumnas();
                cargarImagen(listaArticulo[0].ImagenUrl);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
            dgvArticulos.Columns["Id"].Visible = false;
        }

        private void cargarImagen(string imagen)
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

        private void eliminar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo artSeleccionado = new Articulo();
            try
            {
                DialogResult dialogo = MessageBox.Show("¿Está seguro que desea eliminar este artículo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogo == DialogResult.Yes)
                {
                    artSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    negocio.eliminarItem(artSeleccionado.Id);
                }
                cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tsmNuevoArticulo_Click(object sender, EventArgs e)
        {
            btnAgregar_Click(sender, e);
        }

        private void tsmModificar_Click(object sender, EventArgs e)
        {
            btnModificar_Click(sender, e);
        }

        private void tsmEliminar_Click(object sender, EventArgs e)
        {
            btnEliminar_Click(sender, e);
        }

        private void tsmSalir_Click(object sender, EventArgs e)
        {
            DialogResult pregunta = MessageBox.Show("¿Está seguro que desea salir?", "Cerrando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (pregunta == DialogResult.Yes)
                Close();
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmArticulo alta = new frmArticulo();
            alta.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = new Articulo();
            try
            {
                if (dgvArticulos.SelectedRows.Count == 1)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    frmArticulo Modificar = new frmArticulo(seleccionado);
                    Modificar.ShowDialog();
                    cargar();
                }
                else
                    MessageBox.Show("Ningún artículo se encuentra seleccionado", "Error al seleccionar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvArticulos.SelectedRows.Count > 0)
                    eliminar();
                else
                    MessageBox.Show("Ningún artículo se encuentra seleccionado", "Error al seleccionar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvArticulos_MouseClick(object sender, MouseEventArgs e)
        {
            int cantidad = dgvArticulos.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (cantidad == 1)
                tslEstado.Text = "1 Artículo Seleccionado";
            else
                tslEstado.Text = cantidad + " Artículos Seleccionados";
        }

        private void tsmSeleccionar_Click(object sender, EventArgs e)
        {
            dgvArticulos.SelectAll();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaBusqueda;
            string busqueda = txtBuscar.Text;

            if (busqueda.Length >= 3)
                listaBusqueda = listaArticulo.FindAll(x => x.Nombre.ToUpper().Contains(busqueda.ToUpper()) || x.TipoCategoria.Descripcion.ToUpper().Contains(busqueda.ToUpper()) || x.NombreMarca.Descripcion.ToUpper().Contains(busqueda.ToUpper()));
            else
                listaBusqueda = listaArticulo;
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaBusqueda;
            ocultarColumnas();
        }

        private void tsmDetalles_Click(object sender, EventArgs e)
        {
            Articulo art = new Articulo();
            art = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmDetalles Detalles = new frmDetalles(art);
            Detalles.ShowDialog();
        }

        private void btnFiltros_Click(object sender, EventArgs e)
        {
            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                string filtroCategoria = cbxFiltroCategoria.Text;
                string filtroMarca = cbxFiltroMarca.Text;
                if (filtroCategoria != "" || filtroMarca != "")
                {
                    listaArticulo = negocio.filtrar(filtroCategoria, filtroMarca);
                    dgvArticulos.DataSource = listaArticulo;
                    ocultarColumnas();
                    if (dgvArticulos.SelectedRows.Count == 1)
                        cargarImagen(listaArticulo[0].ImagenUrl);
                }
                else
                    MessageBox.Show("Por favor seleccione un filtro", "Filtrar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            cbxFiltroCategoria.ResetText();
            cbxFiltroMarca.ResetText();
            txtBuscar.ResetText();
            cargar();
        }

        private void tsmManualDeAyuda_Click(object sender, EventArgs e)
        {
            frmAyudaUsuario ayuda = new frmAyudaUsuario();
            ayuda.ShowDialog();
        }

        private void tsmContacto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para mayor información contáctese a: Federico Robledo", "Contacto",MessageBoxButtons.OK , MessageBoxIcon.Information);
        }

        private void csmBotonDerecho_Opening(object sender, CancelEventArgs e)
        {
            dgvArticulos.Select();
        }

        private void tsmBotonDerechoModificar_Click(object sender, EventArgs e)
        {
            btnModificar_Click(sender, e);
        }

        private void tsmBotonDerechoEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void tsmBotonDerechoDetalles_Click(object sender, EventArgs e)
        {
            tsmDetalles_Click(sender, e );
        }

        private void tsmBotonDerechoSeleccionar_Click(object sender, EventArgs e)
        {
            tsmSeleccionar_Click(sender , e );
        }

    }
}
