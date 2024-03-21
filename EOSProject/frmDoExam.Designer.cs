namespace EOSProject {
    partial class frmDoExam {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            grOption = new GroupBox();
            rd_4 = new RadioButton();
            rd_3 = new RadioButton();
            rd_2 = new RadioButton();
            rd_1 = new RadioButton();
            rtbOption = new RichTextBox();
            rtbQuestion = new RichTextBox();
            groupBox2 = new GroupBox();
            btnNext = new Button();
            lbNumberQuestion = new Label();
            checkBox1 = new CheckBox();
            btnFinish = new Button();
            lbTimeTest = new Label();
            label3 = new Label();
            lbSubject = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            lbNumQuestion = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            lbCountDown = new Label();
            grOption.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 48);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 0;
            label1.Text = "Duration:";
            // 
            // grOption
            // 
            grOption.Controls.Add(rd_4);
            grOption.Controls.Add(rd_3);
            grOption.Controls.Add(rd_2);
            grOption.Controls.Add(rd_1);
            grOption.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grOption.ForeColor = Color.Blue;
            grOption.Location = new Point(21, 206);
            grOption.Name = "grOption";
            grOption.Size = new Size(93, 281);
            grOption.TabIndex = 1;
            grOption.TabStop = false;
            grOption.Text = "Answer";
            // 
            // rd_4
            // 
            rd_4.AutoSize = true;
            rd_4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rd_4.ForeColor = Color.FromArgb(0, 0, 64);
            rd_4.Location = new Point(12, 231);
            rd_4.Name = "rd_4";
            rd_4.Size = new Size(50, 29);
            rd_4.TabIndex = 3;
            rd_4.Text = "D";
            rd_4.UseVisualStyleBackColor = true;
            // 
            // rd_3
            // 
            rd_3.AutoSize = true;
            rd_3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rd_3.ForeColor = Color.FromArgb(0, 0, 64);
            rd_3.Location = new Point(12, 177);
            rd_3.Name = "rd_3";
            rd_3.Size = new Size(48, 29);
            rd_3.TabIndex = 2;
            rd_3.Text = "C";
            rd_3.UseVisualStyleBackColor = true;
            // 
            // rd_2
            // 
            rd_2.AutoSize = true;
            rd_2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rd_2.ForeColor = Color.FromArgb(0, 0, 64);
            rd_2.Location = new Point(12, 118);
            rd_2.Name = "rd_2";
            rd_2.Size = new Size(47, 29);
            rd_2.TabIndex = 1;
            rd_2.Text = "B";
            rd_2.UseVisualStyleBackColor = true;
            // 
            // rd_1
            // 
            rd_1.AutoSize = true;
            rd_1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rd_1.ForeColor = Color.FromArgb(0, 0, 64);
            rd_1.Location = new Point(12, 55);
            rd_1.Name = "rd_1";
            rd_1.Size = new Size(49, 29);
            rd_1.TabIndex = 0;
            rd_1.Text = "A";
            rd_1.UseVisualStyleBackColor = true;
            // 
            // rtbOption
            // 
            rtbOption.BackColor = SystemColors.ButtonHighlight;
            rtbOption.Location = new Point(186, 216);
            rtbOption.Name = "rtbOption";
            rtbOption.ReadOnly = true;
            rtbOption.Size = new Size(575, 507);
            rtbOption.TabIndex = 2;
            rtbOption.Text = "(Choose one answer)";
            // 
            // rtbQuestion
            // 
            rtbQuestion.BackColor = SystemColors.ButtonHighlight;
            rtbQuestion.Location = new Point(784, 216);
            rtbQuestion.Name = "rtbQuestion";
            rtbQuestion.ReadOnly = true;
            rtbQuestion.Size = new Size(920, 507);
            rtbQuestion.TabIndex = 3;
            rtbQuestion.Text = "";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnNext);
            groupBox2.Controls.Add(lbNumberQuestion);
            groupBox2.Location = new Point(12, 142);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1734, 612);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            // 
            // btnNext
            // 
            btnNext.BackColor = SystemColors.ButtonHighlight;
            btnNext.Location = new Point(9, 384);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(93, 34);
            btnNext.TabIndex = 1;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // lbNumberQuestion
            // 
            lbNumberQuestion.AutoSize = true;
            lbNumberQuestion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbNumberQuestion.ForeColor = Color.Blue;
            lbNumberQuestion.Location = new Point(174, 27);
            lbNumberQuestion.Name = "lbNumberQuestion";
            lbNumberQuestion.Size = new Size(63, 25);
            lbNumberQuestion.TabIndex = 0;
            lbNumberQuestion.Text = "label2";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = Color.Blue;
            checkBox1.Location = new Point(12, 883);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(235, 29);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "I want to finish this exam";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnFinish
            // 
            btnFinish.BackColor = Color.NavajoWhite;
            btnFinish.Enabled = false;
            btnFinish.Location = new Point(12, 918);
            btnFinish.Name = "btnFinish";
            btnFinish.Size = new Size(112, 34);
            btnFinish.TabIndex = 6;
            btnFinish.Text = "Finish";
            btnFinish.UseVisualStyleBackColor = false;
            btnFinish.Click += btnFinish_Click;
            // 
            // lbTimeTest
            // 
            lbTimeTest.AutoSize = true;
            lbTimeTest.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbTimeTest.ForeColor = Color.Blue;
            lbTimeTest.Location = new Point(193, 48);
            lbTimeTest.Name = "lbTimeTest";
            lbTimeTest.Size = new Size(105, 25);
            lbTimeTest.TabIndex = 7;
            lbTimeTest.Text = "60 minutes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(352, 48);
            label3.Name = "label3";
            label3.Size = new Size(74, 25);
            label3.TabIndex = 0;
            label3.Text = "Subject:";
            // 
            // lbSubject
            // 
            lbSubject.AutoSize = true;
            lbSubject.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbSubject.ForeColor = Color.Blue;
            lbSubject.Location = new Point(481, 48);
            lbSubject.Name = "lbSubject";
            lbSubject.Size = new Size(105, 25);
            lbSubject.TabIndex = 7;
            lbSubject.Text = "60 minutes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(106, 99);
            label2.Name = "label2";
            label2.Size = new Size(75, 25);
            label2.TabIndex = 8;
            label2.Text = "Q Mark:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(211, 99);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(352, 99);
            label5.Name = "label5";
            label5.Size = new Size(106, 25);
            label5.TabIndex = 8;
            label5.Text = "Total Marks:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Blue;
            label7.Location = new Point(193, 99);
            label7.Name = "label7";
            label7.Size = new Size(22, 25);
            label7.TabIndex = 7;
            label7.Text = "1";
            // 
            // lbNumQuestion
            // 
            lbNumQuestion.AutoSize = true;
            lbNumQuestion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbNumQuestion.ForeColor = Color.Blue;
            lbNumQuestion.Location = new Point(481, 99);
            lbNumQuestion.Name = "lbNumQuestion";
            lbNumQuestion.Size = new Size(32, 25);
            lbNumQuestion.TabIndex = 7;
            lbNumQuestion.Text = "10";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(636, 48);
            label6.Name = "label6";
            label6.Size = new Size(74, 25);
            label6.TabIndex = 0;
            label6.Text = "Subject:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Blue;
            label8.Location = new Point(728, 48);
            label8.Name = "label8";
            label8.Size = new Size(105, 25);
            label8.TabIndex = 7;
            label8.Text = "60 minutes";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(922, 104);
            label9.Name = "label9";
            label9.Size = new Size(84, 25);
            label9.TabIndex = 9;
            label9.Text = "Time left:";
            // 
            // lbCountDown
            // 
            lbCountDown.AutoSize = true;
            lbCountDown.Font = new Font("Segoe UI", 34F, FontStyle.Bold, GraphicsUnit.Point);
            lbCountDown.Location = new Point(1055, 51);
            lbCountDown.Name = "lbCountDown";
            lbCountDown.Size = new Size(213, 91);
            lbCountDown.TabIndex = 9;
            lbCountDown.Text = "00:00";
            // 
            // frmDoExam
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1839, 961);
            Controls.Add(lbCountDown);
            Controls.Add(label9);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(lbNumQuestion);
            Controls.Add(label8);
            Controls.Add(lbSubject);
            Controls.Add(label7);
            Controls.Add(lbTimeTest);
            Controls.Add(btnFinish);
            Controls.Add(checkBox1);
            Controls.Add(rtbQuestion);
            Controls.Add(label6);
            Controls.Add(rtbOption);
            Controls.Add(label3);
            Controls.Add(grOption);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Name = "frmDoExam";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FPT Exam Online System";
            Load += frmDoExam_Load;
            grOption.ResumeLayout(false);
            grOption.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox grOption;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private RadioButton rd_4;
        private RadioButton rd_3;
        private RadioButton rd_2;
        private RadioButton rd_1;
        private GroupBox groupBox2;
        private Label lbNumberQuestion;
        private Button btnFinish;
        private Button btnNext;
        private CheckBox checkBox1;
        private RichTextBox rtbOption;
        private RichTextBox rtbQuestion;
        private Label lbTimeTest;
        private Label label3;
        private Label lbSubject;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label lbNumQuestion;
        private Label label6;
        private Label label8;
        private Label label9;
        private Label lbCountDown;
    }
}