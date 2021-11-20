namespace CTH
{
    partial class frmdetallecoordinador
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.lblAsignado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.lblfechacreado = new System.Windows.Forms.Label();
            this.lblsolicitante = new System.Windows.Forms.Label();
            this.lblsector = new System.Windows.Forms.Label();
            this.lblequipo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblurgencia = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAsignar);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(23, 258);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asignacion de agente";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(7, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(199, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(249, 30);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(149, 23);
            this.btnAsignar.TabIndex = 1;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            // 
            // lblAsignado
            // 
            this.lblAsignado.AutoSize = true;
            this.lblAsignado.Location = new System.Drawing.Point(23, 203);
            this.lblAsignado.Name = "lblAsignado";
            this.lblAsignado.Size = new System.Drawing.Size(66, 13);
            this.lblAsignado.TabIndex = 1;
            this.lblAsignado.Text = "Asignado a: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Coordinador: ";
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(366, 382);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(109, 30);
            this.btnguardar.TabIndex = 3;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            // 
            // lblfechacreado
            // 
            this.lblfechacreado.AutoSize = true;
            this.lblfechacreado.Location = new System.Drawing.Point(20, 9);
            this.lblfechacreado.Name = "lblfechacreado";
            this.lblfechacreado.Size = new System.Drawing.Size(99, 13);
            this.lblfechacreado.TabIndex = 4;
            this.lblfechacreado.Text = "Fecha de solicitud: ";
            // 
            // lblsolicitante
            // 
            this.lblsolicitante.AutoSize = true;
            this.lblsolicitante.Location = new System.Drawing.Point(20, 41);
            this.lblsolicitante.Name = "lblsolicitante";
            this.lblsolicitante.Size = new System.Drawing.Size(62, 13);
            this.lblsolicitante.TabIndex = 5;
            this.lblsolicitante.Text = "Solicitante: ";
            // 
            // lblsector
            // 
            this.lblsector.AutoSize = true;
            this.lblsector.Location = new System.Drawing.Point(272, 8);
            this.lblsector.Name = "lblsector";
            this.lblsector.Size = new System.Drawing.Size(44, 13);
            this.lblsector.TabIndex = 6;
            this.lblsector.Text = "Sector: ";
            // 
            // lblequipo
            // 
            this.lblequipo.AutoSize = true;
            this.lblequipo.Location = new System.Drawing.Point(275, 40);
            this.lblequipo.Name = "lblequipo";
            this.lblequipo.Size = new System.Drawing.Size(46, 13);
            this.lblequipo.TabIndex = 7;
            this.lblequipo.Text = "Equipo: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtdescripcion);
            this.groupBox2.Location = new System.Drawing.Point(23, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(452, 145);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Descripción";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Enabled = false;
            this.txtdescripcion.Location = new System.Drawing.Point(7, 20);
            this.txtdescripcion.Multiline = true;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(439, 119);
            this.txtdescripcion.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(518, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Urgencia";
            // 
            // lblurgencia
            // 
            this.lblurgencia.AutoSize = true;
            this.lblurgencia.Location = new System.Drawing.Point(521, 91);
            this.lblurgencia.Name = "lblurgencia";
            this.lblurgencia.Size = new System.Drawing.Size(0, 13);
            this.lblurgencia.TabIndex = 10;
            // 
            // frmdetallecoordinador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblurgencia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblequipo);
            this.Controls.Add(this.lblsector);
            this.Controls.Add(this.lblsolicitante);
            this.Controls.Add(this.lblfechacreado);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAsignado);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmdetallecoordinador";
            this.Text = "Orden de trabajo nueva";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblAsignado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Label lblfechacreado;
        private System.Windows.Forms.Label lblsolicitante;
        private System.Windows.Forms.Label lblsector;
        private System.Windows.Forms.Label lblequipo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblurgencia;
    }
}