namespace navegacionVentanas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cbChocolate = new System.Windows.Forms.CheckBox();
            this.rbtMuggle = new System.Windows.Forms.RadioButton();
            this.rbtWizard = new System.Windows.Forms.RadioButton();
            this.rbtSquibs = new System.Windows.Forms.RadioButton();
            this.gbTipo = new System.Windows.Forms.GroupBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.cboColor = new System.Windows.Forms.ComboBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.btnVerPerfil = new System.Windows.Forms.Button();
            this.gbTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(111, 55);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(210, 55);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Location = new System.Drawing.Point(111, 110);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(94, 13);
            this.lblNacimiento.TabIndex = 2;
            this.lblNacimiento.Text = "Fecha nacimiento:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(507, 156);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(229, 104);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(265, 20);
            this.dtpFechaNacimiento.TabIndex = 4;
            // 
            // cbChocolate
            // 
            this.cbChocolate.AutoSize = true;
            this.cbChocolate.Location = new System.Drawing.Point(229, 156);
            this.cbChocolate.Name = "cbChocolate";
            this.cbChocolate.Size = new System.Drawing.Size(124, 17);
            this.cbChocolate.TabIndex = 5;
            this.cbChocolate.Text = "Te gusta chocolate?";
            this.cbChocolate.UseVisualStyleBackColor = true;
            // 
            // rbtMuggle
            // 
            this.rbtMuggle.AutoSize = true;
            this.rbtMuggle.Checked = true;
            this.rbtMuggle.Location = new System.Drawing.Point(15, 50);
            this.rbtMuggle.Name = "rbtMuggle";
            this.rbtMuggle.Size = new System.Drawing.Size(60, 17);
            this.rbtMuggle.TabIndex = 6;
            this.rbtMuggle.TabStop = true;
            this.rbtMuggle.Text = "Muggle";
            this.rbtMuggle.UseVisualStyleBackColor = true;
            // 
            // rbtWizard
            // 
            this.rbtWizard.AutoSize = true;
            this.rbtWizard.Location = new System.Drawing.Point(149, 50);
            this.rbtWizard.Name = "rbtWizard";
            this.rbtWizard.Size = new System.Drawing.Size(58, 17);
            this.rbtWizard.TabIndex = 7;
            this.rbtWizard.Text = "Wizard";
            this.rbtWizard.UseVisualStyleBackColor = true;
            // 
            // rbtSquibs
            // 
            this.rbtSquibs.AutoSize = true;
            this.rbtSquibs.Location = new System.Drawing.Point(288, 50);
            this.rbtSquibs.Name = "rbtSquibs";
            this.rbtSquibs.Size = new System.Drawing.Size(57, 17);
            this.rbtSquibs.TabIndex = 8;
            this.rbtSquibs.Text = "Squibs";
            this.rbtSquibs.UseVisualStyleBackColor = true;
            // 
            // gbTipo
            // 
            this.gbTipo.Controls.Add(this.rbtMuggle);
            this.gbTipo.Controls.Add(this.rbtSquibs);
            this.gbTipo.Controls.Add(this.rbtWizard);
            this.gbTipo.Location = new System.Drawing.Point(205, 217);
            this.gbTipo.Name = "gbTipo";
            this.gbTipo.Size = new System.Drawing.Size(402, 119);
            this.gbTipo.TabIndex = 9;
            this.gbTipo.TabStop = false;
            this.gbTipo.Text = "Tipo";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(205, 357);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 10;
            this.lblColor.Text = "Color";
            // 
            // cboColor
            // 
            this.cboColor.FormattingEnabled = true;
            this.cboColor.Location = new System.Drawing.Point(281, 354);
            this.cboColor.Name = "cboColor";
            this.cboColor.Size = new System.Drawing.Size(121, 21);
            this.cboColor.TabIndex = 11;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(208, 396);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(88, 13);
            this.lblNumero.TabIndex = 12;
            this.lblNumero.Text = "Numero Favorito:";
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(302, 394);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown.TabIndex = 13;
            // 
            // btnVerPerfil
            // 
            this.btnVerPerfil.Location = new System.Drawing.Point(577, 373);
            this.btnVerPerfil.Name = "btnVerPerfil";
            this.btnVerPerfil.Size = new System.Drawing.Size(75, 23);
            this.btnVerPerfil.TabIndex = 14;
            this.btnVerPerfil.Text = "Ver perfil";
            this.btnVerPerfil.UseVisualStyleBackColor = true;
            this.btnVerPerfil.Click += new System.EventHandler(this.btnVerPerfil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVerPerfil);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.cboColor);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.gbTipo);
            this.Controls.Add(this.cbChocolate);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNacimiento);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbTipo.ResumeLayout(false);
            this.gbTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.CheckBox cbChocolate;
        private System.Windows.Forms.RadioButton rbtMuggle;
        private System.Windows.Forms.RadioButton rbtWizard;
        private System.Windows.Forms.RadioButton rbtSquibs;
        private System.Windows.Forms.GroupBox gbTipo;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ComboBox cboColor;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Button btnVerPerfil;
    }
}

