namespace CTH
{
    partial class CTH_home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patentesYFamiliasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InicioSolicitante = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaOrdenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.misOrdenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inicioAgente = new System.Windows.Forms.ToolStripMenuItem();
            this.oTAsignadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oTFinalizadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inicioCoordinador = new System.Windows.Forms.ToolStripMenuItem();
            this.oTNuevasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oTTerminadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaOrdenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inicioJefeTecnico = new System.Windows.Forms.ToolStripMenuItem();
            this.oTNuevaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oTTerminadasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.oTFinalizadasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.oTCerradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_usuarioconectado = new System.Windows.Forms.Label();
            this.treeHome = new System.Windows.Forms.TreeView();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.configuracionToolStripMenuItem,
            this.InicioSolicitante,
            this.inicioAgente,
            this.inicioCoordinador,
            this.inicioJefeTecnico});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1246, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarSesionToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(72, 22);
            this.inicioToolStripMenuItem.Text = "Usuario";
            // 
            // iniciarSesionToolStripMenuItem
            // 
            this.iniciarSesionToolStripMenuItem.Name = "iniciarSesionToolStripMenuItem";
            this.iniciarSesionToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.iniciarSesionToolStripMenuItem.Text = "Iniciar Sesion";
            this.iniciarSesionToolStripMenuItem.Click += new System.EventHandler(this.iniciarSesionToolStripMenuItem_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.BackgroundImage = global::CTH.Properties.Resources.fondo;
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patentesYFamiliasToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.configuracionToolStripMenuItem.Text = "Configuracion";
            // 
            // patentesYFamiliasToolStripMenuItem
            // 
            this.patentesYFamiliasToolStripMenuItem.Name = "patentesYFamiliasToolStripMenuItem";
            this.patentesYFamiliasToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.patentesYFamiliasToolStripMenuItem.Text = "Patentes y Familias";
            this.patentesYFamiliasToolStripMenuItem.Click += new System.EventHandler(this.patentesYFamiliasToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // InicioSolicitante
            // 
            this.InicioSolicitante.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaOrdenToolStripMenuItem,
            this.misOrdenesToolStripMenuItem});
            this.InicioSolicitante.Name = "InicioSolicitante";
            this.InicioSolicitante.Size = new System.Drawing.Size(54, 22);
            this.InicioSolicitante.Text = "Inicio";
            // 
            // nuevaOrdenToolStripMenuItem
            // 
            this.nuevaOrdenToolStripMenuItem.Name = "nuevaOrdenToolStripMenuItem";
            this.nuevaOrdenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevaOrdenToolStripMenuItem.Text = "Nueva Orden";
            this.nuevaOrdenToolStripMenuItem.Click += new System.EventHandler(this.nuevaOrdenToolStripMenuItem_Click);
            // 
            // misOrdenesToolStripMenuItem
            // 
            this.misOrdenesToolStripMenuItem.Name = "misOrdenesToolStripMenuItem";
            this.misOrdenesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.misOrdenesToolStripMenuItem.Text = "Mis Ordenes";
            this.misOrdenesToolStripMenuItem.Click += new System.EventHandler(this.misOrdenesToolStripMenuItem_Click);
            // 
            // inicioAgente
            // 
            this.inicioAgente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oTAsignadasToolStripMenuItem,
            this.oTFinalizadasToolStripMenuItem});
            this.inicioAgente.Name = "inicioAgente";
            this.inicioAgente.Size = new System.Drawing.Size(54, 22);
            this.inicioAgente.Text = "Inicio";
            // 
            // oTAsignadasToolStripMenuItem
            // 
            this.oTAsignadasToolStripMenuItem.Name = "oTAsignadasToolStripMenuItem";
            this.oTAsignadasToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.oTAsignadasToolStripMenuItem.Text = "OT asignadas";
            // 
            // oTFinalizadasToolStripMenuItem
            // 
            this.oTFinalizadasToolStripMenuItem.Name = "oTFinalizadasToolStripMenuItem";
            this.oTFinalizadasToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.oTFinalizadasToolStripMenuItem.Text = "OT finalizadas";
            // 
            // inicioCoordinador
            // 
            this.inicioCoordinador.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oTNuevasToolStripMenuItem,
            this.oTTerminadasToolStripMenuItem,
            this.nuevaOrdenToolStripMenuItem1});
            this.inicioCoordinador.Name = "inicioCoordinador";
            this.inicioCoordinador.Size = new System.Drawing.Size(54, 22);
            this.inicioCoordinador.Text = "Inicio";
            // 
            // oTNuevasToolStripMenuItem
            // 
            this.oTNuevasToolStripMenuItem.Name = "oTNuevasToolStripMenuItem";
            this.oTNuevasToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.oTNuevasToolStripMenuItem.Text = "OT Nuevas";
            this.oTNuevasToolStripMenuItem.Click += new System.EventHandler(this.oTNuevasToolStripMenuItem_Click);
            // 
            // oTTerminadasToolStripMenuItem
            // 
            this.oTTerminadasToolStripMenuItem.Name = "oTTerminadasToolStripMenuItem";
            this.oTTerminadasToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.oTTerminadasToolStripMenuItem.Text = "OT Terminadas";
            // 
            // nuevaOrdenToolStripMenuItem1
            // 
            this.nuevaOrdenToolStripMenuItem1.Name = "nuevaOrdenToolStripMenuItem1";
            this.nuevaOrdenToolStripMenuItem1.Size = new System.Drawing.Size(179, 22);
            this.nuevaOrdenToolStripMenuItem1.Text = "Nueva Orden";
            // 
            // inicioJefeTecnico
            // 
            this.inicioJefeTecnico.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oTNuevaToolStripMenuItem,
            this.oTTerminadasToolStripMenuItem1,
            this.oTFinalizadasToolStripMenuItem1,
            this.oTCerradasToolStripMenuItem,
            this.informesToolStripMenuItem});
            this.inicioJefeTecnico.Name = "inicioJefeTecnico";
            this.inicioJefeTecnico.Size = new System.Drawing.Size(54, 22);
            this.inicioJefeTecnico.Text = "Inicio";
            // 
            // oTNuevaToolStripMenuItem
            // 
            this.oTNuevaToolStripMenuItem.Name = "oTNuevaToolStripMenuItem";
            this.oTNuevaToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.oTNuevaToolStripMenuItem.Text = "OT Nueva";
            // 
            // oTTerminadasToolStripMenuItem1
            // 
            this.oTTerminadasToolStripMenuItem1.Name = "oTTerminadasToolStripMenuItem1";
            this.oTTerminadasToolStripMenuItem1.Size = new System.Drawing.Size(179, 22);
            this.oTTerminadasToolStripMenuItem1.Text = "OT Terminadas";
            // 
            // oTFinalizadasToolStripMenuItem1
            // 
            this.oTFinalizadasToolStripMenuItem1.Name = "oTFinalizadasToolStripMenuItem1";
            this.oTFinalizadasToolStripMenuItem1.Size = new System.Drawing.Size(179, 22);
            this.oTFinalizadasToolStripMenuItem1.Text = "OT Finalizadas";
            // 
            // oTCerradasToolStripMenuItem
            // 
            this.oTCerradasToolStripMenuItem.Name = "oTCerradasToolStripMenuItem";
            this.oTCerradasToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.oTCerradasToolStripMenuItem.Text = "OT cerradas";
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.equipoToolStripMenuItem,
            this.agenteToolStripMenuItem});
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.informesToolStripMenuItem.Text = "Informes";
            // 
            // equipoToolStripMenuItem
            // 
            this.equipoToolStripMenuItem.Name = "equipoToolStripMenuItem";
            this.equipoToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.equipoToolStripMenuItem.Text = "Equipo";
            // 
            // agenteToolStripMenuItem
            // 
            this.agenteToolStripMenuItem.Name = "agenteToolStripMenuItem";
            this.agenteToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.agenteToolStripMenuItem.Text = "Agente";
            // 
            // lbl_usuarioconectado
            // 
            this.lbl_usuarioconectado.AutoSize = true;
            this.lbl_usuarioconectado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuarioconectado.Location = new System.Drawing.Point(975, 570);
            this.lbl_usuarioconectado.Name = "lbl_usuarioconectado";
            this.lbl_usuarioconectado.Size = new System.Drawing.Size(66, 24);
            this.lbl_usuarioconectado.TabIndex = 1;
            this.lbl_usuarioconectado.Text = "label1";
            this.lbl_usuarioconectado.Visible = false;
            this.lbl_usuarioconectado.Click += new System.EventHandler(this.lbl_usuarioconectado_Click);
            // 
            // treeHome
            // 
            this.treeHome.Location = new System.Drawing.Point(359, 116);
            this.treeHome.Name = "treeHome";
            this.treeHome.Size = new System.Drawing.Size(425, 215);
            this.treeHome.TabIndex = 2;
            // 
            // CTH_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 628);
            this.Controls.Add(this.treeHome);
            this.Controls.Add(this.lbl_usuarioconectado);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CTH_home";
            this.Text = "CTH";
            this.Load += new System.EventHandler(this.CTH_home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarSesionToolStripMenuItem;
        private System.Windows.Forms.Label lbl_usuarioconectado;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patentesYFamiliasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.TreeView treeHome;
        private System.Windows.Forms.ToolStripMenuItem InicioSolicitante;
        private System.Windows.Forms.ToolStripMenuItem nuevaOrdenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem misOrdenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inicioAgente;
        private System.Windows.Forms.ToolStripMenuItem oTAsignadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oTFinalizadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inicioCoordinador;
        private System.Windows.Forms.ToolStripMenuItem oTNuevasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oTTerminadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaOrdenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem inicioJefeTecnico;
        private System.Windows.Forms.ToolStripMenuItem oTNuevaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oTTerminadasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem oTFinalizadasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem oTCerradasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agenteToolStripMenuItem;
    }
}

