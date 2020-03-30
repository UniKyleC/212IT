namespace ContactManager7939147
{
    partial class contactForm
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
            this.buttonPC = new System.Windows.Forms.Button();
            this.buttonBC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPC
            // 
            this.buttonPC.Location = new System.Drawing.Point(45, 52);
            this.buttonPC.Name = "buttonPC";
            this.buttonPC.Size = new System.Drawing.Size(131, 84);
            this.buttonPC.TabIndex = 0;
            this.buttonPC.Text = "Personal Contacts";
            this.buttonPC.UseVisualStyleBackColor = true;
            this.buttonPC.Click += new System.EventHandler(this.buttonPC_Click);
            // 
            // buttonBC
            // 
            this.buttonBC.Location = new System.Drawing.Point(198, 52);
            this.buttonBC.Name = "buttonBC";
            this.buttonBC.Size = new System.Drawing.Size(131, 84);
            this.buttonBC.TabIndex = 1;
            this.buttonBC.Text = "Business Contacts";
            this.buttonBC.UseVisualStyleBackColor = true;
            this.buttonBC.Click += new System.EventHandler(this.buttonBC_Click);
            // 
            // contactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 199);
            this.Controls.Add(this.buttonBC);
            this.Controls.Add(this.buttonPC);
            this.Name = "contactForm";
            this.Text = "Harris Contact Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPC;
        private System.Windows.Forms.Button buttonBC;
    }
}

