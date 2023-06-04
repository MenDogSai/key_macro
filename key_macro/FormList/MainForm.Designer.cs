namespace key_macro
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.statusButton = new System.Windows.Forms.Button();
            this.configButton = new System.Windows.Forms.Button();
            this.debugButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.macroListBox = new System.Windows.Forms.ListBox();
            this.pathButton = new System.Windows.Forms.Button();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.recordButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.stopRadioButton = new System.Windows.Forms.RadioButton();
            this.runRadioButton = new System.Windows.Forms.RadioButton();
            this.iconTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // statusButton
            // 
            this.statusButton.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.statusButton.Location = new System.Drawing.Point(87, 353);
            this.statusButton.Name = "statusButton";
            this.statusButton.Size = new System.Drawing.Size(63, 23);
            this.statusButton.TabIndex = 1;
            this.statusButton.Text = "입력상태";
            this.statusButton.UseVisualStyleBackColor = true;
            this.statusButton.Click += new System.EventHandler(this.StatusButtonClick);
            // 
            // configButton
            // 
            this.configButton.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.configButton.Location = new System.Drawing.Point(9, 353);
            this.configButton.Name = "configButton";
            this.configButton.Size = new System.Drawing.Size(63, 23);
            this.configButton.TabIndex = 2;
            this.configButton.Text = "설정";
            this.configButton.UseVisualStyleBackColor = true;
            // 
            // debugButton
            // 
            this.debugButton.Enabled = false;
            this.debugButton.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.debugButton.Location = new System.Drawing.Point(165, 353);
            this.debugButton.Name = "debugButton";
            this.debugButton.Size = new System.Drawing.Size(63, 23);
            this.debugButton.TabIndex = 3;
            this.debugButton.Text = "실행상태";
            this.debugButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.exitButton.Location = new System.Drawing.Point(244, 353);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(63, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "종료";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButtonClick);
            // 
            // macroListBox
            // 
            this.macroListBox.FormattingEnabled = true;
            this.macroListBox.ItemHeight = 12;
            this.macroListBox.Location = new System.Drawing.Point(9, 105);
            this.macroListBox.Name = "macroListBox";
            this.macroListBox.Size = new System.Drawing.Size(227, 148);
            this.macroListBox.TabIndex = 5;
            // 
            // pathButton
            // 
            this.pathButton.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pathButton.Location = new System.Drawing.Point(210, 73);
            this.pathButton.Name = "pathButton";
            this.pathButton.Size = new System.Drawing.Size(26, 23);
            this.pathButton.TabIndex = 6;
            this.pathButton.Text = "···";
            this.pathButton.UseVisualStyleBackColor = true;
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Location = new System.Drawing.Point(12, 74);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.ReadOnly = true;
            this.fileNameTextBox.Size = new System.Drawing.Size(190, 21);
            this.fileNameTextBox.TabIndex = 8;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.saveButton.Location = new System.Drawing.Point(244, 74);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(63, 23);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "저장";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // recordButton
            // 
            this.recordButton.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.recordButton.Location = new System.Drawing.Point(244, 104);
            this.recordButton.Name = "recordButton";
            this.recordButton.Size = new System.Drawing.Size(63, 23);
            this.recordButton.TabIndex = 10;
            this.recordButton.Text = "기록";
            this.recordButton.UseVisualStyleBackColor = true;
            this.recordButton.Click += new System.EventHandler(this.RecordButtonClick);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.addButton.Location = new System.Drawing.Point(244, 135);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(63, 23);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "추가";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.editButton.Location = new System.Drawing.Point(244, 166);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(63, 23);
            this.editButton.TabIndex = 12;
            this.editButton.Text = "편집";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // copyButton
            // 
            this.copyButton.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.copyButton.Location = new System.Drawing.Point(244, 198);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(63, 23);
            this.copyButton.TabIndex = 13;
            this.copyButton.Text = "복사";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.CopyButtonClick);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.deleteButton.Location = new System.Drawing.Point(244, 231);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(63, 23);
            this.deleteButton.TabIndex = 14;
            this.deleteButton.Text = "삭제";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButtonClick);
            // 
            // stopRadioButton
            // 
            this.stopRadioButton.AutoSize = true;
            this.stopRadioButton.Checked = true;
            this.stopRadioButton.Location = new System.Drawing.Point(191, 41);
            this.stopRadioButton.Name = "stopRadioButton";
            this.stopRadioButton.Size = new System.Drawing.Size(115, 16);
            this.stopRadioButton.TabIndex = 18;
            this.stopRadioButton.TabStop = true;
            this.stopRadioButton.Text = "실행 중단과 편집";
            this.stopRadioButton.UseVisualStyleBackColor = true;
            this.stopRadioButton.CheckedChanged += new System.EventHandler(this.StopRadioButtonCheckedChanged);
            // 
            // runRadioButton
            // 
            this.runRadioButton.AutoSize = true;
            this.runRadioButton.Location = new System.Drawing.Point(12, 41);
            this.runRadioButton.Name = "runRadioButton";
            this.runRadioButton.Size = new System.Drawing.Size(115, 16);
            this.runRadioButton.TabIndex = 17;
            this.runRadioButton.Text = "매크로 실행 가능";
            this.runRadioButton.UseVisualStyleBackColor = true;
            this.runRadioButton.CheckedChanged += new System.EventHandler(this.RunRadioButtonCheckedChanged);
            // 
            // iconTimer
            // 
            this.iconTimer.Interval = 500;
            this.iconTimer.Tick += new System.EventHandler(this.IconTimerTick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 382);
            this.Controls.Add(this.stopRadioButton);
            this.Controls.Add(this.runRadioButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.recordButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.fileNameTextBox);
            this.Controls.Add(this.pathButton);
            this.Controls.Add(this.macroListBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.debugButton);
            this.Controls.Add(this.configButton);
            this.Controls.Add(this.statusButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::key_macro.Properties.Resources.key_macro_ico;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "[키보드 / 마우스] 매크로";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button statusButton;
        private System.Windows.Forms.Button configButton;
        private System.Windows.Forms.Button debugButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListBox macroListBox;
        private System.Windows.Forms.Button pathButton;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button recordButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.RadioButton stopRadioButton;
        private System.Windows.Forms.RadioButton runRadioButton;
        private System.Windows.Forms.Timer iconTimer;
    }
}

