namespace CTH
{
    partial class frmCoordinadornuevas
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
            this.dgvnuevas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnuevas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvnuevas
            // 
            this.dgvnuevas.AllowUserToAddRows = false;
            this.dgvnuevas.AllowUserToDeleteRows = false;
            this.dgvnuevas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnuevas.Location = new System.Drawing.Point(32, 96);
            this.dgvnuevas.Name = "dgvnuevas";
            this.dgvnuevas.ReadOnly = true;
            this.dgvnuevas.Size = new System.Drawing.Size(484, 329);
            this.dgvnuevas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nuevas Ordenes Solicitadas";
            // 
            // btnver
            // 
            this.btnver.Location = new System.Drawing.Point(32, 448);
            this.btnver.Name = "btnver";
            this.btnver.Size = new System.Drawing.Size(232, 23);
            this.btnver.TabIndex = 2;
            this.btnver.Text = "Ver seleccion";
            this.btnver.UseVisualStyleBackColor = true;
            this.btnver.Click += new System.EventHandler(this.btnver_Click);
            // 
            // frmCoordinadornuevas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 499);
            this.Controls.Add(this.btnver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvnuevas);
            this.Name = "frmCoordinadornuevas";
            this.Text = "frmCoordinadornuevas";
            this.Load += new System.EventHandler(this.frmCoordinadornuevas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvnuevas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvnuevas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnver;
    }
}