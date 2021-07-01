
namespace Patron01
{
    partial class Crearcita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crearcita));
            this.tab_vacunas = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tipo_vacuna = new System.Windows.Forms.ComboBox();
            this.nametext = new System.Windows.Forms.TextBox();
            this.cabina_combox = new System.Windows.Forms.ComboBox();
            this.cancelar_btn = new System.Windows.Forms.Button();
            this.date_crearcita = new System.Windows.Forms.DateTimePicker();
            this.id_crearcita = new System.Windows.Forms.TextBox();
            this.cita_btn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.data_mostrar = new System.Windows.Forms.DataGridView();
            this.columnaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaCabina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaTipoVacuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaDosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tipo_segunda = new System.Windows.Forms.ComboBox();
            this.cabina_dosis = new System.Windows.Forms.ComboBox();
            this.cancelar = new System.Windows.Forms.Button();
            this.actualizar = new System.Windows.Forms.Button();
            this.id_actualizar = new System.Windows.Forms.TextBox();
            this.nombre_actualizar = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dia_vacunabtn = new System.Windows.Forms.Button();
            this.dosiscmb = new System.Windows.Forms.ComboBox();
            this.sidecmb = new System.Windows.Forms.ComboBox();
            this.tipocmb = new System.Windows.Forms.ComboBox();
            this.cabincmb = new System.Windows.Forms.ComboBox();
            this.DUI = new System.Windows.Forms.TextBox();
            this.tab_vacunas.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_mostrar)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_vacunas
            // 
            this.tab_vacunas.Controls.Add(this.tabPage1);
            this.tab_vacunas.Controls.Add(this.tabPage2);
            this.tab_vacunas.Controls.Add(this.tabPage3);
            this.tab_vacunas.Controls.Add(this.tabPage4);
            this.tab_vacunas.Controls.Add(this.tabPage5);
            this.tab_vacunas.Location = new System.Drawing.Point(0, 0);
            this.tab_vacunas.Name = "tab_vacunas";
            this.tab_vacunas.SelectedIndex = 0;
            this.tab_vacunas.Size = new System.Drawing.Size(1759, 1282);
            this.tab_vacunas.TabIndex = 0;
            this.tab_vacunas.TabStop = false;
            this.tab_vacunas.TabIndexChanged += new System.EventHandler(this.tab_vacunas_TabIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.tipo_vacuna);
            this.tabPage1.Controls.Add(this.nametext);
            this.tabPage1.Controls.Add(this.cabina_combox);
            this.tabPage1.Controls.Add(this.cancelar_btn);
            this.tabPage1.Controls.Add(this.date_crearcita);
            this.tabPage1.Controls.Add(this.id_crearcita);
            this.tabPage1.Controls.Add(this.cita_btn);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1751, 1244);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Crear Cita";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tipo_vacuna
            // 
            this.tipo_vacuna.FormattingEnabled = true;
            this.tipo_vacuna.Items.AddRange(new object[] {
            "Astrazeneca",
            "Sinovac",
            "Phyzen"});
            this.tipo_vacuna.Location = new System.Drawing.Point(396, 592);
            this.tipo_vacuna.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tipo_vacuna.Name = "tipo_vacuna";
            this.tipo_vacuna.Size = new System.Drawing.Size(360, 33);
            this.tipo_vacuna.TabIndex = 6;
            // 
            // nametext
            // 
            this.nametext.Location = new System.Drawing.Point(396, 427);
            this.nametext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nametext.Name = "nametext";
            this.nametext.Size = new System.Drawing.Size(360, 31);
            this.nametext.TabIndex = 5;
            // 
            // cabina_combox
            // 
            this.cabina_combox.FormattingEnabled = true;
            this.cabina_combox.Items.AddRange(new object[] {
            "Primera cabina",
            "Segunda cabina",
            "Tercera cabina",
            "Cuarta cabina",
            "Quinta cabina"});
            this.cabina_combox.Location = new System.Drawing.Point(396, 660);
            this.cabina_combox.Name = "cabina_combox";
            this.cabina_combox.Size = new System.Drawing.Size(360, 33);
            this.cabina_combox.TabIndex = 5;
            this.cabina_combox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cancelar_btn
            // 
            this.cancelar_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelar_btn.Location = new System.Drawing.Point(893, 416);
            this.cancelar_btn.Name = "cancelar_btn";
            this.cancelar_btn.Size = new System.Drawing.Size(176, 42);
            this.cancelar_btn.TabIndex = 4;
            this.cancelar_btn.Text = "Cancelar";
            this.cancelar_btn.UseVisualStyleBackColor = true;
            // 
            // date_crearcita
            // 
            this.date_crearcita.Location = new System.Drawing.Point(396, 512);
            this.date_crearcita.Name = "date_crearcita";
            this.date_crearcita.Size = new System.Drawing.Size(360, 31);
            this.date_crearcita.TabIndex = 3;
            // 
            // id_crearcita
            // 
            this.id_crearcita.Location = new System.Drawing.Point(396, 348);
            this.id_crearcita.Multiline = true;
            this.id_crearcita.Name = "id_crearcita";
            this.id_crearcita.Size = new System.Drawing.Size(360, 42);
            this.id_crearcita.TabIndex = 1;
            // 
            // cita_btn
            // 
            this.cita_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cita_btn.Location = new System.Drawing.Point(893, 512);
            this.cita_btn.Name = "cita_btn";
            this.cita_btn.Size = new System.Drawing.Size(176, 42);
            this.cita_btn.TabIndex = 0;
            this.cita_btn.Text = "Crear Cita";
            this.cita_btn.UseVisualStyleBackColor = true;
            this.cita_btn.Click += new System.EventHandler(this.cita_btn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.Controls.Add(this.data_mostrar);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1751, 1244);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Visualización de Citas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // data_mostrar
            // 
            this.data_mostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_mostrar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaid,
            this.ColumnaNombre,
            this.ColumnaFecha,
            this.ColumnaCabina,
            this.ColumnaTipoVacuna,
            this.ColumnaDosis});
            this.data_mostrar.Location = new System.Drawing.Point(6, 307);
            this.data_mostrar.Name = "data_mostrar";
            this.data_mostrar.RowHeadersWidth = 62;
            this.data_mostrar.RowTemplate.Height = 33;
            this.data_mostrar.Size = new System.Drawing.Size(1636, 367);
            this.data_mostrar.TabIndex = 0;
            // 
            // columnaid
            // 
            this.columnaid.HeaderText = "Id";
            this.columnaid.MinimumWidth = 8;
            this.columnaid.Name = "columnaid";
            this.columnaid.ReadOnly = true;
            this.columnaid.Width = 190;
            // 
            // ColumnaNombre
            // 
            this.ColumnaNombre.HeaderText = "Nombre";
            this.ColumnaNombre.MinimumWidth = 8;
            this.ColumnaNombre.Name = "ColumnaNombre";
            this.ColumnaNombre.ReadOnly = true;
            this.ColumnaNombre.Width = 190;
            // 
            // ColumnaFecha
            // 
            this.ColumnaFecha.HeaderText = "Fecha";
            this.ColumnaFecha.MinimumWidth = 8;
            this.ColumnaFecha.Name = "ColumnaFecha";
            this.ColumnaFecha.ReadOnly = true;
            this.ColumnaFecha.Width = 190;
            // 
            // ColumnaCabina
            // 
            this.ColumnaCabina.HeaderText = "Cabina";
            this.ColumnaCabina.MinimumWidth = 8;
            this.ColumnaCabina.Name = "ColumnaCabina";
            this.ColumnaCabina.ReadOnly = true;
            this.ColumnaCabina.Width = 190;
            // 
            // ColumnaTipoVacuna
            // 
            this.ColumnaTipoVacuna.HeaderText = "Tipo Vacuna";
            this.ColumnaTipoVacuna.MinimumWidth = 8;
            this.ColumnaTipoVacuna.Name = "ColumnaTipoVacuna";
            this.ColumnaTipoVacuna.ReadOnly = true;
            this.ColumnaTipoVacuna.Width = 190;
            // 
            // ColumnaDosis
            // 
            this.ColumnaDosis.HeaderText = "Dosis";
            this.ColumnaDosis.MinimumWidth = 8;
            this.ColumnaDosis.Name = "ColumnaDosis";
            this.ColumnaDosis.ReadOnly = true;
            this.ColumnaDosis.Width = 190;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Transparent;
            this.tabPage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage3.BackgroundImage")));
            this.tabPage3.Controls.Add(this.tipo_segunda);
            this.tabPage3.Controls.Add(this.cabina_dosis);
            this.tabPage3.Controls.Add(this.cancelar);
            this.tabPage3.Controls.Add(this.actualizar);
            this.tabPage3.Controls.Add(this.id_actualizar);
            this.tabPage3.Controls.Add(this.nombre_actualizar);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1751, 1244);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Actualización de Citas";
            // 
            // tipo_segunda
            // 
            this.tipo_segunda.FormattingEnabled = true;
            this.tipo_segunda.Items.AddRange(new object[] {
            "Astrazeneca",
            "Sinovac",
            "Phyzen"});
            this.tipo_segunda.Location = new System.Drawing.Point(380, 615);
            this.tipo_segunda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tipo_segunda.Name = "tipo_segunda";
            this.tipo_segunda.Size = new System.Drawing.Size(300, 33);
            this.tipo_segunda.TabIndex = 6;
            // 
            // cabina_dosis
            // 
            this.cabina_dosis.FormattingEnabled = true;
            this.cabina_dosis.Items.AddRange(new object[] {
            "Primera cabina",
            "Segunda cabina",
            "Tercera cabina",
            "Cuarta cabina",
            "Quinta cabina"});
            this.cabina_dosis.Location = new System.Drawing.Point(380, 517);
            this.cabina_dosis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cabina_dosis.Name = "cabina_dosis";
            this.cabina_dosis.Size = new System.Drawing.Size(300, 33);
            this.cabina_dosis.TabIndex = 5;
            // 
            // cancelar
            // 
            this.cancelar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelar.Location = new System.Drawing.Point(1066, 1020);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(176, 42);
            this.cancelar.TabIndex = 4;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            // 
            // actualizar
            // 
            this.actualizar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.actualizar.Location = new System.Drawing.Point(901, 414);
            this.actualizar.Name = "actualizar";
            this.actualizar.Size = new System.Drawing.Size(227, 77);
            this.actualizar.TabIndex = 3;
            this.actualizar.Text = "Crear segunda cita";
            this.actualizar.UseVisualStyleBackColor = true;
            this.actualizar.Click += new System.EventHandler(this.actualizar_Click);
            // 
            // id_actualizar
            // 
            this.id_actualizar.Location = new System.Drawing.Point(380, 343);
            this.id_actualizar.Multiline = true;
            this.id_actualizar.Name = "id_actualizar";
            this.id_actualizar.Size = new System.Drawing.Size(300, 42);
            this.id_actualizar.TabIndex = 1;
            // 
            // nombre_actualizar
            // 
            this.nombre_actualizar.Location = new System.Drawing.Point(380, 429);
            this.nombre_actualizar.Multiline = true;
            this.nombre_actualizar.Name = "nombre_actualizar";
            this.nombre_actualizar.Size = new System.Drawing.Size(300, 42);
            this.nombre_actualizar.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage4.BackgroundImage")));
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage4.Size = new System.Drawing.Size(1751, 1244);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Registro de paciente";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(548, 413);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Registrar paciente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage5.BackgroundImage")));
            this.tabPage5.Controls.Add(this.dia_vacunabtn);
            this.tabPage5.Controls.Add(this.dosiscmb);
            this.tabPage5.Controls.Add(this.sidecmb);
            this.tabPage5.Controls.Add(this.tipocmb);
            this.tabPage5.Controls.Add(this.cabincmb);
            this.tabPage5.Controls.Add(this.DUI);
            this.tabPage5.Location = new System.Drawing.Point(4, 34);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage5.Size = new System.Drawing.Size(1751, 1244);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Dia de vacuna";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dia_vacunabtn
            // 
            this.dia_vacunabtn.Location = new System.Drawing.Point(928, 425);
            this.dia_vacunabtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dia_vacunabtn.Name = "dia_vacunabtn";
            this.dia_vacunabtn.Size = new System.Drawing.Size(151, 57);
            this.dia_vacunabtn.TabIndex = 1;
            this.dia_vacunabtn.Text = "Crear registro";
            this.dia_vacunabtn.UseVisualStyleBackColor = true;
            this.dia_vacunabtn.Click += new System.EventHandler(this.dia_vacunabtn_Click);
            // 
            // dosiscmb
            // 
            this.dosiscmb.FormattingEnabled = true;
            this.dosiscmb.Items.AddRange(new object[] {
            "Primera dosis",
            "Segunda dosis"});
            this.dosiscmb.Location = new System.Drawing.Point(329, 586);
            this.dosiscmb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dosiscmb.Name = "dosiscmb";
            this.dosiscmb.Size = new System.Drawing.Size(245, 33);
            this.dosiscmb.TabIndex = 5;
            // 
            // sidecmb
            // 
            this.sidecmb.FormattingEnabled = true;
            this.sidecmb.Items.AddRange(new object[] {
            "Dolor y/o irritacion en el area de la inyeccion",
            "Enrojecimiento en el area de la inyeccion",
            "Fatiga ",
            "Dolor de cabeza",
            "Fatiga",
            "Mialgia",
            "Otro",
            "Ninguno"});
            this.sidecmb.Location = new System.Drawing.Point(491, 513);
            this.sidecmb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sidecmb.Name = "sidecmb";
            this.sidecmb.Size = new System.Drawing.Size(223, 33);
            this.sidecmb.TabIndex = 4;
            // 
            // tipocmb
            // 
            this.tipocmb.FormattingEnabled = true;
            this.tipocmb.Items.AddRange(new object[] {
            "AstraZeneca",
            "Sinovac",
            "Phyzen"});
            this.tipocmb.Location = new System.Drawing.Point(438, 449);
            this.tipocmb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tipocmb.Name = "tipocmb";
            this.tipocmb.Size = new System.Drawing.Size(224, 33);
            this.tipocmb.TabIndex = 3;
            // 
            // cabincmb
            // 
            this.cabincmb.FormattingEnabled = true;
            this.cabincmb.Items.AddRange(new object[] {
            "Primera cabina",
            "Segunda cabina",
            "Tercera cabina",
            "Cuarta cabina",
            "Quinta cabina"});
            this.cabincmb.Location = new System.Drawing.Point(318, 372);
            this.cabincmb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cabincmb.Name = "cabincmb";
            this.cabincmb.Size = new System.Drawing.Size(245, 33);
            this.cabincmb.TabIndex = 2;
            // 
            // DUI
            // 
            this.DUI.Location = new System.Drawing.Point(318, 305);
            this.DUI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DUI.Name = "DUI";
            this.DUI.Size = new System.Drawing.Size(245, 31);
            this.DUI.TabIndex = 0;
            // 
            // Crearcita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 758);
            this.Controls.Add(this.tab_vacunas);
            this.Name = "Crearcita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Crearcita_Load_1);
            this.tab_vacunas.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_mostrar)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_vacunas;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button cancelar_btn;
        private System.Windows.Forms.DateTimePicker date_crearcita;

        private System.Windows.Forms.TextBox id_crearcita;
        private System.Windows.Forms.Button cita_btn;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView data_mostrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaCabina;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaTipoVacuna;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaDosis;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button actualizar;
        
        private System.Windows.Forms.TextBox id_actualizar;
        private System.Windows.Forms.TextBox nombre_actualizar;
        private System.Windows.Forms.ComboBox cabina_combox;
        private System.Windows.Forms.TextBox nametext;
        
        private System.Windows.Forms.ComboBox tipo_vacuna;
        
        
        
        private System.Windows.Forms.ComboBox cabina_dosis;
        private System.Windows.Forms.ComboBox tipo_segunda;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox dosiscmb;
        private System.Windows.Forms.ComboBox sidecmb;
        private System.Windows.Forms.ComboBox tipocmb;
        private System.Windows.Forms.ComboBox cabincmb;
        
        private System.Windows.Forms.TextBox DUI;
        private System.Windows.Forms.Button dia_vacunabtn;
    }
}

