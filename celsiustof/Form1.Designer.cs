namespace celsiustof
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
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.fahrenheitTextBox = new System.Windows.Forms.TextBox();
            this.celsiusTextBox = new System.Windows.Forms.TextBox();
            this.celsuisLabel = new System.Windows.Forms.Label();
            this.fahrenheitLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(73, 245);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 0;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.Calculate);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(291, 245);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(503, 245);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // fahrenheitTextBox
            // 
            this.fahrenheitTextBox.Location = new System.Drawing.Point(266, 133);
            this.fahrenheitTextBox.Name = "fahrenheitTextBox";
            this.fahrenheitTextBox.Size = new System.Drawing.Size(100, 20);
            this.fahrenheitTextBox.TabIndex = 3;
            // 
            // celsiusTextBox
            // 
            this.celsiusTextBox.Location = new System.Drawing.Point(266, 67);
            this.celsiusTextBox.Name = "celsiusTextBox";
            this.celsiusTextBox.Size = new System.Drawing.Size(100, 20);
            this.celsiusTextBox.TabIndex = 4;
            // 
            // celsuisLabel
            // 
            this.celsuisLabel.AutoSize = true;
            this.celsuisLabel.Location = new System.Drawing.Point(177, 67);
            this.celsuisLabel.Name = "celsuisLabel";
            this.celsuisLabel.Size = new System.Drawing.Size(40, 13);
            this.celsuisLabel.TabIndex = 5;
            this.celsuisLabel.Text = "Celsius";
            // 
            // fahrenheitLabel
            // 
            this.fahrenheitLabel.AutoSize = true;
            this.fahrenheitLabel.Location = new System.Drawing.Point(177, 133);
            this.fahrenheitLabel.Name = "fahrenheitLabel";
            this.fahrenheitLabel.Size = new System.Drawing.Size(57, 13);
            this.fahrenheitLabel.TabIndex = 6;
            this.fahrenheitLabel.Text = "Fahrenheit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fahrenheitLabel);
            this.Controls.Add(this.celsuisLabel);
            this.Controls.Add(this.celsiusTextBox);
            this.Controls.Add(this.fahrenheitTextBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CalculateButton);
            this.Name = "Form1";
            this.Text = "Celsius to Fahrenheit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox fahrenheitTextBox;
        private System.Windows.Forms.TextBox celsiusTextBox;
        private System.Windows.Forms.Label celsuisLabel;
        private System.Windows.Forms.Label fahrenheitLabel;
    }
}

