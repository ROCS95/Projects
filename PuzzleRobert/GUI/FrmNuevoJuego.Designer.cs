namespace GUI
{
    partial class FrmNuevoJuego
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
            this.lblpic = new System.Windows.Forms.Label();
            this.pbxImgenJuego = new System.Windows.Forms.PictureBox();
            this.cbxDimenciones = new System.Windows.Forms.ComboBox();
            this.cbxCategorias = new System.Windows.Forms.ComboBox();
            this.lbldim = new System.Windows.Forms.Label();
            this.lblcat = new System.Windows.Forms.Label();
            this.tbxDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescrip = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.lblFInicio = new System.Windows.Forms.Label();
            this.lblFFinal = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblMensaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImgenJuego)).BeginInit();
            this.SuspendLayout();
            // 
            // lblpic
            // 
            this.lblpic.AutoSize = true;
            this.lblpic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpic.Location = new System.Drawing.Point(25, 13);
            this.lblpic.Name = "lblpic";
            this.lblpic.Size = new System.Drawing.Size(128, 16);
            this.lblpic.TabIndex = 1;
            this.lblpic.Text = "Imagen del juego";
            // 
            // pbxImgenJuego
            // 
            this.pbxImgenJuego.Image = global::GUI.Properties.Resources.jpg_jpeg_512;
            this.pbxImgenJuego.Location = new System.Drawing.Point(25, 35);
            this.pbxImgenJuego.Name = "pbxImgenJuego";
            this.pbxImgenJuego.Size = new System.Drawing.Size(177, 177);
            this.pbxImgenJuego.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImgenJuego.TabIndex = 0;
            this.pbxImgenJuego.TabStop = false;
            this.pbxImgenJuego.Click += new System.EventHandler(this.pbxImgenJuego_Click);
            // 
            // cbxDimenciones
            // 
            this.cbxDimenciones.FormattingEnabled = true;
            this.cbxDimenciones.Location = new System.Drawing.Point(274, 76);
            this.cbxDimenciones.Name = "cbxDimenciones";
            this.cbxDimenciones.Size = new System.Drawing.Size(116, 21);
            this.cbxDimenciones.TabIndex = 2;
            // 
            // cbxCategorias
            // 
            this.cbxCategorias.FormattingEnabled = true;
            this.cbxCategorias.Location = new System.Drawing.Point(274, 155);
            this.cbxCategorias.Name = "cbxCategorias";
            this.cbxCategorias.Size = new System.Drawing.Size(116, 21);
            this.cbxCategorias.TabIndex = 3;
            // 
            // lbldim
            // 
            this.lbldim.AutoSize = true;
            this.lbldim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldim.Location = new System.Drawing.Point(271, 43);
            this.lbldim.Name = "lbldim";
            this.lbldim.Size = new System.Drawing.Size(98, 16);
            this.lbldim.TabIndex = 4;
            this.lbldim.Text = "Dimenciones";
            // 
            // lblcat
            // 
            this.lblcat.AutoSize = true;
            this.lblcat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcat.Location = new System.Drawing.Point(271, 120);
            this.lblcat.Name = "lblcat";
            this.lblcat.Size = new System.Drawing.Size(76, 16);
            this.lblcat.TabIndex = 5;
            this.lblcat.Text = "Categoria";
            // 
            // tbxDescripcion
            // 
            this.tbxDescripcion.Location = new System.Drawing.Point(274, 237);
            this.tbxDescripcion.Multiline = true;
            this.tbxDescripcion.Name = "tbxDescripcion";
            this.tbxDescripcion.Size = new System.Drawing.Size(228, 81);
            this.tbxDescripcion.TabIndex = 6;
            // 
            // lblDescrip
            // 
            this.lblDescrip.AutoSize = true;
            this.lblDescrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescrip.Location = new System.Drawing.Point(271, 204);
            this.lblDescrip.Name = "lblDescrip";
            this.lblDescrip.Size = new System.Drawing.Size(91, 16);
            this.lblDescrip.TabIndex = 7;
            this.lblDescrip.Text = "Descripcion";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Location = new System.Drawing.Point(28, 261);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpInicio.TabIndex = 8;
            // 
            // dtpFinal
            // 
            this.dtpFinal.Location = new System.Drawing.Point(28, 332);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(200, 20);
            this.dtpFinal.TabIndex = 9;
            // 
            // lblFInicio
            // 
            this.lblFInicio.AutoSize = true;
            this.lblFInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFInicio.Location = new System.Drawing.Point(25, 227);
            this.lblFInicio.Name = "lblFInicio";
            this.lblFInicio.Size = new System.Drawing.Size(114, 16);
            this.lblFInicio.TabIndex = 10;
            this.lblFInicio.Text = "Fecha de Inicio";
            // 
            // lblFFinal
            // 
            this.lblFFinal.AutoSize = true;
            this.lblFFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFFinal.Location = new System.Drawing.Point(25, 302);
            this.lblFFinal.Name = "lblFFinal";
            this.lblFFinal.Size = new System.Drawing.Size(160, 16);
            this.lblFFinal.TabIndex = 11;
            this.lblFFinal.Text = "Fecha de Finalizacion";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(292, 332);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(70, 50);
            this.btnCrear.TabIndex = 12;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(391, 332);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(70, 50);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblMensaje
            // 
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(25, 387);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(477, 16);
            this.lblMensaje.TabIndex = 14;
            // 
            // FrmNuevoJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 412);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.lblFFinal);
            this.Controls.Add(this.lblFInicio);
            this.Controls.Add(this.dtpFinal);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.lblDescrip);
            this.Controls.Add(this.tbxDescripcion);
            this.Controls.Add(this.lblcat);
            this.Controls.Add(this.lbldim);
            this.Controls.Add(this.cbxCategorias);
            this.Controls.Add(this.cbxDimenciones);
            this.Controls.Add(this.lblpic);
            this.Controls.Add(this.pbxImgenJuego);
            this.Name = "FrmNuevoJuego";
            this.Text = "Nuevo Juego";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmNuevoJuego_FormClosed);
            this.Load += new System.EventHandler(this.FrmNuevoJuego_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImgenJuego)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxImgenJuego;
        private System.Windows.Forms.Label lblpic;
        private System.Windows.Forms.ComboBox cbxDimenciones;
        private System.Windows.Forms.ComboBox cbxCategorias;
        private System.Windows.Forms.Label lbldim;
        private System.Windows.Forms.Label lblcat;
        private System.Windows.Forms.TextBox tbxDescripcion;
        private System.Windows.Forms.Label lblDescrip;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.Label lblFInicio;
        private System.Windows.Forms.Label lblFFinal;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblMensaje;
    }
}