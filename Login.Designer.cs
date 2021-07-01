
namespace Proyecto_Final
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.inicio_sesion = new System.Windows.Forms.Button();
            this.Createuser = new System.Windows.Forms.Button();
            this.contraseñaText = new System.Windows.Forms.TextBox();
            this.usuarioText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inicio_sesion
            // 
            this.inicio_sesion.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inicio_sesion.Location = new System.Drawing.Point(758, 593);
            this.inicio_sesion.Name = "inicio_sesion";
            this.inicio_sesion.Size = new System.Drawing.Size(287, 43);
            this.inicio_sesion.TabIndex = 0;
            this.inicio_sesion.Text = "Iniciar Sesión";
            this.inicio_sesion.UseVisualStyleBackColor = true;
            this.inicio_sesion.Click += new System.EventHandler(this.inicio_sesion_Click);
            // 
            // Createuser
            // 
            this.Createuser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Createuser.Location = new System.Drawing.Point(162, 594);
            this.Createuser.Name = "Createuser";
            this.Createuser.Size = new System.Drawing.Size(287, 42);
            this.Createuser.TabIndex = 2;
            this.Createuser.Text = "Crear Nuevo Usuario";
            this.Createuser.UseVisualStyleBackColor = true;
            this.Createuser.Click += new System.EventHandler(this.Createuser_Click);
            // 
            // contraseñaText
            // 
            this.contraseñaText.Location = new System.Drawing.Point(546, 462);
            this.contraseñaText.Multiline = true;
            this.contraseñaText.Name = "contraseñaText";
            this.contraseñaText.Size = new System.Drawing.Size(385, 46);
            this.contraseñaText.TabIndex = 3;
            // 
            // usuarioText
            // 
            this.usuarioText.Location = new System.Drawing.Point(546, 344);
            this.usuarioText.Multiline = true;
            this.usuarioText.Name = "usuarioText";
            this.usuarioText.Size = new System.Drawing.Size(385, 46);
            this.usuarioText.TabIndex = 4;
            this.usuarioText.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1209, 713);
            this.Controls.Add(this.usuarioText);
            this.Controls.Add(this.contraseñaText);
            this.Controls.Add(this.Createuser);
            this.Controls.Add(this.inicio_sesion);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button inicio_sesion;
        
        private System.Windows.Forms.Button Createuser;
        private System.Windows.Forms.TextBox contraseñaText;
        private System.Windows.Forms.TextBox usuarioText;
    }
}

