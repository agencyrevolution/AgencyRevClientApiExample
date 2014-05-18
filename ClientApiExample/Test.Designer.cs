namespace ClientApiExample
{
    partial class Test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblXml = new System.Windows.Forms.Label();
            this.btnSubmitJson = new System.Windows.Forms.Button();
            this.lblJson = new System.Windows.Forms.Label();
            this.lblDocumentation = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAccountId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMultipleJson = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Location = new System.Drawing.Point(22, 68);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit Xml";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // lblXml
            // 
            this.lblXml.AutoSize = true;
            this.lblXml.Location = new System.Drawing.Point(22, 49);
            this.lblXml.Name = "lblXml";
            this.lblXml.Size = new System.Drawing.Size(114, 13);
            this.lblXml.TabIndex = 1;
            this.lblXml.Text = "Waiting for Submission";
            // 
            // btnSubmitJson
            // 
            this.btnSubmitJson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitJson.Location = new System.Drawing.Point(25, 138);
            this.btnSubmitJson.Name = "btnSubmitJson";
            this.btnSubmitJson.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitJson.TabIndex = 0;
            this.btnSubmitJson.Text = "Submit Json";
            this.btnSubmitJson.UseVisualStyleBackColor = true;
            this.btnSubmitJson.Click += new System.EventHandler(this.btnSubmitJson_Click);
            // 
            // lblJson
            // 
            this.lblJson.AutoSize = true;
            this.lblJson.Location = new System.Drawing.Point(25, 119);
            this.lblJson.Name = "lblJson";
            this.lblJson.Size = new System.Drawing.Size(114, 13);
            this.lblJson.TabIndex = 1;
            this.lblJson.Text = "Waiting for Submission";
            // 
            // lblDocumentation
            // 
            this.lblDocumentation.AutoSize = true;
            this.lblDocumentation.Location = new System.Drawing.Point(36, 326);
            this.lblDocumentation.Name = "lblDocumentation";
            this.lblDocumentation.Size = new System.Drawing.Size(138, 13);
            this.lblDocumentation.TabIndex = 2;
            this.lblDocumentation.TabStop = true;
            this.lblDocumentation.Text = "View Online Documentation";
            this.lblDocumentation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblDocumentation_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 323);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAccountId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(25, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 132);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Credentials";
            // 
            // txtPassword
            // 
            this.txtPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ClientApiExample.Properties.Settings.Default, "Password", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtPassword.Location = new System.Drawing.Point(83, 86);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(242, 20);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.Text = global::ClientApiExample.Properties.Settings.Default.Password;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ClientApiExample.Properties.Settings.Default, "Username", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtUsername.Location = new System.Drawing.Point(83, 55);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(242, 20);
            this.txtUsername.TabIndex = 9;
            this.txtUsername.Text = global::ClientApiExample.Properties.Settings.Default.Username;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Username";
            // 
            // txtAccountId
            // 
            this.txtAccountId.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ClientApiExample.Properties.Settings.Default, "AccountId", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtAccountId.Location = new System.Drawing.Point(83, 25);
            this.txtAccountId.Name = "txtAccountId";
            this.txtAccountId.Size = new System.Drawing.Size(242, 20);
            this.txtAccountId.TabIndex = 7;
            this.txtAccountId.Text = global::ClientApiExample.Properties.Settings.Default.AccountId;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Account Id";
            // 
            // btnMultipleJson
            // 
            this.btnMultipleJson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultipleJson.Location = new System.Drawing.Point(182, 138);
            this.btnMultipleJson.Name = "btnMultipleJson";
            this.btnMultipleJson.Size = new System.Drawing.Size(127, 23);
            this.btnMultipleJson.TabIndex = 7;
            this.btnMultipleJson.Text = "Submit Multiple Json";
            this.btnMultipleJson.UseVisualStyleBackColor = true;
            this.btnMultipleJson.Click += new System.EventHandler(this.btnMultipleJson_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(182, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Submit Multiple Xml";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnMultipleJson_Click);
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 397);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMultipleJson);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDocumentation);
            this.Controls.Add(this.lblJson);
            this.Controls.Add(this.lblXml);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmitJson);
            this.Controls.Add(this.btnSubmit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Test";
            this.Text = "Test Application";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblXml;
        private System.Windows.Forms.Button btnSubmitJson;
        private System.Windows.Forms.Label lblJson;
        private System.Windows.Forms.LinkLabel lblDocumentation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAccountId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMultipleJson;
        private System.Windows.Forms.Button button1;
    }
}

