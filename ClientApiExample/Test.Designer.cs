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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAuthKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtListId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.btnSubmitJson.Location = new System.Drawing.Point(22, 128);
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
            this.lblJson.Location = new System.Drawing.Point(22, 109);
            this.lblJson.Name = "lblJson";
            this.lblJson.Size = new System.Drawing.Size(114, 13);
            this.lblJson.TabIndex = 1;
            this.lblJson.Text = "Waiting for Submission";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(354, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAuthKey);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtListId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(25, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 132);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Credentials";
            // 
            // txtAuthKey
            // 
            this.txtAuthKey.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ClientApiExample.Properties.Settings.Default, "AuthKey", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtAuthKey.Location = new System.Drawing.Point(83, 55);
            this.txtAuthKey.Name = "txtAuthKey";
            this.txtAuthKey.Size = new System.Drawing.Size(242, 20);
            this.txtAuthKey.TabIndex = 9;
            this.txtAuthKey.Text = global::ClientApiExample.Properties.Settings.Default.AuthKey;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Auth Key";
            // 
            // txtListId
            // 
            this.txtListId.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ClientApiExample.Properties.Settings.Default, "ListId", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtListId.Location = new System.Drawing.Point(83, 25);
            this.txtListId.Name = "txtListId";
            this.txtListId.Size = new System.Drawing.Size(242, 20);
            this.txtListId.TabIndex = 7;
            this.txtListId.Text = global::ClientApiExample.Properties.Settings.Default.ListId;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "List Id";
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 330);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAuthKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtListId;
        private System.Windows.Forms.Label label2;
    }
}

