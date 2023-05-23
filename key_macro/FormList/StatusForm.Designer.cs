namespace key_macro.FormList
{
    partial class StatusForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatusForm));
            this.inputKeyLabel = new System.Windows.Forms.Label();
            this.controlsLabel = new System.Windows.Forms.Label();
            this.languageLabel = new System.Windows.Forms.Label();
            this.mousePositionLabel = new System.Windows.Forms.Label();
            this.mouseButtonsLabel = new System.Windows.Forms.Label();
            this.inputKeyTextBox = new System.Windows.Forms.TextBox();
            this.languageTextBox = new System.Windows.Forms.TextBox();
            this.mousePositionTextBox = new System.Windows.Forms.TextBox();
            this.ctrlLabel = new System.Windows.Forms.Label();
            this.altLabel = new System.Windows.Forms.Label();
            this.shiftLabel = new System.Windows.Forms.Label();
            this.rightLabel = new System.Windows.Forms.Label();
            this.middleLabel = new System.Windows.Forms.Label();
            this.leftLabel = new System.Windows.Forms.Label();
            this.x2Label = new System.Windows.Forms.Label();
            this.x1Label = new System.Windows.Forms.Label();
            this.imeCheckTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // inputKeyLabel
            // 
            this.inputKeyLabel.AutoSize = true;
            this.inputKeyLabel.Location = new System.Drawing.Point(39, 9);
            this.inputKeyLabel.Name = "inputKeyLabel";
            this.inputKeyLabel.Size = new System.Drawing.Size(49, 12);
            this.inputKeyLabel.TabIndex = 0;
            this.inputKeyLabel.Text = "입력 키:";
            // 
            // controlsLabel
            // 
            this.controlsLabel.AutoSize = true;
            this.controlsLabel.Location = new System.Drawing.Point(39, 34);
            this.controlsLabel.Name = "controlsLabel";
            this.controlsLabel.Size = new System.Drawing.Size(49, 12);
            this.controlsLabel.TabIndex = 1;
            this.controlsLabel.Text = "제어 키:";
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Location = new System.Drawing.Point(7, 61);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(81, 12);
            this.languageLabel.TabIndex = 2;
            this.languageLabel.Text = "IME 한/영 키:";
            // 
            // mousePositionLabel
            // 
            this.mousePositionLabel.AutoSize = true;
            this.mousePositionLabel.Location = new System.Drawing.Point(15, 96);
            this.mousePositionLabel.Name = "mousePositionLabel";
            this.mousePositionLabel.Size = new System.Drawing.Size(73, 12);
            this.mousePositionLabel.TabIndex = 3;
            this.mousePositionLabel.Text = "마우스 위치:";
            // 
            // mouseButtonsLabel
            // 
            this.mouseButtonsLabel.AutoSize = true;
            this.mouseButtonsLabel.Location = new System.Drawing.Point(15, 120);
            this.mouseButtonsLabel.Name = "mouseButtonsLabel";
            this.mouseButtonsLabel.Size = new System.Drawing.Size(73, 12);
            this.mouseButtonsLabel.TabIndex = 4;
            this.mouseButtonsLabel.Text = "마우스 버튼:";
            // 
            // inputKeyTextBox
            // 
            this.inputKeyTextBox.Location = new System.Drawing.Point(94, 5);
            this.inputKeyTextBox.Name = "inputKeyTextBox";
            this.inputKeyTextBox.ReadOnly = true;
            this.inputKeyTextBox.Size = new System.Drawing.Size(222, 21);
            this.inputKeyTextBox.TabIndex = 5;
            // 
            // languageTextBox
            // 
            this.languageTextBox.Location = new System.Drawing.Point(94, 57);
            this.languageTextBox.Name = "languageTextBox";
            this.languageTextBox.ReadOnly = true;
            this.languageTextBox.Size = new System.Drawing.Size(222, 21);
            this.languageTextBox.TabIndex = 6;
            // 
            // mousePositionTextBox
            // 
            this.mousePositionTextBox.Location = new System.Drawing.Point(94, 91);
            this.mousePositionTextBox.Name = "mousePositionTextBox";
            this.mousePositionTextBox.ReadOnly = true;
            this.mousePositionTextBox.Size = new System.Drawing.Size(222, 21);
            this.mousePositionTextBox.TabIndex = 7;
            // 
            // ctrlLabel
            // 
            this.ctrlLabel.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ctrlLabel.Image = global::key_macro.Properties.Resources.lamp_off;
            this.ctrlLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ctrlLabel.Location = new System.Drawing.Point(94, 32);
            this.ctrlLabel.Name = "ctrlLabel";
            this.ctrlLabel.Size = new System.Drawing.Size(53, 17);
            this.ctrlLabel.TabIndex = 8;
            this.ctrlLabel.Text = " Ctrl";
            this.ctrlLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // altLabel
            // 
            this.altLabel.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.altLabel.Image = global::key_macro.Properties.Resources.lamp_off;
            this.altLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.altLabel.Location = new System.Drawing.Point(136, 32);
            this.altLabel.Name = "altLabel";
            this.altLabel.Size = new System.Drawing.Size(53, 17);
            this.altLabel.TabIndex = 9;
            this.altLabel.Text = "Alt";
            this.altLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shiftLabel
            // 
            this.shiftLabel.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.shiftLabel.Image = global::key_macro.Properties.Resources.lamp_off;
            this.shiftLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.shiftLabel.Location = new System.Drawing.Point(191, 32);
            this.shiftLabel.Name = "shiftLabel";
            this.shiftLabel.Size = new System.Drawing.Size(53, 17);
            this.shiftLabel.TabIndex = 10;
            this.shiftLabel.Text = " Shift";
            this.shiftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rightLabel
            // 
            this.rightLabel.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rightLabel.Image = global::key_macro.Properties.Resources.lamp_off;
            this.rightLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rightLabel.Location = new System.Drawing.Point(191, 117);
            this.rightLabel.Name = "rightLabel";
            this.rightLabel.Size = new System.Drawing.Size(61, 17);
            this.rightLabel.TabIndex = 13;
            this.rightLabel.Text = " Right";
            this.rightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // middleLabel
            // 
            this.middleLabel.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.middleLabel.Image = global::key_macro.Properties.Resources.lamp_off;
            this.middleLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.middleLabel.Location = new System.Drawing.Point(134, 117);
            this.middleLabel.Name = "middleLabel";
            this.middleLabel.Size = new System.Drawing.Size(64, 17);
            this.middleLabel.TabIndex = 12;
            this.middleLabel.Text = "  Middle";
            this.middleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leftLabel
            // 
            this.leftLabel.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.leftLabel.Image = global::key_macro.Properties.Resources.lamp_off;
            this.leftLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.leftLabel.Location = new System.Drawing.Point(94, 117);
            this.leftLabel.Name = "leftLabel";
            this.leftLabel.Size = new System.Drawing.Size(53, 17);
            this.leftLabel.TabIndex = 11;
            this.leftLabel.Text = " Left";
            this.leftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // x2Label
            // 
            this.x2Label.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.x2Label.Image = global::key_macro.Properties.Resources.lamp_off;
            this.x2Label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.x2Label.Location = new System.Drawing.Point(284, 117);
            this.x2Label.Name = "x2Label";
            this.x2Label.Size = new System.Drawing.Size(51, 17);
            this.x2Label.TabIndex = 15;
            this.x2Label.Text = "X2";
            this.x2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // x1Label
            // 
            this.x1Label.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.x1Label.Image = global::key_macro.Properties.Resources.lamp_off;
            this.x1Label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.x1Label.Location = new System.Drawing.Point(240, 117);
            this.x1Label.Name = "x1Label";
            this.x1Label.Size = new System.Drawing.Size(52, 17);
            this.x1Label.TabIndex = 14;
            this.x1Label.Text = "X1";
            this.x1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imeCheckTimer
            // 
            this.imeCheckTimer.Interval = 1;
            this.imeCheckTimer.Tick += new System.EventHandler(this.imeCheckTimerTick);
            // 
            // StatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 139);
            this.Controls.Add(this.x2Label);
            this.Controls.Add(this.x1Label);
            this.Controls.Add(this.rightLabel);
            this.Controls.Add(this.middleLabel);
            this.Controls.Add(this.leftLabel);
            this.Controls.Add(this.shiftLabel);
            this.Controls.Add(this.altLabel);
            this.Controls.Add(this.ctrlLabel);
            this.Controls.Add(this.mousePositionTextBox);
            this.Controls.Add(this.languageTextBox);
            this.Controls.Add(this.inputKeyTextBox);
            this.Controls.Add(this.mouseButtonsLabel);
            this.Controls.Add(this.mousePositionLabel);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.controlsLabel);
            this.Controls.Add(this.inputKeyLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StatusForm";
            this.Text = "[키보드 / 마우스] 상태표시";
            this.Load += new System.EventHandler(this.StatusFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputKeyLabel;
        private System.Windows.Forms.Label controlsLabel;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.Label mousePositionLabel;
        private System.Windows.Forms.Label mouseButtonsLabel;
        private System.Windows.Forms.TextBox inputKeyTextBox;
        private System.Windows.Forms.TextBox languageTextBox;
        private System.Windows.Forms.TextBox mousePositionTextBox;
        private System.Windows.Forms.Label ctrlLabel;
        private System.Windows.Forms.Label altLabel;
        private System.Windows.Forms.Label shiftLabel;
        private System.Windows.Forms.Label rightLabel;
        private System.Windows.Forms.Label middleLabel;
        private System.Windows.Forms.Label leftLabel;
        private System.Windows.Forms.Label x2Label;
        private System.Windows.Forms.Label x1Label;
        private System.Windows.Forms.Timer imeCheckTimer;
    }
}