namespace GUI
{
    partial class FrmReg
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
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDimension = new System.Windows.Forms.ComboBox();
            this.lblDimensiones = new System.Windows.Forms.Label();
            this.txtPass2 = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblPass2 = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblUs = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.checkListCat = new System.Windows.Forms.CheckedListBox();
            this.lblCat = new System.Windows.Forms.Label();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTel
            // 
            this.txtTel.BackColor = System.Drawing.SystemColors.Control;
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.ForeColor = System.Drawing.Color.Black;
            this.txtTel.Location = new System.Drawing.Point(192, 169);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(191, 24);
            this.txtTel.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 32;
            this.label1.Text = "Teléfono";
            // 
            // cbDimension
            // 
            this.cbDimension.BackColor = System.Drawing.SystemColors.Control;
            this.cbDimension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDimension.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDimension.ForeColor = System.Drawing.Color.Black;
            this.cbDimension.FormattingEnabled = true;
            this.cbDimension.Items.AddRange(new object[] {
            "3 x 3",
            "4 x 4"});
            this.cbDimension.Location = new System.Drawing.Point(162, 195);
            this.cbDimension.Name = "cbDimension";
            this.cbDimension.Size = new System.Drawing.Size(221, 26);
            this.cbDimension.TabIndex = 31;
            // 
            // lblDimensiones
            // 
            this.lblDimensiones.AutoSize = true;
            this.lblDimensiones.BackColor = System.Drawing.Color.Transparent;
            this.lblDimensiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDimensiones.ForeColor = System.Drawing.Color.White;
            this.lblDimensiones.Location = new System.Drawing.Point(48, 190);
            this.lblDimensiones.Name = "lblDimensiones";
            this.lblDimensiones.Size = new System.Drawing.Size(95, 18);
            this.lblDimensiones.TabIndex = 30;
            this.lblDimensiones.Text = "Dimensiones";
            // 
            // txtPass2
            // 
            this.txtPass2.BackColor = System.Drawing.SystemColors.Control;
            this.txtPass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass2.ForeColor = System.Drawing.Color.Black;
            this.txtPass2.Location = new System.Drawing.Point(192, 139);
            this.txtPass2.Name = "txtPass2";
            this.txtPass2.PasswordChar = '*';
            this.txtPass2.Size = new System.Drawing.Size(191, 24);
            this.txtPass2.TabIndex = 29;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.SystemColors.Control;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.Black;
            this.txtPass.Location = new System.Drawing.Point(192, 113);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(191, 24);
            this.txtPass.TabIndex = 28;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.SystemColors.Control;
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.Color.Black;
            this.txtCorreo.Location = new System.Drawing.Point(192, 87);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(191, 24);
            this.txtCorreo.TabIndex = 27;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtUsuario.Location = new System.Drawing.Point(192, 61);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(191, 24);
            this.txtUsuario.TabIndex = 26;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(192, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(191, 24);
            this.txtNombre.TabIndex = 25;
            // 
            // lblPass2
            // 
            this.lblPass2.AutoSize = true;
            this.lblPass2.BackColor = System.Drawing.Color.Transparent;
            this.lblPass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass2.ForeColor = System.Drawing.Color.White;
            this.lblPass2.Location = new System.Drawing.Point(48, 141);
            this.lblPass2.Name = "lblPass2";
            this.lblPass2.Size = new System.Drawing.Size(131, 18);
            this.lblPass2.TabIndex = 24;
            this.lblPass2.Text = "Repita Contraseña";
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.BackColor = System.Drawing.Color.Transparent;
            this.lbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.ForeColor = System.Drawing.Color.White;
            this.lbPass.Location = new System.Drawing.Point(48, 112);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(85, 18);
            this.lbPass.TabIndex = 23;
            this.lbPass.Text = "Contraseña";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.BackColor = System.Drawing.Color.Transparent;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.White;
            this.lblCorreo.Location = new System.Drawing.Point(48, 85);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(55, 18);
            this.lblCorreo.TabIndex = 22;
            this.lblCorreo.Text = "Correo";
            // 
            // lblUs
            // 
            this.lblUs.AutoSize = true;
            this.lblUs.BackColor = System.Drawing.Color.Transparent;
            this.lblUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUs.ForeColor = System.Drawing.Color.White;
            this.lblUs.Location = new System.Drawing.Point(48, 60);
            this.lblUs.Name = "lblUs";
            this.lblUs.Size = new System.Drawing.Size(60, 18);
            this.lblUs.TabIndex = 21;
            this.lblUs.Text = "Usuario";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(48, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 18);
            this.lblNombre.TabIndex = 20;
            this.lblNombre.Text = "Nombre";
            // 
            // lblMsg
            // 
            this.lblMsg.BackColor = System.Drawing.Color.Transparent;
            this.lblMsg.ForeColor = System.Drawing.Color.White;
            this.lblMsg.Location = new System.Drawing.Point(134, 369);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(395, 23);
            this.lblMsg.TabIndex = 36;
            // 
            // checkListCat
            // 
            this.checkListCat.BackColor = System.Drawing.SystemColors.Control;
            this.checkListCat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkListCat.FormattingEnabled = true;
            this.checkListCat.Location = new System.Drawing.Point(137, 251);
            this.checkListCat.Name = "checkListCat";
            this.checkListCat.Size = new System.Drawing.Size(205, 90);
            this.checkListCat.TabIndex = 35;
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.BackColor = System.Drawing.Color.Transparent;
            this.lblCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCat.ForeColor = System.Drawing.Color.White;
            this.lblCat.Location = new System.Drawing.Point(51, 265);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(72, 18);
            this.lblCat.TabIndex = 34;
            this.lblCat.Text = "Categoría";
            // 
            // pbFoto
            // 
            this.pbFoto.Image = global::GUI.Properties.Resources.users1;
            this.pbFoto.Location = new System.Drawing.Point(600, 43);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(144, 120);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 38;
            this.pbFoto.TabStop = false;
            this.pbFoto.Click += new System.EventHandler(this.pbFoto_Click);
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(685, 369);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(75, 23);
            this.btnReg.TabIndex = 37;
            this.btnReg.Text = "Registrar";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.RegPuzzle;
            this.ClientSize = new System.Drawing.Size(796, 430);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.checkListCat);
            this.Controls.Add(this.lblCat);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDimension);
            this.Controls.Add(this.lblDimensiones);
            this.Controls.Add(this.txtPass2);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblPass2);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblUs);
            this.Controls.Add(this.lblNombre);
            this.Name = "FrmReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Back);
            this.Load += new System.EventHandler(this.FrmReg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDimension;
        private System.Windows.Forms.Label lblDimensiones;
        private System.Windows.Forms.TextBox txtPass2;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblPass2;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblUs;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.CheckedListBox checkListCat;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}