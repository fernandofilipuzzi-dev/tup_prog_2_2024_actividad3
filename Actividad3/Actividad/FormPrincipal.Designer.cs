namespace Actividad3
{
    partial class FormPrincipal
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
            this.btnAltaComisaria = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnListrarIncidentes = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbAdministracion = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxIncidente = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMotivo = new System.Windows.Forms.TextBox();
            this.btnRegistrarIncidente = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.nupMIncidente = new System.Windows.Forms.NumericUpDown();
            this.nupHIncidente = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nupNumeroGuardia = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAginacionGuardias = new System.Windows.Forms.Button();
            this.nupMDuracion = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nupHGuardiaDesde = new System.Windows.Forms.NumericUpDown();
            this.nupMGuardiaDesde = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbNumeroPlaca = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.gbAdministracion.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupMIncidente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupHIncidente)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupNumeroGuardia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMDuracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupHGuardiaDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMGuardiaDesde)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAltaComisaria
            // 
            this.btnAltaComisaria.Location = new System.Drawing.Point(359, 25);
            this.btnAltaComisaria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAltaComisaria.Name = "btnAltaComisaria";
            this.btnAltaComisaria.Size = new System.Drawing.Size(132, 52);
            this.btnAltaComisaria.TabIndex = 0;
            this.btnAltaComisaria.Text = "Creación comisaría(1)";
            this.btnAltaComisaria.UseVisualStyleBackColor = true;
            this.btnAltaComisaria.Click += new System.EventHandler(this.btnAltaComisaria_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(264, 578);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(133, 52);
            this.btnCerrar.TabIndex = 14;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnListrarIncidentes
            // 
            this.btnListrarIncidentes.Location = new System.Drawing.Point(499, 25);
            this.btnListrarIncidentes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnListrarIncidentes.Name = "btnListrarIncidentes";
            this.btnListrarIncidentes.Size = new System.Drawing.Size(132, 52);
            this.btnListrarIncidentes.TabIndex = 1;
            this.btnListrarIncidentes.Text = "Listar incidentes(4)";
            this.btnListrarIncidentes.UseVisualStyleBackColor = true;
            this.btnListrarIncidentes.Click += new System.EventHandler(this.btnListrarIncidentes_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAltaComisaria);
            this.groupBox1.Controls.Add(this.btnListrarIncidentes);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 85);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administracion comisaría";
            // 
            // gbAdministracion
            // 
            this.gbAdministracion.Controls.Add(this.groupBox5);
            this.gbAdministracion.Controls.Add(this.groupBox3);
            this.gbAdministracion.Controls.Add(this.label1);
            this.gbAdministracion.Controls.Add(this.cmbNumeroPlaca);
            this.gbAdministracion.Enabled = false;
            this.gbAdministracion.Location = new System.Drawing.Point(12, 103);
            this.gbAdministracion.Name = "gbAdministracion";
            this.gbAdministracion.Size = new System.Drawing.Size(650, 467);
            this.gbAdministracion.TabIndex = 8;
            this.gbAdministracion.TabStop = false;
            this.gbAdministracion.Text = "Operaciones sobre el agente";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.cbxIncidente);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.tbNombre);
            this.groupBox5.Controls.Add(this.tbDNI);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.tbMotivo);
            this.groupBox5.Controls.Add(this.btnRegistrarIncidente);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.nupMIncidente);
            this.groupBox5.Controls.Add(this.nupHIncidente);
            this.groupBox5.Location = new System.Drawing.Point(21, 212);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(612, 233);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Administración de incidentes";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Tipo Incidente";
            // 
            // cbxIncidente
            // 
            this.cbxIncidente.FormattingEnabled = true;
            this.cbxIncidente.Items.AddRange(new object[] {
            "Denuncia",
            "Arresto"});
            this.cbxIncidente.Location = new System.Drawing.Point(157, 27);
            this.cbxIncidente.Name = "cbxIncidente";
            this.cbxIncidente.Size = new System.Drawing.Size(121, 28);
            this.cbxIncidente.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(321, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "DNI";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Persona";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(157, 110);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(158, 26);
            this.tbNombre.TabIndex = 8;
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(364, 110);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(96, 26);
            this.tbDNI.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Motivo:";
            // 
            // tbMotivo
            // 
            this.tbMotivo.Location = new System.Drawing.Point(157, 145);
            this.tbMotivo.Multiline = true;
            this.tbMotivo.Name = "tbMotivo";
            this.tbMotivo.Size = new System.Drawing.Size(303, 66);
            this.tbMotivo.TabIndex = 10;
            // 
            // btnRegistrarIncidente
            // 
            this.btnRegistrarIncidente.Location = new System.Drawing.Point(478, 160);
            this.btnRegistrarIncidente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegistrarIncidente.Name = "btnRegistrarIncidente";
            this.btnRegistrarIncidente.Size = new System.Drawing.Size(106, 51);
            this.btnRegistrarIncidente.TabIndex = 11;
            this.btnRegistrarIncidente.Text = "Registrar Indicente(3)";
            this.btnRegistrarIncidente.UseVisualStyleBackColor = true;
            this.btnRegistrarIncidente.Click += new System.EventHandler(this.btnRegistrarDenuncia_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Hora";
            // 
            // nupMIncidente
            // 
            this.nupMIncidente.Location = new System.Drawing.Point(231, 72);
            this.nupMIncidente.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nupMIncidente.Name = "nupMIncidente";
            this.nupMIncidente.Size = new System.Drawing.Size(59, 26);
            this.nupMIncidente.TabIndex = 7;
            // 
            // nupHIncidente
            // 
            this.nupHIncidente.Location = new System.Drawing.Point(157, 72);
            this.nupHIncidente.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nupHIncidente.Name = "nupHIncidente";
            this.nupHIncidente.Size = new System.Drawing.Size(62, 26);
            this.nupHIncidente.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nupNumeroGuardia);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnAginacionGuardias);
            this.groupBox3.Controls.Add(this.nupMDuracion);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.nupHGuardiaDesde);
            this.groupBox3.Controls.Add(this.nupMGuardiaDesde);
            this.groupBox3.Location = new System.Drawing.Point(21, 74);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(612, 132);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Administración de guardias";
            // 
            // nupNumeroGuardia
            // 
            this.nupNumeroGuardia.Location = new System.Drawing.Point(157, 25);
            this.nupNumeroGuardia.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupNumeroGuardia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nupNumeroGuardia.Name = "nupNumeroGuardia";
            this.nupNumeroGuardia.Size = new System.Drawing.Size(133, 26);
            this.nupNumeroGuardia.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Duracion en M";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nro Guardia";
            // 
            // btnAginacionGuardias
            // 
            this.btnAginacionGuardias.Location = new System.Drawing.Point(452, 43);
            this.btnAginacionGuardias.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAginacionGuardias.Name = "btnAginacionGuardias";
            this.btnAginacionGuardias.Size = new System.Drawing.Size(132, 52);
            this.btnAginacionGuardias.TabIndex = 5;
            this.btnAginacionGuardias.Text = "Asignación de las guardias(2)";
            this.btnAginacionGuardias.UseVisualStyleBackColor = true;
            this.btnAginacionGuardias.Click += new System.EventHandler(this.btnAsignarGuardias_Click);
            // 
            // nupMDuracion
            // 
            this.nupMDuracion.Location = new System.Drawing.Point(157, 91);
            this.nupMDuracion.Maximum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.nupMDuracion.Name = "nupMDuracion";
            this.nupMDuracion.Size = new System.Drawing.Size(133, 26);
            this.nupMDuracion.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Desde";
            // 
            // nupHGuardiaDesde
            // 
            this.nupHGuardiaDesde.Location = new System.Drawing.Point(157, 57);
            this.nupHGuardiaDesde.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nupHGuardiaDesde.Name = "nupHGuardiaDesde";
            this.nupHGuardiaDesde.Size = new System.Drawing.Size(62, 26);
            this.nupHGuardiaDesde.TabIndex = 2;
            // 
            // nupMGuardiaDesde
            // 
            this.nupMGuardiaDesde.Location = new System.Drawing.Point(231, 57);
            this.nupMGuardiaDesde.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nupMGuardiaDesde.Name = "nupMGuardiaDesde";
            this.nupMGuardiaDesde.Size = new System.Drawing.Size(59, 26);
            this.nupMGuardiaDesde.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Placa de Agente";
            // 
            // cmbNumeroPlaca
            // 
            this.cmbNumeroPlaca.FormattingEnabled = true;
            this.cmbNumeroPlaca.Location = new System.Drawing.Point(149, 27);
            this.cmbNumeroPlaca.Name = "cmbNumeroPlaca";
            this.cmbNumeroPlaca.Size = new System.Drawing.Size(133, 28);
            this.cmbNumeroPlaca.TabIndex = 2;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 634);
            this.Controls.Add(this.gbAdministracion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCerrar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPrincipal";
            this.Text = "Actividad 3 - \"Ana es policia!\"";
            this.groupBox1.ResumeLayout(false);
            this.gbAdministracion.ResumeLayout(false);
            this.gbAdministracion.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupMIncidente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupHIncidente)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupNumeroGuardia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMDuracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupHGuardiaDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMGuardiaDesde)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAltaComisaria;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnListrarIncidentes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbAdministracion;
        private System.Windows.Forms.Button btnAginacionGuardias;
        private System.Windows.Forms.ComboBox cmbNumeroPlaca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nupNumeroGuardia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nupMGuardiaDesde;
        private System.Windows.Forms.NumericUpDown nupMDuracion;
        private System.Windows.Forms.NumericUpDown nupHGuardiaDesde;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMotivo;
        private System.Windows.Forms.Button btnRegistrarIncidente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nupMIncidente;
        private System.Windows.Forms.NumericUpDown nupHIncidente;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxIncidente;
    }
}

