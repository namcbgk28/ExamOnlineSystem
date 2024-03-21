namespace EOSProject {
    partial class frmAddTo {
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
            cbExam = new ComboBox();
            lbExam = new Label();
            label3 = new Label();
            btnAdd = new Button();
            lbSubject = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(182, 28);
            label1.Name = "label1";
            label1.Size = new Size(255, 25);
            label1.TabIndex = 0;
            label1.Text = "Choose the exam and subject !";
            // 
            // cbExam
            // 
            cbExam.DropDownStyle = ComboBoxStyle.DropDownList;
            cbExam.FormattingEnabled = true;
            cbExam.Location = new Point(182, 92);
            cbExam.Name = "cbExam";
            cbExam.Size = new Size(264, 33);
            cbExam.TabIndex = 1;
            // 
            // lbExam
            // 
            lbExam.AutoSize = true;
            lbExam.Location = new Point(35, 92);
            lbExam.Name = "lbExam";
            lbExam.Size = new Size(54, 25);
            lbExam.TabIndex = 3;
            lbExam.Text = "Exam";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 177);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 3;
            label3.Text = "Subject";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(519, 198);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 41);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lbSubject
            // 
            lbSubject.AutoSize = true;
            lbSubject.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbSubject.Location = new Point(182, 177);
            lbSubject.Name = "lbSubject";
            lbSubject.Size = new Size(75, 25);
            lbSubject.TabIndex = 5;
            lbSubject.Text = "Subject";
            // 
            // frmAddTo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 251);
            Controls.Add(lbSubject);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(lbExam);
            Controls.Add(cbExam);
            Controls.Add(label1);
            Name = "frmAddTo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAddTo";
            Load += frmAddTo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbExam;
        private Label lbExam;
        private Label label3;
        private Button btnAdd;
        private Label lbSubject;
    }
}