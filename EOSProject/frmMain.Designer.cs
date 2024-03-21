namespace EOSProject {
    partial class frmMain {
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
            menuStrip1 = new MenuStrip();
            mnExam = new ToolStripMenuItem();
            mnTest = new ToolStripMenuItem();
            mnResult = new ToolStripMenuItem();
            label1 = new Label();
            lbHello = new Label();
            lbGuide = new Label();
            btnLogOut = new Button();
            tbTestCode = new TextBox();
            btnEnter = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnExam, mnTest, mnResult });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(756, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnExam
            // 
            mnExam.Name = "mnExam";
            mnExam.Size = new Size(158, 29);
            mnExam.Text = "Question Library";
            mnExam.Click += mnExam_Click;
            // 
            // mnTest
            // 
            mnTest.Name = "mnTest";
            mnTest.Size = new Size(116, 29);
            mnTest.Text = "Test Library";
            mnTest.Click += mnTest_Click;
            // 
            // mnResult
            // 
            mnResult.Name = "mnResult";
            mnResult.Size = new Size(75, 29);
            mnResult.Text = "Result";
            mnResult.Click += mnResult_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(212, 51);
            label1.Name = "label1";
            label1.Size = new Size(324, 47);
            label1.TabIndex = 1;
            label1.Text = "Exam Online System";
            // 
            // lbHello
            // 
            lbHello.AutoSize = true;
            lbHello.Location = new Point(24, 135);
            lbHello.Name = "lbHello";
            lbHello.Size = new Size(0, 25);
            lbHello.TabIndex = 2;
            // 
            // lbGuide
            // 
            lbGuide.AutoSize = true;
            lbGuide.Location = new Point(264, 185);
            lbGuide.Name = "lbGuide";
            lbGuide.Size = new Size(227, 25);
            lbGuide.TabIndex = 3;
            lbGuide.Text = "Please choose your option!";
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(611, 306);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(133, 43);
            btnLogOut.TabIndex = 4;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // tbTestCode
            // 
            tbTestCode.Location = new Point(194, 235);
            tbTestCode.Name = "tbTestCode";
            tbTestCode.Size = new Size(359, 31);
            tbTestCode.TabIndex = 5;
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(279, 306);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(176, 42);
            btnEnter.TabIndex = 6;
            btnEnter.Text = "Enter the exam";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(756, 361);
            Controls.Add(btnEnter);
            Controls.Add(tbTestCode);
            Controls.Add(btnLogOut);
            Controls.Add(lbGuide);
            Controls.Add(lbHello);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMain";
            FormClosed += frmMain_FormClosed;
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnExam;
        private ToolStripMenuItem mnResult;
        private Label label1;
        private Label lbHello;
        private Label lbGuide;
        private Button btnLogOut;
        private ToolStripMenuItem mnTest;
        private TextBox tbTestCode;
        private Button btnEnter;
    }
}