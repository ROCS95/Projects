namespace GUI
{
    partial class FrmPrincipal
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
            this.gbxUsuario = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btninsertcat = new System.Windows.Forms.Button();
            this.btndeletecat = new System.Windows.Forms.Button();
            this.btninsertdim = new System.Windows.Forms.Button();
            this.btndeletedim = new System.Windows.Forms.Button();
            this.btnNuevoJuego = new System.Windows.Forms.Button();
            this.btnPublicar = new System.Windows.Forms.Button();
            this.gbxUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxUsuario
            // 
            this.gbxUsuario.Controls.Add(this.lblNombre);
            this.gbxUsuario.Controls.Add(this.lblUsuario);
            this.gbxUsuario.Controls.Add(this.pictureBox1);
            this.gbxUsuario.Location = new System.Drawing.Point(534, 12);
            this.gbxUsuario.Name = "gbxUsuario";
            this.gbxUsuario.Size = new System.Drawing.Size(149, 69);
            this.gbxUsuario.TabIndex = 0;
            this.gbxUsuario.TabStop = false;
            this.gbxUsuario.Text = "Mi cuenta";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(18, 39);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(18, 19);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.Click += new System.EventHandler(this.lblUsuario_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(91, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(45, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(176, 160);
            this.listBox1.TabIndex = 1;
            this.listBox1.Visible = false;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(263, 51);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(175, 160);
            this.listBox2.TabIndex = 2;
            this.listBox2.Visible = false;
            // 
            // btninsertcat
            // 
            this.btninsertcat.Location = new System.Drawing.Point(45, 232);
            this.btninsertcat.Name = "btninsertcat";
            this.btninsertcat.Size = new System.Drawing.Size(75, 36);
            this.btninsertcat.TabIndex = 3;
            this.btninsertcat.Text = "Insertar Categoria";
            this.btninsertcat.UseVisualStyleBackColor = true;
            this.btninsertcat.Visible = false;
            this.btninsertcat.Click += new System.EventHandler(this.btninsertcat_Click);
            // 
            // btndeletecat
            // 
            this.btndeletecat.Location = new System.Drawing.Point(146, 232);
            this.btndeletecat.Name = "btndeletecat";
            this.btndeletecat.Size = new System.Drawing.Size(75, 36);
            this.btndeletecat.TabIndex = 4;
            this.btndeletecat.Text = "Eliminar Categoria";
            this.btndeletecat.UseVisualStyleBackColor = true;
            this.btndeletecat.Visible = false;
            // 
            // btninsertdim
            // 
            this.btninsertdim.Location = new System.Drawing.Point(263, 233);
            this.btninsertdim.Name = "btninsertdim";
            this.btninsertdim.Size = new System.Drawing.Size(75, 36);
            this.btninsertdim.TabIndex = 5;
            this.btninsertdim.Text = "Insertar Dimencion";
            this.btninsertdim.UseVisualStyleBackColor = true;
            this.btninsertdim.Visible = false;
            this.btninsertdim.Click += new System.EventHandler(this.btninsertdim_Click);
            // 
            // btndeletedim
            // 
            this.btndeletedim.Location = new System.Drawing.Point(363, 233);
            this.btndeletedim.Name = "btndeletedim";
            this.btndeletedim.Size = new System.Drawing.Size(75, 36);
            this.btndeletedim.TabIndex = 6;
            this.btndeletedim.Text = "Eliminar dimencion";
            this.btndeletedim.UseVisualStyleBackColor = true;
            this.btndeletedim.Visible = false;
            // 
            // btnNuevoJuego
            // 
            this.btnNuevoJuego.Location = new System.Drawing.Point(555, 136);
            this.btnNuevoJuego.Name = "btnNuevoJuego";
            this.btnNuevoJuego.Size = new System.Drawing.Size(102, 75);
            this.btnNuevoJuego.TabIndex = 7;
            this.btnNuevoJuego.Text = "Nuevo Juego";
            this.btnNuevoJuego.UseVisualStyleBackColor = true;
            this.btnNuevoJuego.Visible = false;
            this.btnNuevoJuego.Click += new System.EventHandler(this.btnNuevoJuego_Click);
            // 
            // btnPublicar
            // 
            this.btnPublicar.Location = new System.Drawing.Point(555, 248);
            this.btnPublicar.Name = "btnPublicar";
            this.btnPublicar.Size = new System.Drawing.Size(102, 75);
            this.btnPublicar.TabIndex = 8;
            this.btnPublicar.Text = "Publicar Juego";
            this.btnPublicar.UseVisualStyleBackColor = true;
            this.btnPublicar.Visible = false;
            this.btnPublicar.Click += new System.EventHandler(this.btnPublicar_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 347);
            this.Controls.Add(this.btnPublicar);
            this.Controls.Add(this.btnNuevoJuego);
            this.Controls.Add(this.btndeletedim);
            this.Controls.Add(this.btninsertdim);
            this.Controls.Add(this.btndeletecat);
            this.Controls.Add(this.btninsertcat);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.gbxUsuario);
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.gbxUsuario.ResumeLayout(false);
            this.gbxUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxUsuario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btninsertcat;
        private System.Windows.Forms.Button btndeletecat;
        private System.Windows.Forms.Button btninsertdim;
        private System.Windows.Forms.Button btndeletedim;
        private System.Windows.Forms.Button btnNuevoJuego;
        private System.Windows.Forms.Button btnPublicar;
    }
}