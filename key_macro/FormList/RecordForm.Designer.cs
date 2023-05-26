namespace key_macro.FormList
{
    partial class RecordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordForm));
            this.recordListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.recordButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.recordTimer = new System.Windows.Forms.Timer(this.components);
            this.testLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mouseMoveUpDown = new System.Windows.Forms.NumericUpDown();
            this.mouseMoveCheckBox = new System.Windows.Forms.CheckBox();
            this.delayCheckBox = new System.Windows.Forms.CheckBox();
            this.delayUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mouseMoveUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // recordListBox
            // 
            this.recordListBox.FormattingEnabled = true;
            this.recordListBox.ItemHeight = 12;
            this.recordListBox.Location = new System.Drawing.Point(12, 131);
            this.recordListBox.Name = "recordListBox";
            this.recordListBox.Size = new System.Drawing.Size(227, 148);
            this.recordListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "기록 상태:";
            // 
            // recordButton
            // 
            this.recordButton.Location = new System.Drawing.Point(80, 93);
            this.recordButton.Name = "recordButton";
            this.recordButton.Size = new System.Drawing.Size(159, 23);
            this.recordButton.TabIndex = 2;
            this.recordButton.Text = "기록 대기 중";
            this.recordButton.UseVisualStyleBackColor = true;
            this.recordButton.Click += new System.EventHandler(this.recordButtonClick);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(173, 397);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(63, 23);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButtonClick);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(247, 397);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(63, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButtonClick);
            // 
            // recordTimer
            // 
            this.recordTimer.Interval = 1;
            this.recordTimer.Tick += new System.EventHandler(this.recordTimerTick);
            // 
            // testLabel
            // 
            this.testLabel.AutoSize = true;
            this.testLabel.Location = new System.Drawing.Point(15, 286);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(38, 12);
            this.testLabel.TabIndex = 5;
            this.testLabel.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "이상일 때";
            // 
            // mouseMoveUpDown
            // 
            this.mouseMoveUpDown.Location = new System.Drawing.Point(245, 187);
            this.mouseMoveUpDown.Name = "mouseMoveUpDown";
            this.mouseMoveUpDown.Size = new System.Drawing.Size(54, 21);
            this.mouseMoveUpDown.TabIndex = 7;
            this.mouseMoveUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // mouseMoveCheckBox
            // 
            this.mouseMoveCheckBox.AutoSize = true;
            this.mouseMoveCheckBox.Location = new System.Drawing.Point(245, 165);
            this.mouseMoveCheckBox.Name = "mouseMoveCheckBox";
            this.mouseMoveCheckBox.Size = new System.Drawing.Size(92, 16);
            this.mouseMoveCheckBox.TabIndex = 8;
            this.mouseMoveCheckBox.Text = "마우스 이동:";
            this.mouseMoveCheckBox.UseVisualStyleBackColor = true;
            // 
            // delayCheckBox
            // 
            this.delayCheckBox.AutoSize = true;
            this.delayCheckBox.Location = new System.Drawing.Point(245, 224);
            this.delayCheckBox.Name = "delayCheckBox";
            this.delayCheckBox.Size = new System.Drawing.Size(80, 16);
            this.delayCheckBox.TabIndex = 9;
            this.delayCheckBox.Text = "시간 지연:";
            this.delayCheckBox.UseVisualStyleBackColor = true;
            // 
            // delayUpDown
            // 
            this.delayUpDown.Location = new System.Drawing.Point(245, 246);
            this.delayUpDown.Maximum = new decimal(new int[] {
            9000,
            0,
            0,
            0});
            this.delayUpDown.Name = "delayUpDown";
            this.delayUpDown.Size = new System.Drawing.Size(54, 21);
            this.delayUpDown.TabIndex = 11;
            this.delayUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "m/s 이상일 때";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "기록 옵션:";
            // 
            // RecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 443);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.delayUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.delayCheckBox);
            this.Controls.Add(this.mouseMoveCheckBox);
            this.Controls.Add(this.mouseMoveUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.testLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.recordButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.recordListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RecordForm";
            this.Text = "매크로 기록";
            ((System.ComponentModel.ISupportInitialize)(this.mouseMoveUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox recordListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button recordButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Timer recordTimer;
        private System.Windows.Forms.Label testLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown mouseMoveUpDown;
        private System.Windows.Forms.CheckBox mouseMoveCheckBox;
        private System.Windows.Forms.CheckBox delayCheckBox;
        private System.Windows.Forms.NumericUpDown delayUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}