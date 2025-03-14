using System;
using System.Data;
using System.Drawing.Text;
using Empleados;

namespace Gestor_de_empleados
{


    public partial class Forms : Form
    {

        private List<Empleado> empleados = new List<Empleado>();
        public Forms()
        {
            InitializeComponent();
        }

        private void Forms_Load(object sender, EventArgs e)
        {
            cmbCargo.DropDownStyle = ComboBoxStyle.DropDownList;

            // Definir las columnas del DataGridView
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "NOMBRE";
            dataGridView1.Columns[1].Name = "APELLIDO";
            dataGridView1.Columns[2].Name = "EDAD";
            dataGridView1.Columns[3].Name = "SALARIO";
            dataGridView1.Columns[4].Name = "CARGO";
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Bloquear la tecla
            }

        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Permitir solo números y la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Bloquear la tecla
            }

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras y la tecla de retroceso
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Bloquear la tecla
            }


        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras y la tecla de retroceso
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Bloquear la tecla
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {




        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                 string.IsNullOrWhiteSpace(txtApellido.Text) ||
                 string.IsNullOrWhiteSpace(txtEdad.Text) ||
                 string.IsNullOrWhiteSpace(txtSalario.Text) ||
                 string.IsNullOrWhiteSpace(cmbCargo.Text))
                {
                    MessageBox.Show("Por favor, llene todos los campos");
                }
                else
                {
                    Empleado nuevoEmpleado;

                    if (cmbCargo.Text == "ADMINISTRATIVO")
                    {
                        nuevoEmpleado = new Administrativo(txtNombre.Text, txtApellido.Text,
                            Convert.ToInt32(txtEdad.Text), Convert.ToInt32(txtSalario.Text));
                    }
                    else
                    {
                        nuevoEmpleado = new Tecnico(txtNombre.Text, txtApellido.Text,
                            Convert.ToInt32(txtEdad.Text), Convert.ToInt32(txtSalario.Text));
                    }

                    // Agregar el empleado a la lista
                    empleados.Add(nuevoEmpleado);

                    // Agregar los datos al DataGridView
                    dataGridView1.Rows.Add(nuevoEmpleado.Nombre, nuevoEmpleado.Apellido,
                        nuevoEmpleado.Edad, nuevoEmpleado.Salario, cmbCargo.Text);

                    MessageBox.Show("Empleado guardado con éxito");

                    // Limpiar los campos después de guardar
                    txtNombre.Clear();
                    txtApellido.Clear();
                    txtEdad.Clear();
                    txtSalario.Clear();
                    cmbCargo.SelectedIndex = -1;
                }
            }






        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            /* if (dataGridView1.CurrentRow == null)
             {
                 MessageBox.Show("Seleccione un empleado para eliminar.");
                 return;
             }

             // Obtiene el índice de la fila seleccionada en el DataGridView
             int indice = dataGridView1.CurrentRow.Index;

             if (indice >= 0 && indice < dataGridView1.Rows.Count)
             {
                 // Obtener el nombre del empleado seleccionado
                 string nombreEmpleado = dataGridView1.Rows[indice].Cells[0].Value.ToString();

                 // Buscar el empleado en la lista por nombre
                 var empleado = empleados.FirstOrDefault(emp => emp.Nombre == nombreEmpleado);

                 if (empleado != null)
                 {
                     // Marcar el empleado como inactivo (eliminación lógica)
                     empleado.Activo = false;
                     MessageBox.Show("Empleado eliminado con éxito");

                     // Actualizar la vista del DataGridView para reflejar los cambios
                     ActualizarDataGridView();
                 }
             }*/

            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;

                DialogResult confirmacion = MessageBox.Show("¿Está seguro de eliminar este empleado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    // Eliminar el empleado de la lista
                    empleados.RemoveAt(index);
                  
                    MessageBox.Show("Empleado eliminado con éxito");


                  ActualizarDataGridView();
                }

                
            }

        }

        // Método para actualizar el DataGridView con los empleados activos, listar empleados activos
        private void ActualizarDataGridView()
        {
            // Limpiar las filas actuales del DataGridView
            dataGridView1.Rows.Clear();

            // Filtrar los empleados activos
            var empleadosActivos = empleados.Where(emp => emp.Activo).ToList();

            // Agregar cada empleado activo al DataGridView
            foreach (var empleado in empleadosActivos)
            {
                dataGridView1.Rows.Add(empleado.Nombre, empleado.Apellido, empleado.Edad, empleado.Salario, empleado.Cargo);
            }
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

     

    }
}

