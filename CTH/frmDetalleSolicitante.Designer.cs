﻿namespace CTH
{
    partial class frmDetalleSolicitante
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
            this.lblfechaalta = new System.Windows.Forms.Label();
            this.lblestado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha de solicitud";
            // 
            // lblfechaalta
            // 
            this.lblfechaalta.AutoSize = true;
            this.lblfechaalta.Location = new System.Drawing.Point(113, 13);
            this.lblfechaalta.Name = "lblfechaalta";
            this.lblfechaalta.Size = new System.Drawing.Size(0, 13);
            this.lblfechaalta.TabIndex = 1;
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Location = new System.Drawing.Point(232, 13);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(46, 13);
            this.lblestado.TabIndex = 2;
            this.lblestado.Text = "Estado: ";
            // 
            // frmDetalleSolicitante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.lblfechaalta);
            this.Controls.Add(this.label1);
            this.Name = "frmDetalleSolicitante";
            this.Text = "frmDetalleSolicitante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblfechaalta;
        private System.Windows.Forms.Label lblestado;
    }
}