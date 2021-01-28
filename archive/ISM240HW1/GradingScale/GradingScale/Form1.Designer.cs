namespace GradingScale
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
            this.label = new System.Windows.Forms.Label();
            this.aButton = new System.Windows.Forms.Button();
            this.aminusButton = new System.Windows.Forms.Button();
            this.bplusbutton = new System.Windows.Forms.Button();
            this.cbutton = new System.Windows.Forms.Button();
            this.cminusButton = new System.Windows.Forms.Button();
            this.fButton = new System.Windows.Forms.Button();
            this.bButton = new System.Windows.Forms.Button();
            this.bminusButton = new System.Windows.Forms.Button();
            this.cplusButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(320, 47);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(74, 13);
            this.label.TabIndex = 1;
            this.label.Text = "Grading Scale";
            // 
            // aButton
            // 
            this.aButton.Location = new System.Drawing.Point(181, 117);
            this.aButton.Name = "aButton";
            this.aButton.Size = new System.Drawing.Size(75, 23);
            this.aButton.TabIndex = 2;
            this.aButton.Text = "A";
            this.aButton.UseVisualStyleBackColor = true;
            this.aButton.Click += new System.EventHandler(this.AButton_Click);
            // 
            // aminusButton
            // 
            this.aminusButton.Location = new System.Drawing.Point(301, 117);
            this.aminusButton.Name = "aminusButton";
            this.aminusButton.Size = new System.Drawing.Size(75, 23);
            this.aminusButton.TabIndex = 3;
            this.aminusButton.Text = "A -";
            this.aminusButton.UseVisualStyleBackColor = true;
            this.aminusButton.Click += new System.EventHandler(this.AminusButton_Click);
            // 
            // bplusbutton
            // 
            this.bplusbutton.Location = new System.Drawing.Point(420, 117);
            this.bplusbutton.Name = "bplusbutton";
            this.bplusbutton.Size = new System.Drawing.Size(75, 23);
            this.bplusbutton.TabIndex = 4;
            this.bplusbutton.Text = "B+";
            this.bplusbutton.UseVisualStyleBackColor = true;
            this.bplusbutton.Click += new System.EventHandler(this.Bplusbutton_Click);
            // 
            // cbutton
            // 
            this.cbutton.Location = new System.Drawing.Point(181, 303);
            this.cbutton.Name = "cbutton";
            this.cbutton.Size = new System.Drawing.Size(75, 23);
            this.cbutton.TabIndex = 5;
            this.cbutton.Text = "C";
            this.cbutton.UseVisualStyleBackColor = true;
            this.cbutton.Click += new System.EventHandler(this.Cbutton_Click);
            // 
            // cminusButton
            // 
            this.cminusButton.Location = new System.Drawing.Point(301, 303);
            this.cminusButton.Name = "cminusButton";
            this.cminusButton.Size = new System.Drawing.Size(75, 23);
            this.cminusButton.TabIndex = 6;
            this.cminusButton.Text = "C -";
            this.cminusButton.UseVisualStyleBackColor = true;
            this.cminusButton.Click += new System.EventHandler(this.CminusButton_Click);
            // 
            // fButton
            // 
            this.fButton.Location = new System.Drawing.Point(420, 303);
            this.fButton.Name = "fButton";
            this.fButton.Size = new System.Drawing.Size(75, 23);
            this.fButton.TabIndex = 7;
            this.fButton.Text = "F";
            this.fButton.UseVisualStyleBackColor = true;
            this.fButton.Click += new System.EventHandler(this.FButton_Click);
            // 
            // bButton
            // 
            this.bButton.Location = new System.Drawing.Point(181, 206);
            this.bButton.Name = "bButton";
            this.bButton.Size = new System.Drawing.Size(75, 23);
            this.bButton.TabIndex = 8;
            this.bButton.Text = "B";
            this.bButton.UseVisualStyleBackColor = true;
            this.bButton.Click += new System.EventHandler(this.BButton_Click);
            // 
            // bminusButton
            // 
            this.bminusButton.Location = new System.Drawing.Point(301, 206);
            this.bminusButton.Name = "bminusButton";
            this.bminusButton.Size = new System.Drawing.Size(75, 23);
            this.bminusButton.TabIndex = 9;
            this.bminusButton.Text = "B -";
            this.bminusButton.UseVisualStyleBackColor = true;
            this.bminusButton.Click += new System.EventHandler(this.BminusButton_Click);
            // 
            // cplusButton
            // 
            this.cplusButton.Location = new System.Drawing.Point(420, 206);
            this.cplusButton.Name = "cplusButton";
            this.cplusButton.Size = new System.Drawing.Size(75, 23);
            this.cplusButton.TabIndex = 10;
            this.cplusButton.Text = "C +";
            this.cplusButton.UseVisualStyleBackColor = true;
            this.cplusButton.Click += new System.EventHandler(this.CplusButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cplusButton);
            this.Controls.Add(this.bminusButton);
            this.Controls.Add(this.bButton);
            this.Controls.Add(this.fButton);
            this.Controls.Add(this.cminusButton);
            this.Controls.Add(this.cbutton);
            this.Controls.Add(this.bplusbutton);
            this.Controls.Add(this.aminusButton);
            this.Controls.Add(this.aButton);
            this.Controls.Add(this.label);
            this.Name = "Form1";
            this.Text = "Grading Scale";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button aButton;
        private System.Windows.Forms.Button aminusButton;
        private System.Windows.Forms.Button bplusbutton;
        private System.Windows.Forms.Button cbutton;
        private System.Windows.Forms.Button cminusButton;
        private System.Windows.Forms.Button fButton;
        private System.Windows.Forms.Button bButton;
        private System.Windows.Forms.Button bminusButton;
        private System.Windows.Forms.Button cplusButton;
    }
}

