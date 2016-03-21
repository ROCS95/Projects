namespace GUI
{
    partial class FrmPublicar
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
            this.lbxJuegos = new System.Windows.Forms.ListBox();
            this.btnPublicar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxJuegos
            // 
            this.lbxJuegos.FormattingEnabled = true;
            this.lbxJuegos.Location = new System.Drawing.Point(46, 30);
            this.lbxJuegos.Name = "lbxJuegos";
            this.lbxJuegos.Size = new System.Drawing.Size(273, 160);
            this.lbxJuegos.TabIndex = 0;
            // 
            // btnPublicar
            // 
            this.btnPublicar.Location = new System.Drawing.Point(73, 207);
            this.btnPublicar.Name = "btnPublicar";
            this.btnPublicar.Size = new System.Drawing.Size(102, 75);
            this.btnPublicar.TabIndex = 1;
            this.btnPublicar.Text = "Publicar";
            this.btnPublicar.UseVisualStyleBackColor = true;
            this.btnPublicar.Click += new System.EventHandler(this.btnPublicar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(193, 207);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 75);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmPublicar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 294);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnPublicar);
            this.Controls.Add(this.lbxJuegos);
            this.Name = "FrmPublicar";
            this.Text = "FrmPublicar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPublicar_FormClosed);
            this.Load += new System.EventHandler(this.FrmPublicar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxJuegos;
        private System.Windows.Forms.Button btnPublicar;
        private System.Windows.Forms.Button btnCancelar;
    }
}