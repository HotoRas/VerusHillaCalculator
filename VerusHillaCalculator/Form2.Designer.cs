namespace VerusHillaCalculator
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            CopyingLabel = new Label();
            BtnClose = new Button();
            BtnMIT = new Button();
            pictureBox1 = new PictureBox();
            VersionLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // CopyingLabel
            // 
            CopyingLabel.AutoSize = true;
            CopyingLabel.Location = new Point(12, 56);
            CopyingLabel.Name = "CopyingLabel";
            CopyingLabel.Size = new Size(286, 30);
            CopyingLabel.TabIndex = 0;
            CopyingLabel.Text = "Copyright (C) since 2003 Nexon, all rights reserved.\r\nCopyright (C) 2023 HotoRas under MIT license";
            // 
            // BtnClose
            // 
            BtnClose.Location = new Point(223, 115);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(75, 23);
            BtnClose.TabIndex = 1;
            BtnClose.Text = "확인 (&O)";
            BtnClose.UseVisualStyleBackColor = true;
            BtnClose.Click += BtnClose_Click;
            // 
            // BtnMIT
            // 
            BtnMIT.Location = new Point(103, 115);
            BtnMIT.Name = "BtnMIT";
            BtnMIT.Size = new Size(114, 23);
            BtnMIT.TabIndex = 2;
            BtnMIT.Text = "라이센스 보기 (&L)";
            BtnMIT.UseVisualStyleBackColor = true;
            BtnMIT.Click += BtnMIT_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 37);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // VersionLabel
            // 
            VersionLabel.AutoSize = true;
            VersionLabel.Location = new Point(55, 19);
            VersionLabel.Name = "VersionLabel";
            VersionLabel.Size = new Size(163, 30);
            VersionLabel.TabIndex = 4;
            VersionLabel.Text = "메이플스토리 진 힐라 계산기\r\nversion 1.0.0 (20231216)";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(314, 146);
            Controls.Add(VersionLabel);
            Controls.Add(pictureBox1);
            Controls.Add(BtnMIT);
            Controls.Add(BtnClose);
            Controls.Add(CopyingLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(330, 147);
            Name = "Form2";
            Text = "정보";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CopyingLabel;
        private Button BtnClose;
        private Button BtnMIT;
        private PictureBox pictureBox1;
        private Label VersionLabel;
    }
}