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
    public partial class Username : Form
    {
        public Username()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Username_Load(object sender, EventArgs e)
        {
            var db = new ProyectoContext();
            typeemp.DataSource = db.TipoEmployees.ToList();
            typeemp.DisplayMember = "type";
            typeemp.ValueMember = "Id";
        }

        private void createuser_Click(object sender, EventArgs e)
        {
            bool auxiliar = namecmb.Text.Length > 0 && emailcmb.Text.Length > 0  && adresscmb.Text.Length >0 && user.Text.Length > 0 && password.Text.Length > 0;
            
           if (auxiliar)
            {
                string name = namecmb.Text;
                string email = emailcmb.Text;
                string adress = adresscmb.Text;
                TipoEmployee tipo = (TipoEmployee)typeemp.SelectedItem;
                string user1 = user.Text;
                string pass = password.Text;
                

                var db = new ProyectoContext();

                TipoEmployee tipo2 = db.Set<TipoEmployee>()
                        .SingleOrDefault(p => p.Id == tipo.Id);
               
                Employee u = new Employee(name, email, adress, user1, pass, tipo2);
                db.Add(u);
                db.SaveChanges();

                MessageBox.Show("¡Usuario creado exitosamente!", "Proyecto final",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                

            }
            else 
            {
                MessageBox.Show("¡Datos invalidos!", "Proyecto final",
                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Hide();
            }
            

            
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
