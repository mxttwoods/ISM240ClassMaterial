namespace In_class_excersize
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
            this.createButton = new System.Windows.Forms.Button();
            this.studentIdListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(431, 361);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(149, 106);
            this.createButton.TabIndex = 0;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // studentIdListBox
            // 
            this.studentIdListBox.FormattingEnabled = true;
            this.studentIdListBox.ItemHeight = 16;
            this.studentIdListBox.Location = new System.Drawing.Point(431, 129);
            this.studentIdListBox.Name = "studentIdListBox";
            this.studentIdListBox.Size = new System.Drawing.Size(120, 84);
            this.studentIdListBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 747);
            this.Controls.Add(this.studentIdListBox);
            this.Controls.Add(this.createButton);
            this.Name = "Form1";
            this.Text = "Create";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.ListBox studentIdListBox;
    }
}

