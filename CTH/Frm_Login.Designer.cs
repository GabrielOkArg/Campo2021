
namespace CTH
{
    partial class Frm_Login
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblContra = new System.Windows.Forms.Label();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.Aceptar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Platform Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(23, 35);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(57, 20);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(26, 65);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(233, 20);
            this.txtUsuario.TabIndex = 1;
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.Font = new System.Drawing.Font("Platform Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContra.Location = new System.Drawing.Point(26, 104);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(79, 20);
            this.lblContra.TabIndex = 2;
            this.lblContra.Text = "Contraseña";
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(26, 134);
            this.txtContra.Name = "txtContra";
            this.txtContra.PasswordChar = '+';
            this.txtContra.Size = new System.Drawing.Size(233, 20);
            this.txtContra.TabIndex = 3;
            // 
            // Aceptar
            // 
            this.Aceptar.Font = new System.Drawing.Font("Platform Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aceptar.Location = new System.Drawing.Point(29, 194);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(75, 38);
            this.Aceptar.TabIndex = 4;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Font = new System.Drawing.Font("Platform Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.Location = new System.Drawing.Point(184, 194);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 38);
            this.Cancelar.TabIndex = 5;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 285);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.lblContra);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Name = "Frm_Login";
            this.Text = "Frm_Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Button Cancelar;
    }
}