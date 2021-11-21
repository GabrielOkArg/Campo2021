namespace CTH
{
    partial class frmActualizarAgenteOT
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
            this.rbAbierta = new System.Windows.Forms.RadioButton();
            this.rbTerminada = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtxtdetalle = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblid = new System.Windows.Forms.Label();
            this.lblsolicitante = new System.Windows.Forms.Label();
            this.lblcoordinador = new System.Windows.Forms.Label();
            this.lblurgencia = new System.Windows.Forms.Label();
            this.lblequipo = new System.Windows.Forms.Label();
            this.lblsector = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnterminar = new System.Windows.Forms.Button();
            this.btndetalle = new System.Windows.Forms.Button();
            this.btndetalleot = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTerminada);
            this.groupBox1.Controls.Add(this.rbAbierta);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado de la Orden de Trabajo";
            // 
            // rbAbierta
            // 
            this.rbAbierta.AutoSize = true;
            this.rbAbierta.Location = new System.Drawing.Point(7, 20);
            this.rbAbierta.Name = "rbAbierta";
            this.rbAbierta.Size = new System.Drawing.Size(58, 17);
            this.rbAbierta.TabIndex = 0;
            this.rbAbierta.TabStop = true;
            this.rbAbierta.Text = "Abierta";
            this.rbAbierta.UseVisualStyleBackColor = true;
            // 
            // rbTerminada
            // 
            this.rbTerminada.AutoSize = true;
            this.rbTerminada.Location = new System.Drawing.Point(7, 56);
            this.rbTerminada.Name = "rbTerminada";
            this.rbTerminada.Size = new System.Drawing.Size(75, 17);
            this.rbTerminada.TabIndex = 1;
            this.rbTerminada.TabStop = true;
            this.rbTerminada.Text = "Terminada";
            this.rbTerminada.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtxtdetalle);
            this.groupBox2.Location = new System.Drawing.Point(20, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(741, 207);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle tecnico";
            // 
            // rtxtdetalle
            // 
            this.rtxtdetalle.Location = new System.Drawing.Point(7, 20);
            this.rtxtdetalle.Name = "rtxtdetalle";
            this.rtxtdetalle.Size = new System.Drawing.Size(716, 181);
            this.rtxtdetalle.TabIndex = 0;
            this.rtxtdetalle.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblsector);
            this.groupBox3.Controls.Add(this.lblequipo);
            this.groupBox3.Controls.Add(this.lblurgencia);
            this.groupBox3.Controls.Add(this.lblcoordinador);
            this.groupBox3.Controls.Add(this.lblsolicitante);
            this.groupBox3.Controls.Add(this.lblid);
            this.groupBox3.Location = new System.Drawing.Point(239, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(522, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos de Orden de Trabajo";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(7, 20);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(50, 13);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "Numero: ";
            // 
            // lblsolicitante
            // 
            this.lblsolicitante.AutoSize = true;
            this.lblsolicitante.Location = new System.Drawing.Point(119, 19);
            this.lblsolicitante.Name = "lblsolicitante";
            this.lblsolicitante.Size = new System.Drawing.Size(62, 13);
            this.lblsolicitante.TabIndex = 1;
            this.lblsolicitante.Text = "Solicitante: ";
            // 
            // lblcoordinador
            // 
            this.lblcoordinador.AutoSize = true;
            this.lblcoordinador.Location = new System.Drawing.Point(301, 19);
            this.lblcoordinador.Name = "lblcoordinador";
            this.lblcoordinador.Size = new System.Drawing.Size(64, 13);
            this.lblcoordinador.TabIndex = 2;
            this.lblcoordinador.Text = "Coordinador";
            // 
            // lblurgencia
            // 
            this.lblurgencia.AutoSize = true;
            this.lblurgencia.Location = new System.Drawing.Point(7, 57);
            this.lblurgencia.Name = "lblurgencia";
            this.lblurgencia.Size = new System.Drawing.Size(56, 13);
            this.lblurgencia.TabIndex = 3;
            this.lblurgencia.Text = "Urgencia: ";
            // 
            // lblequipo
            // 
            this.lblequipo.AutoSize = true;
            this.lblequipo.Location = new System.Drawing.Point(301, 57);
            this.lblequipo.Name = "lblequipo";
            this.lblequipo.Size = new System.Drawing.Size(46, 13);
            this.lblequipo.TabIndex = 4;
            this.lblequipo.Text = "Equipo: ";
            // 
            // lblsector
            // 
            this.lblsector.AutoSize = true;
            this.lblsector.Location = new System.Drawing.Point(119, 57);
            this.lblsector.Name = "lblsector";
            this.lblsector.Size = new System.Drawing.Size(44, 13);
            this.lblsector.TabIndex = 5;
            this.lblsector.Text = "Sector: ";
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(430, 374);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(156, 47);
            this.btnguardar.TabIndex = 3;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            // 
            // btnterminar
            // 
            this.btnterminar.Location = new System.Drawing.Point(605, 374);
            this.btnterminar.Name = "btnterminar";
            this.btnterminar.Size = new System.Drawing.Size(156, 47);
            this.btnterminar.TabIndex = 4;
            this.btnterminar.Text = "Terminar orden de trabajo";
            this.btnterminar.UseVisualStyleBackColor = true;
            // 
            // btndetalle
            // 
            this.btndetalle.Location = new System.Drawing.Point(239, 116);
            this.btndetalle.Name = "btndetalle";
            this.btndetalle.Size = new System.Drawing.Size(243, 24);
            this.btndetalle.TabIndex = 5;
            this.btndetalle.Text = "Ver detalle de equipo";
            this.btndetalle.UseVisualStyleBackColor = true;
            // 
            // btndetalleot
            // 
            this.btndetalleot.Location = new System.Drawing.Point(489, 116);
            this.btndetalleot.Name = "btndetalleot";
            this.btndetalleot.Size = new System.Drawing.Size(272, 23);
            this.btndetalleot.TabIndex = 6;
            this.btndetalleot.Text = "Ver descripcion de la orden";
            this.btndetalleot.UseVisualStyleBackColor = true;
            this.btndetalleot.Click += new System.EventHandler(this.btndetalleot_Click);
            // 
            // frmActualizarAgenteOT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btndetalleot);
            this.Controls.Add(this.btndetalle);
            this.Controls.Add(this.btnterminar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmActualizarAgenteOT";
            this.Text = "frmActualizarAgenteOT";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbTerminada;
        private System.Windows.Forms.RadioButton rbAbierta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtxtdetalle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblsector;
        private System.Windows.Forms.Label lblequipo;
        private System.Windows.Forms.Label lblurgencia;
        private System.Windows.Forms.Label lblcoordinador;
        private System.Windows.Forms.Label lblsolicitante;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnterminar;
        private System.Windows.Forms.Button btndetalle;
        private System.Windows.Forms.Button btndetalleot;
    }
}