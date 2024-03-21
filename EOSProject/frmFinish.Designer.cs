namespace EOSProject {
    partial class frmFinish {
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
            btnFinish = new Button();
            chbFinish = new CheckBox();
            btnExist = new Button();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            lbNumQuestion = new Label();
            label8 = new Label();
            lbSubject = new Label();
            label7 = new Label();
            lbTimeTest = new Label();
            label6 = new Label();
            label3 = new Label();
            label1 = new Label();
            label9 = new Label();
            lbCountDown = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // btnFinish
            // 
            btnFinish.BackColor = Color.NavajoWhite;
            btnFinish.Enabled = false;
            btnFinish.Location = new Point(12, 404);
            btnFinish.Name = "btnFinish";
            btnFinish.Size = new Size(112, 34);
            btnFinish.TabIndex = 8;
            btnFinish.Text = "Finish";
            btnFinish.UseVisualStyleBackColor = false;
            // 
            // chbFinish
            // 
            chbFinish.AutoSize = true;
            chbFinish.Checked = true;
            chbFinish.CheckState = CheckState.Checked;
            chbFinish.Enabled = false;
            chbFinish.ForeColor = Color.Blue;
            chbFinish.Location = new Point(15, 369);
            chbFinish.Name = "chbFinish";
            chbFinish.Size = new Size(235, 29);
            chbFinish.TabIndex = 7;
            chbFinish.Text = "I want to finish this exam";
            chbFinish.UseVisualStyleBackColor = true;
            chbFinish.CheckedChanged += chbFinish_CheckedChanged;
            // 
            // btnExist
            // 
            btnExist.Location = new Point(642, 404);
            btnExist.Name = "btnExist";
            btnExist.Size = new Size(112, 34);
            btnExist.TabIndex = 9;
            btnExist.Text = "Exist";
            btnExist.UseVisualStyleBackColor = true;
            btnExist.Click += btnExist_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(261, 60);
            label5.Name = "label5";
            label5.Size = new Size(106, 25);
            label5.TabIndex = 18;
            label5.Text = "Total Marks:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(120, 60);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 60);
            label2.Name = "label2";
            label2.Size = new Size(75, 25);
            label2.TabIndex = 20;
            label2.Text = "Q Mark:";
            // 
            // lbNumQuestion
            // 
            lbNumQuestion.AutoSize = true;
            lbNumQuestion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbNumQuestion.ForeColor = Color.Blue;
            lbNumQuestion.Location = new Point(390, 60);
            lbNumQuestion.Name = "lbNumQuestion";
            lbNumQuestion.Size = new Size(32, 25);
            lbNumQuestion.TabIndex = 13;
            lbNumQuestion.Text = "10";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Blue;
            label8.Location = new Point(637, 9);
            label8.Name = "label8";
            label8.Size = new Size(105, 25);
            label8.TabIndex = 14;
            label8.Text = "60 minutes";
            // 
            // lbSubject
            // 
            lbSubject.AutoSize = true;
            lbSubject.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbSubject.ForeColor = Color.Blue;
            lbSubject.Location = new Point(390, 9);
            lbSubject.Name = "lbSubject";
            lbSubject.Size = new Size(105, 25);
            lbSubject.TabIndex = 15;
            lbSubject.Text = "60 minutes";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Blue;
            label7.Location = new Point(102, 60);
            label7.Name = "label7";
            label7.Size = new Size(22, 25);
            label7.TabIndex = 16;
            label7.Text = "1";
            // 
            // lbTimeTest
            // 
            lbTimeTest.AutoSize = true;
            lbTimeTest.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbTimeTest.ForeColor = Color.Blue;
            lbTimeTest.Location = new Point(102, 9);
            lbTimeTest.Name = "lbTimeTest";
            lbTimeTest.Size = new Size(105, 25);
            lbTimeTest.TabIndex = 17;
            lbTimeTest.Text = "60 minutes";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(545, 9);
            label6.Name = "label6";
            label6.Size = new Size(74, 25);
            label6.TabIndex = 10;
            label6.Text = "Subject:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(261, 9);
            label3.Name = "label3";
            label3.Size = new Size(74, 25);
            label3.TabIndex = 11;
            label3.Text = "Subject:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 9);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 12;
            label1.Text = "Duration:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Blue;
            label9.Location = new Point(141, 409);
            label9.Name = "label9";
            label9.Size = new Size(180, 25);
            label9.TabIndex = 21;
            label9.Text = "Submit Successfully";
            // 
            // lbCountDown
            // 
            lbCountDown.AutoSize = true;
            lbCountDown.Font = new Font("Segoe UI", 34F, FontStyle.Bold, GraphicsUnit.Point);
            lbCountDown.Location = new Point(557, 74);
            lbCountDown.Name = "lbCountDown";
            lbCountDown.Size = new Size(213, 91);
            lbCountDown.TabIndex = 22;
            lbCountDown.Text = "00:00";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(424, 127);
            label10.Name = "label10";
            label10.Size = new Size(84, 25);
            label10.TabIndex = 23;
            label10.Text = "Time left:";
            // 
            // frmFinish
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbCountDown);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(lbNumQuestion);
            Controls.Add(label8);
            Controls.Add(lbSubject);
            Controls.Add(label7);
            Controls.Add(lbTimeTest);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnExist);
            Controls.Add(btnFinish);
            Controls.Add(chbFinish);
            Name = "frmFinish";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Finish";
            Load += frmFinish_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFinish;
        private CheckBox chbFinish;
        private Button btnExist;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label lbNumQuestion;
        private Label label8;
        private Label lbSubject;
        private Label label7;
        private Label lbTimeTest;
        private Label label6;
        private Label label3;
        private Label label1;
        private Label label9;
        private Label lbCountDown;
        private Label label10;
    }
}