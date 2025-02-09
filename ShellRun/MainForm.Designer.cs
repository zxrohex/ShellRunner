namespace ShellRunner
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
            components = new System.ComponentModel.Container();
            ApplicationMainStatusStrip = new StatusStrip();
            MainToolStripStatusLabel = new ToolStripStatusLabel();
            MainInfoToolStripStatusLabel = new ToolStripStatusLabel();
            ApplicationMainMenuStrip = new MenuStrip();
            ApplicationHeaderPanel = new Panel();
            RunOrKillButton = new Button();
            InfoStatusLabel = new Label();
            TitleStatusLabel = new Label();
            ProcessIconPictureBox = new PictureBox();
            SettingsFileGroupBox = new GroupBox();
            SelectFileButton = new Button();
            FileTextBox = new TextBox();
            InformationTabControl = new TabControl();
            ProcessInformationTabPage = new TabPage();
            ProcessMoreInfoLabel = new Label();
            ProcessDescriptionLabel = new Label();
            ProcessTitleLabel = new Label();
            ProcessIconNdPictureBox = new PictureBox();
            ProcessOutputTabPage = new TabPage();
            SendStdInputButton = new Button();
            StdInputTextBox = new TextBox();
            OutputLogRichTextBox = new RichTextBox();
            ExecutionSettingsTabControl = new TabControl();
            ExecutionSettingsTabPage = new TabPage();
            SettingsMainGroupBox = new GroupBox();
            SettingsCreationGroupBox = new GroupBox();
            RunAsCheckBox = new CheckBox();
            LoadUserProfileCheckBox = new CheckBox();
            CreateNoWindowCheckBox = new CheckBox();
            SettingsArgumentsGroupBox = new GroupBox();
            ArgsTextBox = new TextBox();
            SettingsExecutionTypeGroupBox = new GroupBox();
            ExecutionTypeComboBox = new ComboBox();
            ProcessInformationUpdateTimer = new System.Windows.Forms.Timer(components);
            ApplicationMainStatusStrip.SuspendLayout();
            ApplicationHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProcessIconPictureBox).BeginInit();
            SettingsFileGroupBox.SuspendLayout();
            InformationTabControl.SuspendLayout();
            ProcessInformationTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProcessIconNdPictureBox).BeginInit();
            ProcessOutputTabPage.SuspendLayout();
            ExecutionSettingsTabControl.SuspendLayout();
            ExecutionSettingsTabPage.SuspendLayout();
            SettingsMainGroupBox.SuspendLayout();
            SettingsCreationGroupBox.SuspendLayout();
            SettingsArgumentsGroupBox.SuspendLayout();
            SettingsExecutionTypeGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ApplicationMainStatusStrip
            // 
            ApplicationMainStatusStrip.Items.AddRange(new ToolStripItem[] { MainToolStripStatusLabel, MainInfoToolStripStatusLabel });
            ApplicationMainStatusStrip.Location = new Point(0, 541);
            ApplicationMainStatusStrip.Name = "ApplicationMainStatusStrip";
            ApplicationMainStatusStrip.Size = new Size(396, 22);
            ApplicationMainStatusStrip.TabIndex = 0;
            ApplicationMainStatusStrip.Text = "statusStrip1";
            // 
            // MainToolStripStatusLabel
            // 
            MainToolStripStatusLabel.Name = "MainToolStripStatusLabel";
            MainToolStripStatusLabel.Size = new Size(190, 17);
            MainToolStripStatusLabel.Spring = true;
            MainToolStripStatusLabel.Text = "Idling.";
            MainToolStripStatusLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MainInfoToolStripStatusLabel
            // 
            MainInfoToolStripStatusLabel.Name = "MainInfoToolStripStatusLabel";
            MainInfoToolStripStatusLabel.Size = new Size(190, 17);
            MainInfoToolStripStatusLabel.Spring = true;
            MainInfoToolStripStatusLabel.Text = "No process started yet.";
            MainInfoToolStripStatusLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ApplicationMainMenuStrip
            // 
            ApplicationMainMenuStrip.Location = new Point(0, 0);
            ApplicationMainMenuStrip.Name = "ApplicationMainMenuStrip";
            ApplicationMainMenuStrip.Size = new Size(396, 24);
            ApplicationMainMenuStrip.TabIndex = 1;
            ApplicationMainMenuStrip.Text = "menuStrip1";
            // 
            // ApplicationHeaderPanel
            // 
            ApplicationHeaderPanel.BackColor = Color.White;
            ApplicationHeaderPanel.BorderStyle = BorderStyle.Fixed3D;
            ApplicationHeaderPanel.Controls.Add(RunOrKillButton);
            ApplicationHeaderPanel.Controls.Add(InfoStatusLabel);
            ApplicationHeaderPanel.Controls.Add(TitleStatusLabel);
            ApplicationHeaderPanel.Controls.Add(ProcessIconPictureBox);
            ApplicationHeaderPanel.Dock = DockStyle.Top;
            ApplicationHeaderPanel.Location = new Point(0, 24);
            ApplicationHeaderPanel.Name = "ApplicationHeaderPanel";
            ApplicationHeaderPanel.Size = new Size(396, 84);
            ApplicationHeaderPanel.TabIndex = 2;
            // 
            // RunOrKillButton
            // 
            RunOrKillButton.Image = Properties.Resources.Run;
            RunOrKillButton.Location = new Point(353, 43);
            RunOrKillButton.Name = "RunOrKillButton";
            RunOrKillButton.Size = new Size(30, 23);
            RunOrKillButton.TabIndex = 3;
            RunOrKillButton.UseVisualStyleBackColor = true;
            RunOrKillButton.Click += RunOrKillButton_Click;
            // 
            // InfoStatusLabel
            // 
            InfoStatusLabel.Location = new Point(47, 25);
            InfoStatusLabel.Name = "InfoStatusLabel";
            InfoStatusLabel.Size = new Size(336, 15);
            InfoStatusLabel.TabIndex = 2;
            InfoStatusLabel.Text = "%SysOrProcInfo%";
            // 
            // TitleStatusLabel
            // 
            TitleStatusLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            TitleStatusLabel.Location = new Point(47, 8);
            TitleStatusLabel.Name = "TitleStatusLabel";
            TitleStatusLabel.Size = new Size(336, 16);
            TitleStatusLabel.TabIndex = 1;
            TitleStatusLabel.Text = "ShellRunner";
            // 
            // ProcessIconPictureBox
            // 
            ProcessIconPictureBox.Location = new Point(9, 8);
            ProcessIconPictureBox.Name = "ProcessIconPictureBox";
            ProcessIconPictureBox.Size = new Size(32, 32);
            ProcessIconPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            ProcessIconPictureBox.TabIndex = 0;
            ProcessIconPictureBox.TabStop = false;
            // 
            // SettingsFileGroupBox
            // 
            SettingsFileGroupBox.Controls.Add(SelectFileButton);
            SettingsFileGroupBox.Controls.Add(FileTextBox);
            SettingsFileGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            SettingsFileGroupBox.Location = new Point(11, 113);
            SettingsFileGroupBox.Name = "SettingsFileGroupBox";
            SettingsFileGroupBox.Size = new Size(374, 60);
            SettingsFileGroupBox.TabIndex = 3;
            SettingsFileGroupBox.TabStop = false;
            SettingsFileGroupBox.Text = "File";
            // 
            // SelectFileButton
            // 
            SelectFileButton.Location = new Point(288, 22);
            SelectFileButton.Name = "SelectFileButton";
            SelectFileButton.Size = new Size(75, 23);
            SelectFileButton.TabIndex = 1;
            SelectFileButton.Text = "Select";
            SelectFileButton.UseVisualStyleBackColor = true;
            SelectFileButton.Click += SelectFileButton_Click;
            // 
            // FileTextBox
            // 
            FileTextBox.Location = new Point(11, 22);
            FileTextBox.Name = "FileTextBox";
            FileTextBox.Size = new Size(271, 23);
            FileTextBox.TabIndex = 0;
            // 
            // InformationTabControl
            // 
            InformationTabControl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            InformationTabControl.Controls.Add(ProcessInformationTabPage);
            InformationTabControl.Controls.Add(ProcessOutputTabPage);
            InformationTabControl.Location = new Point(11, 410);
            InformationTabControl.Name = "InformationTabControl";
            InformationTabControl.SelectedIndex = 0;
            InformationTabControl.Size = new Size(374, 122);
            InformationTabControl.TabIndex = 4;
            // 
            // ProcessInformationTabPage
            // 
            ProcessInformationTabPage.Controls.Add(ProcessMoreInfoLabel);
            ProcessInformationTabPage.Controls.Add(ProcessDescriptionLabel);
            ProcessInformationTabPage.Controls.Add(ProcessTitleLabel);
            ProcessInformationTabPage.Controls.Add(ProcessIconNdPictureBox);
            ProcessInformationTabPage.Location = new Point(4, 24);
            ProcessInformationTabPage.Name = "ProcessInformationTabPage";
            ProcessInformationTabPage.Padding = new Padding(3);
            ProcessInformationTabPage.Size = new Size(366, 94);
            ProcessInformationTabPage.TabIndex = 0;
            ProcessInformationTabPage.Text = "Process Information";
            ProcessInformationTabPage.UseVisualStyleBackColor = true;
            // 
            // ProcessMoreInfoLabel
            // 
            ProcessMoreInfoLabel.Location = new Point(7, 46);
            ProcessMoreInfoLabel.Name = "ProcessMoreInfoLabel";
            ProcessMoreInfoLabel.Size = new Size(353, 40);
            ProcessMoreInfoLabel.TabIndex = 3;
            ProcessMoreInfoLabel.Text = "Some more information will display here once you start a process.";
            // 
            // ProcessDescriptionLabel
            // 
            ProcessDescriptionLabel.Location = new Point(45, 21);
            ProcessDescriptionLabel.Name = "ProcessDescriptionLabel";
            ProcessDescriptionLabel.Size = new Size(314, 17);
            ProcessDescriptionLabel.TabIndex = 2;
            ProcessDescriptionLabel.Text = "Start a process.";
            // 
            // ProcessTitleLabel
            // 
            ProcessTitleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ProcessTitleLabel.Location = new Point(45, 6);
            ProcessTitleLabel.Name = "ProcessTitleLabel";
            ProcessTitleLabel.Size = new Size(314, 16);
            ProcessTitleLabel.TabIndex = 1;
            ProcessTitleLabel.Text = "No process started yet.";
            // 
            // ProcessIconNdPictureBox
            // 
            ProcessIconNdPictureBox.BorderStyle = BorderStyle.Fixed3D;
            ProcessIconNdPictureBox.Location = new Point(7, 6);
            ProcessIconNdPictureBox.Name = "ProcessIconNdPictureBox";
            ProcessIconNdPictureBox.Size = new Size(32, 32);
            ProcessIconNdPictureBox.TabIndex = 0;
            ProcessIconNdPictureBox.TabStop = false;
            // 
            // ProcessOutputTabPage
            // 
            ProcessOutputTabPage.Controls.Add(SendStdInputButton);
            ProcessOutputTabPage.Controls.Add(StdInputTextBox);
            ProcessOutputTabPage.Controls.Add(OutputLogRichTextBox);
            ProcessOutputTabPage.Location = new Point(4, 24);
            ProcessOutputTabPage.Name = "ProcessOutputTabPage";
            ProcessOutputTabPage.Padding = new Padding(3);
            ProcessOutputTabPage.Size = new Size(366, 94);
            ProcessOutputTabPage.TabIndex = 1;
            ProcessOutputTabPage.Text = "Process Output";
            ProcessOutputTabPage.UseVisualStyleBackColor = true;
            // 
            // SendStdInputButton
            // 
            SendStdInputButton.Enabled = false;
            SendStdInputButton.Location = new Point(284, 65);
            SendStdInputButton.Name = "SendStdInputButton";
            SendStdInputButton.Size = new Size(75, 23);
            SendStdInputButton.TabIndex = 2;
            SendStdInputButton.Text = "Send";
            SendStdInputButton.UseVisualStyleBackColor = true;
            // 
            // StdInputTextBox
            // 
            StdInputTextBox.Enabled = false;
            StdInputTextBox.Location = new Point(7, 64);
            StdInputTextBox.Name = "StdInputTextBox";
            StdInputTextBox.Size = new Size(271, 23);
            StdInputTextBox.TabIndex = 1;
            // 
            // OutputLogRichTextBox
            // 
            OutputLogRichTextBox.Location = new Point(7, 6);
            OutputLogRichTextBox.Name = "OutputLogRichTextBox";
            OutputLogRichTextBox.ReadOnly = true;
            OutputLogRichTextBox.Size = new Size(352, 54);
            OutputLogRichTextBox.TabIndex = 0;
            OutputLogRichTextBox.Text = "";
            // 
            // ExecutionSettingsTabControl
            // 
            ExecutionSettingsTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ExecutionSettingsTabControl.Controls.Add(ExecutionSettingsTabPage);
            ExecutionSettingsTabControl.Location = new Point(11, 179);
            ExecutionSettingsTabControl.Name = "ExecutionSettingsTabControl";
            ExecutionSettingsTabControl.SelectedIndex = 0;
            ExecutionSettingsTabControl.Size = new Size(374, 225);
            ExecutionSettingsTabControl.TabIndex = 5;
            // 
            // ExecutionSettingsTabPage
            // 
            ExecutionSettingsTabPage.Controls.Add(SettingsMainGroupBox);
            ExecutionSettingsTabPage.Controls.Add(SettingsExecutionTypeGroupBox);
            ExecutionSettingsTabPage.Location = new Point(4, 24);
            ExecutionSettingsTabPage.Name = "ExecutionSettingsTabPage";
            ExecutionSettingsTabPage.Padding = new Padding(3);
            ExecutionSettingsTabPage.Size = new Size(366, 197);
            ExecutionSettingsTabPage.TabIndex = 0;
            ExecutionSettingsTabPage.Text = "Settings";
            ExecutionSettingsTabPage.UseVisualStyleBackColor = true;
            // 
            // SettingsMainGroupBox
            // 
            SettingsMainGroupBox.Controls.Add(SettingsCreationGroupBox);
            SettingsMainGroupBox.Controls.Add(SettingsArgumentsGroupBox);
            SettingsMainGroupBox.Location = new Point(7, 62);
            SettingsMainGroupBox.Name = "SettingsMainGroupBox";
            SettingsMainGroupBox.Size = new Size(352, 127);
            SettingsMainGroupBox.TabIndex = 1;
            SettingsMainGroupBox.TabStop = false;
            SettingsMainGroupBox.Text = "Settings";
            // 
            // SettingsCreationGroupBox
            // 
            SettingsCreationGroupBox.Controls.Add(RunAsCheckBox);
            SettingsCreationGroupBox.Controls.Add(LoadUserProfileCheckBox);
            SettingsCreationGroupBox.Controls.Add(CreateNoWindowCheckBox);
            SettingsCreationGroupBox.Location = new Point(8, 74);
            SettingsCreationGroupBox.Name = "SettingsCreationGroupBox";
            SettingsCreationGroupBox.Size = new Size(336, 47);
            SettingsCreationGroupBox.TabIndex = 1;
            SettingsCreationGroupBox.TabStop = false;
            SettingsCreationGroupBox.Text = "Creation Settings";
            // 
            // RunAsCheckBox
            // 
            RunAsCheckBox.AutoSize = true;
            RunAsCheckBox.Location = new Point(263, 19);
            RunAsCheckBox.Name = "RunAsCheckBox";
            RunAsCheckBox.Size = new Size(63, 19);
            RunAsCheckBox.TabIndex = 2;
            RunAsCheckBox.Text = "Run As";
            RunAsCheckBox.UseVisualStyleBackColor = true;
            // 
            // LoadUserProfileCheckBox
            // 
            LoadUserProfileCheckBox.AutoSize = true;
            LoadUserProfileCheckBox.Location = new Point(142, 19);
            LoadUserProfileCheckBox.Name = "LoadUserProfileCheckBox";
            LoadUserProfileCheckBox.Size = new Size(115, 19);
            LoadUserProfileCheckBox.TabIndex = 1;
            LoadUserProfileCheckBox.Text = "Load User Profile";
            LoadUserProfileCheckBox.UseVisualStyleBackColor = true;
            // 
            // CreateNoWindowCheckBox
            // 
            CreateNoWindowCheckBox.AutoSize = true;
            CreateNoWindowCheckBox.Location = new Point(10, 19);
            CreateNoWindowCheckBox.Name = "CreateNoWindowCheckBox";
            CreateNoWindowCheckBox.Size = new Size(126, 19);
            CreateNoWindowCheckBox.TabIndex = 0;
            CreateNoWindowCheckBox.Text = "Create No Window";
            CreateNoWindowCheckBox.UseVisualStyleBackColor = true;
            // 
            // SettingsArgumentsGroupBox
            // 
            SettingsArgumentsGroupBox.Controls.Add(ArgsTextBox);
            SettingsArgumentsGroupBox.Location = new Point(8, 16);
            SettingsArgumentsGroupBox.Name = "SettingsArgumentsGroupBox";
            SettingsArgumentsGroupBox.Padding = new Padding(9, 4, 9, 3);
            SettingsArgumentsGroupBox.Size = new Size(336, 52);
            SettingsArgumentsGroupBox.TabIndex = 0;
            SettingsArgumentsGroupBox.TabStop = false;
            SettingsArgumentsGroupBox.Text = "Arguments";
            // 
            // ArgsTextBox
            // 
            ArgsTextBox.Dock = DockStyle.Fill;
            ArgsTextBox.Location = new Point(9, 20);
            ArgsTextBox.Name = "ArgsTextBox";
            ArgsTextBox.Size = new Size(318, 23);
            ArgsTextBox.TabIndex = 0;
            // 
            // SettingsExecutionTypeGroupBox
            // 
            SettingsExecutionTypeGroupBox.Controls.Add(ExecutionTypeComboBox);
            SettingsExecutionTypeGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            SettingsExecutionTypeGroupBox.Location = new Point(7, 6);
            SettingsExecutionTypeGroupBox.Name = "SettingsExecutionTypeGroupBox";
            SettingsExecutionTypeGroupBox.Padding = new Padding(8, 5, 8, 3);
            SettingsExecutionTypeGroupBox.Size = new Size(352, 52);
            SettingsExecutionTypeGroupBox.TabIndex = 0;
            SettingsExecutionTypeGroupBox.TabStop = false;
            SettingsExecutionTypeGroupBox.Text = "Execution Type";
            // 
            // ExecutionTypeComboBox
            // 
            ExecutionTypeComboBox.Dock = DockStyle.Fill;
            ExecutionTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ExecutionTypeComboBox.FormattingEnabled = true;
            ExecutionTypeComboBox.Items.AddRange(new object[] { "NoShellExecute", "ShellExecute", "CMD /k" });
            ExecutionTypeComboBox.Location = new Point(8, 21);
            ExecutionTypeComboBox.Name = "ExecutionTypeComboBox";
            ExecutionTypeComboBox.Size = new Size(336, 23);
            ExecutionTypeComboBox.TabIndex = 0;
            ExecutionTypeComboBox.SelectedIndexChanged += ExecutionTypeComboBox_SelectedIndexChanged;
            // 
            // ProcessInformationUpdateTimer
            // 
            ProcessInformationUpdateTimer.Interval = 1000;
            ProcessInformationUpdateTimer.Tick += ProcessInformationUpdateTimer_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 563);
            Controls.Add(ExecutionSettingsTabControl);
            Controls.Add(InformationTabControl);
            Controls.Add(SettingsFileGroupBox);
            Controls.Add(ApplicationHeaderPanel);
            Controls.Add(ApplicationMainStatusStrip);
            Controls.Add(ApplicationMainMenuStrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MainMenuStrip = ApplicationMainMenuStrip;
            MaximizeBox = false;
            Name = "MainForm";
            ShowIcon = false;
            Text = "ShellRunner";
            Load += MainForm_Load;
            ApplicationMainStatusStrip.ResumeLayout(false);
            ApplicationMainStatusStrip.PerformLayout();
            ApplicationHeaderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ProcessIconPictureBox).EndInit();
            SettingsFileGroupBox.ResumeLayout(false);
            SettingsFileGroupBox.PerformLayout();
            InformationTabControl.ResumeLayout(false);
            ProcessInformationTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ProcessIconNdPictureBox).EndInit();
            ProcessOutputTabPage.ResumeLayout(false);
            ProcessOutputTabPage.PerformLayout();
            ExecutionSettingsTabControl.ResumeLayout(false);
            ExecutionSettingsTabPage.ResumeLayout(false);
            SettingsMainGroupBox.ResumeLayout(false);
            SettingsCreationGroupBox.ResumeLayout(false);
            SettingsCreationGroupBox.PerformLayout();
            SettingsArgumentsGroupBox.ResumeLayout(false);
            SettingsArgumentsGroupBox.PerformLayout();
            SettingsExecutionTypeGroupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private void SelectFileBtn_Click1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private StatusStrip ApplicationMainStatusStrip;
        private MenuStrip ApplicationMainMenuStrip;
        private Panel ApplicationHeaderPanel;
        private Label InfoStatusLabel;
        private Label TitleStatusLabel;
        private PictureBox ProcessIconPictureBox;
        private GroupBox SettingsFileGroupBox;
        private TextBox FileTextBox;
        private Button SelectFileButton;
        private ToolStripStatusLabel MainToolStripStatusLabel;
        private ToolStripStatusLabel MainInfoToolStripStatusLabel;
        private TabControl InformationTabControl;
        private TabPage ProcessInformationTabPage;
        private TabPage ProcessOutputTabPage;
        private TabControl ExecutionSettingsTabControl;
        private TabPage ExecutionSettingsTabPage;
        private PictureBox ProcessIconNdPictureBox;
        private Label ProcessDescriptionLabel;
        private Label ProcessTitleLabel;
        private Label ProcessMoreInfoLabel;
        private System.Windows.Forms.Timer ProcessInformationUpdateTimer;
        private GroupBox SettingsExecutionTypeGroupBox;
        private ComboBox ExecutionTypeComboBox;
        private GroupBox SettingsMainGroupBox;
        private GroupBox SettingsArgumentsGroupBox;
        private TextBox ArgsTextBox;
        private GroupBox SettingsCreationGroupBox;
        private CheckBox LoadUserProfileCheckBox;
        private CheckBox CreateNoWindowCheckBox;
        private CheckBox RunAsCheckBox;
        private Button RunOrKillButton;
        private Button SendStdInputButton;
        private TextBox StdInputTextBox;
        private RichTextBox OutputLogRichTextBox;
    }
}
