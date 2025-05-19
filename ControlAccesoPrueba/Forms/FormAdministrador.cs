using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlAccesoPrueba.Repositorios;
using ControlAccesoPrueba.Modelos;

namespace ControlAccesoPrueba.Forms
{
    public partial class FormAdministrador : Form
    {
        public FormAdministrador()
        {
            InitializeComponent();
        }

        private void FormAdministrador_Load(object sender, EventArgs e)
        {
            cmbRol.DataSource = Enum.GetValues(typeof(RolEmpleado));
        }

        private void bttAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int empleadoID = int.Parse(txtID.Text);
                string nombre = txtNombre.Text;
                string zonaAcceso = txtZona.Text;

                if (!Enum.TryParse(cmbRol.SelectedItem.ToString(), out RolEmpleado rolseleccionado))
                {
                    MessageBox.Show("Error: Tipo de habitación no válido.");
                }

                var repo = new EmpleadoRepository();
                repo.AgregarEmpleado(empleadoID, nombre, rolseleccionado, zonaAcceso);
                MessageBox.Show("Empleado agregado correctamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
