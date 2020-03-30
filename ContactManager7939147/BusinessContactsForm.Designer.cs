namespace ContactManager7939147
{
    partial class BusinessContactsForm
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
            this.dgvBusiness = new System.Windows.Forms.DataGridView();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.buttonSaveNew = new System.Windows.Forms.Button();
            this.buttonUpdateSel = new System.Windows.Forms.Button();
            this.buttonSaveSel = new System.Windows.Forms.Button();
            this.buttonDeleteSel = new System.Windows.Forms.Button();
            this.txbxFirstName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelMobileTel = new System.Windows.Forms.Label();
            this.labelBusinessTel = new System.Windows.Forms.Label();
            this.labelAddr1 = new System.Windows.Forms.Label();
            this.labelAddr2 = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelPostcode = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.txbxLastName = new System.Windows.Forms.TextBox();
            this.txbxMobile = new System.Windows.Forms.TextBox();
            this.txbxBusinessTel = new System.Windows.Forms.TextBox();
            this.txbxEmail = new System.Windows.Forms.TextBox();
            this.txbxAddr1 = new System.Windows.Forms.TextBox();
            this.txbxAddr2 = new System.Windows.Forms.TextBox();
            this.txbxCity = new System.Windows.Forms.TextBox();
            this.txbxPostcode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusiness)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBusiness
            // 
            this.dgvBusiness.AllowUserToAddRows = false;
            this.dgvBusiness.AllowUserToDeleteRows = false;
            this.dgvBusiness.AllowUserToResizeColumns = false;
            this.dgvBusiness.AllowUserToResizeRows = false;
            this.dgvBusiness.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusiness.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBusiness.Location = new System.Drawing.Point(12, 171);
            this.dgvBusiness.MultiSelect = false;
            this.dgvBusiness.Name = "dgvBusiness";
            this.dgvBusiness.ReadOnly = true;
            this.dgvBusiness.RowHeadersWidth = 51;
            this.dgvBusiness.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBusiness.Size = new System.Drawing.Size(775, 267);
            this.dgvBusiness.TabIndex = 0;
            this.dgvBusiness.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBusiness_CellClick);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(700, 40);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(87, 23);
            this.buttonRefresh.TabIndex = 1;
            this.buttonRefresh.Text = "Refresh Grid";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.Location = new System.Drawing.Point(712, 69);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(75, 23);
            this.buttonAddNew.TabIndex = 2;
            this.buttonAddNew.Text = "Add New";
            this.buttonAddNew.UseVisualStyleBackColor = true;
            this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
            // 
            // buttonSaveNew
            // 
            this.buttonSaveNew.Enabled = false;
            this.buttonSaveNew.Location = new System.Drawing.Point(711, 99);
            this.buttonSaveNew.Name = "buttonSaveNew";
            this.buttonSaveNew.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveNew.TabIndex = 3;
            this.buttonSaveNew.Text = "Save New";
            this.buttonSaveNew.UseVisualStyleBackColor = true;
            this.buttonSaveNew.Click += new System.EventHandler(this.buttonSaveNew_Click);
            // 
            // buttonUpdateSel
            // 
            this.buttonUpdateSel.Location = new System.Drawing.Point(587, 69);
            this.buttonUpdateSel.Name = "buttonUpdateSel";
            this.buttonUpdateSel.Size = new System.Drawing.Size(119, 23);
            this.buttonUpdateSel.TabIndex = 4;
            this.buttonUpdateSel.Text = "Update Selected";
            this.buttonUpdateSel.UseVisualStyleBackColor = true;
            this.buttonUpdateSel.Click += new System.EventHandler(this.buttonUpdateSel_Click);
            // 
            // buttonSaveSel
            // 
            this.buttonSaveSel.Enabled = false;
            this.buttonSaveSel.Location = new System.Drawing.Point(587, 99);
            this.buttonSaveSel.Name = "buttonSaveSel";
            this.buttonSaveSel.Size = new System.Drawing.Size(118, 23);
            this.buttonSaveSel.TabIndex = 5;
            this.buttonSaveSel.Text = "Save Selected";
            this.buttonSaveSel.UseVisualStyleBackColor = true;
            this.buttonSaveSel.Click += new System.EventHandler(this.buttonSaveSel_Click);
            // 
            // buttonDeleteSel
            // 
            this.buttonDeleteSel.Location = new System.Drawing.Point(587, 128);
            this.buttonDeleteSel.Name = "buttonDeleteSel";
            this.buttonDeleteSel.Size = new System.Drawing.Size(118, 23);
            this.buttonDeleteSel.TabIndex = 6;
            this.buttonDeleteSel.Text = "Delete Selected";
            this.buttonDeleteSel.UseVisualStyleBackColor = true;
            this.buttonDeleteSel.Click += new System.EventHandler(this.buttonDeleteSel_Click);
            // 
            // txbxFirstName
            // 
            this.txbxFirstName.Enabled = false;
            this.txbxFirstName.Location = new System.Drawing.Point(82, 40);
            this.txbxFirstName.Name = "txbxFirstName";
            this.txbxFirstName.Size = new System.Drawing.Size(146, 20);
            this.txbxFirstName.TabIndex = 7;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(9, 43);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(67, 15);
            this.labelFirstName.TabIndex = 8;
            this.labelFirstName.Text = "First Name";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(8, 66);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(67, 15);
            this.labelLastName.TabIndex = 9;
            this.labelLastName.Text = "Last Name";
            // 
            // labelMobileTel
            // 
            this.labelMobileTel.AutoSize = true;
            this.labelMobileTel.Location = new System.Drawing.Point(9, 90);
            this.labelMobileTel.Name = "labelMobileTel";
            this.labelMobileTel.Size = new System.Drawing.Size(55, 15);
            this.labelMobileTel.TabIndex = 10;
            this.labelMobileTel.Text = "Mobile #";
            // 
            // labelBusinessTel
            // 
            this.labelBusinessTel.AutoSize = true;
            this.labelBusinessTel.Location = new System.Drawing.Point(10, 112);
            this.labelBusinessTel.Name = "labelBusinessTel";
            this.labelBusinessTel.Size = new System.Drawing.Size(66, 15);
            this.labelBusinessTel.TabIndex = 11;
            this.labelBusinessTel.Text = "Business #";
            // 
            // labelAddr1
            // 
            this.labelAddr1.AutoSize = true;
            this.labelAddr1.Location = new System.Drawing.Point(242, 46);
            this.labelAddr1.Name = "labelAddr1";
            this.labelAddr1.Size = new System.Drawing.Size(96, 15);
            this.labelAddr1.TabIndex = 12;
            this.labelAddr1.Text = "Address (Line 1)";
            // 
            // labelAddr2
            // 
            this.labelAddr2.AutoSize = true;
            this.labelAddr2.Location = new System.Drawing.Point(242, 66);
            this.labelAddr2.Name = "labelAddr2";
            this.labelAddr2.Size = new System.Drawing.Size(96, 15);
            this.labelAddr2.TabIndex = 13;
            this.labelAddr2.Text = "Address (Line 2)";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(244, 90);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(26, 15);
            this.labelCity.TabIndex = 14;
            this.labelCity.Text = "City";
            // 
            // labelPostcode
            // 
            this.labelPostcode.AutoSize = true;
            this.labelPostcode.Location = new System.Drawing.Point(245, 114);
            this.labelPostcode.Name = "labelPostcode";
            this.labelPostcode.Size = new System.Drawing.Size(58, 15);
            this.labelPostcode.TabIndex = 15;
            this.labelPostcode.Text = "Postcode";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(11, 134);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(39, 15);
            this.labelEmail.TabIndex = 16;
            this.labelEmail.Text = "Email";
            // 
            // txbxLastName
            // 
            this.txbxLastName.Enabled = false;
            this.txbxLastName.Location = new System.Drawing.Point(83, 63);
            this.txbxLastName.Name = "txbxLastName";
            this.txbxLastName.Size = new System.Drawing.Size(144, 20);
            this.txbxLastName.TabIndex = 17;
            // 
            // txbxMobile
            // 
            this.txbxMobile.Enabled = false;
            this.txbxMobile.Location = new System.Drawing.Point(83, 85);
            this.txbxMobile.Name = "txbxMobile";
            this.txbxMobile.Size = new System.Drawing.Size(144, 20);
            this.txbxMobile.TabIndex = 18;
            // 
            // txbxBusinessTel
            // 
            this.txbxBusinessTel.Enabled = false;
            this.txbxBusinessTel.Location = new System.Drawing.Point(83, 107);
            this.txbxBusinessTel.Name = "txbxBusinessTel";
            this.txbxBusinessTel.Size = new System.Drawing.Size(144, 20);
            this.txbxBusinessTel.TabIndex = 19;
            // 
            // txbxEmail
            // 
            this.txbxEmail.Enabled = false;
            this.txbxEmail.Location = new System.Drawing.Point(83, 131);
            this.txbxEmail.Name = "txbxEmail";
            this.txbxEmail.Size = new System.Drawing.Size(144, 20);
            this.txbxEmail.TabIndex = 20;
            // 
            // txbxAddr1
            // 
            this.txbxAddr1.Enabled = false;
            this.txbxAddr1.Location = new System.Drawing.Point(344, 40);
            this.txbxAddr1.Name = "txbxAddr1";
            this.txbxAddr1.Size = new System.Drawing.Size(144, 20);
            this.txbxAddr1.TabIndex = 21;
            // 
            // txbxAddr2
            // 
            this.txbxAddr2.Enabled = false;
            this.txbxAddr2.Location = new System.Drawing.Point(344, 63);
            this.txbxAddr2.Name = "txbxAddr2";
            this.txbxAddr2.Size = new System.Drawing.Size(144, 20);
            this.txbxAddr2.TabIndex = 22;
            // 
            // txbxCity
            // 
            this.txbxCity.Enabled = false;
            this.txbxCity.Location = new System.Drawing.Point(344, 88);
            this.txbxCity.Name = "txbxCity";
            this.txbxCity.Size = new System.Drawing.Size(144, 20);
            this.txbxCity.TabIndex = 23;
            // 
            // txbxPostcode
            // 
            this.txbxPostcode.Enabled = false;
            this.txbxPostcode.Location = new System.Drawing.Point(344, 114);
            this.txbxPostcode.Name = "txbxPostcode";
            this.txbxPostcode.Size = new System.Drawing.Size(144, 20);
            this.txbxPostcode.TabIndex = 24;
            // 
            // BusinessContactsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbxPostcode);
            this.Controls.Add(this.txbxCity);
            this.Controls.Add(this.txbxAddr2);
            this.Controls.Add(this.txbxAddr1);
            this.Controls.Add(this.txbxEmail);
            this.Controls.Add(this.txbxBusinessTel);
            this.Controls.Add(this.txbxMobile);
            this.Controls.Add(this.txbxLastName);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPostcode);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelAddr2);
            this.Controls.Add(this.labelAddr1);
            this.Controls.Add(this.labelBusinessTel);
            this.Controls.Add(this.labelMobileTel);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.txbxFirstName);
            this.Controls.Add(this.buttonDeleteSel);
            this.Controls.Add(this.buttonSaveSel);
            this.Controls.Add(this.buttonUpdateSel);
            this.Controls.Add(this.buttonSaveNew);
            this.Controls.Add(this.buttonAddNew);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.dgvBusiness);
            this.Name = "BusinessContactsForm";
            this.Text = "Business Contacts";
            this.Load += new System.EventHandler(this.BusinessContactsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusiness)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBusiness;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonAddNew;
        private System.Windows.Forms.Button buttonSaveNew;
        private System.Windows.Forms.Button buttonUpdateSel;
        private System.Windows.Forms.Button buttonSaveSel;
        private System.Windows.Forms.Button buttonDeleteSel;
        private System.Windows.Forms.TextBox txbxFirstName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelMobileTel;
        private System.Windows.Forms.Label labelBusinessTel;
        private System.Windows.Forms.Label labelAddr1;
        private System.Windows.Forms.Label labelAddr2;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelPostcode;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox txbxLastName;
        private System.Windows.Forms.TextBox txbxMobile;
        private System.Windows.Forms.TextBox txbxBusinessTel;
        private System.Windows.Forms.TextBox txbxEmail;
        private System.Windows.Forms.TextBox txbxAddr1;
        private System.Windows.Forms.TextBox txbxAddr2;
        private System.Windows.Forms.TextBox txbxCity;
        private System.Windows.Forms.TextBox txbxPostcode;
    }
}