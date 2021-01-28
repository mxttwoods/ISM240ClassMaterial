namespace Health_Club_Membership_Fee_Calculator
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
            this.yogalessons = new System.Windows.Forms.CheckBox();
            this.zumbalessons = new System.Windows.Forms.CheckBox();
            this.karatelessons = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.adultmembership = new System.Windows.Forms.CheckBox();
            this.childmembership = new System.Windows.Forms.CheckBox();
            this.studentmembership = new System.Windows.Forms.CheckBox();
            this.finalprice = new System.Windows.Forms.Label();
            this.seniormembership = new System.Windows.Forms.CheckBox();
            this.personaltraining = new System.Windows.Forms.CheckBox();
            this.finalpriceLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton_Click = new System.Windows.Forms.Button();
            this.clearButton_Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yogalessons
            // 
            this.yogalessons.AutoSize = true;
            this.yogalessons.Location = new System.Drawing.Point(780, 120);
            this.yogalessons.Name = "yogalessons";
            this.yogalessons.Size = new System.Drawing.Size(120, 21);
            this.yogalessons.TabIndex = 0;
            this.yogalessons.Text = "Yoga Lessons";
            this.yogalessons.UseVisualStyleBackColor = true;
            // 
            // zumbalessons
            // 
            this.zumbalessons.AutoSize = true;
            this.zumbalessons.Location = new System.Drawing.Point(780, 200);
            this.zumbalessons.Name = "zumbalessons";
            this.zumbalessons.Size = new System.Drawing.Size(131, 21);
            this.zumbalessons.TabIndex = 1;
            this.zumbalessons.Text = "Zumba Lessons";
            this.zumbalessons.UseVisualStyleBackColor = true;
            // 
            // karatelessons
            // 
            this.karatelessons.AutoSize = true;
            this.karatelessons.Location = new System.Drawing.Point(780, 283);
            this.karatelessons.Name = "karatelessons";
            this.karatelessons.Size = new System.Drawing.Size(129, 21);
            this.karatelessons.TabIndex = 2;
            this.karatelessons.Text = "Karate Lessons";
            this.karatelessons.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(438, 437);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 22);
            this.textBox1.TabIndex = 3;
            // 
            // adultmembership
            // 
            this.adultmembership.AutoSize = true;
            this.adultmembership.Location = new System.Drawing.Point(159, 110);
            this.adultmembership.Name = "adultmembership";
            this.adultmembership.Size = new System.Drawing.Size(143, 21);
            this.adultmembership.TabIndex = 4;
            this.adultmembership.Text = "Adult Membership";
            this.adultmembership.UseVisualStyleBackColor = true;
            this.adultmembership.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // childmembership
            // 
            this.childmembership.AutoSize = true;
            this.childmembership.Location = new System.Drawing.Point(159, 200);
            this.childmembership.Name = "childmembership";
            this.childmembership.Size = new System.Drawing.Size(142, 21);
            this.childmembership.TabIndex = 5;
            this.childmembership.Text = "Child Membership";
            this.childmembership.UseVisualStyleBackColor = true;
            // 
            // studentmembership
            // 
            this.studentmembership.AutoSize = true;
            this.studentmembership.Location = new System.Drawing.Point(160, 283);
            this.studentmembership.Name = "studentmembership";
            this.studentmembership.Size = new System.Drawing.Size(160, 21);
            this.studentmembership.TabIndex = 6;
            this.studentmembership.Text = "Student Membership";
            this.studentmembership.UseVisualStyleBackColor = true;
            // 
            // finalprice
            // 
            this.finalprice.AutoSize = true;
            this.finalprice.Location = new System.Drawing.Point(493, 285);
            this.finalprice.Name = "finalprice";
            this.finalprice.Size = new System.Drawing.Size(0, 17);
            this.finalprice.TabIndex = 7;
            // 
            // seniormembership
            // 
            this.seniormembership.AutoSize = true;
            this.seniormembership.Location = new System.Drawing.Point(159, 360);
            this.seniormembership.Name = "seniormembership";
            this.seniormembership.Size = new System.Drawing.Size(152, 21);
            this.seniormembership.TabIndex = 8;
            this.seniormembership.Text = "Senior Membership";
            this.seniormembership.UseVisualStyleBackColor = true;
            // 
            // personaltraining
            // 
            this.personaltraining.AutoSize = true;
            this.personaltraining.Location = new System.Drawing.Point(780, 360);
            this.personaltraining.Name = "personaltraining";
            this.personaltraining.Size = new System.Drawing.Size(142, 21);
            this.personaltraining.TabIndex = 9;
            this.personaltraining.Text = "Personal Training";
            this.personaltraining.UseVisualStyleBackColor = true;
            // 
            // finalpriceLabel
            // 
            this.finalpriceLabel.AutoSize = true;
            this.finalpriceLabel.Location = new System.Drawing.Point(493, 319);
            this.finalpriceLabel.Name = "finalpriceLabel";
            this.finalpriceLabel.Size = new System.Drawing.Size(46, 17);
            this.finalpriceLabel.TabIndex = 10;
            this.finalpriceLabel.Text = "label1";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(312, 543);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 11;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            // 
            // exitButton_Click
            // 
            this.exitButton_Click.Location = new System.Drawing.Point(624, 543);
            this.exitButton_Click.Name = "exitButton_Click";
            this.exitButton_Click.Size = new System.Drawing.Size(75, 23);
            this.exitButton_Click.TabIndex = 12;
            this.exitButton_Click.Text = "Exit";
            this.exitButton_Click.UseVisualStyleBackColor = true;
            // 
            // clearButton_Click
            // 
            this.clearButton_Click.Location = new System.Drawing.Point(481, 543);
            this.clearButton_Click.Name = "clearButton_Click";
            this.clearButton_Click.Size = new System.Drawing.Size(75, 23);
            this.clearButton_Click.TabIndex = 13;
            this.clearButton_Click.Text = "Clear";
            this.clearButton_Click.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 713);
            this.Controls.Add(this.clearButton_Click);
            this.Controls.Add(this.exitButton_Click);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.finalpriceLabel);
            this.Controls.Add(this.personaltraining);
            this.Controls.Add(this.seniormembership);
            this.Controls.Add(this.finalprice);
            this.Controls.Add(this.studentmembership);
            this.Controls.Add(this.childmembership);
            this.Controls.Add(this.adultmembership);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.karatelessons);
            this.Controls.Add(this.zumbalessons);
            this.Controls.Add(this.yogalessons);
            this.Name = "Form1";
            this.Text = "Membership Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox yogalessons;
        private System.Windows.Forms.CheckBox zumbalessons;
        private System.Windows.Forms.CheckBox karatelessons;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox adultmembership;
        private System.Windows.Forms.CheckBox childmembership;
        private System.Windows.Forms.CheckBox studentmembership;
        private System.Windows.Forms.Label finalprice;
        private System.Windows.Forms.CheckBox seniormembership;
        private System.Windows.Forms.CheckBox personaltraining;
        private System.Windows.Forms.Label finalpriceLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton_Click;
        private System.Windows.Forms.Button clearButton_Click;
    }
}

