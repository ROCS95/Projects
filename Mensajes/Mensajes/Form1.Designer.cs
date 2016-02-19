namespace Mensajes
{
    partial class Form1
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
            this.btnvisual = new System.Windows.Forms.Button();
            this.lblseleccion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gboxicon = new System.Windows.Forms.GroupBox();
            this.rbtnerror = new System.Windows.Forms.RadioButton();
            this.rbtnquest = new System.Windows.Forms.RadioButton();
            this.rbtnexcl = new System.Windows.Forms.RadioButton();
            this.rbtninfo = new System.Windows.Forms.RadioButton();
            this.gboxboton = new System.Windows.Forms.GroupBox();
            this.rbtnaretrycan = new System.Windows.Forms.RadioButton();
            this.rbtnretrycan = new System.Windows.Forms.RadioButton();
            this.rbtnyesno = new System.Windows.Forms.RadioButton();
            this.rbtnyesnocan = new System.Windows.Forms.RadioButton();
            this.rbtnokcan = new System.Windows.Forms.RadioButton();
            this.rbtnok = new System.Windows.Forms.RadioButton();
            this.gboxicon.SuspendLayout();
            this.gboxboton.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnvisual
            // 
            this.btnvisual.Location = new System.Drawing.Point(408, 231);
            this.btnvisual.Name = "btnvisual";
            this.btnvisual.Size = new System.Drawing.Size(75, 50);
            this.btnvisual.TabIndex = 9;
            this.btnvisual.Text = "Visualizar";
            this.btnvisual.UseVisualStyleBackColor = true;
            this.btnvisual.Click += new System.EventHandler(this.btnvisual_Click);
            // 
            // lblseleccion
            // 
            this.lblseleccion.Location = new System.Drawing.Point(350, 299);
            this.lblseleccion.Name = "lblseleccion";
            this.lblseleccion.Size = new System.Drawing.Size(200, 24);
            this.lblseleccion.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-113, -27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Selecciona para visualizar";
            // 
            // gboxicon
            // 
            this.gboxicon.Controls.Add(this.rbtnerror);
            this.gboxicon.Controls.Add(this.rbtnquest);
            this.gboxicon.Controls.Add(this.rbtnexcl);
            this.gboxicon.Controls.Add(this.rbtninfo);
            this.gboxicon.Location = new System.Drawing.Point(350, 70);
            this.gboxicon.Name = "gboxicon";
            this.gboxicon.Size = new System.Drawing.Size(200, 145);
            this.gboxicon.TabIndex = 6;
            this.gboxicon.TabStop = false;
            this.gboxicon.Text = "Tipo Icono";
            // 
            // rbtnerror
            // 
            this.rbtnerror.AutoSize = true;
            this.rbtnerror.Location = new System.Drawing.Point(25, 106);
            this.rbtnerror.Name = "rbtnerror";
            this.rbtnerror.Size = new System.Drawing.Size(46, 17);
            this.rbtnerror.TabIndex = 3;
            this.rbtnerror.TabStop = true;
            this.rbtnerror.Text = "error";
            this.rbtnerror.UseVisualStyleBackColor = true;
            // 
            // rbtnquest
            // 
            this.rbtnquest.AutoSize = true;
            this.rbtnquest.Location = new System.Drawing.Point(25, 83);
            this.rbtnquest.Name = "rbtnquest";
            this.rbtnquest.Size = new System.Drawing.Size(60, 17);
            this.rbtnquest.TabIndex = 2;
            this.rbtnquest.TabStop = true;
            this.rbtnquest.Text = "quetion";
            this.rbtnquest.UseVisualStyleBackColor = true;
            // 
            // rbtnexcl
            // 
            this.rbtnexcl.AutoSize = true;
            this.rbtnexcl.Location = new System.Drawing.Point(25, 60);
            this.rbtnexcl.Name = "rbtnexcl";
            this.rbtnexcl.Size = new System.Drawing.Size(81, 17);
            this.rbtnexcl.TabIndex = 1;
            this.rbtnexcl.TabStop = true;
            this.rbtnexcl.Text = "exclamation";
            this.rbtnexcl.UseVisualStyleBackColor = true;
            // 
            // rbtninfo
            // 
            this.rbtninfo.AutoSize = true;
            this.rbtninfo.Location = new System.Drawing.Point(25, 37);
            this.rbtninfo.Name = "rbtninfo";
            this.rbtninfo.Size = new System.Drawing.Size(76, 17);
            this.rbtninfo.TabIndex = 0;
            this.rbtninfo.TabStop = true;
            this.rbtninfo.Text = "information";
            this.rbtninfo.UseVisualStyleBackColor = true;
            this.rbtninfo.CheckedChanged += new System.EventHandler(this.tipoinfo_CheckedChanged);
            // 
            // gboxboton
            // 
            this.gboxboton.Controls.Add(this.rbtnaretrycan);
            this.gboxboton.Controls.Add(this.rbtnretrycan);
            this.gboxboton.Controls.Add(this.rbtnyesno);
            this.gboxboton.Controls.Add(this.rbtnyesnocan);
            this.gboxboton.Controls.Add(this.rbtnokcan);
            this.gboxboton.Controls.Add(this.rbtnok);
            this.gboxboton.Location = new System.Drawing.Point(43, 70);
            this.gboxboton.Name = "gboxboton";
            this.gboxboton.Size = new System.Drawing.Size(200, 188);
            this.gboxboton.TabIndex = 5;
            this.gboxboton.TabStop = false;
            this.gboxboton.Text = "Tipo Boton";
            // 
            // rbtnaretrycan
            // 
            this.rbtnaretrycan.AutoSize = true;
            this.rbtnaretrycan.Location = new System.Drawing.Point(7, 151);
            this.rbtnaretrycan.Name = "rbtnaretrycan";
            this.rbtnaretrycan.Size = new System.Drawing.Size(107, 17);
            this.rbtnaretrycan.TabIndex = 5;
            this.rbtnaretrycan.Text = "abort retry cancel";
            this.rbtnaretrycan.UseVisualStyleBackColor = true;
            // 
            // rbtnretrycan
            // 
            this.rbtnretrycan.AutoSize = true;
            this.rbtnretrycan.Location = new System.Drawing.Point(7, 128);
            this.rbtnretrycan.Name = "rbtnretrycan";
            this.rbtnretrycan.Size = new System.Drawing.Size(80, 17);
            this.rbtnretrycan.TabIndex = 4;
            this.rbtnretrycan.Text = "retry cancel";
            this.rbtnretrycan.UseVisualStyleBackColor = true;
            // 
            // rbtnyesno
            // 
            this.rbtnyesno.AutoSize = true;
            this.rbtnyesno.Location = new System.Drawing.Point(7, 80);
            this.rbtnyesno.Name = "rbtnyesno";
            this.rbtnyesno.Size = new System.Drawing.Size(56, 17);
            this.rbtnyesno.TabIndex = 3;
            this.rbtnyesno.Text = "yes no";
            this.rbtnyesno.UseVisualStyleBackColor = true;
            // 
            // rbtnyesnocan
            // 
            this.rbtnyesnocan.AutoSize = true;
            this.rbtnyesnocan.Location = new System.Drawing.Point(7, 103);
            this.rbtnyesnocan.Name = "rbtnyesnocan";
            this.rbtnyesnocan.Size = new System.Drawing.Size(91, 17);
            this.rbtnyesnocan.TabIndex = 2;
            this.rbtnyesnocan.Text = "yes no cancel";
            this.rbtnyesnocan.UseVisualStyleBackColor = true;
            // 
            // rbtnokcan
            // 
            this.rbtnokcan.AutoSize = true;
            this.rbtnokcan.Location = new System.Drawing.Point(7, 57);
            this.rbtnokcan.Name = "rbtnokcan";
            this.rbtnokcan.Size = new System.Drawing.Size(72, 17);
            this.rbtnokcan.TabIndex = 1;
            this.rbtnokcan.Text = "ok cancel";
            this.rbtnokcan.UseVisualStyleBackColor = true;
            // 
            // rbtnok
            // 
            this.rbtnok.AutoSize = true;
            this.rbtnok.Location = new System.Drawing.Point(7, 34);
            this.rbtnok.Name = "rbtnok";
            this.rbtnok.Size = new System.Drawing.Size(37, 17);
            this.rbtnok.TabIndex = 0;
            this.rbtnok.Text = "ok";
            this.rbtnok.UseVisualStyleBackColor = true;
            this.rbtnok.CheckedChanged += new System.EventHandler(this.tipoboton_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 421);
            this.Controls.Add(this.btnvisual);
            this.Controls.Add(this.lblseleccion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gboxicon);
            this.Controls.Add(this.gboxboton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gboxicon.ResumeLayout(false);
            this.gboxicon.PerformLayout();
            this.gboxboton.ResumeLayout(false);
            this.gboxboton.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnvisual;
        private System.Windows.Forms.Label lblseleccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gboxicon;
        private System.Windows.Forms.RadioButton rbtnerror;
        private System.Windows.Forms.RadioButton rbtnquest;
        private System.Windows.Forms.RadioButton rbtnexcl;
        private System.Windows.Forms.RadioButton rbtninfo;
        private System.Windows.Forms.GroupBox gboxboton;
        private System.Windows.Forms.RadioButton rbtnaretrycan;
        private System.Windows.Forms.RadioButton rbtnretrycan;
        private System.Windows.Forms.RadioButton rbtnyesno;
        private System.Windows.Forms.RadioButton rbtnyesnocan;
        private System.Windows.Forms.RadioButton rbtnokcan;
        private System.Windows.Forms.RadioButton rbtnok;
    }
}

