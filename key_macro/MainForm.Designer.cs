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
            this.testLabel = new System.Windows.Forms.Label();
            this.statusButton = new System.Windows.Forms.Button();
            this.configButton = new System.Windows.Forms.Button();
            this.debugButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testLabel
            // 
            this.testLabel.AutoSize = true;
            this.testLabel.Location = new System.Drawing.Point(12, 9);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(38, 12);
            this.testLabel.TabIndex = 0;
            this.testLabel.Text = "label1";
            // 
            // statusButton
            // 
            this.statusButton.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.statusButton.Location = new System.Drawing.Point(86, 415);
            this.statusButton.Name = "statusButton";
            this.statusButton.Size = new System.Drawing.Size(63, 23);
            this.statusButton.TabIndex = 1;
            this.statusButton.Text = "입력상태";
            this.statusButton.UseVisualStyleBackColor = true;
            this.statusButton.Click += new System.EventHandler(this.statusButtonClick);
            // 
            // configButton
            // 
            this.configButton.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.configButton.Location = new System.Drawing.Point(8, 415);
            this.configButton.Name = "configButton";
            this.configButton.Size = new System.Drawing.Size(63, 23);
            this.configButton.TabIndex = 2;
            this.configButton.Text = "설정";
            this.configButton.UseVisualStyleBackColor = true;
            // 
            // debugButton
            // 
            this.debugButton.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.debugButton.Location = new System.Drawing.Point(164, 415);
            this.debugButton.Name = "debugButton";
            this.debugButton.Size = new System.Drawing.Size(63, 23);
            this.debugButton.TabIndex = 3;
            this.debugButton.Text = "실행상태";
            this.debugButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.exitButton.Location = new System.Drawing.Point(243, 415);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(63, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "종료";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButtonClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 442);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.debugButton);
            this.Controls.Add(this.configButton);
            this.Controls.Add(this.statusButton);
            this.Controls.Add(this.testLabel);
            this.Icon = global::key_macro.Properties.Resources.key_macro_ico;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "[키보드 / 마우스] 매크로";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label testLabel;
        private System.Windows.Forms.Button statusButton;
        private System.Windows.Forms.Button configButton;
        private System.Windows.Forms.Button debugButton;
        private System.Windows.Forms.Button exitButton;
    }
}

