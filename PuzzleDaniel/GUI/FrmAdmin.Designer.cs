namespace GUI
{
    partial class FrmAdmin
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
            this.pnlEditar = new System.Windows.Forms.Panel();
            this.listEditar = new System.Windows.Forms.ListBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.txtAgregar = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dimensionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.juegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.juegoNuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verJuegosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlJuego = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMsgJuego = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.lblFin = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.dtFin = new System.Windows.Forms.DateTimePicker();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.lblEvento = new System.Windows.Forms.Label();
            this.txtEvento = new System.Windows.Forms.TextBox();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.lblDimensiones = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.cbDimJ = new System.Windows.Forms.ComboBox();
            this.cbCatJ = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnlVerJuegos = new System.Windows.Forms.Panel();
            this.listJuegos = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMsgVerJ = new System.Windows.Forms.Label();
            this.btnPublicar = new System.Windows.Forms.Button();
            this.pnlEditar.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnlJuego.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.pnlVerJuegos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEditar
            // 
            this.pnlEditar.Controls.Add(this.listEditar);
            this.pnlEditar.Controls.Add(this.lblMsg);
            this.pnlEditar.Controls.Add(this.txtAgregar);
            this.pnlEditar.Controls.Add(this.btnAgregar);
            this.pnlEditar.Controls.Add(this.btnEliminar);
            this.pnlEditar.Location = new System.Drawing.Point(30, 55);
            this.pnlEditar.Name = "pnlEditar";
            this.pnlEditar.Size = new System.Drawing.Size(381, 302);
            this.pnlEditar.TabIndex = 11;
            // 
            // listEditar
            // 
            this.listEditar.FormattingEnabled = true;
            this.listEditar.Location = new System.Drawing.Point(86, 19);
            this.listEditar.Name = "listEditar";
            this.listEditar.Size = new System.Drawing.Size(166, 147);
            this.listEditar.TabIndex = 2;
            // 
            // lblMsg
            // 
            this.lblMsg.Location = new System.Drawing.Point(29, 255);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(300, 23);
            this.lblMsg.TabIndex = 8;
            // 
            // txtAgregar
            // 
            this.txtAgregar.Location = new System.Drawing.Point(86, 172);
            this.txtAgregar.Name = "txtAgregar";
            this.txtAgregar.Size = new System.Drawing.Size(100, 20);
            this.txtAgregar.TabIndex = 9;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(86, 204);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(177, 204);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.juegoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(638, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriaToolStripMenuItem,
            this.dimensionToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.categoriaToolStripMenuItem.Text = "Categoría";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // dimensionToolStripMenuItem
            // 
            this.dimensionToolStripMenuItem.Name = "dimensionToolStripMenuItem";
            this.dimensionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dimensionToolStripMenuItem.Text = "Dimensión";
            this.dimensionToolStripMenuItem.Click += new System.EventHandler(this.dimensionToolStripMenuItem_Click);
            // 
            // juegoToolStripMenuItem
            // 
            this.juegoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.juegoNuevoToolStripMenuItem,
            this.verJuegosToolStripMenuItem});
            this.juegoToolStripMenuItem.Name = "juegoToolStripMenuItem";
            this.juegoToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.juegoToolStripMenuItem.Text = "Juego";
            // 
            // juegoNuevoToolStripMenuItem
            // 
            this.juegoNuevoToolStripMenuItem.Name = "juegoNuevoToolStripMenuItem";
            this.juegoNuevoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.juegoNuevoToolStripMenuItem.Text = "Juego nuevo";
            this.juegoNuevoToolStripMenuItem.Click += new System.EventHandler(this.juegoNuevoToolStripMenuItem_Click);
            // 
            // verJuegosToolStripMenuItem
            // 
            this.verJuegosToolStripMenuItem.Name = "verJuegosToolStripMenuItem";
            this.verJuegosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.verJuegosToolStripMenuItem.Text = "Ver juegos";
            this.verJuegosToolStripMenuItem.Click += new System.EventHandler(this.verJuegosToolStripMenuItem_Click);
            // 
            // pnlJuego
            // 
            this.pnlJuego.Controls.Add(this.label1);
            this.pnlJuego.Controls.Add(this.lblMsgJuego);
            this.pnlJuego.Controls.Add(this.btnCrear);
            this.pnlJuego.Controls.Add(this.lblFin);
            this.pnlJuego.Controls.Add(this.lblInicio);
            this.pnlJuego.Controls.Add(this.dtFin);
            this.pnlJuego.Controls.Add(this.dtInicio);
            this.pnlJuego.Controls.Add(this.lblEvento);
            this.pnlJuego.Controls.Add(this.txtEvento);
            this.pnlJuego.Controls.Add(this.pbFoto);
            this.pnlJuego.Controls.Add(this.lblDimensiones);
            this.pnlJuego.Controls.Add(this.lblCat);
            this.pnlJuego.Controls.Add(this.cbDimJ);
            this.pnlJuego.Controls.Add(this.cbCatJ);
            this.pnlJuego.Location = new System.Drawing.Point(13, 28);
            this.pnlJuego.Name = "pnlJuego";
            this.pnlJuego.Size = new System.Drawing.Size(585, 353);
            this.pnlJuego.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Imagen";
            // 
            // lblMsgJuego
            // 
            this.lblMsgJuego.Location = new System.Drawing.Point(71, 306);
            this.lblMsgJuego.Name = "lblMsgJuego";
            this.lblMsgJuego.Size = new System.Drawing.Size(375, 23);
            this.lblMsgJuego.TabIndex = 12;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(479, 306);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 11;
            this.btnCrear.Text = "Crear Juego";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.Location = new System.Drawing.Point(276, 214);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(59, 13);
            this.lblFin.TabIndex = 10;
            this.lblFin.Text = "Fecha final";
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(40, 215);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(65, 13);
            this.lblInicio.TabIndex = 9;
            this.lblInicio.Text = "Fecha Inicio";
            // 
            // dtFin
            // 
            this.dtFin.Location = new System.Drawing.Point(276, 234);
            this.dtFin.Name = "dtFin";
            this.dtFin.Size = new System.Drawing.Size(200, 20);
            this.dtFin.TabIndex = 8;
            this.dtFin.Value = new System.DateTime(2016, 4, 28, 0, 0, 0, 0);
            // 
            // dtInicio
            // 
            this.dtInicio.Location = new System.Drawing.Point(40, 234);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(200, 20);
            this.dtInicio.TabIndex = 7;
            this.dtInicio.Value = new System.DateTime(2016, 4, 28, 0, 0, 0, 0);
            // 
            // lblEvento
            // 
            this.lblEvento.AutoSize = true;
            this.lblEvento.Location = new System.Drawing.Point(40, 153);
            this.lblEvento.Name = "lblEvento";
            this.lblEvento.Size = new System.Drawing.Size(41, 13);
            this.lblEvento.TabIndex = 6;
            this.lblEvento.Text = "Evento";
            // 
            // txtEvento
            // 
            this.txtEvento.Location = new System.Drawing.Point(40, 173);
            this.txtEvento.Name = "txtEvento";
            this.txtEvento.Size = new System.Drawing.Size(368, 20);
            this.txtEvento.TabIndex = 5;
            // 
            // pbFoto
            // 
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoto.Location = new System.Drawing.Point(404, 17);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(161, 149);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 4;
            this.pbFoto.TabStop = false;
            this.pbFoto.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblDimensiones
            // 
            this.lblDimensiones.AutoSize = true;
            this.lblDimensiones.Location = new System.Drawing.Point(40, 78);
            this.lblDimensiones.Name = "lblDimensiones";
            this.lblDimensiones.Size = new System.Drawing.Size(67, 13);
            this.lblDimensiones.TabIndex = 3;
            this.lblDimensiones.Text = "Dimensiones";
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Location = new System.Drawing.Point(40, 27);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(59, 13);
            this.lblCat.TabIndex = 2;
            this.lblCat.Text = "Categorías";
            // 
            // cbDimJ
            // 
            this.cbDimJ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDimJ.FormattingEnabled = true;
            this.cbDimJ.Location = new System.Drawing.Point(40, 94);
            this.cbDimJ.Name = "cbDimJ";
            this.cbDimJ.Size = new System.Drawing.Size(121, 21);
            this.cbDimJ.TabIndex = 1;
            // 
            // cbCatJ
            // 
            this.cbCatJ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCatJ.FormattingEnabled = true;
            this.cbCatJ.Location = new System.Drawing.Point(40, 46);
            this.cbCatJ.Name = "cbCatJ";
            this.cbCatJ.Size = new System.Drawing.Size(121, 21);
            this.cbCatJ.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pnlVerJuegos
            // 
            this.pnlVerJuegos.Controls.Add(this.listJuegos);
            this.pnlVerJuegos.Controls.Add(this.label2);
            this.pnlVerJuegos.Controls.Add(this.lblMsgVerJ);
            this.pnlVerJuegos.Controls.Add(this.btnPublicar);
            this.pnlVerJuegos.Location = new System.Drawing.Point(0, 27);
            this.pnlVerJuegos.Name = "pnlVerJuegos";
            this.pnlVerJuegos.Size = new System.Drawing.Size(585, 353);
            this.pnlVerJuegos.TabIndex = 13;
            // 
            // listJuegos
            // 
            this.listJuegos.FormattingEnabled = true;
            this.listJuegos.Location = new System.Drawing.Point(41, 46);
            this.listJuegos.Name = "listJuegos";
            this.listJuegos.Size = new System.Drawing.Size(162, 225);
            this.listJuegos.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Juegos";
            // 
            // lblMsgVerJ
            // 
            this.lblMsgVerJ.Location = new System.Drawing.Point(74, 306);
            this.lblMsgVerJ.Name = "lblMsgVerJ";
            this.lblMsgVerJ.Size = new System.Drawing.Size(372, 23);
            this.lblMsgVerJ.TabIndex = 2;
            // 
            // btnPublicar
            // 
            this.btnPublicar.Location = new System.Drawing.Point(233, 235);
            this.btnPublicar.Name = "btnPublicar";
            this.btnPublicar.Size = new System.Drawing.Size(75, 23);
            this.btnPublicar.TabIndex = 1;
            this.btnPublicar.Text = "Publicar";
            this.btnPublicar.UseVisualStyleBackColor = true;
            this.btnPublicar.Click += new System.EventHandler(this.btnPublicar_Click);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 393);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlJuego);
            this.Controls.Add(this.pnlEditar);
            this.Controls.Add(this.pnlVerJuegos);
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Close);
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.pnlEditar.ResumeLayout(false);
            this.pnlEditar.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlJuego.ResumeLayout(false);
            this.pnlJuego.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.pnlVerJuegos.ResumeLayout(false);
            this.pnlVerJuegos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlEditar;
        private System.Windows.Forms.ListBox listEditar;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.TextBox txtAgregar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dimensionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem juegoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem juegoNuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verJuegosToolStripMenuItem;
        private System.Windows.Forms.Panel pnlJuego;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.DateTimePicker dtFin;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.Label lblEvento;
        private System.Windows.Forms.TextBox txtEvento;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Label lblDimensiones;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.ComboBox cbDimJ;
        private System.Windows.Forms.ComboBox cbCatJ;
        private System.Windows.Forms.Label lblMsgJuego;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel pnlVerJuegos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMsgVerJ;
        private System.Windows.Forms.Button btnPublicar;
        private System.Windows.Forms.ListBox listJuegos;
        private System.Windows.Forms.Label label1;
    }
}