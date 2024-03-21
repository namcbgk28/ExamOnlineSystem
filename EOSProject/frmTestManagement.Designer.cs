namespace EOSProject {
    partial class frmTestManagement {
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
            dgvTestList = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            tbTestCode = new TextBox();
            cbSubject = new ComboBox();
            cbExam = new ComboBox();
            numPaperNo = new NumericUpDown();
            rdOn = new RadioButton();
            rdOff = new RadioButton();
            numTimeTest = new NumericUpDown();
            btnAdd = new Button();
            groupBox1 = new GroupBox();
            btnRefresh = new Button();
            btnClose = new Button();
            Update = new Button();
            numNumOfQuestion = new NumericUpDown();
            label12 = new Label();
            cbSubjects = new ComboBox();
            cbExams = new ComboBox();
            dtpFromDate = new DateTimePicker();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            dtpToDate = new DateTimePicker();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTestList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPaperNo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTimeTest).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numNumOfQuestion).BeginInit();
            SuspendLayout();
            // 
            // dgvTestList
            // 
            dgvTestList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTestList.Location = new Point(30, 213);
            dgvTestList.Name = "dgvTestList";
            dgvTestList.RowHeadersWidth = 62;
            dgvTestList.RowTemplate.Height = 33;
            dgvTestList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTestList.Size = new Size(1117, 587);
            dgvTestList.TabIndex = 0;
            dgvTestList.CellClick += dgvTestList_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(480, 9);
            label1.Name = "label1";
            label1.Size = new Size(196, 47);
            label1.TabIndex = 1;
            label1.Text = "Test Library";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 91);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 2;
            label2.Text = "Test Code";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 158);
            label3.Name = "label3";
            label3.Size = new Size(75, 25);
            label3.TabIndex = 2;
            label3.Text = "Subject";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 226);
            label4.Name = "label4";
            label4.Size = new Size(58, 25);
            label4.TabIndex = 2;
            label4.Text = "Exam";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 293);
            label5.Name = "label5";
            label5.Size = new Size(91, 25);
            label5.TabIndex = 2;
            label5.Text = "Paper No";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 350);
            label6.Name = "label6";
            label6.Size = new Size(65, 25);
            label6.TabIndex = 3;
            label6.Text = "Status";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(34, 420);
            label7.Name = "label7";
            label7.Size = new Size(87, 25);
            label7.TabIndex = 3;
            label7.Text = "Duration";
            // 
            // tbTestCode
            // 
            tbTestCode.Location = new Point(236, 85);
            tbTestCode.Name = "tbTestCode";
            tbTestCode.ReadOnly = true;
            tbTestCode.Size = new Size(369, 31);
            tbTestCode.TabIndex = 4;
            // 
            // cbSubject
            // 
            cbSubject.FormattingEnabled = true;
            cbSubject.Location = new Point(236, 150);
            cbSubject.Name = "cbSubject";
            cbSubject.Size = new Size(253, 33);
            cbSubject.TabIndex = 5;
            // 
            // cbExam
            // 
            cbExam.FormattingEnabled = true;
            cbExam.Location = new Point(236, 223);
            cbExam.Name = "cbExam";
            cbExam.Size = new Size(253, 33);
            cbExam.TabIndex = 5;
            // 
            // numPaperNo
            // 
            numPaperNo.Location = new Point(236, 293);
            numPaperNo.Name = "numPaperNo";
            numPaperNo.Size = new Size(180, 31);
            numPaperNo.TabIndex = 6;
            // 
            // rdOn
            // 
            rdOn.AutoSize = true;
            rdOn.Checked = true;
            rdOn.Location = new Point(236, 350);
            rdOn.Name = "rdOn";
            rdOn.Size = new Size(62, 29);
            rdOn.TabIndex = 7;
            rdOn.TabStop = true;
            rdOn.Text = "On";
            rdOn.UseVisualStyleBackColor = true;
            // 
            // rdOff
            // 
            rdOff.AutoSize = true;
            rdOff.Location = new Point(351, 350);
            rdOff.Name = "rdOff";
            rdOff.Size = new Size(65, 29);
            rdOff.TabIndex = 7;
            rdOff.Text = "Off";
            rdOff.UseVisualStyleBackColor = true;
            // 
            // numTimeTest
            // 
            numTimeTest.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numTimeTest.Location = new Point(236, 418);
            numTimeTest.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            numTimeTest.Minimum = new decimal(new int[] { 30, 0, 0, 0 });
            numTimeTest.Name = "numTimeTest";
            numTimeTest.Size = new Size(180, 31);
            numTimeTest.TabIndex = 6;
            numTimeTest.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(21, 530);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add New";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRefresh);
            groupBox1.Controls.Add(btnClose);
            groupBox1.Controls.Add(rdOff);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(rdOn);
            groupBox1.Controls.Add(Update);
            groupBox1.Controls.Add(tbTestCode);
            groupBox1.Controls.Add(cbSubject);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(numPaperNo);
            groupBox1.Controls.Add(numNumOfQuestion);
            groupBox1.Controls.Add(numTimeTest);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(cbExam);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(1183, 213);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(646, 615);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Test Details";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(332, 530);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(112, 34);
            btnRefresh.TabIndex = 9;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(489, 530);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 34);
            btnClose.TabIndex = 9;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // Update
            // 
            Update.Location = new Point(184, 530);
            Update.Name = "Update";
            Update.Size = new Size(112, 34);
            Update.TabIndex = 0;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = true;
            Update.Click += Update_Click;
            // 
            // numNumOfQuestion
            // 
            numNumOfQuestion.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            numNumOfQuestion.Location = new Point(236, 480);
            numNumOfQuestion.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            numNumOfQuestion.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numNumOfQuestion.Name = "numNumOfQuestion";
            numNumOfQuestion.Size = new Size(180, 31);
            numNumOfQuestion.TabIndex = 6;
            numNumOfQuestion.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(34, 486);
            label12.Name = "label12";
            label12.Size = new Size(186, 25);
            label12.TabIndex = 3;
            label12.Text = "Number of Question";
            // 
            // cbSubjects
            // 
            cbSubjects.FormattingEnabled = true;
            cbSubjects.Location = new Point(106, 80);
            cbSubjects.Name = "cbSubjects";
            cbSubjects.Size = new Size(245, 33);
            cbSubjects.TabIndex = 10;
            cbSubjects.SelectedIndexChanged += cbSubjects_SelectedIndexChanged;
            // 
            // cbExams
            // 
            cbExams.FormattingEnabled = true;
            cbExams.Location = new Point(106, 145);
            cbExams.Name = "cbExams";
            cbExams.Size = new Size(245, 33);
            cbExams.TabIndex = 10;
            cbExams.SelectedIndexChanged += cbExams_SelectedIndexChanged;
            // 
            // dtpFromDate
            // 
            dtpFromDate.Location = new Point(558, 83);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.Size = new Size(300, 31);
            dtpFromDate.TabIndex = 11;
            dtpFromDate.ValueChanged += dtpFromDate_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(30, 83);
            label8.Name = "label8";
            label8.Size = new Size(70, 25);
            label8.TabIndex = 12;
            label8.Text = "Subject";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(30, 153);
            label9.Name = "label9";
            label9.Size = new Size(54, 25);
            label9.TabIndex = 12;
            label9.Text = "Exam";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(480, 88);
            label10.Name = "label10";
            label10.Size = new Size(54, 25);
            label10.TabIndex = 13;
            label10.Text = "From";
            // 
            // dtpToDate
            // 
            dtpToDate.Location = new Point(558, 142);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.Size = new Size(300, 31);
            dtpToDate.TabIndex = 11;
            dtpToDate.ValueChanged += dtpToDate_ValueChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(480, 148);
            label11.Name = "label11";
            label11.Size = new Size(30, 25);
            label11.TabIndex = 13;
            label11.Text = "To";
            // 
            // frmTestManagement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1848, 840);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(dtpToDate);
            Controls.Add(dtpFromDate);
            Controls.Add(cbExams);
            Controls.Add(cbSubjects);
            Controls.Add(label1);
            Controls.Add(dgvTestList);
            Controls.Add(groupBox1);
            Name = "frmTestManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmTestManagement";
            FormClosed += frmTestManagement_FormClosed;
            Load += frmTestManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTestList).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPaperNo).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTimeTest).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numNumOfQuestion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTestList;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox tbTestCode;
        private ComboBox cbSubject;
        private ComboBox cbExam;
        private NumericUpDown numPaperNo;
        private RadioButton rdOn;
        private RadioButton rdOff;
        private NumericUpDown numTimeTest;
        private Button btnAdd;
        private GroupBox groupBox1;
        private Button Update;
        private Button btnClose;
        private ComboBox cbSubjects;
        private ComboBox cbExams;
        private DateTimePicker dtpFromDate;
        private Label label8;
        private Label label9;
        private Label label10;
        private DateTimePicker dtpToDate;
        private Label label11;
        private Button btnRefresh;
        private NumericUpDown numNumOfQuestion;
        private Label label12;
    }
}