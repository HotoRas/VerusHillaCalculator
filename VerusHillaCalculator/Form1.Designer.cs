namespace VerusHillaCalculator
{
    partial class Form1
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
            BtnStart = new Button();
            BtnPhase = new Button();
            GlobalTimer = new System.Windows.Forms.Timer(components);
            ModeNormal = new RadioButton();
            IngameControlG = new GroupBox();
            BtnFinish = new Button();
            DifficultyG = new GroupBox();
            ModeHard = new RadioButton();
            GameTimer = new Label();
            TimerGroup = new GroupBox();
            NextTimer = new Label();
            LabelNext = new Label();
            SettingsGroup = new GroupBox();
            GlobalMenu = new MenuStrip();
            파일FToolStripMenuItem = new ToolStripMenuItem();
            정보IToolStripMenuItem = new ToolStripMenuItem();
            IngameControlG.SuspendLayout();
            DifficultyG.SuspendLayout();
            TimerGroup.SuspendLayout();
            SettingsGroup.SuspendLayout();
            GlobalMenu.SuspendLayout();
            SuspendLayout();
            // 
            // BtnStart
            // 
            BtnStart.Location = new Point(6, 22);
            BtnStart.Name = "BtnStart";
            BtnStart.Size = new Size(87, 23);
            BtnStart.TabIndex = 0;
            BtnStart.Text = "시작";
            BtnStart.UseVisualStyleBackColor = true;
            BtnStart.Click += BtnStart_Click;
            // 
            // BtnPhase
            // 
            BtnPhase.Location = new Point(6, 51);
            BtnPhase.Name = "BtnPhase";
            BtnPhase.Size = new Size(87, 23);
            BtnPhase.TabIndex = 1;
            BtnPhase.Text = "다음 페이즈";
            BtnPhase.UseVisualStyleBackColor = true;
            // 
            // GlobalTimer
            // 
            GlobalTimer.Interval = 1000;
            // 
            // ModeNormal
            // 
            ModeNormal.AutoSize = true;
            ModeNormal.Location = new Point(6, 22);
            ModeNormal.Name = "ModeNormal";
            ModeNormal.Size = new Size(77, 19);
            ModeNormal.TabIndex = 2;
            ModeNormal.TabStop = true;
            ModeNormal.Text = "노멀 모드";
            ModeNormal.UseVisualStyleBackColor = true;
            ModeNormal.CheckedChanged += ModeNormal_CheckedChanged;
            // 
            // IngameControlG
            // 
            IngameControlG.Controls.Add(BtnFinish);
            IngameControlG.Controls.Add(BtnStart);
            IngameControlG.Controls.Add(BtnPhase);
            IngameControlG.Location = new Point(478, 47);
            IngameControlG.Name = "IngameControlG";
            IngameControlG.Size = new Size(99, 110);
            IngameControlG.TabIndex = 3;
            IngameControlG.TabStop = false;
            IngameControlG.Text = "인게임 컨트롤";
            // 
            // BtnFinish
            // 
            BtnFinish.Location = new Point(6, 80);
            BtnFinish.Name = "BtnFinish";
            BtnFinish.Size = new Size(87, 23);
            BtnFinish.TabIndex = 5;
            BtnFinish.Text = "종료";
            BtnFinish.UseVisualStyleBackColor = true;
            // 
            // DifficultyG
            // 
            DifficultyG.Controls.Add(ModeHard);
            DifficultyG.Controls.Add(ModeNormal);
            DifficultyG.Location = new Point(6, 22);
            DifficultyG.Name = "DifficultyG";
            DifficultyG.Size = new Size(91, 74);
            DifficultyG.TabIndex = 4;
            DifficultyG.TabStop = false;
            DifficultyG.Text = "게임 모드";
            DifficultyG.Enter += OutgameControlG_Enter;
            // 
            // ModeHard
            // 
            ModeHard.AutoSize = true;
            ModeHard.Location = new Point(6, 47);
            ModeHard.Name = "ModeHard";
            ModeHard.Size = new Size(77, 19);
            ModeHard.TabIndex = 3;
            ModeHard.TabStop = true;
            ModeHard.Text = "하드 모드";
            ModeHard.UseVisualStyleBackColor = true;
            ModeHard.CheckedChanged += ModeHard_CheckedChanged;
            // 
            // GameTimer
            // 
            GameTimer.AutoSize = true;
            GameTimer.Font = new Font("맑은 고딕", 36F, FontStyle.Regular, GraphicsUnit.Point);
            GameTimer.Location = new Point(6, 19);
            GameTimer.Name = "GameTimer";
            GameTimer.Size = new Size(143, 65);
            GameTimer.TabIndex = 5;
            GameTimer.Text = "30:00";
            // 
            // TimerGroup
            // 
            TimerGroup.Controls.Add(NextTimer);
            TimerGroup.Controls.Add(LabelNext);
            TimerGroup.Controls.Add(GameTimer);
            TimerGroup.Location = new Point(32, 47);
            TimerGroup.Name = "TimerGroup";
            TimerGroup.Size = new Size(440, 91);
            TimerGroup.TabIndex = 6;
            TimerGroup.TabStop = false;
            TimerGroup.Text = "타이머";
            // 
            // NextTimer
            // 
            NextTimer.AutoSize = true;
            NextTimer.Font = new Font("맑은 고딕", 36F, FontStyle.Regular, GraphicsUnit.Point);
            NextTimer.ForeColor = Color.Red;
            NextTimer.Location = new Point(291, 19);
            NextTimer.Name = "NextTimer";
            NextTimer.Size = new Size(117, 65);
            NextTimer.TabIndex = 6;
            NextTimer.Text = "2:44";
            // 
            // LabelNext
            // 
            LabelNext.AutoSize = true;
            LabelNext.Font = new Font("맑은 고딕", 36F, FontStyle.Regular, GraphicsUnit.Point);
            LabelNext.Location = new Point(155, 19);
            LabelNext.Name = "LabelNext";
            LabelNext.Size = new Size(284, 65);
            LabelNext.TabIndex = 7;
            LabelNext.Text = "(다음:       )";
            // 
            // SettingsGroup
            // 
            SettingsGroup.Controls.Add(DifficultyG);
            SettingsGroup.Location = new Point(32, 144);
            SettingsGroup.Name = "SettingsGroup";
            SettingsGroup.Size = new Size(440, 248);
            SettingsGroup.TabIndex = 7;
            SettingsGroup.TabStop = false;
            SettingsGroup.Text = "사전 설정";
            // 
            // GlobalMenu
            // 
            GlobalMenu.Items.AddRange(new ToolStripItem[] { 파일FToolStripMenuItem });
            GlobalMenu.Location = new Point(0, 0);
            GlobalMenu.Name = "GlobalMenu";
            GlobalMenu.Size = new Size(800, 24);
            GlobalMenu.TabIndex = 8;
            GlobalMenu.Text = "menuStrip1";
            // 
            // 파일FToolStripMenuItem
            // 
            파일FToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 정보IToolStripMenuItem });
            파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
            파일FToolStripMenuItem.Size = new Size(61, 20);
            파일FToolStripMenuItem.Text = "파일 (&F)";
            // 
            // 정보IToolStripMenuItem
            // 
            정보IToolStripMenuItem.Name = "정보IToolStripMenuItem";
            정보IToolStripMenuItem.Size = new Size(180, 22);
            정보IToolStripMenuItem.Text = "정보 (&I)";
            정보IToolStripMenuItem.Click += 정보IToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SettingsGroup);
            Controls.Add(TimerGroup);
            Controls.Add(IngameControlG);
            Controls.Add(GlobalMenu);
            MainMenuStrip = GlobalMenu;
            Name = "Form1";
            Text = "진 힐라 타이머";
            Load += Form1_Load;
            IngameControlG.ResumeLayout(false);
            DifficultyG.ResumeLayout(false);
            DifficultyG.PerformLayout();
            TimerGroup.ResumeLayout(false);
            TimerGroup.PerformLayout();
            SettingsGroup.ResumeLayout(false);
            GlobalMenu.ResumeLayout(false);
            GlobalMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnStart;
        private Button BtnPhase;
        private System.Windows.Forms.Timer GlobalTimer;
        private RadioButton ModeNormal;
        private GroupBox IngameControlG;
        private GroupBox DifficultyG;
        private Button BtnFinish;
        private RadioButton ModeHard;
        private Label GameTimer;
        private GroupBox TimerGroup;
        private GroupBox SettingsGroup;
        private Label NextTimer;
        private Label LabelNext;
        private MenuStrip GlobalMenu;
        private ToolStripMenuItem 파일FToolStripMenuItem;
        private ToolStripMenuItem 정보IToolStripMenuItem;
    }
}
