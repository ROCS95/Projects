namespace GUI
{
    partial class FrmPuzzle
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
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.txtPerfil = new System.Windows.Forms.TextBox();
            this.listJuegos = new System.Windows.Forms.ListBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.pnlPuzzle = new System.Windows.Forms.Panel();
            this.pbImgFinal = new System.Windows.Forms.PictureBox();
            this.lblPuzzle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgFinal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(704, 271);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnAdmin.TabIndex = 7;
            this.btnAdmin.Text = "Administrar";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(704, 324);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(44, 28);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(133, 122);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 5;
            this.pbImagen.TabStop = false;
            // 
            // txtPerfil
            // 
            this.txtPerfil.BackColor = System.Drawing.SystemColors.Control;
            this.txtPerfil.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPerfil.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtPerfil.Enabled = false;
            this.txtPerfil.Location = new System.Drawing.Point(44, 165);
            this.txtPerfil.Multiline = true;
            this.txtPerfil.Name = "txtPerfil";
            this.txtPerfil.Size = new System.Drawing.Size(100, 89);
            this.txtPerfil.TabIndex = 8;
            // 
            // listJuegos
            // 
            this.listJuegos.FormattingEnabled = true;
            this.listJuegos.Location = new System.Drawing.Point(33, 259);
            this.listJuegos.Name = "listJuegos";
            this.listJuegos.Size = new System.Drawing.Size(120, 160);
            this.listJuegos.TabIndex = 9;
            this.listJuegos.SelectedIndexChanged += new System.EventHandler(this.listJuegos_SelectedIndexChanged);
            // 
            // lblMsg
            // 
            this.lblMsg.Location = new System.Drawing.Point(181, 392);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(475, 23);
            this.lblMsg.TabIndex = 10;
            // 
            // pnlPuzzle
            // 
            this.pnlPuzzle.BackColor = System.Drawing.SystemColors.MenuText;
            this.pnlPuzzle.Location = new System.Drawing.Point(229, 28);
            this.pnlPuzzle.Name = "pnlPuzzle";
            this.pnlPuzzle.Size = new System.Drawing.Size(350, 350);
            this.pnlPuzzle.TabIndex = 11;
            // 
            // pbImgFinal
            // 
            this.pbImgFinal.Location = new System.Drawing.Point(635, 53);
            this.pbImgFinal.Name = "pbImgFinal";
            this.pbImgFinal.Size = new System.Drawing.Size(130, 115);
            this.pbImgFinal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImgFinal.TabIndex = 12;
            this.pbImgFinal.TabStop = false;
            // 
            // lblPuzzle
            // 
            this.lblPuzzle.AutoSize = true;
            this.lblPuzzle.Location = new System.Drawing.Point(654, 28);
            this.lblPuzzle.Name = "lblPuzzle";
            this.lblPuzzle.Size = new System.Drawing.Size(90, 13);
            this.lblPuzzle.TabIndex = 13;
            this.lblPuzzle.Text = "Puzzle a resolver.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Juegos Disponibles";
            // 
            // FrmPuzzle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 431);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPuzzle);
            this.Controls.Add(this.pbImgFinal);
            this.Controls.Add(this.pnlPuzzle);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.listJuegos);
            this.Controls.Add(this.txtPerfil);
            this.Controls.Add(this.pbImagen);
            this.Name = "FrmPuzzle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Puzzle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Cerrar);
            this.Load += new System.EventHandler(this.FrmPuzzle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgFinal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.TextBox txtPerfil;
        private System.Windows.Forms.ListBox listJuegos;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Panel pnlPuzzle;
        private System.Windows.Forms.PictureBox pbImgFinal;
        private System.Windows.Forms.Label lblPuzzle;
        private System.Windows.Forms.Label label1;
    }
}