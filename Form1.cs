using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestiónTablaEmpleados
{
    public partial class FormularioEmpleados : Form
    {
        public FormularioEmpleados()
        {
            InitializeComponent();
        }

        private void FormularioEmpleados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'empresaDataSet1.TEmpleados' Puede moverla o quitarla según sea necesario.
            this.tEmpleadosTableAdapter.Fill(this.empresaDataSet1.TEmpleados);
            if(empresaDataSet1.TEmpleados.Rows.Count == 0)
            {
                grupoBoxDatosEmpleado.Enabled = false;
                groupoBoxDatosEmpresa.Enabled = false;
                botonEliminar.Enabled = false;
                botonPrimero.Enabled = false;
                botonAnterior.Enabled = false;
                botonSiguiente.Enabled = false;
                botonUltimo.Enabled = false;
                botonGuardar.Enabled = false;
                botonCancelar.Enabled = false;
                botonAceptar.Enabled = false;
                botonEditar.Enabled = false;
                fechanacimientoDateTimePicker.Visible = false;  
                fechacontratoDateTimePicker.Visible = false;      
                fotoPictureBox.Enabled = false; 
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tEmpleadosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tEmpleadosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.empresaDataSet1);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void botonAnadir_Click(object sender, EventArgs e)
        {
            grupoBoxDatosEmpleado.Enabled = true;
            groupoBoxDatosEmpresa.Enabled = true;   
            botonCancelar.Enabled = true;
            //botonGuardar.Enabled = true;
            fechanacimientoDateTimePicker.Visible = true;
            fechacontratoDateTimePicker.Visible = true;
            botonAceptar.Enabled = true;
            fotoPictureBox.Enabled = true;  
            //this.Validate();
            //this.tEmpleadosBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.empresaDataSet1);            
            idEmpleadoLabel1.Text = (empresaDataSet1.TEmpleados.Rows.Count + 1).ToString();
        }

        private void botonPrimero_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {

        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            FormularioEmpleados_Load(sender, e);
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            FormularioEmpleados_Load(sender, e);
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            //Form1_FormClosing(sender, new FormClosingEventArgs(CloseReason.UserClosing, false));
            this.Close();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Deseas salir de la aplicación?",
                "Salir",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (respuesta == DialogResult.No)
            {
                e.Cancel = true; // Cancela el cierre
            }
            else
            {
                //Application.Exit(); // Cierra la aplicación
            }
        }

        private void errorProvider1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Haz clic en el icono del ErrorProvider.");
            MessageBox.Show("Haz clic en el icono del Error.");
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            // Validaciones existentes
            if (string.IsNullOrWhiteSpace(nombreTextBox.Text))
                errorProvider1.SetError(nombreTextBox, "El nombre es obligatorio.");
            else
                errorProvider1.SetError(nombreTextBox, "");

            if (string.IsNullOrWhiteSpace(apellidounoTextBox.Text))
                errorProvider1.SetError(apellidounoTextBox, "El primer apellido es obligatorio.");
            else
                errorProvider1.SetError(apellidounoTextBox, "");

            if (string.IsNullOrWhiteSpace(apellidodosTextBox.Text))
                errorProvider1.SetError(apellidodosTextBox, "El segundo apellido es obligatorio.");
            else
                errorProvider1.SetError(apellidodosTextBox, "");

            if (string.IsNullOrWhiteSpace(dniTextBox.Text))
                errorProvider1.SetError(dniTextBox, "El DNI es obligatorio.");
            else
                errorProvider1.SetError(dniTextBox, "");

            if (string.IsNullOrWhiteSpace(direccionTextBox.Text))
                errorProvider1.SetError(direccionTextBox, "La dirección es obligatoria.");
            else
                errorProvider1.SetError(direccionTextBox, "");

            if (string.IsNullOrWhiteSpace(ciudadTextBox.Text))
                errorProvider1.SetError(ciudadTextBox, "La ciudad es obligatoria.");
            else
                errorProvider1.SetError(ciudadTextBox, "");

            if (string.IsNullOrWhiteSpace(telefonoTextBox.Text))
                errorProvider1.SetError(telefonoTextBox, "El teléfono es obligatorio.");
            else
                errorProvider1.SetError(telefonoTextBox, "");

            if (string.IsNullOrWhiteSpace(ecorreoTextBox.Text))
                errorProvider1.SetError(ecorreoTextBox, "El correo electrónico es obligatorio.");
            else
                errorProvider1.SetError(ecorreoTextBox, "");

            if (string.IsNullOrWhiteSpace(puestoTextBox.Text))
                errorProvider1.SetError(puestoTextBox, "El puesto es obligatorio.");
            else
                errorProvider1.SetError(puestoTextBox, "");

            if (string.IsNullOrWhiteSpace(departamentoTextBox.Text))
                errorProvider1.SetError(departamentoTextBox, "El departamento es obligatorio.");
            else
                errorProvider1.SetError(departamentoTextBox, "");

            if (string.IsNullOrWhiteSpace(salarioTextBox.Text))
                errorProvider1.SetError(salarioTextBox, "El salario es obligatorio.");
            else
                errorProvider1.SetError(salarioTextBox, "");

            if (string.IsNullOrWhiteSpace(estadoTextBox.Text))
                errorProvider1.SetError(estadoTextBox, "El estado es obligatorio.");
            else
                errorProvider1.SetError(estadoTextBox, "");

            // Si hay errores, no insertar
            bool hasErrors = new[] {
                nombreTextBox, apellidounoTextBox, apellidodosTextBox,
                dniTextBox, direccionTextBox, ciudadTextBox,
                telefonoTextBox, ecorreoTextBox, puestoTextBox,
                departamentoTextBox, salarioTextBox, estadoTextBox
            }.Any(tb => !string.IsNullOrEmpty(errorProvider1.GetError(tb)));

            if (hasErrors)
            {
                MessageBox.Show("Corrige los errores antes de aceptar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Preparar valores
                int idEmpleado = 0;
                int.TryParse(idEmpleadoLabel1.Text, out idEmpleado);

                string nombre = nombreTextBox.Text.Trim();
                string apellido1 = apellidounoTextBox.Text.Trim();
                string apellido2 = apellidodosTextBox.Text.Trim();
                DateTime fechaNacimiento = fechanacimientoDateTimePicker.Value.Date;
                string dni = string.IsNullOrWhiteSpace(dniTextBox.Text) ? "" : dniTextBox.Text.Trim();
                string direccion = string.IsNullOrWhiteSpace(direccionTextBox.Text) ? null : direccionTextBox.Text.Trim();
                string ciudad = string.IsNullOrWhiteSpace(ciudadTextBox.Text) ? null : ciudadTextBox.Text.Trim();
                string telefono = string.IsNullOrWhiteSpace(telefonoTextBox.Text) ? null : telefonoTextBox.Text.Trim();
                string correo = string.IsNullOrWhiteSpace(ecorreoTextBox.Text) ? null : ecorreoTextBox.Text.Trim();
                string puesto = string.IsNullOrWhiteSpace(puestoTextBox.Text) ? "" : puestoTextBox.Text.Trim();
                string departamento = string.IsNullOrWhiteSpace(departamentoTextBox.Text) ? "" : departamentoTextBox.Text.Trim();
                DateTime fechaContrato = fechacontratoDateTimePicker.Value.Date;

                decimal? salario = null;
                if (decimal.TryParse(salarioTextBox.Text, out decimal parsedSalario))
                    salario = parsedSalario;

                int estado = 1;
                if (!int.TryParse(estadoTextBox.Text, out estado))
                    estado = 1;

                // Convertir foto a byte[]
                byte[] fotoBytes;
                if (fotoPictureBox.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        // Guardar como PNG para consistencia; puedes ajustar el formato si lo deseas
                        fotoPictureBox.Image.Save(ms, ImageFormat.Png);
                        fotoBytes = ms.ToArray();
                    }
                }
                else
                {
                    // No puede ser null porque el TableAdapter lanza excepción si es null.
                    fotoBytes = new byte[0];
                }

              

                // Refrescar datos en el DataSet y BindingSource
                this.tEmpleadosTableAdapter.Fill(this.empresaDataSet1.TEmpleados);
                MessageBox.Show("Empleado insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Opcional: desactivar edición o limpiar campos
                grupoBoxDatosEmpleado.Enabled = false;
                groupoBoxDatosEmpresa.Enabled = false;
                botonAceptar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nombreLabel_Click(object sender, EventArgs e)
        {

        }

        private void apellidodosLabel_Click(object sender, EventArgs e)
        {

        }

        private void tEmpleadosBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void fotoPictureBox_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Seleccionar imagen";
                dialog.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Intentar cargar la imagen
                        Image img = Image.FromFile(dialog.FileName);

                        fotoPictureBox.Image = img;
                        fotoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    catch (Exception ex)
                    {
                        // Avisar al usuario del error
                        MessageBox.Show(
                            "No se pudo abrir la imagen.\nDetalles: " + ex.Message+ " Compruebe que la imagen es correcta.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }
            }
        }
    }    
}
