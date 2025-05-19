using ControlAccesoPrueba.Modelos;
using ControlAccesoPrueba.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlAccesoPrueba.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BttIngresar_Click(object sender, EventArgs e)
        {
            string usuario =  TxtUsuario.Text.Trim();
            string contraseña = TxtContraseña.Text.Trim();

            UsuariosRepository repo = new UsuariosRepository();
            UsuarioLogin empleado = repo.ValidarLogin(usuario,contraseña);

            if (empleado != null)
            {
                MessageBox.Show($"¡Bienvenido {empleado.Usuario}! Rol: {empleado.Rol}");

                //Abrir forms de acuerdo al rol

                if (empleado.Rol == "Administrador")
                {
                    new FormAdministrador().Show();
                }

                if (empleado.Rol == "Seguridad")
                {
                    new FormSeguridad().Show();
                }
                //Cerrar forms actual
                this.Hide();
            }

            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
    }
}
