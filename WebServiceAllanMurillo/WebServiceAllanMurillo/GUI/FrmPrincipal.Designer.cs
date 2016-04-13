namespace WebServiceAllanMurillo.GUI
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
            this.fromUSD = new System.Windows.Forms.TextBox();
            this.fromCRC = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.toUSD = new System.Windows.Forms.TextBox();
            this.toCRC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fromUSD
            // 
            this.fromUSD.Location = new System.Drawing.Point(87, 25);
            this.fromUSD.Name = "fromUSD";
            this.fromUSD.Size = new System.Drawing.Size(100, 20);
            this.fromUSD.TabIndex = 2;
            // 
            // fromCRC
            // 
            this.fromCRC.Location = new System.Drawing.Point(87, 60);
            this.fromCRC.Name = "fromCRC";
            this.fromCRC.Size = new System.Drawing.Size(100, 20);
            this.fromCRC.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "USD->CRC";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(193, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "CRC->USD";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // toUSD
            // 
            this.toUSD.Location = new System.Drawing.Point(274, 60);
            this.toUSD.Name = "toUSD";
            this.toUSD.Size = new System.Drawing.Size(100, 20);
            this.toUSD.TabIndex = 6;
            // 
            // toCRC
            // 
            this.toCRC.Location = new System.Drawing.Point(274, 24);
            this.toCRC.Name = "toCRC";
            this.toCRC.Size = new System.Drawing.Size(100, 20);
            this.toCRC.TabIndex = 7;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 123);
            this.Controls.Add(this.toCRC);
            this.Controls.Add(this.toUSD);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fromCRC);
            this.Controls.Add(this.fromUSD);
            this.Name = "FrmPrincipal";
            this.Text = "Web Service - Allan Murillo A";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox fromUSD;
        private System.Windows.Forms.TextBox fromCRC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox toUSD;
        private System.Windows.Forms.TextBox toCRC;
    }
}