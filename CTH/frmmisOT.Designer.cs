namespace CTH
{
    partial class frmmisOT
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
            this.dgvot = new System.Windows.Forms.DataGridView();
            this.lblfechasolicitud = new System.Windows.Forms.Label();
            this.lblcoordinador = new System.Windows.Forms.Label();
            this.lblsector = new System.Windows.Forms.Label();
            this.lblurgencia = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvequipo = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvequipo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvot
            // 
            this.dgvot.AllowUserToAddRows = false;
            this.dgvot.AllowUserToDeleteRows = false;
            this.dgvot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvot.Location = new System.Drawing.Point(13, 13);
            this.dgvot.Name = "dgvot";
            this.dgvot.ReadOnly = true;
            this.dgvot.Size = new System.Drawing.Size(759, 207);
            this.dgvot.TabIndex = 0;
            this.dgvot.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvot_CellContentClick);
            // 
            // lblfechasolicitud
            // 
            this.lblfechasolicitud.AutoSize = true;
            this.lblfechasolicitud.Location = new System.Drawing.Point(12, 239);
            this.lblfechasolicitud.Name = "lblfechasolicitud";
            this.lblfechasolicitud.Size = new System.Drawing.Size(59, 13);
            this.lblfechasolicitud.TabIndex = 1;
            this.lblfechasolicitud.Text = "Solicitado: ";
            // 
            // lblcoordinador
            // 
            this.lblcoordinador.AutoSize = true;
            this.lblcoordinador.Location = new System.Drawing.Point(190, 239);
            this.lblcoordinador.Name = "lblcoordinador";
            this.lblcoordinador.Size = new System.Drawing.Size(70, 13);
            this.lblcoordinador.TabIndex = 2;
            this.lblcoordinador.Text = "Coordinador: ";
            // 
            // lblsector
            // 
            this.lblsector.AutoSize = true;
            this.lblsector.Location = new System.Drawing.Point(398, 240);
            this.lblsector.Name = "lblsector";
            this.lblsector.Size = new System.Drawing.Size(44, 13);
            this.lblsector.TabIndex = 3;
            this.lblsector.Text = "Sector: ";
            // 
            // lblurgencia
            // 
            this.lblurgencia.AutoSize = true;
            this.lblurgencia.Location = new System.Drawing.Point(675, 240);
            this.lblurgencia.Name = "lblurgencia";
            this.lblurgencia.Size = new System.Drawing.Size(0, 13);
            this.lblurgencia.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(609, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Urgencia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Detalle";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 288);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(429, 147);
            this.textBox1.TabIndex = 7;
            // 
            // dgvequipo
            // 
            this.dgvequipo.AllowUserToAddRows = false;
            this.dgvequipo.AllowUserToDeleteRows = false;
            this.dgvequipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvequipo.Location = new System.Drawing.Point(449, 288);
            this.dgvequipo.Name = "dgvequipo";
            this.dgvequipo.ReadOnly = true;
            this.dgvequipo.Size = new System.Drawing.Size(323, 96);
            this.dgvequipo.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(449, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Equipo afectado";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(470, 390);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(302, 44);
            this.btnActualizar.TabIndex = 10;
            this.btnActualizar.Text = "Actualizar Orden";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // frmmisOT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvequipo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblurgencia);
            this.Controls.Add(this.lblsector);
            this.Controls.Add(this.lblcoordinador);
            this.Controls.Add(this.lblfechasolicitud);
            this.Controls.Add(this.dgvot);
            this.Name = "frmmisOT";
            this.Text = "frmmisOT";
            ((System.ComponentModel.ISupportInitialize)(this.dgvot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvequipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvot;
        private System.Windows.Forms.Label lblfechasolicitud;
        private System.Windows.Forms.Label lblcoordinador;
        private System.Windows.Forms.Label lblsector;
        private System.Windows.Forms.Label lblurgencia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvequipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnActualizar;
    }
}