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

namespace Patron01
{
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool comprobar = dui.Text.Length > 0 && name.Text.Length > 0 && direccion.Text.Length > 0 && phone.Text.Length > 0 && email.Text.Length > 0;
            if (comprobar)
            {


                var db = new ProyectoContext();

                string dui1 = dui.Text;
                string name1 = name.Text;
                string adress = direccion.Text;
                string telefono = phone.Text;
                string email1 = email.Text;
                InstitutionObjective institution = (InstitutionObjective)tipo_institucion.SelectedItem;
                Disease disease = (Disease)enfermedadcmb.SelectedItem;
                
                InstitutionObjective institution1 = db.Set<InstitutionObjective>()
                       .SingleOrDefault(p => p.id == institution.id);

                Disease disease1 = db.Set<Disease>()
                    .SingleOrDefault(p => p.id == disease.id);

                Pacient u = new Pacient(dui1, name1, adress, telefono, email1, disease1, institution1);
                
                db.Add(u);
                db.SaveChanges();

                MessageBox.Show("¡Paciente registrado exitosamente!", "Proyecto final",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();


            }
            else 
            {
                MessageBox.Show("¡Datos invalidos!", "Proyecto final",
                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }



        }

        private void Patient_Load(object sender, EventArgs e)
        {
            var db = new ProyectoContext();
            tipo_institucion.DataSource = db.InstitutionObjectives.ToList();
            tipo_institucion.DisplayMember = "Institution";
            tipo_institucion.ValueMember = "id";

            enfermedadcmb.DataSource = db.Diseases.ToList();
            enfermedadcmb.DisplayMember = "disease";
            enfermedadcmb.ValueMember = "id";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
