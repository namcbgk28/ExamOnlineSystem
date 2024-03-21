namespace EOSProject {
    partial class frmResultDetail {
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
            dgvDetail = new DataGridView();
            label1 = new Label();
            btnClose = new Button();
            tbSearch = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDetail).BeginInit();
            SuspendLayout();
            // 
            // dgvDetail
            // 
            dgvDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetail.Location = new Point(30, 128);
            dgvDetail.Name = "dgvDetail";
            dgvDetail.RowHeadersWidth = 62;
            dgvDetail.RowTemplate.Height = 33;
            dgvDetail.Size = new Size(968, 367);
            dgvDetail.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(408, 26);
            label1.Name = "label1";
            label1.Size = new Size(210, 47);
            label1.TabIndex = 1;
            label1.Text = "Result Detail";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(886, 75);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 34);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(117, 75);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(245, 31);
            tbSearch.TabIndex = 3;
            tbSearch.TextChanged += tbSearch_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 81);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 4;
            label2.Text = "Search";
            // 
            // frmResultDetail
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 519);
            Controls.Add(label2);
            Controls.Add(tbSearch);
            Controls.Add(btnClose);
            Controls.Add(label1);
            Controls.Add(dgvDetail);
            Name = "frmResultDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmResultDetail";
            Load += frmResultDetail_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDetail;
        private Label label1;
        private Button btnClose;
        private TextBox tbSearch;
        private Label label2;
    }
}