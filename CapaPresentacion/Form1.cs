using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocio;


namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        //TODO:Cargar la lógica de negocio que se conecta con la base de datos
        private readonly LibroBLL libroBLL = new LibroBLL();


        public Form1()
        {
            InitializeComponent();

            //TODO:Llenar el combo con los tipos de libros disponibles
            cmbTipoLibro.Items.AddRange(new string[] { "Impreso", "Digital" });
            cmbTipoLibro.SelectedIndex = 0;

            //TODO:Ajustar campos visibles según tipo seleccionado
            AjustarCamposSegunTipo();
            //TODO: evitar el uso inapropiado del dgvLibros
            dgvLibros.ReadOnly = true;
        }

        //TODO:Ocultar o mostrar campos según el tipo de libro
        private void AjustarCamposSegunTipo()
        {
            bool esImpreso = cmbTipoLibro.SelectedItem.ToString() == "Impreso";

            txtEditorial.Enabled = txtPeso.Enabled = esImpreso;
            txtFormato.Enabled = txtTamanoMB.Enabled = !esImpreso;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Libro nuevoLibro;

                //TODO: Crear el objeto según el tipo seleccionado
                if (cmbTipoLibro.SelectedItem.ToString() == "Impreso")
                {
                    nuevoLibro = new LibroImpreso
                    {
                        Titulo = txtTitulo.Text.Trim(),
                        Autor = txtAutor.Text.Trim(),
                        EditorialReal = txtEditorial.Text.Trim(),
                        PesoReal = decimal.Parse(txtPeso.Text.Trim())
                    };
                }
                else
                {
                    nuevoLibro = new LibroDigital
                    {
                        Titulo = txtTitulo.Text.Trim(),
                        Autor = txtAutor.Text.Trim(),
                        FormatoReal = txtFormato.Text.Trim(),
                        TamanoReal = decimal.Parse(txtTamanoMB.Text.Trim())
                    };
                }

                //TODO: Ver si estamos editando un libro (usamos Tag para guardar el ID)
                if (txtTitulo.Tag != null)
                {
                    nuevoLibro.LibroID = (int)txtTitulo.Tag;
                    libroBLL.ModificarLibro(nuevoLibro);
                    MessageBox.Show("Libro actualizado correctamente.", "Edición completa");
                    txtTitulo.Tag = null;
                }
                else
                {
                    libroBLL.AgregarLibro(nuevoLibro);
                    MessageBox.Show("Libro agregado correctamente.", "Éxito");
                }

                //TODO: Limpiar campos y actualizar la tabla
                LimpiarCampos();
                btnListar_Click(null, null);
            }
            catch (FormatException)
            {
                MessageBox.Show("Verifica que los campos numéricos tengan formato válido.", "Error de formato");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el libro: " + ex.Message, "Error");
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                var listaLibros = libroBLL.ObtenerLibros();

                dgvLibros.DataSource = null;
                dgvLibros.AutoGenerateColumns = true;
                dgvLibros.DataSource = listaLibros;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar libros: " + ex.Message, "Error");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvLibros.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un libro para eliminar.");
                return;
            }

            try
            {
                Libro libroSeleccionado = (Libro)dgvLibros.SelectedRows[0].DataBoundItem;

                var confirm = MessageBox.Show(
                    $"¿Seguro que deseas eliminar el libro: {libroSeleccionado.Titulo}?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    libroBLL.EliminarLibro(libroSeleccionado.LibroID);
                    MessageBox.Show("Libro eliminado correctamente.");
                    btnListar_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el libro: " + ex.Message, "Error");
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvLibros.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un libro para editar.");
                return;
            }

            try
            {
                Libro libroSeleccionado = (Libro)dgvLibros.SelectedRows[0].DataBoundItem;

                txtTitulo.Text = libroSeleccionado.Titulo;
                txtAutor.Text = libroSeleccionado.Autor;

                if (libroSeleccionado is LibroImpreso impreso)
                {
                    cmbTipoLibro.SelectedItem = "Impreso";
                    txtEditorial.Text = impreso.Editorial;
                    txtPeso.Text = impreso.Peso.ToString();
                }
                else if (libroSeleccionado is LibroDigital digital)
                {
                    cmbTipoLibro.SelectedItem = "Digital";
                    txtFormato.Text = digital.Formato;
                    txtTamanoMB.Text = digital.TamanoMB.ToString();
                }

                AjustarCamposSegunTipo();
                txtTitulo.Tag = libroSeleccionado.LibroID;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar libro para editar: " + ex.Message, "Error");
            }
        }

        //TODO:Limpiar todos los campos del formulario
        private void LimpiarCampos()
        {
            txtTitulo.Clear();
            txtAutor.Clear();
            txtEditorial.Clear();
            txtPeso.Clear();
            txtFormato.Clear();
            txtTamanoMB.Clear();
            cmbTipoLibro.SelectedIndex = 0;
            AjustarCamposSegunTipo();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void cmbTipoLibro_SelectedIndexChanged(object sender, EventArgs e)
        {
            AjustarCamposSegunTipo();
        }

       
    }
}
