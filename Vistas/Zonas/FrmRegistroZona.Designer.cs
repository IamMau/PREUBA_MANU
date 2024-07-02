namespace PROYECTO_IT_HEFESTO.Vistas.Zonas
{
    partial class FrmRegistroZona
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtZona = new Guna.UI2.WinForms.Guna2TextBox();
            this.CmbDep = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CmbMunic = new Guna.UI2.WinForms.Guna2ComboBox();
            this.BtnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.BtnClose = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRE DE LA ZONA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "DEPARTAMENTO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "MUNICIPIO";
            // 
            // TxtZona
            // 
            this.TxtZona.BorderColor = System.Drawing.Color.Aqua;
            this.TxtZona.BorderRadius = 15;
            this.TxtZona.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtZona.DefaultText = "";
            this.TxtZona.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtZona.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtZona.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtZona.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtZona.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtZona.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtZona.ForeColor = System.Drawing.Color.DimGray;
            this.TxtZona.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtZona.Location = new System.Drawing.Point(12, 129);
            this.TxtZona.Name = "TxtZona";
            this.TxtZona.PasswordChar = '\0';
            this.TxtZona.PlaceholderText = "";
            this.TxtZona.SelectedText = "";
            this.TxtZona.Size = new System.Drawing.Size(200, 36);
            this.TxtZona.TabIndex = 3;
            // 
            // CmbDep
            // 
            this.CmbDep.BackColor = System.Drawing.Color.Transparent;
            this.CmbDep.BorderColor = System.Drawing.Color.Aqua;
            this.CmbDep.BorderRadius = 15;
            this.CmbDep.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDep.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbDep.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbDep.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmbDep.ForeColor = System.Drawing.Color.DimGray;
            this.CmbDep.ItemHeight = 30;
            this.CmbDep.Location = new System.Drawing.Point(237, 129);
            this.CmbDep.Name = "CmbDep";
            this.CmbDep.Size = new System.Drawing.Size(186, 36);
            this.CmbDep.TabIndex = 4;
            // 
            // CmbMunic
            // 
            this.CmbMunic.BackColor = System.Drawing.Color.Transparent;
            this.CmbMunic.BorderColor = System.Drawing.Color.Aqua;
            this.CmbMunic.BorderRadius = 15;
            this.CmbMunic.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbMunic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMunic.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbMunic.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbMunic.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CmbMunic.ForeColor = System.Drawing.Color.DimGray;
            this.CmbMunic.ItemHeight = 30;
            this.CmbMunic.Location = new System.Drawing.Point(429, 129);
            this.CmbMunic.Name = "CmbMunic";
            this.CmbMunic.Size = new System.Drawing.Size(175, 36);
            this.CmbMunic.TabIndex = 5;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnGuardar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnGuardar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnGuardar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnGuardar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Location = new System.Drawing.Point(0, 343);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(616, 45);
            this.BtnGuardar.TabIndex = 6;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(577, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(39, 29);
            this.BtnClose.TabIndex = 7;
            this.BtnClose.Text = "X";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FrmRegistroZona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 388);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.CmbMunic);
            this.Controls.Add(this.CmbDep);
            this.Controls.Add(this.TxtZona);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRegistroZona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRegistroZona";
            this.Load += new System.EventHandler(this.FrmRegistroZona_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox TxtZona;
        private Guna.UI2.WinForms.Guna2ComboBox CmbDep;
        private Guna.UI2.WinForms.Guna2ComboBox CmbMunic;
        private Guna.UI2.WinForms.Guna2Button BtnGuardar;
        private Guna.UI2.WinForms.Guna2Button BtnClose;
    }
}