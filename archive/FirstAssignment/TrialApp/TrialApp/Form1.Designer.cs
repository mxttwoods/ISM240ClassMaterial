namespace TrialApp
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
            this.answerLabel = new System.Windows.Forms.Label();
            this.showAnswerButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Location = new System.Drawing.Point(345, 117);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(64, 13);
            this.answerLabel.TabIndex = 0;
            this.answerLabel.Text = "18 + 64 = ? ";
            this.answerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showAnswerButton
            // 
            this.showAnswerButton.Location = new System.Drawing.Point(80, 254);
            this.showAnswerButton.Name = "showAnswerButton";
            this.showAnswerButton.Size = new System.Drawing.Size(108, 50);
            this.showAnswerButton.TabIndex = 1;
            this.showAnswerButton.Text = "Show Answer";
            this.showAnswerButton.UseVisualStyleBackColor = true;
            this.showAnswerButton.Click += new System.EventHandler(this.showAnswer);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(591, 254);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(108, 50);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.showAnswerButton);
            this.Controls.Add(this.answerLabel);
            this.Name = "Form1";
            this.Text = "Math Tutor Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.Button showAnswerButton;
        private System.Windows.Forms.Button exitButton;
    }
}

