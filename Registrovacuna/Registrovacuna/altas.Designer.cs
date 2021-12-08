
namespace Registrovacuna
{
    partial class altas
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
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtappaterno = new System.Windows.Forms.TextBox();
            this.txtapmaterno = new System.Windows.Forms.TextBox();
            this.txtfechanac = new System.Windows.Forms.TextBox();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.lblcurp = new System.Windows.Forms.Label();
            this.cmbsexo = new System.Windows.Forms.ComboBox();
            this.lblsexo = new System.Windows.Forms.Label();
            this.txtlugarnac = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(67, 24);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(351, 31);
            this.txtnombre.TabIndex = 0;
            this.txtnombre.Text = "Nombre(s)";
            this.txtnombre.Click += new System.EventHandler(this.txtnombre_Click);
            // 
            // txtappaterno
            // 
            this.txtappaterno.Location = new System.Drawing.Point(67, 62);
            this.txtappaterno.Name = "txtappaterno";
            this.txtappaterno.Size = new System.Drawing.Size(351, 31);
            this.txtappaterno.TabIndex = 1;
            this.txtappaterno.Text = "Primer apellido";
            this.txtappaterno.Click += new System.EventHandler(this.txtappaterno_Click);
            // 
            // txtapmaterno
            // 
            this.txtapmaterno.Location = new System.Drawing.Point(67, 100);
            this.txtapmaterno.Name = "txtapmaterno";
            this.txtapmaterno.Size = new System.Drawing.Size(351, 31);
            this.txtapmaterno.TabIndex = 2;
            this.txtapmaterno.Text = "Segundo apellido";
            this.txtapmaterno.Click += new System.EventHandler(this.txtapmaterno_Click);
            // 
            // txtfechanac
            // 
            this.txtfechanac.Enabled = false;
            this.txtfechanac.Location = new System.Drawing.Point(67, 138);
            this.txtfechanac.Name = "txtfechanac";
            this.txtfechanac.Size = new System.Drawing.Size(198, 31);
            this.txtfechanac.TabIndex = 3;
            this.txtfechanac.Text = "Fecha de nacimiento";
            // 
            // dtpfecha
            // 
            this.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfecha.Location = new System.Drawing.Point(267, 138);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(151, 31);
            this.dtpfecha.TabIndex = 4;
            this.dtpfecha.ValueChanged += new System.EventHandler(this.dtpfecha_ValueChanged);
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(67, 324);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(351, 31);
            this.txtcorreo.TabIndex = 7;
            this.txtcorreo.Text = "Correo electronico";
            this.txtcorreo.Click += new System.EventHandler(this.txtcorreo_Click);
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(67, 361);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(351, 31);
            this.txttelefono.TabIndex = 8;
            this.txttelefono.Text = "Numero de telefono";
            this.txttelefono.Click += new System.EventHandler(this.txttelefono_Click);
            // 
            // btnregistrar
            // 
            this.btnregistrar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnregistrar.Location = new System.Drawing.Point(67, 449);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(351, 40);
            this.btnregistrar.TabIndex = 9;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btncancelar.Location = new System.Drawing.Point(67, 495);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(351, 40);
            this.btncancelar.TabIndex = 10;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // lblcurp
            // 
            this.lblcurp.AutoSize = true;
            this.lblcurp.Location = new System.Drawing.Point(158, 499);
            this.lblcurp.Name = "lblcurp";
            this.lblcurp.Size = new System.Drawing.Size(0, 25);
            this.lblcurp.TabIndex = 12;
            this.lblcurp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbsexo
            // 
            this.cmbsexo.FormattingEnabled = true;
            this.cmbsexo.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.cmbsexo.Location = new System.Drawing.Point(236, 212);
            this.cmbsexo.Name = "cmbsexo";
            this.cmbsexo.Size = new System.Drawing.Size(182, 33);
            this.cmbsexo.TabIndex = 6;
            // 
            // lblsexo
            // 
            this.lblsexo.AutoSize = true;
            this.lblsexo.Location = new System.Drawing.Point(67, 220);
            this.lblsexo.Name = "lblsexo";
            this.lblsexo.Size = new System.Drawing.Size(50, 25);
            this.lblsexo.TabIndex = 14;
            this.lblsexo.Text = "Sexo";
            // 
            // txtlugarnac
            // 
            this.txtlugarnac.Location = new System.Drawing.Point(67, 175);
            this.txtlugarnac.Name = "txtlugarnac";
            this.txtlugarnac.Size = new System.Drawing.Size(351, 31);
            this.txtlugarnac.TabIndex = 5;
            this.txtlugarnac.Text = "Lugar de nacimiento";
            this.txtlugarnac.Click += new System.EventHandler(this.txtlugarnac_Click);
            // 
            // altas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(480, 545);
            this.Controls.Add(this.txtlugarnac);
            this.Controls.Add(this.lblsexo);
            this.Controls.Add(this.cmbsexo);
            this.Controls.Add(this.lblcurp);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.txtfechanac);
            this.Controls.Add(this.txtapmaterno);
            this.Controls.Add(this.txtappaterno);
            this.Controls.Add(this.txtnombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "altas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear cuenta";
            this.Load += new System.EventHandler(this.altas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtappaterno;
        private System.Windows.Forms.TextBox txtapmaterno;
        private System.Windows.Forms.TextBox txtfechanac;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label lblcurp;
        private System.Windows.Forms.ComboBox cmbsexo;
        private System.Windows.Forms.Label lblsexo;
        private System.Windows.Forms.TextBox txtlugarnac;
    }
}