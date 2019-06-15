namespace InstUI
{
    partial class License
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(License));
            this.title = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.agree = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.decline = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(379, 45);
            this.title.TabIndex = 0;
            this.title.Text = "licenseTitle from strings";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.ForeColor = System.Drawing.Color.White;
            this.description.Location = new System.Drawing.Point(16, 64);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(213, 20);
            this.description.TabIndex = 1;
            this.description.Text = "licenseDescription from strings";
            // 
            // agree
            // 
            this.agree.Location = new System.Drawing.Point(713, 415);
            this.agree.Name = "agree";
            this.agree.Size = new System.Drawing.Size(75, 23);
            this.agree.TabIndex = 2;
            this.agree.Text = "licenseAgree";
            this.agree.UseVisualStyleBackColor = true;
            this.agree.Click += new System.EventHandler(this.Agree_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(20, 88);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(768, 321);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
            // 
            // decline
            // 
            this.decline.Location = new System.Drawing.Point(632, 415);
            this.decline.Name = "decline";
            this.decline.Size = new System.Drawing.Size(75, 23);
            this.decline.TabIndex = 4;
            this.decline.Text = "licenseAgree";
            this.decline.UseVisualStyleBackColor = true;
            this.decline.Click += new System.EventHandler(this.Decline_Click);
            // 
            // License
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.decline);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.agree);
            this.Controls.Add(this.description);
            this.Controls.Add(this.title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "License";
            this.Text = "{Product} Installer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Button agree;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button decline;
    }
}

