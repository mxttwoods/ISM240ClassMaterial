namespace FlagsHW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.usaPictureBox = new System.Windows.Forms.PictureBox();
            this.ukPictureBox = new System.Windows.Forms.PictureBox();
            this.canadaPictureBox = new System.Windows.Forms.PictureBox();
            this.countryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ukPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canadaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click to see the name of the country.";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // usaPictureBox
            // 
            this.usaPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("usaPictureBox.Image")));
            this.usaPictureBox.Location = new System.Drawing.Point(48, 137);
            this.usaPictureBox.Name = "usaPictureBox";
            this.usaPictureBox.Size = new System.Drawing.Size(199, 101);
            this.usaPictureBox.TabIndex = 1;
            this.usaPictureBox.TabStop = false;
            this.usaPictureBox.Click += new System.EventHandler(this.UsaPictureBox_Click);
            // 
            // ukPictureBox
            // 
            this.ukPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ukPictureBox.Image")));
            this.ukPictureBox.Location = new System.Drawing.Point(315, 137);
            this.ukPictureBox.Name = "ukPictureBox";
            this.ukPictureBox.Size = new System.Drawing.Size(201, 101);
            this.ukPictureBox.TabIndex = 2;
            this.ukPictureBox.TabStop = false;
            this.ukPictureBox.Click += new System.EventHandler(this.UkPictureBox_Click);
            // 
            // canadaPictureBox
            // 
            this.canadaPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("canadaPictureBox.Image")));
            this.canadaPictureBox.Location = new System.Drawing.Point(588, 137);
            this.canadaPictureBox.Name = "canadaPictureBox";
            this.canadaPictureBox.Size = new System.Drawing.Size(200, 100);
            this.canadaPictureBox.TabIndex = 3;
            this.canadaPictureBox.TabStop = false;
            this.canadaPictureBox.Click += new System.EventHandler(this.CanadaPictureBox_Click);
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.countryLabel.Location = new System.Drawing.Point(324, 290);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(142, 13);
            this.countryLabel.TabIndex = 4;
            this.countryLabel.Text = "                                             ";
            this.countryLabel.Click += new System.EventHandler(this.CountryLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.canadaPictureBox);
            this.Controls.Add(this.ukPictureBox);
            this.Controls.Add(this.usaPictureBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Flags";
            ((System.ComponentModel.ISupportInitialize)(this.usaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ukPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canadaPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox usaPictureBox;
        private System.Windows.Forms.PictureBox ukPictureBox;
        private System.Windows.Forms.PictureBox canadaPictureBox;
        private System.Windows.Forms.Label countryLabel;
    }
}

