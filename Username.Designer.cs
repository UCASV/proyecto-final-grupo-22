
namespace Proyecto_Final
{
    partial class Username
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Username));
            this.namecmb = new System.Windows.Forms.TextBox();
            this.emailcmb = new System.Windows.Forms.TextBox();
            this.adresscmb = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.typeemp = new System.Windows.Forms.ComboBox();
            this.cancel = new System.Windows.Forms.Button();
            this.createuser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // namecmb
            // 
            this.namecmb.Location = new System.Drawing.Point(359, 173);
            this.namecmb.Name = "namecmb";
            this.namecmb.Size = new System.Drawing.Size(360, 31);
            this.namecmb.TabIndex = 0;
            // 
            // emailcmb
            // 
            this.emailcmb.Location = new System.Drawing.Point(359, 250);
            this.emailcmb.Name = "emailcmb";
            this.emailcmb.Size = new System.Drawing.Size(360, 31);
            this.emailcmb.TabIndex = 1;
            // 
            // adresscmb
            // 
            this.adresscmb.Location = new System.Drawing.Point(359, 336);
            this.adresscmb.Name = "adresscmb";
            this.adresscmb.Size = new System.Drawing.Size(360, 31);
            this.adresscmb.TabIndex = 2;
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(359, 509);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(360, 31);
            this.user.TabIndex = 3;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(359, 574);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(360, 31);
            this.password.TabIndex = 4;
            // 
            // typeemp
            // 
            this.typeemp.FormattingEnabled = true;
            this.typeemp.Items.AddRange(new object[] {
            "Enfermero",
            "Doctor",
            "Pasante",
            "Policia",
            "Soldado"});
            this.typeemp.Location = new System.Drawing.Point(419, 423);
            this.typeemp.Name = "typeemp";
            this.typeemp.Size = new System.Drawing.Size(360, 33);
            this.typeemp.TabIndex = 5;
            this.typeemp.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancel.Location = new System.Drawing.Point(902, 622);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(249, 38);
            this.cancel.TabIndex = 6;
            this.cancel.Text = "Cancelar";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // createuser
            // 
            this.createuser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createuser.Location = new System.Drawing.Point(902, 524);
            this.createuser.Name = "createuser";
            this.createuser.Size = new System.Drawing.Size(249, 38);
            this.createuser.TabIndex = 7;
            this.createuser.Text = "Crear Usuario";
            this.createuser.UseVisualStyleBackColor = true;
            this.createuser.Click += new System.EventHandler(this.createuser_Click);
            // 
            // Username
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1209, 713);
            this.Controls.Add(this.createuser);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.typeemp);
            this.Controls.Add(this.password);
            this.Controls.Add(this.user);
            this.Controls.Add(this.adresscmb);
            this.Controls.Add(this.emailcmb);
            this.Controls.Add(this.namecmb);
            this.Name = "Username";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Username";
            this.Load += new System.EventHandler(this.Username_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox namecmb;
        private System.Windows.Forms.TextBox emailcmb;
        private System.Windows.Forms.TextBox adresscmb;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.ComboBox typeemp;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button createuser;
    }
}