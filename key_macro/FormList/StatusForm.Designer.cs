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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Image = global::key_macro.Properties.Resources.lamp_off;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(191, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = " Right";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Image = global::key_macro.Properties.Resources.lamp_off;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(134, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "  Middle";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Image = global::key_macro.Properties.Resources.lamp_off;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(94, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = " Left";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Image = global::key_macro.Properties.Resources.lamp_off;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(284, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "X2";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Image = global::key_macro.Properties.Resources.lamp_off;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(240, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "X1";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 139);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StatusForm";
            this.Text = "[키보드 / 마우스] 상태표시";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}