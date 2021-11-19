
namespace CTH
{
    partial class NuevaOT
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
            this.cmbSector = new System.Windows.Forms.ComboBox();
            this.cmbEquipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cmbUrgencia = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Solicitante:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sector";
            // 
            // cmbSector
            // 
            this.cmbSector.FormattingEnabled = true;
            this.cmbSector.Location = new System.Drawing.Point(20, 95);
            this.cmbSector.Name = "cmbSector";
            this.cmbSector.Size = new System.Drawing.Size(215, 21);
            this.cmbSector.TabIndex = 2;
            this.cmbSector.SelectedIndexChanged += new System.EventHandler(this.cmbSector_SelectedIndexChanged);
            // 
            // cmbEquipo
            // 
            this.cmbEquipo.FormattingEnabled = true;
            this.cmbEquipo.Location = new System.Drawing.Point(299, 95);
            this.cmbEquipo.Name = "cmbEquipo";
            this.cmbEquipo.Size = new System.Drawing.Size(215, 21);
            this.cmbEquipo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(296, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Equipo (Opcional)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Descipción de la solicitud";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(23, 159);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(502, 174);
            this.txtDescripcion.TabIndex = 6;
            // 
            // cmbUrgencia
            // 
            this.cmbUrgencia.FormattingEnabled = true;
            this.cmbUrgencia.Location = new System.Drawing.Point(573, 95);
            this.cmbUrgencia.Name = "cmbUrgencia";
            this.cmbUrgencia.Size = new System.Drawing.Size(215, 21);
            this.cmbUrgencia.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(570, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Urgencia";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(573, 284);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(215, 49);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // NuevaOT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 375);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbUrgencia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbEquipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbSector);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NuevaOT";
            this.Text = "NuevaOT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSector;
        private System.Windows.Forms.ComboBox cmbEquipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cmbUrgencia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGuardar;
    }
}