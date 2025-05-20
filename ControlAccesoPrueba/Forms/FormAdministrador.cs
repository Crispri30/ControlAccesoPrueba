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
                    MessageBox.Show("Error: Tipo de rol no válido.");
                }

                var repo = new EmpleadoRepository();
                repo.AgregarEmpleado(empleadoID, nombre, rolseleccionado, zonaAcceso);
                MessageBox.Show("Empleado agregado correctamente");

                txtID.Clear();
                txtNombre.Clear();
                txtZona.Clear();
                cmbRol.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int empleadoID = int.Parse(txtID.Text);
                var repo = new EmpleadoRepository();
                repo.EliminarEmpleado(empleadoID);

                txtID.Clear();
                txtNombre.Clear();
                txtZona.Clear();
                cmbRol.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int empleadoID = int.Parse(txtID.Text);
                string nombre = txtNombre.Text;
                string zonaAcceso = txtZona.Text;

                if (!Enum.TryParse(cmbRol.SelectedItem.ToString(), out RolEmpleado rolseleccionado))
                {
                    MessageBox.Show("Error: Tipo de rol no válido.");
                }

                var repo = new EmpleadoRepository();
                repo.ActualizarEmpleado(empleadoID, nombre, rolseleccionado, zonaAcceso);

                txtID.Clear();
                txtNombre.Clear();
                txtZona.Clear();
                cmbRol.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttAgregarVis_Click(object sender, EventArgs e)
        {
            try
            {
                int visitanteID = int.Parse(txtIDVis.Text);
                string nombreVisitante = txtNombreVis.Text;
                string telefono = txtTelefono.Text;
                string motivoVisita = txtMotivoVisita.Text;

                var repo = new VisitanteRepository();
                repo.AgregarVisitante(visitanteID, nombreVisitante, telefono, motivoVisita);

                txtIDVis.Clear();
                txtNombreVis.Clear();
                txtTelefono.Clear();
                txtMotivoVisita.Clear();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttActualizarVis_Click(object sender, EventArgs e)
        {
            try
            {
                int visitanteID = int.Parse(txtIDVis.Text);
                string nombreVisitante = txtNombreVis.Text;
                string telefono = txtTelefono.Text;
                string motivoVisita = txtMotivoVisita.Text;

                var repo = new VisitanteRepository();
                repo.ActualizarVisitantes(visitanteID, nombreVisitante, telefono, motivoVisita);

                txtIDVis.Clear();
                txtNombreVis.Clear();
                txtTelefono.Clear();
                txtMotivoVisita.Clear();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttEliminarVis_Click(object sender, EventArgs e)
        {
            try
            {
                int visitanteID = int.Parse(txtIDVis.Text);
              
                var repo = new VisitanteRepository();
                repo.EliminarVisitantes(visitanteID);

                txtIDVis.Clear();
                txtNombreVis.Clear();
                txtTelefono.Clear();
                txtMotivoVisita.Clear();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
