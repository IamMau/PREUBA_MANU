namespace PROYECTO_IT_HEFESTO.Vistas.Servidores
{
    partial class FrmServer
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPathFiles = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPathBackups = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.BtnSalir = new Guna.UI2.WinForms.Guna2Button();
            this.BtnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.BtnRuta = new System.Windows.Forms.Button();
            this.path_archivos = new System.Windows.Forms.FolderBrowserDialog();
            this.BtnImagen = new System.Windows.Forms.Button();
            this.PxtDoc = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PxtDoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servidor de Archivos";
            // 
            // TxtPathFiles
            // 
            this.TxtPathFiles.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPathFiles.DefaultText = "";
            this.TxtPathFiles.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtPathFiles.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtPathFiles.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPathFiles.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPathFiles.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPathFiles.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtPathFiles.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPathFiles.Location = new System.Drawing.Point(15, 132);
            this.TxtPathFiles.Name = "TxtPathFiles";
            this.TxtPathFiles.PasswordChar = '\0';
            this.TxtPathFiles.PlaceholderText = "";
            this.TxtPathFiles.SelectedText = "";
            this.TxtPathFiles.Size = new System.Drawing.Size(454, 36);
            this.TxtPathFiles.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Servidor deBackups";
            // 
            // TxtPathBackups
            // 
            this.TxtPathBackups.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPathBackups.DefaultText = "";
            this.TxtPathBackups.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtPathBackups.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtPathBackups.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPathBackups.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPathBackups.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPathBackups.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtPathBackups.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPathBackups.Location = new System.Drawing.Point(15, 232);
            this.TxtPathBackups.Name = "TxtPathBackups";
            this.TxtPathBackups.PasswordChar = '\0';
            this.TxtPathBackups.PlaceholderText = "";
            this.TxtPathBackups.SelectedText = "";
            this.TxtPathBackups.Size = new System.Drawing.Size(454, 36);
            this.TxtPathBackups.TabIndex = 3;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnGuardar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnGuardar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnGuardar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Location = new System.Drawing.Point(54, 333);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(180, 45);
            this.BtnGuardar.TabIndex = 4;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSalir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSalir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSalir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSalir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnSalir.ForeColor = System.Drawing.Color.White;
            this.BtnSalir.Location = new System.Drawing.Point(426, 333);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(180, 45);
            this.BtnSalir.TabIndex = 5;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnCancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(240, 333);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(180, 45);
            this.BtnCancelar.TabIndex = 6;
            this.BtnCancelar.Text = "Cancelar ";
            // 
            // BtnRuta
            // 
            this.BtnRuta.Location = new System.Drawing.Point(474, 132);
            this.BtnRuta.Name = "BtnRuta";
            this.BtnRuta.Size = new System.Drawing.Size(50, 36);
            this.BtnRuta.TabIndex = 7;
            this.BtnRuta.Text = "button1";
            this.BtnRuta.UseVisualStyleBackColor = true;
            this.BtnRuta.Click += new System.EventHandler(this.BtnRuta_Click);
            // 
            // BtnImagen
            // 
            this.BtnImagen.Location = new System.Drawing.Point(625, 254);
            this.BtnImagen.Name = "BtnImagen";
            this.BtnImagen.Size = new System.Drawing.Size(65, 29);
            this.BtnImagen.TabIndex = 8;
            this.BtnImagen.Text = "Buscar";
            this.BtnImagen.UseVisualStyleBackColor = true;
            this.BtnImagen.Click += new System.EventHandler(this.BtnImagen_Click);
            // 
            // PxtDoc
            // 
            this.PxtDoc.ImageRotate = 0F;
            this.PxtDoc.Location = new System.Drawing.Point(558, 27);
            this.PxtDoc.Name = "PxtDoc";
            this.PxtDoc.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PxtDoc.Size = new System.Drawing.Size(207, 221);
            this.PxtDoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PxtDoc.TabIndex = 9;
            this.PxtDoc.TabStop = false;
            // 
            // FrmServer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(790, 459);
            this.Controls.Add(this.PxtDoc);
            this.Controls.Add(this.BtnImagen);
            this.Controls.Add(this.BtnRuta);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.TxtPathBackups);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtPathFiles);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmServer";
            this.Load += new System.EventHandler(this.FrmServer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PxtDoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox TxtPathFiles;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox TxtPathBackups;
        private Guna.UI2.WinForms.Guna2Button BtnGuardar;
        private Guna.UI2.WinForms.Guna2Button BtnSalir;
        private Guna.UI2.WinForms.Guna2Button BtnCancelar;
        private System.Windows.Forms.Button BtnRuta;
        private System.Windows.Forms.FolderBrowserDialog path_archivos;
        private System.Windows.Forms.Button BtnImagen;
        private Guna.UI2.WinForms.Guna2CirclePictureBox PxtDoc;
    }
}