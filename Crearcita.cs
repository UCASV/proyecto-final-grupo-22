using Microsoft.EntityFrameworkCore;
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
using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace Patron01
{
    public partial class Crearcita : Form
    {
        Pacient logged;
        List<DateVaccine> dateVaccines;
        List<Index_cabin> index;
        List<Pacient> pacients;

        public Crearcita(Pacient u)
        {
            InitializeComponent();
            logged = u;
        }
        public Crearcita()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       
        private void cita_btn_Click(object sender, EventArgs e)
        {
            var db = new ProyectoContext();
            cabina_combox.DataSource = db.Index_Cabins.ToList();
            cabina_combox.DisplayMember = "index";
            cabina_combox.ValueMember = "id";

            tipo_vacuna.DataSource = db.TypeVaccines.ToList();
            tipo_vacuna.DisplayMember = "type_Vaccine";
            tipo_vacuna.ValueMember = "id";

            
            

            List<Pacient> pacients = db.Pacients.ToList();
            string Dui = id_crearcita.Text;
            string name = nametext.Text;

            var pacientelist = pacients
                .Where(u => u.DUI.Equals(Dui))
               .ToList();
            bool encontrado = pacientelist.Count() > 0;

            //string aux = "00035819";
            Console.WriteLine(encontrado);
            if (encontrado)

            {
                Pacient pc = db.Set<Pacient>()
                    .SingleOrDefault(u => u.DUI == id_crearcita.Text);
                DateTime datetime = date_crearcita.Value;
                String fecha = date_crearcita.Value.ToString("dd/MM/yyyy");

                Index_cabin index = (Index_cabin)cabina_combox.SelectedItem;
                TypeVaccine type = (TypeVaccine)tipo_vacuna.SelectedItem;
                Dosi nueva_date =
                    db.Set<Dosi>().SingleOrDefault(d => d.id == 1);






                Index_cabin index1 = db.Set<Index_cabin>()
                     .SingleOrDefault(p => p.id == index.id);
                TypeVaccine type1 = db.Set<TypeVaccine>()
                    .SingleOrDefault(p => p.id == type.id);
               
                DateVaccine dateVaccines1 = new DateVaccine(index1, pc, datetime, type1, nueva_date, name);


                db.Add(dateVaccines1);
                db.SaveChanges();

                MessageBox.Show("¡Cita creada exitosamente!", "Proyecto final",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                tab_vacunas.SelectedIndex = 1;
                PdfDocument pdf = new PdfDocument(new PdfWriter(new FileStream("/Users/Administrador/Desktop/cita.pdf", FileMode.Create, FileAccess.Write)));
                Document document = new Document(pdf);
                
                document.Add(new Paragraph("DUI: " + Dui));
                document.Add(new Paragraph("Nombre: "+ name));
                document.Add(new Paragraph("Fecha: "+fecha));
                document.Add(new Paragraph("Tipo de vacuna: " +type1.type_Vaccine));
                document.Add(new Paragraph("Dosis: " +nueva_date.dosis));
                document.Add(new Paragraph("Cabina: " + index1.index));

                document.Close();






            }
            else
                
                MessageBox.Show("El DUI no coincide con ningun paciente", "Proyecto final",
                MessageBoxButtons.OK, MessageBoxIcon.Information);




        }
        private void OnLoadTab_Vacunas()
        {
            var db = new ProyectoContext();
            data_mostrar.RowCount = 1;
            dateVaccines = db.DateVaccines.Include(r => r.Cabin1).Include(r => r.Pacient).Include(r=> r.Type).Include(r => r.dosis).ToList();
            int rowid;
            foreach (DateVaccine date in dateVaccines) 
            {
                rowid = data_mostrar.Rows.Add();
                //data_mostrar.Rows[rowid].Cells[0].Value = date.id;
                data_mostrar.Rows[rowid].Cells[0].Value = date.Pacient.DUI;
                data_mostrar.Rows[rowid].Cells[1].Value = date.Pacient.name;
                data_mostrar.Rows[rowid].Cells[2].Value = date.date;
                data_mostrar.Rows[rowid].Cells[3].Value = date.Cabin1.index;
                data_mostrar.Rows[rowid].Cells[4].Value = date.Type.type_Vaccine;
                data_mostrar.Rows[rowid].Cells[5].Value = date.dosis.dosis;

            }
        }

       

        private void Crearcita_Load_1(object sender, EventArgs e)
        {

            OnLoadTab_Vacunas();
        }

        private void tab_vacunas_TabIndexChanged(object sender, EventArgs e)
        {
            if (tab_vacunas.SelectedIndex == 1)
            {
                OnLoadTab_Vacunas();
            }
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            var db = new ProyectoContext();

            cabina_dosis.DataSource = db.Index_Cabins.ToList();
            cabina_dosis.DisplayMember = "index";
            cabina_dosis.ValueMember = "id";
            
            tipo_segunda.DataSource = db.TypeVaccines.ToList();
            tipo_segunda.DisplayMember = "type_Vaccine";
            tipo_segunda.ValueMember = "id";


            List<Pacient> pacients = db.Pacients.ToList();
            List<DateVaccine> date = db.DateVaccines.ToList();
            string id = id_actualizar.Text;
            string name1 = nombre_actualizar.Text;
            var datelist = dateVaccines
                .Where(u => u.id.Equals(id))
                .ToList();
            var clientelist = date
                .Where(u => u.Pacient.DUI.Equals(id))
               .ToList();
            bool encontrado = clientelist.Count() > 0 ;




            if (encontrado)

            {



                Dosi nueva_date =
                     db.Set<Dosi>().SingleOrDefault(d => d.id == 2);



                TypeVaccine type = (TypeVaccine)tipo_segunda.SelectedItem;
                TypeVaccine type1 = db.Set<TypeVaccine>()
                   .SingleOrDefault(p => p.id == type.id);





                Pacient dv = db.Set<Pacient>()
                    .SingleOrDefault(u => u.DUI == id_actualizar.Text);
                DateTime fecha = clientelist[0].date;
               Convert.ToDateTime(fecha);
               fecha = fecha.AddDays(42);

                String fecha1 = clientelist[0].date.ToString("dd/MM/yyyy");

                Index_cabin index = (Index_cabin)cabina_dosis.SelectedItem;
                Index_cabin index1 = db.Set<Index_cabin>()
                     .SingleOrDefault(p => p.id == index.id);
                
                
               
               DateVaccine dateVaccines1 = new DateVaccine(index1, dv, fecha, type1, nueva_date, name1);
                db.Add(dateVaccines1);
                db.SaveChanges();

                MessageBox.Show("¡Cita creada exitosamente!", "Proyecto final",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                tab_vacunas.SelectedIndex = 1;

                tab_vacunas.SelectedIndex = 1;
                PdfDocument pdf = new PdfDocument(new PdfWriter(new FileStream("/Users/Administrador/Desktop/segunda_dosis.pdf", FileMode.Create, FileAccess.Write)));
                Document document = new Document(pdf);

                document.Add(new Paragraph("DUI: " + id));
                document.Add(new Paragraph("Nombre: " + name1));
                document.Add(new Paragraph("Fecha: " + fecha1));
                document.Add(new Paragraph("Tipo de vacuna: " + type1.type_Vaccine));
                document.Add(new Paragraph("Dosis: " + nueva_date.dosis));
                document.Add(new Paragraph("Cabina: " + index1.index));

                document.Close();

            }
            else

                MessageBox.Show("El DUI no coincide con ningun paciente", "Proyecto final",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Patient crear = new Patient();
            crear.ShowDialog();
        }

        private void dia_vacunabtn_Click(object sender, EventArgs e)
        {
            var db = new ProyectoContext();
            tipocmb.DataSource = db.TypeVaccines.ToList();
            tipocmb.DisplayMember = "type_Vaccine";
            tipocmb.ValueMember = "id";

            sidecmb.DataSource = db.SideEffects.ToList();
            sidecmb.DisplayMember = "side";
            sidecmb.ValueMember = "id";

            dosiscmb.DataSource = db.Dosis.ToList();
            dosiscmb.DisplayMember = "dosis";
            dosiscmb.ValueMember = "id";

            cabincmb.DataSource = db.Index_Cabins.ToList();
            cabincmb.DisplayMember = "index";
            cabincmb.ValueMember = "id";

            string dui = DUI.Text;
            List<Pacient> date = db.Pacients.ToList();
            var clientelist = date
              .Where(u => u.DUI.Equals(dui))
             .ToList();
            bool encontrado = clientelist.Count() > 0;

            if (encontrado)
            {

                Dosi dosi = (Dosi)dosiscmb.SelectedItem;
                Dosi dosi1 = db.Set<Dosi>()
                   .SingleOrDefault(p => p.id == dosi.id);

                TypeVaccine type = (TypeVaccine)tipocmb.SelectedItem;
                TypeVaccine type1 = db.Set<TypeVaccine>()
                   .SingleOrDefault(p => p.id == type.id);

                SideEffect side = (SideEffect)sidecmb.SelectedItem;
                SideEffect side1 = db.Set<SideEffect>()
                    .SingleOrDefault(p => p.id == side.id);

                Index_cabin index = (Index_cabin)cabincmb.SelectedItem;
                Index_cabin index1 = db.Set<Index_cabin>()
                    .SingleOrDefault(p => p.id == index.id);


                Pacient dv = db.Set<Pacient>()
                    .SingleOrDefault(u => u.DUI == DUI.Text);

                DayVaccine dateVaccines1 = new DayVaccine(dv, index1, side1, type1, dosi1);
                db.Add(dateVaccines1);
                db.SaveChanges();

                MessageBox.Show("¡Registro creado exitosamente!", "Proyecto final",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                tab_vacunas.SelectedIndex = 5;







            }
            else
            {
               MessageBox.Show("El DUI no coincide con ningun paciente", "Proyecto final",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }
    }
}
