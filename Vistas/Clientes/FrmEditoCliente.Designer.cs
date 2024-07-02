namespace PROYECTO_IT_HEFESTO.Vistas.Clientes
{
    partial class FrmEditoCliente
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
            this.BtnSeleccionarImagen = new Guna.UI2.WinForms.Guna2Button();
            this.PcCliente = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.BtnActualizar = new Guna.UI2.WinForms.Guna2Button();
            this.TxtCorreo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DtpFn = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.CmbGenero = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TxtTelefono = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtDireccion = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtNr = new Guna.UI2.WinForms.Guna2TextBox();
            this.CmbTipo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TxtDni = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtCelular = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtEliminado = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtClose = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.PcCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSeleccionarImagen
            // 
            this.BtnSeleccionarImagen.BorderColor = System.Drawing.Color.Aqua;
            this.BtnSeleccionarImagen.BorderRadius = 15;
            this.BtnSeleccionarImagen.BorderThickness = 1;
            this.BtnSeleccionarImagen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSeleccionarImagen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSeleccionarImagen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSeleccionarImagen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSeleccionarImagen.FillColor = System.Drawing.Color.Transparent;
            this.BtnSeleccionarImagen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnSeleccionarImagen.ForeColor = System.Drawing.Color.DimGray;
            this.BtnSeleccionarImagen.Location = new System.Drawing.Point(578, 171);
            this.BtnSeleccionarImagen.Name = "BtnSeleccionarImagen";
            this.BtnSeleccionarImagen.Size = new System.Drawing.Size(161, 36);
            this.BtnSeleccionarImagen.TabIndex = 41;
            this.BtnSeleccionarImagen.Text = "Buscar";
            this.BtnSeleccionarImagen.Click += new System.EventHandler(this.BtnSeleccionarImagen_Click);
            // 
            // PcCliente
            // 
            this.PcCliente.ImageRotate = 0F;
            this.PcCliente.Location = new System.Drawing.Point(578, 10);
            this.PcCliente.Name = "PcCliente";
            this.PcCliente.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PcCliente.Size = new System.Drawing.Size(161, 158);
            this.PcCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PcCliente.TabIndex = 40;
            this.PcCliente.TabStop = false;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnActualizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnActualizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnActualizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnActualizar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnActualizar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnActualizar.ForeColor = System.Drawing.Color.White;
            this.BtnActualizar.Location = new System.Drawing.Point(0, 322);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(751, 45);
            this.BtnActualizar.TabIndex = 39;
            this.BtnActualizar.Text = "Registrar Cliente";
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.BorderColor = System.Drawing.Color.Aqua;
            this.TxtCorreo.BorderRadius = 15;
            this.TxtCorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCorreo.DefaultText = "";
            this.TxtCorreo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtCorreo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtCorreo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCorreo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCorreo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCorreo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtCorreo.ForeColor = System.Drawing.Color.DimGray;
            this.TxtCorreo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCorreo.Location = new System.Drawing.Point(195, 245);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.PasswordChar = '\0';
            this.TxtCorreo.PlaceholderText = "";
            this.TxtCorreo.SelectedText = "";
            this.TxtCorreo.Size = new System.Drawing.Size(349, 36);
            this.TxtCorreo.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(206, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 37;
            this.label9.Text = "CORREO";
            // 
            // DtpFn
            // 
            this.DtpFn.BorderColor = System.Drawing.Color.Aqua;
            this.DtpFn.BorderRadius = 15;
            this.DtpFn.BorderThickness = 1;
            this.DtpFn.Checked = true;
            this.DtpFn.FillColor = System.Drawing.Color.White;
            this.DtpFn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DtpFn.ForeColor = System.Drawing.Color.DimGray;
            this.DtpFn.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DtpFn.Location = new System.Drawing.Point(3, 245);
            this.DtpFn.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DtpFn.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DtpFn.Name = "DtpFn";
            this.DtpFn.Size = new System.Drawing.Size(186, 36);
            this.DtpFn.TabIndex = 36;
            this.DtpFn.Value = new System.DateTime(2024, 6, 8, 2, 30, 32, 508);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 17);
            this.label8.TabIndex = 35;
            this.label8.Text = "FECHA DE NACIMIENTO";
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
            this.CmbGenero.Location = new System.Drawing.Point(397, 171);
            this.CmbGenero.Name = "CmbGenero";
            this.CmbGenero.Size = new System.Drawing.Size(147, 36);
            this.CmbGenero.TabIndex = 34;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.BorderColor = System.Drawing.Color.Aqua;
            this.TxtTelefono.BorderRadius = 15;
            this.TxtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtTelefono.DefaultText = "";
            this.TxtTelefono.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtTelefono.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtTelefono.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtTelefono.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtTelefono.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtTelefono.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtTelefono.ForeColor = System.Drawing.Color.DimGray;
            this.TxtTelefono.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtTelefono.Location = new System.Drawing.Point(3, 171);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.PasswordChar = '\0';
            this.TxtTelefono.PlaceholderText = "";
            this.TxtTelefono.SelectedText = "";
            this.TxtTelefono.Size = new System.Drawing.Size(186, 36);
            this.TxtTelefono.TabIndex = 32;
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.BorderColor = System.Drawing.Color.Aqua;
            this.TxtDireccion.BorderRadius = 15;
            this.TxtDireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtDireccion.DefaultText = "";
            this.TxtDireccion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtDireccion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtDireccion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtDireccion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtDireccion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtDireccion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtDireccion.ForeColor = System.Drawing.Color.DimGray;
            this.TxtDireccion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtDireccion.Location = new System.Drawing.Point(3, 100);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.PasswordChar = '\0';
            this.TxtDireccion.PlaceholderText = "";
            this.TxtDireccion.SelectedText = "";
            this.TxtDireccion.Size = new System.Drawing.Size(541, 36);
            this.TxtDireccion.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "DIRECCION";
            // 
            // TxtNr
            // 
            this.TxtNr.BorderColor = System.Drawing.Color.Aqua;
            this.TxtNr.BorderRadius = 15;
            this.TxtNr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNr.DefaultText = "";
            this.TxtNr.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtNr.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtNr.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtNr.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtNr.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtNr.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtNr.ForeColor = System.Drawing.Color.DimGray;
            this.TxtNr.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtNr.Location = new System.Drawing.Point(344, 30);
            this.TxtNr.Name = "TxtNr";
            this.TxtNr.PasswordChar = '\0';
            this.TxtNr.PlaceholderText = "";
            this.TxtNr.SelectedText = "";
            this.TxtNr.Size = new System.Drawing.Size(200, 36);
            this.TxtNr.TabIndex = 29;
            // 
            // CmbTipo
            // 
            this.CmbTipo.BackColor = System.Drawing.Color.Transparent;
            this.CmbTipo.BorderColor = System.Drawing.Color.Aqua;
            this.CmbTipo.BorderRadius = 15;
            this.CmbTipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbTipo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbTipo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmbTipo.ForeColor = System.Drawing.Color.DimGray;
            this.CmbTipo.ItemHeight = 30;
            this.CmbTipo.Location = new System.Drawing.Point(209, 30);
            this.CmbTipo.Name = "CmbTipo";
            this.CmbTipo.Size = new System.Drawing.Size(129, 36);
            this.CmbTipo.TabIndex = 28;
            // 
            // TxtDni
            // 
            this.TxtDni.BorderColor = System.Drawing.Color.Aqua;
            this.TxtDni.BorderRadius = 15;
            this.TxtDni.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtDni.DefaultText = "";
            this.TxtDni.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtDni.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtDni.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtDni.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtDni.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtDni.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtDni.ForeColor = System.Drawing.Color.DimGray;
            this.TxtDni.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtDni.Location = new System.Drawing.Point(3, 30);
            this.TxtDni.Name = "TxtDni";
            this.TxtDni.PasswordChar = '\0';
            this.TxtDni.PlaceholderText = "";
            this.TxtDni.SelectedText = "";
            this.TxtDni.Size = new System.Drawing.Size(200, 36);
            this.TxtDni.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(357, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "NOMBRE_RAZON";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "TELEFONO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "CELULAR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(408, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "GENERO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "TIPO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "DNI";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(575, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 17);
            this.label10.TabIndex = 42;
            this.label10.Text = "ELIMINADO";
            // 
            // TxtCelular
            // 
            this.TxtCelular.BorderColor = System.Drawing.Color.Aqua;
            this.TxtCelular.BorderRadius = 15;
            this.TxtCelular.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCelular.DefaultText = "";
            this.TxtCelular.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtCelular.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtCelular.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCelular.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCelular.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCelular.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtCelular.ForeColor = System.Drawing.Color.DimGray;
            this.TxtCelular.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCelular.Location = new System.Drawing.Point(195, 171);
            this.TxtCelular.Name = "TxtCelular";
            this.TxtCelular.PasswordChar = '\0';
            this.TxtCelular.PlaceholderText = "";
            this.TxtCelular.SelectedText = "";
            this.TxtCelular.Size = new System.Drawing.Size(196, 36);
            this.TxtCelular.TabIndex = 33;
            // 
            // TxtEliminado
            // 
            this.TxtEliminado.BorderColor = System.Drawing.Color.Aqua;
            this.TxtEliminado.BorderRadius = 15;
            this.TxtEliminado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtEliminado.DefaultText = "";
            this.TxtEliminado.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtEliminado.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtEliminado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtEliminado.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtEliminado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtEliminado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtEliminado.ForeColor = System.Drawing.Color.DimGray;
            this.TxtEliminado.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtEliminado.Location = new System.Drawing.Point(568, 245);
            this.TxtEliminado.Name = "TxtEliminado";
            this.TxtEliminado.PasswordChar = '\0';
            this.TxtEliminado.PlaceholderText = "";
            this.TxtEliminado.SelectedText = "";
            this.TxtEliminado.Size = new System.Drawing.Size(105, 36);
            this.TxtEliminado.TabIndex = 43;
            // 
            // TxtClose
            // 
            this.TxtClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.TxtClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.TxtClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.TxtClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.TxtClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtClose.ForeColor = System.Drawing.Color.White;
            this.TxtClose.Location = new System.Drawing.Point(716, 0);
            this.TxtClose.Name = "TxtClose";
            this.TxtClose.Size = new System.Drawing.Size(35, 27);
            this.TxtClose.TabIndex = 44;
            this.TxtClose.Text = "X";
            this.TxtClose.Click += new System.EventHandler(this.TxtClose_Click);
            // 
            // FrmEditoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 367);
            this.Controls.Add(this.TxtClose);
            this.Controls.Add(this.TxtEliminado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BtnSeleccionarImagen);
            this.Controls.Add(this.PcCliente);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.TxtCorreo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DtpFn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CmbGenero);
            this.Controls.Add(this.TxtCelular);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtNr);
            this.Controls.Add(this.CmbTipo);
            this.Controls.Add(this.TxtDni);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmEditoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditoCliente";
            this.Load += new System.EventHandler(this.FrmEditoCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PcCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button BtnSeleccionarImagen;
        private Guna.UI2.WinForms.Guna2CirclePictureBox PcCliente;
        private Guna.UI2.WinForms.Guna2Button BtnActualizar;
        private Guna.UI2.WinForms.Guna2TextBox TxtCorreo;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2DateTimePicker DtpFn;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2ComboBox CmbGenero;
        private Guna.UI2.WinForms.Guna2TextBox TxtTelefono;
        private Guna.UI2.WinForms.Guna2TextBox TxtDireccion;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox TxtNr;
        private Guna.UI2.WinForms.Guna2ComboBox CmbTipo;
        private Guna.UI2.WinForms.Guna2TextBox TxtDni;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox TxtCelular;
        private Guna.UI2.WinForms.Guna2TextBox TxtEliminado;
        private Guna.UI2.WinForms.Guna2Button TxtClose;
    }
}