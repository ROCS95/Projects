namespace LoginRobert.GUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbuser = new System.Windows.Forms.TextBox();
            this.tbcontra = new System.Windows.Forms.TextBox();
            this.btnlog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(186, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "SingIn";
            // 
            // tbuser
            // 
            this.tbuser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbuser.BackColor = System.Drawing.Color.ForestGreen;
            this.tbuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbuser.Location = new System.Drawing.Point(149, 154);
            this.tbuser.Multiline = true;
            this.tbuser.Name = "tbuser";
            this.tbuser.Size = new System.Drawing.Size(186, 41);
            this.tbuser.TabIndex = 1;
            this.tbuser.Text = "User";
            this.tbuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbcontra
            // 
            this.tbcontra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbcontra.BackColor = System.Drawing.Color.ForestGreen;
            this.tbcontra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcontra.Location = new System.Drawing.Point(149, 212);
            this.tbcontra.Multiline = true;
            this.tbcontra.Name = "tbcontra";
            this.tbcontra.PasswordChar = '♠';
            this.tbcontra.Size = new System.Drawing.Size(186, 37);
            this.tbcontra.TabIndex = 2;
            this.tbcontra.Text = "Password";
            this.tbcontra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnlog
            // 
            this.btnlog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnlog.BackColor = System.Drawing.Color.ForestGreen;
            this.btnlog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnlog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlog.Location = new System.Drawing.Point(193, 267);
            this.btnlog.Name = "btnlog";
            this.btnlog.Size = new System.Drawing.Size(100, 50);
            this.btnlog.TabIndex = 3;
            this.btnlog.Text = "Log";
            this.btnlog.UseVisualStyleBackColor = false;
            this.btnlog.Click += new System.EventHandler(this.btnlog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(493, 405);
            this.Controls.Add(this.btnlog);
            this.Controls.Add(this.tbcontra);
            this.Controls.Add(this.tbuser);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "SingIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbuser;
        private System.Windows.Forms.TextBox tbcontra;
        private System.Windows.Forms.Button btnlog;
    }
}

