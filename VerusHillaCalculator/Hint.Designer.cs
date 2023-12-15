namespace VerusHillaCalculator
{
    partial class Hint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hint));
            tabControl1 = new TabControl();
            HintTimer = new TabPage();
            label1 = new Label();
            HintDeathCount = new TabPage();
            label2 = new Label();
            BtnClose = new Button();
            tabControl1.SuspendLayout();
            HintTimer.SuspendLayout();
            HintDeathCount.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(HintTimer);
            tabControl1.Controls.Add(HintDeathCount);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(495, 221);
            tabControl1.TabIndex = 0;
            // 
            // HintTimer
            // 
            HintTimer.BackColor = Color.FromArgb(255, 185, 185);
            HintTimer.Controls.Add(label1);
            HintTimer.Location = new Point(4, 24);
            HintTimer.Name = "HintTimer";
            HintTimer.Padding = new Padding(3);
            HintTimer.Size = new Size(487, 193);
            HintTimer.TabIndex = 0;
            HintTimer.Text = "타이머";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 3);
            label1.Name = "label1";
            label1.Size = new Size(470, 180);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // HintDeathCount
            // 
            HintDeathCount.BackColor = Color.FromArgb(192, 255, 192);
            HintDeathCount.Controls.Add(label2);
            HintDeathCount.Location = new Point(4, 24);
            HintDeathCount.Name = "HintDeathCount";
            HintDeathCount.Padding = new Padding(3);
            HintDeathCount.Size = new Size(487, 193);
            HintDeathCount.TabIndex = 1;
            HintDeathCount.Text = "실카 계산기";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 3);
            label2.Name = "label2";
            label2.Size = new Size(475, 120);
            label2.TabIndex = 0;
            label2.Text = resources.GetString("label2.Text");
            // 
            // BtnClose
            // 
            BtnClose.Location = new Point(428, 238);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(75, 23);
            BtnClose.TabIndex = 1;
            BtnClose.Text = "확인 (&O)";
            BtnClose.UseVisualStyleBackColor = true;
            BtnClose.Click += BtnClose_Click;
            // 
            // Hint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(523, 273);
            Controls.Add(BtnClose);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Hint";
            Text = "도움말";
            Load += Hint_Load;
            tabControl1.ResumeLayout(false);
            HintTimer.ResumeLayout(false);
            HintTimer.PerformLayout();
            HintDeathCount.ResumeLayout(false);
            HintDeathCount.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage HintTimer;
        private TabPage HintDeathCount;
        private Label label1;
        private Label label2;
        private Button BtnClose;
    }
}