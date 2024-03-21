namespace EOSProject {
    partial class frmQuestionDetails {
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
            groupBox1 = new GroupBox();
            cbExam = new ComboBox();
            cbSubject = new ComboBox();
            tbQuestionContent = new RichTextBox();
            tbQuestionID = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            rdOption4 = new RadioButton();
            rdOption3 = new RadioButton();
            rdOption2 = new RadioButton();
            rdOption1 = new RadioButton();
            contentOption4 = new RichTextBox();
            contentOption3 = new RichTextBox();
            contentOption2 = new RichTextBox();
            contentOption1 = new RichTextBox();
            btnSave = new Button();
            btnClose = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbExam);
            groupBox1.Controls.Add(cbSubject);
            groupBox1.Controls.Add(tbQuestionContent);
            groupBox1.Controls.Add(tbQuestionID);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 71);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(739, 558);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Question Information";
            // 
            // cbExam
            // 
            cbExam.FormattingEnabled = true;
            cbExam.Location = new Point(253, 446);
            cbExam.Name = "cbExam";
            cbExam.Size = new Size(456, 33);
            cbExam.TabIndex = 5;
            // 
            // cbSubject
            // 
            cbSubject.FormattingEnabled = true;
            cbSubject.Location = new Point(257, 363);
            cbSubject.Name = "cbSubject";
            cbSubject.Size = new Size(182, 33);
            cbSubject.TabIndex = 5;
            // 
            // tbQuestionContent
            // 
            tbQuestionContent.Location = new Point(257, 153);
            tbQuestionContent.Name = "tbQuestionContent";
            tbQuestionContent.Size = new Size(452, 171);
            tbQuestionContent.TabIndex = 3;
            tbQuestionContent.Text = "";
            // 
            // tbQuestionID
            // 
            tbQuestionID.Location = new Point(257, 63);
            tbQuestionID.Name = "tbQuestionID";
            tbQuestionID.Size = new Size(182, 31);
            tbQuestionID.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(15, 454);
            label5.Name = "label5";
            label5.Size = new Size(58, 25);
            label5.TabIndex = 1;
            label5.Text = "Exam";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(15, 371);
            label4.Name = "label4";
            label4.Size = new Size(75, 25);
            label4.TabIndex = 1;
            label4.Text = "Subject";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(15, 153);
            label3.Name = "label3";
            label3.Size = new Size(162, 25);
            label3.TabIndex = 1;
            label3.Text = "Question Content";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(15, 69);
            label2.Name = "label2";
            label2.Size = new Size(113, 25);
            label2.TabIndex = 1;
            label2.Text = "Question ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(580, 9);
            label1.Name = "label1";
            label1.Size = new Size(345, 47);
            label1.TabIndex = 1;
            label1.Text = "Question Information";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(rdOption4);
            groupBox2.Controls.Add(rdOption3);
            groupBox2.Controls.Add(rdOption2);
            groupBox2.Controls.Add(rdOption1);
            groupBox2.Controls.Add(contentOption4);
            groupBox2.Controls.Add(contentOption3);
            groupBox2.Controls.Add(contentOption2);
            groupBox2.Controls.Add(contentOption1);
            groupBox2.Location = new Point(781, 71);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(700, 716);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Answers";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(552, 47);
            label7.Name = "label7";
            label7.Size = new Size(142, 25);
            label7.TabIndex = 10;
            label7.Text = "Correct Answer";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(239, 47);
            label6.Name = "label6";
            label6.Size = new Size(80, 25);
            label6.TabIndex = 11;
            label6.Text = "Content";
            // 
            // rdOption4
            // 
            rdOption4.AutoSize = true;
            rdOption4.Location = new Point(609, 620);
            rdOption4.Name = "rdOption4";
            rdOption4.Size = new Size(21, 20);
            rdOption4.TabIndex = 8;
            rdOption4.UseVisualStyleBackColor = true;
            // 
            // rdOption3
            // 
            rdOption3.AutoSize = true;
            rdOption3.Location = new Point(609, 469);
            rdOption3.Name = "rdOption3";
            rdOption3.Size = new Size(21, 20);
            rdOption3.TabIndex = 7;
            rdOption3.UseVisualStyleBackColor = true;
            // 
            // rdOption2
            // 
            rdOption2.AutoSize = true;
            rdOption2.Location = new Point(609, 310);
            rdOption2.Name = "rdOption2";
            rdOption2.Size = new Size(21, 20);
            rdOption2.TabIndex = 6;
            rdOption2.UseVisualStyleBackColor = true;
            // 
            // rdOption1
            // 
            rdOption1.AutoSize = true;
            rdOption1.Checked = true;
            rdOption1.Location = new Point(609, 149);
            rdOption1.Name = "rdOption1";
            rdOption1.Size = new Size(21, 20);
            rdOption1.TabIndex = 5;
            rdOption1.TabStop = true;
            rdOption1.UseVisualStyleBackColor = true;
            // 
            // contentOption4
            // 
            contentOption4.Location = new Point(37, 565);
            contentOption4.Name = "contentOption4";
            contentOption4.Size = new Size(517, 126);
            contentOption4.TabIndex = 4;
            contentOption4.Text = "";
            // 
            // contentOption3
            // 
            contentOption3.Location = new Point(37, 413);
            contentOption3.Name = "contentOption3";
            contentOption3.Size = new Size(517, 119);
            contentOption3.TabIndex = 3;
            contentOption3.Text = "";
            // 
            // contentOption2
            // 
            contentOption2.Location = new Point(37, 251);
            contentOption2.Name = "contentOption2";
            contentOption2.Size = new Size(517, 127);
            contentOption2.TabIndex = 2;
            contentOption2.Text = "";
            // 
            // contentOption1
            // 
            contentOption1.Location = new Point(37, 90);
            contentOption1.Name = "contentOption1";
            contentOption1.Size = new Size(517, 120);
            contentOption1.TabIndex = 1;
            contentOption1.Text = "";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(301, 679);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(169, 51);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(497, 679);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(169, 51);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmQuestionDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1513, 799);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "frmQuestionDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmQuestionDetails";
            Load += frmQuestionDetails_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private RichTextBox tbQuestionContent;
        private TextBox tbQuestionID;
        private GroupBox groupBox2;
        private RichTextBox contentOption2;
        private RichTextBox contentOption1;
        private RichTextBox contentOption4;
        private RichTextBox contentOption3;
        private RadioButton rdOption4;
        private RadioButton rdOption3;
        private RadioButton rdOption2;
        private RadioButton rdOption1;
        private Button btnSave;
        private ComboBox cbExam;
        private ComboBox cbSubject;
        private Label label7;
        private Label label6;
        private Button btnClose;
    }
}