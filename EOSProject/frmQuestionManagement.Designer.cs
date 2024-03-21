namespace EOSProject {
    partial class frmQuestionManagement {
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
            dgvQuestion = new DataGridView();
            cbSubject = new ComboBox();
            cbExam = new ComboBox();
            textBox1 = new TextBox();
            dgvAnswer = new DataGridView();
            label1 = new Label();
            lbExam = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnClose = new Button();
            btnAddto = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvQuestion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAnswer).BeginInit();
            SuspendLayout();
            // 
            // dgvQuestion
            // 
            dgvQuestion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuestion.Location = new Point(58, 214);
            dgvQuestion.Name = "dgvQuestion";
            dgvQuestion.RowHeadersWidth = 62;
            dgvQuestion.RowTemplate.Height = 33;
            dgvQuestion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQuestion.Size = new Size(857, 436);
            dgvQuestion.TabIndex = 0;
            dgvQuestion.CellClick += dgvQuestion_CellClick;
            // 
            // cbSubject
            // 
            cbSubject.FormattingEnabled = true;
            cbSubject.Location = new Point(129, 70);
            cbSubject.Name = "cbSubject";
            cbSubject.Size = new Size(172, 33);
            cbSubject.TabIndex = 1;
            cbSubject.SelectedIndexChanged += cbSubject_SelectedIndexChanged;
            // 
            // cbExam
            // 
            cbExam.FormattingEnabled = true;
            cbExam.Location = new Point(410, 69);
            cbExam.Name = "cbExam";
            cbExam.Size = new Size(227, 33);
            cbExam.TabIndex = 1;
            cbExam.SelectedIndexChanged += cbExam_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(810, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(270, 31);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // dgvAnswer
            // 
            dgvAnswer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnswer.Location = new Point(952, 214);
            dgvAnswer.Name = "dgvAnswer";
            dgvAnswer.RowHeadersWidth = 62;
            dgvAnswer.RowTemplate.Height = 33;
            dgvAnswer.Size = new Size(740, 436);
            dgvAnswer.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 72);
            label1.Name = "label1";
            label1.Size = new Size(70, 25);
            label1.TabIndex = 4;
            label1.Text = "Subject";
            // 
            // lbExam
            // 
            lbExam.AutoSize = true;
            lbExam.Location = new Point(350, 72);
            lbExam.Name = "lbExam";
            lbExam.Size = new Size(54, 25);
            lbExam.TabIndex = 4;
            lbExam.Text = "Exam";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(740, 73);
            label3.Name = "label3";
            label3.Size = new Size(64, 25);
            label3.TabIndex = 4;
            label3.Text = "Search";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(647, 9);
            label4.Name = "label4";
            label4.Size = new Size(271, 47);
            label4.TabIndex = 4;
            label4.Text = "Question Library";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(58, 186);
            label5.Name = "label5";
            label5.Size = new Size(89, 25);
            label5.TabIndex = 4;
            label5.Text = "Question";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(952, 186);
            label6.Name = "label6";
            label6.Size = new Size(75, 25);
            label6.TabIndex = 4;
            label6.Text = "Answer";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(129, 132);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(218, 41);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add New Question";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(433, 132);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(101, 41);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(618, 132);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(101, 41);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnAddto
            // 
            btnAddto.Location = new Point(803, 132);
            btnAddto.Name = "btnAddto";
            btnAddto.Size = new Size(121, 41);
            btnAddto.TabIndex = 6;
            btnAddto.Text = "Add to?";
            btnAddto.UseVisualStyleBackColor = true;
            btnAddto.Click += btnAddto_Click;
            // 
            // frmQuestionManagement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1714, 662);
            Controls.Add(btnAddto);
            Controls.Add(btnClose);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lbExam);
            Controls.Add(label1);
            Controls.Add(dgvAnswer);
            Controls.Add(textBox1);
            Controls.Add(cbExam);
            Controls.Add(cbSubject);
            Controls.Add(dgvQuestion);
            Name = "frmQuestionManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QuestionManagement";
            FormClosed += frmQuestionManagement_FormClosed;
            Load += QuestionManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvQuestion).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAnswer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvQuestion;
        private ComboBox cbSubject;
        private ComboBox cbExam;
        private TextBox textBox1;
        private DataGridView dgvAnswer;
        private Label label1;
        private Label lbExam;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnClose;
        private Button btnAddto;
    }
}