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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordForm));
            this.recordListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.mouseMoveUpDown = new System.Windows.Forms.NumericUpDown();
            this.mouseMoveCheckBox = new System.Windows.Forms.CheckBox();
            this.delayCheckBox = new System.Windows.Forms.CheckBox();
            this.delayUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.startCheckBox = new System.Windows.Forms.CheckBox();
            this.mouseWheelcheckBox = new System.Windows.Forms.CheckBox();
            this.mouseButtonCheckBox = new System.Windows.Forms.CheckBox();
            this.includePosCheckBox = new System.Windows.Forms.CheckBox();
            this.keyboardCheckBox = new System.Windows.Forms.CheckBox();
            this.recordLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.countUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mouseMoveUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // recordListBox
            // 
            this.recordListBox.FormattingEnabled = true;
            this.recordListBox.ItemHeight = 12;
            this.recordListBox.Location = new System.Drawing.Point(12, 83);
            this.recordListBox.Name = "recordListBox";
            this.recordListBox.Size = new System.Drawing.Size(227, 196);
            this.recordListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "기록 상태:";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(269, 324);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(63, 23);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButtonClick);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(337, 324);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(63, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "이상일 때";
            // 
            // mouseMoveUpDown
            // 
            this.mouseMoveUpDown.Location = new System.Drawing.Point(256, 206);
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
            this.mouseMoveCheckBox.Checked = true;
            this.mouseMoveCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mouseMoveCheckBox.Location = new System.Drawing.Point(245, 184);
            this.mouseMoveCheckBox.Name = "mouseMoveCheckBox";
            this.mouseMoveCheckBox.Size = new System.Drawing.Size(92, 16);
            this.mouseMoveCheckBox.TabIndex = 8;
            this.mouseMoveCheckBox.Text = "마우스 이동:";
            this.mouseMoveCheckBox.UseVisualStyleBackColor = true;
            this.mouseMoveCheckBox.CheckedChanged += new System.EventHandler(this.MouseMoveCheckBoxCheckedChanged);
            // 
            // delayCheckBox
            // 
            this.delayCheckBox.AutoSize = true;
            this.delayCheckBox.Checked = true;
            this.delayCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.delayCheckBox.Location = new System.Drawing.Point(245, 233);
            this.delayCheckBox.Name = "delayCheckBox";
            this.delayCheckBox.Size = new System.Drawing.Size(80, 16);
            this.delayCheckBox.TabIndex = 9;
            this.delayCheckBox.Text = "시간 지연:";
            this.delayCheckBox.UseVisualStyleBackColor = true;
            this.delayCheckBox.CheckedChanged += new System.EventHandler(this.DelayCheckBoxCheckedChanged);
            // 
            // delayUpDown
            // 
            this.delayUpDown.Location = new System.Drawing.Point(256, 255);
            this.delayUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.delayUpDown.Minimum = new decimal(new int[] {
            1,
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
            this.label3.Location = new System.Drawing.Point(316, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "m/s 이상일 때";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "기록 옵션:";
            // 
            // startCheckBox
            // 
            this.startCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.startCheckBox.Location = new System.Drawing.Point(80, 54);
            this.startCheckBox.Name = "startCheckBox";
            this.startCheckBox.Size = new System.Drawing.Size(159, 23);
            this.startCheckBox.TabIndex = 13;
            this.startCheckBox.Text = "기록 대기중";
            this.startCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.startCheckBox.UseVisualStyleBackColor = true;
            this.startCheckBox.CheckedChanged += new System.EventHandler(this.StartCheckBoxCheckedChanged);
            // 
            // mouseWheelcheckBox
            // 
            this.mouseWheelcheckBox.AutoSize = true;
            this.mouseWheelcheckBox.Location = new System.Drawing.Point(245, 120);
            this.mouseWheelcheckBox.Name = "mouseWheelcheckBox";
            this.mouseWheelcheckBox.Size = new System.Drawing.Size(76, 16);
            this.mouseWheelcheckBox.TabIndex = 15;
            this.mouseWheelcheckBox.Text = "마우스 휠";
            this.mouseWheelcheckBox.UseVisualStyleBackColor = true;
            // 
            // mouseButtonCheckBox
            // 
            this.mouseButtonCheckBox.AutoSize = true;
            this.mouseButtonCheckBox.Checked = true;
            this.mouseButtonCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mouseButtonCheckBox.Location = new System.Drawing.Point(245, 142);
            this.mouseButtonCheckBox.Name = "mouseButtonCheckBox";
            this.mouseButtonCheckBox.Size = new System.Drawing.Size(92, 16);
            this.mouseButtonCheckBox.TabIndex = 16;
            this.mouseButtonCheckBox.Text = "마우스 버튼:";
            this.mouseButtonCheckBox.UseVisualStyleBackColor = true;
            this.mouseButtonCheckBox.CheckedChanged += new System.EventHandler(this.MouseButtonCheckBoxCheckedChanged);
            // 
            // includePosCheckBox
            // 
            this.includePosCheckBox.AutoSize = true;
            this.includePosCheckBox.Location = new System.Drawing.Point(257, 162);
            this.includePosCheckBox.Name = "includePosCheckBox";
            this.includePosCheckBox.Size = new System.Drawing.Size(76, 16);
            this.includePosCheckBox.TabIndex = 17;
            this.includePosCheckBox.Text = "위치 포함";
            this.includePosCheckBox.UseVisualStyleBackColor = true;
            // 
            // keyboardCheckBox
            // 
            this.keyboardCheckBox.AutoSize = true;
            this.keyboardCheckBox.Checked = true;
            this.keyboardCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.keyboardCheckBox.Location = new System.Drawing.Point(245, 98);
            this.keyboardCheckBox.Name = "keyboardCheckBox";
            this.keyboardCheckBox.Size = new System.Drawing.Size(76, 16);
            this.keyboardCheckBox.TabIndex = 18;
            this.keyboardCheckBox.Text = "키보드 키";
            this.keyboardCheckBox.UseVisualStyleBackColor = true;
            // 
            // recordLabel
            // 
            this.recordLabel.AutoSize = true;
            this.recordLabel.Location = new System.Drawing.Point(15, 286);
            this.recordLabel.Name = "recordLabel";
            this.recordLabel.Size = new System.Drawing.Size(155, 12);
            this.recordLabel.TabIndex = 19;
            this.recordLabel.Text = "0개의 항목이 기록 됨 (0 초)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 12);
            this.label5.TabIndex = 20;
            this.label5.Text = "매크로 반복 실행 횟수:";
            // 
            // countUpDown
            // 
            this.countUpDown.Location = new System.Drawing.Point(152, 300);
            this.countUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.countUpDown.Name = "countUpDown";
            this.countUpDown.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.countUpDown.Size = new System.Drawing.Size(45, 21);
            this.countUpDown.TabIndex = 21;
            this.countUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 12);
            this.label6.TabIndex = 22;
            this.label6.Text = "회(0이면 무한 반복)";
            // 
            // RecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 353);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.countUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.recordLabel);
            this.Controls.Add(this.keyboardCheckBox);
            this.Controls.Add(this.includePosCheckBox);
            this.Controls.Add(this.mouseButtonCheckBox);
            this.Controls.Add(this.mouseWheelcheckBox);
            this.Controls.Add(this.startCheckBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.delayUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.delayCheckBox);
            this.Controls.Add(this.mouseMoveCheckBox);
            this.Controls.Add(this.mouseMoveUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
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
            ((System.ComponentModel.ISupportInitialize)(this.countUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox recordListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown mouseMoveUpDown;
        private System.Windows.Forms.CheckBox mouseMoveCheckBox;
        private System.Windows.Forms.CheckBox delayCheckBox;
        private System.Windows.Forms.NumericUpDown delayUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox startCheckBox;
        private System.Windows.Forms.CheckBox mouseWheelcheckBox;
        private System.Windows.Forms.CheckBox mouseButtonCheckBox;
        private System.Windows.Forms.CheckBox includePosCheckBox;
        private System.Windows.Forms.CheckBox keyboardCheckBox;
        private System.Windows.Forms.Label recordLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown countUpDown;
        private System.Windows.Forms.Label label6;
    }
}