namespace CapitalsWorld
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
            this.btnSubmitAnswer = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.optChoice1 = new System.Windows.Forms.RadioButton();
            this.optChoice2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnSubmitAnswer
            // 
            this.btnSubmitAnswer.Location = new System.Drawing.Point(69, 153);
            this.btnSubmitAnswer.Name = "btnSubmitAnswer";
            this.btnSubmitAnswer.Size = new System.Drawing.Size(96, 23);
            this.btnSubmitAnswer.TabIndex = 0;
            this.btnSubmitAnswer.Text = "Submit Answer";
            this.btnSubmitAnswer.UseVisualStyleBackColor = true;
            this.btnSubmitAnswer.Click += new System.EventHandler(this.btnSubmitAnswer_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(66, 47);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(35, 13);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "label1";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(66, 209);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(35, 13);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "label2";
            // 
            // optChoice1
            // 
            this.optChoice1.AutoSize = true;
            this.optChoice1.Location = new System.Drawing.Point(69, 84);
            this.optChoice1.Name = "optChoice1";
            this.optChoice1.Size = new System.Drawing.Size(85, 17);
            this.optChoice1.TabIndex = 3;
            this.optChoice1.TabStop = true;
            this.optChoice1.Text = "radioButton1";
            this.optChoice1.UseVisualStyleBackColor = true;
            // 
            // optChoice2
            // 
            this.optChoice2.AutoSize = true;
            this.optChoice2.Location = new System.Drawing.Point(69, 120);
            this.optChoice2.Name = "optChoice2";
            this.optChoice2.Size = new System.Drawing.Size(85, 17);
            this.optChoice2.TabIndex = 4;
            this.optChoice2.TabStop = true;
            this.optChoice2.Text = "radioButton2";
            this.optChoice2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.optChoice2);
            this.Controls.Add(this.optChoice1);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnSubmitAnswer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmitAnswer;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.RadioButton optChoice1;
        private System.Windows.Forms.RadioButton optChoice2;
    }
}

