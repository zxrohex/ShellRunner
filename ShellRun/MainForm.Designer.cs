namespace ShellRun
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            FileGroupBox = new GroupBox();
            SelectFileBtn = new Button();
            FileTextBox = new TextBox();
            groupBox1 = new GroupBox();
            ExecutionTypeComboBox = new ComboBox();
            groupBox2 = new GroupBox();
            ArgsTextBox = new TextBox();
            ExecuteBtn = new Button();
            groupBox3 = new GroupBox();
            RedirectAllOutputCheckBox = new CheckBox();
            CreateNoWindowCheckBox = new CheckBox();
            panel2 = new Panel();
            ApplicationMainMenuStrip = new MenuStrip();
            label1 = new Label();
            label2 = new Label();
            SystemInformationLabel = new Label();
            shellRunnerToolStripMenuItem = new ToolStripMenuItem();
            überToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            FileGroupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            panel2.SuspendLayout();
            ApplicationMainMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(FileGroupBox);
            panel1.Location = new Point(12, 109);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 78);
            panel1.TabIndex = 0;
            // 
            // FileGroupBox
            // 
            FileGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FileGroupBox.Controls.Add(SelectFileBtn);
            FileGroupBox.Controls.Add(FileTextBox);
            FileGroupBox.Location = new Point(12, 10);
            FileGroupBox.Name = "FileGroupBox";
            FileGroupBox.Size = new Size(374, 53);
            FileGroupBox.TabIndex = 1;
            FileGroupBox.TabStop = false;
            FileGroupBox.Text = "File";
            // 
            // SelectFileBtn
            // 
            SelectFileBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SelectFileBtn.Location = new Point(302, 19);
            SelectFileBtn.Name = "SelectFileBtn";
            SelectFileBtn.Size = new Size(66, 23);
            SelectFileBtn.TabIndex = 1;
            SelectFileBtn.Text = "Select";
            SelectFileBtn.UseVisualStyleBackColor = true;
            SelectFileBtn.Click += SelectFileBtn_Click;
            // 
            // FileTextBox
            // 
            FileTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            FileTextBox.Location = new Point(11, 19);
            FileTextBox.Name = "FileTextBox";
            FileTextBox.Size = new Size(285, 23);
            FileTextBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(ExecutionTypeComboBox);
            groupBox1.Location = new Point(12, 203);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 50);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Execution-Typ";
            // 
            // ExecutionTypeComboBox
            // 
            ExecutionTypeComboBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ExecutionTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ExecutionTypeComboBox.FormattingEnabled = true;
            ExecutionTypeComboBox.Items.AddRange(new object[] { "NoShellExecute", "ShellExecute", "CMD /k" });
            ExecutionTypeComboBox.Location = new Point(8, 19);
            ExecutionTypeComboBox.Name = "ExecutionTypeComboBox";
            ExecutionTypeComboBox.Size = new Size(384, 23);
            ExecutionTypeComboBox.TabIndex = 0;
            ExecutionTypeComboBox.SelectedIndexChanged += ExecutionTypeComboBox_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(ArgsTextBox);
            groupBox2.Location = new Point(12, 259);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(400, 50);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Argumente";
            // 
            // ArgsTextBox
            // 
            ArgsTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ArgsTextBox.Location = new Point(8, 19);
            ArgsTextBox.Name = "ArgsTextBox";
            ArgsTextBox.Size = new Size(384, 23);
            ArgsTextBox.TabIndex = 0;
            // 
            // ExecuteBtn
            // 
            ExecuteBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ExecuteBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ExecuteBtn.Location = new Point(320, 395);
            ExecuteBtn.Name = "ExecuteBtn";
            ExecuteBtn.Size = new Size(92, 23);
            ExecuteBtn.TabIndex = 3;
            ExecuteBtn.Text = "Execute";
            ExecuteBtn.UseVisualStyleBackColor = true;
            ExecuteBtn.Click += ExecuteBtn_Click;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(RedirectAllOutputCheckBox);
            groupBox3.Controls.Add(CreateNoWindowCheckBox);
            groupBox3.Location = new Point(12, 315);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(400, 71);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Andere Optionen";
            // 
            // RedirectAllOutputCheckBox
            // 
            RedirectAllOutputCheckBox.AutoSize = true;
            RedirectAllOutputCheckBox.Location = new Point(9, 43);
            RedirectAllOutputCheckBox.Name = "RedirectAllOutputCheckBox";
            RedirectAllOutputCheckBox.Size = new Size(127, 19);
            RedirectAllOutputCheckBox.TabIndex = 1;
            RedirectAllOutputCheckBox.Text = "Redirect All Output";
            RedirectAllOutputCheckBox.UseVisualStyleBackColor = true;
            // 
            // CreateNoWindowCheckBox
            // 
            CreateNoWindowCheckBox.AutoSize = true;
            CreateNoWindowCheckBox.Location = new Point(9, 22);
            CreateNoWindowCheckBox.Name = "CreateNoWindowCheckBox";
            CreateNoWindowCheckBox.Size = new Size(126, 19);
            CreateNoWindowCheckBox.TabIndex = 0;
            CreateNoWindowCheckBox.Text = "Create No Window";
            CreateNoWindowCheckBox.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(SystemInformationLabel);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(424, 76);
            panel2.TabIndex = 5;
            // 
            // ApplicationMainMenuStrip
            // 
            ApplicationMainMenuStrip.Items.AddRange(new ToolStripItem[] { shellRunnerToolStripMenuItem });
            ApplicationMainMenuStrip.Location = new Point(0, 0);
            ApplicationMainMenuStrip.Name = "ApplicationMainMenuStrip";
            ApplicationMainMenuStrip.Size = new Size(424, 24);
            ApplicationMainMenuStrip.TabIndex = 6;
            ApplicationMainMenuStrip.Text = "menuStrip1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 0;
            label1.Text = "ShellRunner";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 25);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 1;
            label2.Text = "Dateien ausführen";
            // 
            // SystemInformationLabel
            // 
            SystemInformationLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SystemInformationLabel.AutoEllipsis = true;
            SystemInformationLabel.Location = new Point(12, 51);
            SystemInformationLabel.Name = "SystemInformationLabel";
            SystemInformationLabel.Size = new Size(400, 16);
            SystemInformationLabel.TabIndex = 2;
            SystemInformationLabel.Text = "label3";
            // 
            // shellRunnerToolStripMenuItem
            // 
            shellRunnerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { überToolStripMenuItem });
            shellRunnerToolStripMenuItem.Name = "shellRunnerToolStripMenuItem";
            shellRunnerToolStripMenuItem.Size = new Size(82, 20);
            shellRunnerToolStripMenuItem.Text = "ShellRunner";
            // 
            // überToolStripMenuItem
            // 
            überToolStripMenuItem.Name = "überToolStripMenuItem";
            überToolStripMenuItem.Size = new Size(180, 22);
            überToolStripMenuItem.Text = "About";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 430);
            Controls.Add(panel2);
            Controls.Add(groupBox3);
            Controls.Add(ExecuteBtn);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(ApplicationMainMenuStrip);
            MainMenuStrip = ApplicationMainMenuStrip;
            Name = "MainForm";
            Text = "ShellRunner";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            FileGroupBox.ResumeLayout(false);
            FileGroupBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ApplicationMainMenuStrip.ResumeLayout(false);
            ApplicationMainMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void SelectFileBtn_Click1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panel1;
        private GroupBox FileGroupBox;
        private Button SelectFileBtn;
        private TextBox FileTextBox;
        private GroupBox groupBox1;
        private ComboBox ExecutionTypeComboBox;
        private GroupBox groupBox2;
        private TextBox ArgsTextBox;
        private Button ExecuteBtn;
        private GroupBox groupBox3;
        private CheckBox CreateNoWindowCheckBox;
        private CheckBox RedirectAllOutputCheckBox;
        private Panel panel2;
        private MenuStrip ApplicationMainMenuStrip;
        private Label label1;
        private Label SystemInformationLabel;
        private Label label2;
        private ToolStripMenuItem shellRunnerToolStripMenuItem;
        private ToolStripMenuItem überToolStripMenuItem;
    }
}
