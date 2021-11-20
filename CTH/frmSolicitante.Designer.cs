namespace CTH
{
    partial class frmSolicitante
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
            this.dgvsolicitudes = new System.Windows.Forms.DataGridView();
            this.btnVer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsolicitudes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvsolicitudes
            // 
            this.dgvsolicitudes.AllowUserToAddRows = false;
            this.dgvsolicitudes.AllowUserToDeleteRows = false;
            this.dgvsolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsolicitudes.Location = new System.Drawing.Point(12, 29);
            this.dgvsolicitudes.Name = "dgvsolicitudes";
            this.dgvsolicitudes.ReadOnly = true;
            this.dgvsolicitudes.Size = new System.Drawing.Size(573, 213);
            this.dgvsolicitudes.TabIndex = 0;
            this.dgvsolicitudes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsolicitudes_CellContentClick);
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(12, 248);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(186, 23);
            this.btnVer.TabIndex = 1;
            this.btnVer.Text = "Ver detalle";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // frmSolicitante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 316);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.dgvsolicitudes);
            this.Name = "frmSolicitante";
            this.Text = "frmSolicitante";
            ((System.ComponentModel.ISupportInitialize)(this.dgvsolicitudes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvsolicitudes;
        private System.Windows.Forms.Button btnVer;
    }
}