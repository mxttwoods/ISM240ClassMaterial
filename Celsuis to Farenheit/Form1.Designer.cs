namespace Celsuis_to_Farenheit
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.celsuisLabel = new System.Windows.Forms.Label();
            this.fahrenheitLabel = new System.Windows.Forms.Label();
            this.celsiusTextBox = new System.Windows.Forms.TextBox();
            this.fahrenheitTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(65, 259);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(352, 259);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(81, 23);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(643, 259);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // celsuisLabel
            // 
            this.celsuisLabel.AutoSize = true;
            this.celsuisLabel.Location = new System.Drawing.Point(118, 96);
            this.celsuisLabel.Name = "celsuisLabel";
            this.celsuisLabel.Size = new System.Drawing.Size(53, 17);
            this.celsuisLabel.TabIndex = 3;
            this.celsuisLabel.Text = "Celsuis";
            // 
            // fahrenheitLabel
            // 
            this.fahrenheitLabel.AutoSize = true;
            this.fahrenheitLabel.Location = new System.Drawing.Point(118, 151);
            this.fahrenheitLabel.Name = "fahrenheitLabel";
            this.fahrenheitLabel.Size = new System.Drawing.Size(76, 17);
            this.fahrenheitLabel.TabIndex = 4;
            this.fahrenheitLabel.Text = "Fahrenheit";
            // 
            // celsiusTextBox
            // 
            this.celsiusTextBox.Location = new System.Drawing.Point(333, 96);
            this.celsiusTextBox.Name = "celsiusTextBox";
            this.celsiusTextBox.Size = new System.Drawing.Size(100, 22);
            this.celsiusTextBox.TabIndex = 5;
            // 
            // fahrenheitTextBox
            // 
            this.fahrenheitTextBox.Location = new System.Drawing.Point(333, 151);
            this.fahrenheitTextBox.Name = "fahrenheitTextBox";
            this.fahrenheitTextBox.Size = new System.Drawing.Size(100, 22);
            this.fahrenheitTextBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fahrenheitTextBox);
            this.Controls.Add(this.celsiusTextBox);
            this.Controls.Add(this.fahrenheitLabel);
            this.Controls.Add(this.celsuisLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Name = "Form1";
            this.Text = "Celsuis and Farenheit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label celsuisLabel;
        private System.Windows.Forms.Label fahrenheitLabel;
        private System.Windows.Forms.TextBox celsiusTextBox;
        private System.Windows.Forms.TextBox fahrenheitTextBox;
    }
}

