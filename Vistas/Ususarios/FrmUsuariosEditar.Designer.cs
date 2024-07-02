namespace PROYECTO_IT_HEFESTO.Vistas.Ususarios
{
    partial class FrmUsuariosEditar
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
            this.BtnRegistrar = new Guna.UI2.WinForms.Guna2Button();
            this.CmbRol = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CmbGenero = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DtpNac = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.TxtCorreo = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtClave = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.BorderColor = System.Drawing.Color.Aqua;
            this.BtnRegistrar.BorderThickness = 1;
            this.BtnRegistrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnRegistrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnRegistrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnRegistrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnRegistrar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnRegistrar.FillColor = System.Drawing.Color.Aqua;
            this.BtnRegistrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnRegistrar.ForeColor = System.Drawing.Color.DimGray;
            this.BtnRegistrar.Location = new System.Drawing.Point(0, 210);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(617, 45);
            this.BtnRegistrar.TabIndex = 31;
            this.BtnRegistrar.Text = "REGISTRAR";
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // CmbRol
            // 
            this.CmbRol.BackColor = System.Drawing.Color.Transparent;
            this.CmbRol.BorderColor = System.Drawing.Color.Aqua;
            this.CmbRol.BorderRadius = 15;
            this.CmbRol.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbRol.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbRol.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbRol.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmbRol.ForeColor = System.Drawing.Color.DimGray;
            this.CmbRol.ItemHeight = 30;
            this.CmbRol.Location = new System.Drawing.Point(410, 160);
            this.CmbRol.Name = "CmbRol";
            this.CmbRol.Size = new System.Drawing.Size(200, 36);
            this.CmbRol.TabIndex = 30;
            // 
            // CmbGenero
            // 
            this.CmbGenero.BackColor = System.Drawing.Color.Transparent;
            this.CmbGenero.BorderColor = System.Drawing.Color.Aqua;
            this.CmbGenero.BorderRadius = 15;
            this.CmbGenero.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbGenero.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbGenero.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbGenero.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmbGenero.ForeColor = System.Drawing.Color.DimGray;
            this.CmbGenero.ItemHeight = 30;
            this.CmbGenero.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMENINO"});
            this.CmbGenero.Location = new System.Drawing.Point(436, 24);
            this.CmbGenero.Name = "CmbGenero";
            this.CmbGenero.Size = new System.Drawing.Size(177, 36);
            this.CmbGenero.TabIndex = 29;
            // 
            // DtpNac
            // 
            this.DtpNac.BorderColor = System.Drawing.Color.Aqua;
            this.DtpNac.BorderRadius = 15;
            this.DtpNac.BorderThickness = 1;
            this.DtpNac.Checked = true;
            this.DtpNac.FillColor = System.Drawing.Color.White;
            this.DtpNac.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DtpNac.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DtpNac.Location = new System.Drawing.Point(230, 24);
            this.DtpNac.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DtpNac.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DtpNac.Name = "DtpNac";
            this.DtpNac.Size = new System.Drawing.Size(200, 36);
            this.DtpNac.TabIndex = 28;
            this.DtpNac.Value = new System.DateTime(2024, 6, 7, 13, 12, 20, 850);
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.BorderColor = System.Drawing.Color.Cyan;
            this.TxtCorreo.BorderRadius = 15;
            this.TxtCorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCorreo.DefaultText = "";
            this.TxtCorreo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtCorreo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtCorreo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCorreo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCorreo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCorreo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtCorreo.ForeColor = System.Drawing.Color.DimGray;
            this.TxtCorreo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCorreo.Location = new System.Drawing.Point(2, 87);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.PasswordChar = '\0';
            this.TxtCorreo.PlaceholderText = "";
            this.TxtCorreo.SelectedText = "";
            this.TxtCorreo.Size = new System.Drawing.Size(610, 42);
            this.TxtCorreo.TabIndex = 27;
            // 
            // TxtClave
            // 
            this.TxtClave.BorderColor = System.Drawing.Color.Cyan;
            this.TxtClave.BorderRadius = 15;
            this.TxtClave.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtClave.DefaultText = "";
            this.TxtClave.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtClave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtClave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtClave.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtClave.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtClave.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtClave.ForeColor = System.Drawing.Color.DimGray;
            this.TxtClave.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtClave.Location = new System.Drawing.Point(206, 160);
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.PasswordChar = '\0';
            this.TxtClave.PlaceholderText = "";
            this.TxtClave.SelectedText = "";
            this.TxtClave.Size = new System.Drawing.Size(198, 36);
            this.TxtClave.TabIndex = 26;
            // 
            // TxtUsername
            // 
            this.TxtUsername.BorderColor = System.Drawing.Color.Cyan;
            this.TxtUsername.BorderRadius = 15;
            this.TxtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtUsername.DefaultText = "";
            this.TxtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtUsername.ForeColor = System.Drawing.Color.DimGray;
            this.TxtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtUsername.Location = new System.Drawing.Point(0, 160);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.PasswordChar = '\0';
            this.TxtUsername.PlaceholderText = "";
            this.TxtUsername.SelectedText = "";
            this.TxtUsername.Size = new System.Drawing.Size(200, 36);
            this.TxtUsername.TabIndex = 25;
            // 
            // TxtNombre
            // 
            this.TxtNombre.BorderColor = System.Drawing.Color.Cyan;
            this.TxtNombre.BorderRadius = 15;
            this.TxtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNombre.DefaultText = "";
            this.TxtNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtNombre.ForeColor = System.Drawing.Color.DimGray;
            this.TxtNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtNombre.Location = new System.Drawing.Point(2, 24);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.PasswordChar = '\0';
            this.TxtNombre.PlaceholderText = "";
            this.TxtNombre.SelectedText = "";
            this.TxtNombre.Size = new System.Drawing.Size(224, 36);
            this.TxtNombre.TabIndex = 24;
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(436, 137);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(25, 22);
            this.guna2HtmlLabel7.TabIndex = 23;
            this.guna2HtmlLabel7.Text = "Rol";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(18, 66);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(55, 22);
            this.guna2HtmlLabel6.TabIndex = 22;
            this.guna2HtmlLabel6.Text = "Correo";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(243, 3);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(161, 22);
            this.guna2HtmlLabel5.TabIndex = 21;
            this.guna2HtmlLabel5.Text = "Fecha de Nacimiento";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(451, 3);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(60, 22);
            this.guna2HtmlLabel4.TabIndex = 20;
            this.guna2HtmlLabel4.Text = "Genero";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(224, 137);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(48, 22);
            this.guna2HtmlLabel2.TabIndex = 19;
            this.guna2HtmlLabel2.Text = "Clave";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(18, 137);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(77, 22);
            this.guna2HtmlLabel1.TabIndex = 18;
            this.guna2HtmlLabel1.Text = "Username";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(18, 3);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(62, 22);
            this.guna2HtmlLabel3.TabIndex = 17;
            this.guna2HtmlLabel3.Text = "Nombre";
            // 
            // FrmUsuariosEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 255);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.CmbRol);
            this.Controls.Add(this.CmbGenero);
            this.Controls.Add(this.DtpNac);
            this.Controls.Add(this.TxtCorreo);
            this.Controls.Add(this.TxtClave);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.guna2HtmlLabel7);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmUsuariosEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUsuariosEditar";
            this.Load += new System.EventHandler(this.FrmUsuariosEditar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button BtnRegistrar;
        private Guna.UI2.WinForms.Guna2ComboBox CmbRol;
        private Guna.UI2.WinForms.Guna2ComboBox CmbGenero;
        private Guna.UI2.WinForms.Guna2DateTimePicker DtpNac;
        private Guna.UI2.WinForms.Guna2TextBox TxtCorreo;
        private Guna.UI2.WinForms.Guna2TextBox TxtClave;
        private Guna.UI2.WinForms.Guna2TextBox TxtUsername;
        private Guna.UI2.WinForms.Guna2TextBox TxtNombre;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
    }
}