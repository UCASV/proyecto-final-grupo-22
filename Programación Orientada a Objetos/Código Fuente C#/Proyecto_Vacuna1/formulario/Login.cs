using Patron01;
using Proyecto_Vacuna.model;
using Proyecto_Vacuna1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proyecto_Final
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Createuser_Click(object sender, EventArgs e)
        {
            Username Newusername = new Username();
            Newusername.ShowDialog();
            this.Hide();
        }

        private void inicio_sesion_Click(object sender, EventArgs e)
        {
            var db = new ProyectoContext();

            List<Employee> employees = db.Employees.ToList();

            string usuario = usuarioText.Text;
            string contraseña = contraseñaText.Text;

            var usuariolist = employees
                .Where(U => U.user == usuario
                && U.password == contraseña)
                .ToList();

            bool encontrado = usuariolist.Count() > 0;

            if (encontrado)
            {
                MessageBox.Show("¡Bienvenido!", "Proyecto final",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Employee u = usuariolist[0];
                Crearcita crear = new Crearcita();
                crear.ShowDialog();

            }
            else
                MessageBox.Show("Empleado no existe en la base de datos", "Proyecto final",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
