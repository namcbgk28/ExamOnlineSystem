namespace EOSProject {
    partial class frmResultManagement {
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
            lbSort = new Label();
            cbSubject = new ComboBox();
            dgvResult = new DataGridView();
            btnSort = new Button();
            btnClose = new Button();
            btnView = new Button();
            cbClass = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvResult).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(497, 9);
            label1.Name = "label1";
            label1.Size = new Size(257, 47);
            label1.TabIndex = 0;
            label1.Text = "Result for exam";
            // 
            // lbSort
            // 
            lbSort.AutoSize = true;
            lbSort.Location = new Point(86, 104);
            lbSort.Name = "lbSort";
            lbSort.Size = new Size(45, 25);
            lbSort.TabIndex = 1;
            lbSort.Text = "Sort";
            // 
            // cbSubject
            // 
            cbSubject.FormattingEnabled = true;
            cbSubject.Location = new Point(337, 101);
            cbSubject.Name = "cbSubject";
            cbSubject.Size = new Size(219, 33);
            cbSubject.TabIndex = 3;
            cbSubject.SelectedIndexChanged += cbSubject_SelectedIndexChanged;
            // 
            // dgvResult
            // 
            dgvResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResult.Location = new Point(54, 176);
            dgvResult.Name = "dgvResult";
            dgvResult.RowHeadersWidth = 62;
            dgvResult.RowTemplate.Height = 33;
            dgvResult.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResult.Size = new Size(1225, 442);
            dgvResult.TabIndex = 4;
            dgvResult.CellClick += dgvResult_CellClick;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(137, 99);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(112, 34);
            btnSort.TabIndex = 5;
            btnSort.Text = "Score ASC";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(788, 101);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 34);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnView
            // 
            btnView.Location = new Point(615, 101);
            btnView.Name = "btnView";
            btnView.Size = new Size(112, 34);
            btnView.TabIndex = 6;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // cbClass
            // 
            cbClass.FormattingEnabled = true;
            cbClass.Location = new Point(987, 101);
            cbClass.Name = "cbClass";
            cbClass.Size = new Size(219, 33);
            cbClass.TabIndex = 3;
            cbClass.SelectedIndexChanged += cbClass_SelectedIndexChanged;
            // 
            // frmResultManagement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1354, 630);
            Controls.Add(btnView);
            Controls.Add(btnClose);
            Controls.Add(btnSort);
            Controls.Add(dgvResult);
            Controls.Add(cbClass);
            Controls.Add(cbSubject);
            Controls.Add(lbSort);
            Controls.Add(label1);
            Name = "frmResultManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Result Management";
            FormClosed += frmResultManagement_FormClosed;
            Load += frmResultManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbSort;
        private ComboBox cbSubject;
        private DataGridView dgvResult;
        private Button btnSort;
        private Button btnClose;
        private Button btnView;
        private ComboBox cbClass;
    }
}