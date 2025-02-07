namespace ShellRunner
{
    partial class OutputConsole
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            OutputRichTextBox = new RichTextBox();
            WriteInputTextBox = new TextBox();
            WriteInputBtn = new Button();
            SuspendLayout();
            // 
            // OutputRichTextBox
            // 
            OutputRichTextBox.Dock = DockStyle.Top;
            OutputRichTextBox.Location = new Point(0, 0);
            OutputRichTextBox.Name = "OutputRichTextBox";
            OutputRichTextBox.ReadOnly = true;
            OutputRichTextBox.Size = new Size(408, 282);
            OutputRichTextBox.TabIndex = 0;
            OutputRichTextBox.Text = "";
            // 
            // WriteInputTextBox
            // 
            WriteInputTextBox.Location = new Point(9, 287);
            WriteInputTextBox.Name = "WriteInputTextBox";
            WriteInputTextBox.Size = new Size(310, 23);
            WriteInputTextBox.TabIndex = 1;
            // 
            // WriteInputBtn
            // 
            WriteInputBtn.Location = new Point(325, 287);
            WriteInputBtn.Name = "WriteInputBtn";
            WriteInputBtn.Size = new Size(75, 23);
            WriteInputBtn.TabIndex = 2;
            WriteInputBtn.Text = "Send";
            WriteInputBtn.UseVisualStyleBackColor = true;
            WriteInputBtn.Click += WriteInputBtn_Click;
            // 
            // OutputConsole
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 316);
            Controls.Add(WriteInputBtn);
            Controls.Add(WriteInputTextBox);
            Controls.Add(OutputRichTextBox);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "OutputConsole";
            Text = "OutputConsole";
            FormClosing += OutputConsole_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox OutputRichTextBox;
        private TextBox WriteInputTextBox;
        private Button WriteInputBtn;
    }
}