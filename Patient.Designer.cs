
namespace Patron01
{
    partial class Patient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patient));
            this.dui = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.direccion = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.tipo_institucion = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.enfermedadcmb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dui
            // 
            this.dui.Location = new System.Drawing.Point(328, 271);
            this.dui.MaxLength = 10;
            this.dui.Name = "dui";
            this.dui.Size = new System.Drawing.Size(248, 31);
            this.dui.TabIndex = 1;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(328, 336);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(248, 31);
            this.name.TabIndex = 2;
            // 
            // direccion
            // 
            this.direccion.Location = new System.Drawing.Point(328, 407);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(248, 31);
            this.direccion.TabIndex = 3;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(328, 469);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(328, 31);
            this.phone.TabIndex = 4;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(446, 534);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(248, 31);
            this.email.TabIndex = 5;
            // 
            // tipo_institucion
            // 
            this.tipo_institucion.FormattingEnabled = true;
            this.tipo_institucion.Items.AddRange(new object[] {
            "Adultos mayores de 60 años",
            "Personal integrado de la salud",
            "Encargados de la seguridad nacional ",
            "Personas mayores de 18 años con enfermedad no transmisible o discapacidad",
            "Personal del gobierno actual"});
            this.tipo_institucion.Location = new System.Drawing.Point(446, 662);
            this.tipo_institucion.Name = "tipo_institucion";
            this.tipo_institucion.Size = new System.Drawing.Size(248, 33);
            this.tipo_institucion.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(949, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 50);
            this.button1.TabIndex = 7;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(949, 523);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 50);
            this.button2.TabIndex = 8;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // enfermedadcmb
            // 
            this.enfermedadcmb.FormattingEnabled = true;
            this.enfermedadcmb.Items.AddRange(new object[] {
            "Hipertension arterial",
            "Diabetes",
            "Sobrepeso",
            "Dislipidemia",
            "Enfermedad renal cronica",
            "Ninguna"});
            this.enfermedadcmb.Location = new System.Drawing.Point(446, 591);
            this.enfermedadcmb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.enfermedadcmb.Name = "enfermedadcmb";
            this.enfermedadcmb.Size = new System.Drawing.Size(248, 33);
            this.enfermedadcmb.TabIndex = 9;
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1209, 713);
            this.Controls.Add(this.enfermedadcmb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tipo_institucion);
            this.Controls.Add(this.email);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.name);
            this.Controls.Add(this.dui);
            this.Name = "Patient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Patient";
            this.Load += new System.EventHandler(this.Patient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.TextBox dui;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.ComboBox tipo_institucion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox enfermedadcmb;
    }
}