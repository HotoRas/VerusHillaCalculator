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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            DeathCounter = new NumericUpDown();
            LabelDeathCount = new Label();
            BoxStringCount = new TextBox();
            LabelStringCount = new Label();
            LabelMemberCount = new Label();
            MemberCount = new NumericUpDown();
            GlobalMenu = new MenuStrip();
            파일FToolStripMenuItem = new ToolStripMenuItem();
            정보IToolStripMenuItem = new ToolStripMenuItem();
            라이센스LToolStripMenuItem = new ToolStripMenuItem();
            종료QToolStripMenuItem = new ToolStripMenuItem();
            toolTip = new ToolTip(components);
            BtnExit = new Button();
            HintToolStrip = new ToolStripMenuItem();
            IngameControlG.SuspendLayout();
            DifficultyG.SuspendLayout();
            TimerGroup.SuspendLayout();
            SettingsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DeathCounter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MemberCount).BeginInit();
            GlobalMenu.SuspendLayout();
            SuspendLayout();
            // 
            // BtnStart
            // 
            BtnStart.Location = new Point(6, 22);
            BtnStart.Name = "BtnStart";
            BtnStart.Size = new Size(95, 23);
            BtnStart.TabIndex = 0;
            BtnStart.Text = "시작 (&S)";
            BtnStart.UseVisualStyleBackColor = true;
            BtnStart.Click += BtnStart_Click;
            // 
            // BtnPhase
            // 
            BtnPhase.Location = new Point(107, 22);
            BtnPhase.Name = "BtnPhase";
            BtnPhase.Size = new Size(112, 52);
            BtnPhase.TabIndex = 1;
            BtnPhase.Text = "다음 페이즈\r\n(실카) (&P)";
            BtnPhase.UseVisualStyleBackColor = true;
            BtnPhase.Click += BtnPhase_Click;
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
            ModeNormal.Size = new Size(98, 19);
            ModeNormal.TabIndex = 2;
            ModeNormal.TabStop = true;
            ModeNormal.Text = "노멀 모드 (&N)";
            ModeNormal.UseVisualStyleBackColor = true;
            ModeNormal.CheckedChanged += ModeNormal_CheckedChanged;
            // 
            // IngameControlG
            // 
            IngameControlG.Controls.Add(BtnFinish);
            IngameControlG.Controls.Add(BtnStart);
            IngameControlG.Controls.Add(BtnPhase);
            IngameControlG.Location = new Point(250, 144);
            IngameControlG.Name = "IngameControlG";
            IngameControlG.Size = new Size(225, 81);
            IngameControlG.TabIndex = 3;
            IngameControlG.TabStop = false;
            IngameControlG.Text = "인게임 컨트롤";
            // 
            // BtnFinish
            // 
            BtnFinish.Location = new Point(6, 51);
            BtnFinish.Name = "BtnFinish";
            BtnFinish.Size = new Size(95, 23);
            BtnFinish.TabIndex = 5;
            BtnFinish.Text = "종료 (&N)";
            BtnFinish.UseVisualStyleBackColor = true;
            BtnFinish.Click += BtnFinish_Click;
            // 
            // DifficultyG
            // 
            DifficultyG.Controls.Add(ModeHard);
            DifficultyG.Controls.Add(ModeNormal);
            DifficultyG.Location = new Point(6, 22);
            DifficultyG.Name = "DifficultyG";
            DifficultyG.Size = new Size(116, 74);
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
            ModeHard.Size = new Size(98, 19);
            ModeHard.TabIndex = 3;
            ModeHard.TabStop = true;
            ModeHard.Text = "하드 모드 (&H)";
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
            TimerGroup.Location = new Point(12, 28);
            TimerGroup.Name = "TimerGroup";
            TimerGroup.Size = new Size(463, 110);
            TimerGroup.TabIndex = 6;
            TimerGroup.TabStop = false;
            TimerGroup.Text = "실카 타이머";
            // 
            // NextTimer
            // 
            NextTimer.AutoSize = true;
            NextTimer.BackColor = Color.Transparent;
            NextTimer.Font = new Font("맑은 고딕", 36F, FontStyle.Regular, GraphicsUnit.Point);
            NextTimer.ForeColor = Color.Red;
            NextTimer.Location = new Point(282, 19);
            NextTimer.Name = "NextTimer";
            NextTimer.Size = new Size(143, 65);
            NextTimer.TabIndex = 6;
            NextTimer.Text = "02:44";
            // 
            // LabelNext
            // 
            LabelNext.AutoSize = true;
            LabelNext.Font = new Font("맑은 고딕", 36F, FontStyle.Regular, GraphicsUnit.Point);
            LabelNext.Location = new Point(139, 19);
            LabelNext.Name = "LabelNext";
            LabelNext.Size = new Size(318, 65);
            LabelNext.TabIndex = 7;
            LabelNext.Text = "(다음:         )";
            // 
            // SettingsGroup
            // 
            SettingsGroup.Controls.Add(DeathCounter);
            SettingsGroup.Controls.Add(LabelDeathCount);
            SettingsGroup.Controls.Add(BoxStringCount);
            SettingsGroup.Controls.Add(LabelStringCount);
            SettingsGroup.Controls.Add(LabelMemberCount);
            SettingsGroup.Controls.Add(MemberCount);
            SettingsGroup.Controls.Add(DifficultyG);
            SettingsGroup.Location = new Point(12, 144);
            SettingsGroup.Name = "SettingsGroup";
            SettingsGroup.Size = new Size(232, 109);
            SettingsGroup.TabIndex = 7;
            SettingsGroup.TabStop = false;
            SettingsGroup.Text = "사전 설정 및 브리핑 계산";
            // 
            // DeathCounter
            // 
            DeathCounter.Location = new Point(177, 46);
            DeathCounter.Name = "DeathCounter";
            DeathCounter.Size = new Size(42, 23);
            DeathCounter.TabIndex = 10;
            DeathCounter.ValueChanged += DeathCounter_ValueChanged;
            // 
            // LabelDeathCount
            // 
            LabelDeathCount.AutoSize = true;
            LabelDeathCount.Location = new Point(128, 48);
            LabelDeathCount.Name = "LabelDeathCount";
            LabelDeathCount.Size = new Size(47, 15);
            LabelDeathCount.TabIndex = 9;
            LabelDeathCount.Text = "총 데카";
            // 
            // BoxStringCount
            // 
            BoxStringCount.Location = new Point(193, 72);
            BoxStringCount.MaxLength = 4;
            BoxStringCount.Name = "BoxStringCount";
            BoxStringCount.ReadOnly = true;
            BoxStringCount.Size = new Size(26, 23);
            BoxStringCount.TabIndex = 8;
            BoxStringCount.Text = "3";
            BoxStringCount.TextAlign = HorizontalAlignment.Right;
            // 
            // LabelStringCount
            // 
            LabelStringCount.AutoSize = true;
            LabelStringCount.Location = new Point(128, 75);
            LabelStringCount.Name = "LabelStringCount";
            LabelStringCount.Size = new Size(59, 15);
            LabelStringCount.TabIndex = 7;
            LabelStringCount.Text = "현재 실카";
            // 
            // LabelMemberCount
            // 
            LabelMemberCount.AutoSize = true;
            LabelMemberCount.Location = new Point(128, 22);
            LabelMemberCount.Name = "LabelMemberCount";
            LabelMemberCount.Size = new Size(43, 15);
            LabelMemberCount.TabIndex = 6;
            LabelMemberCount.Text = "인원수";
            // 
            // MemberCount
            // 
            MemberCount.Location = new Point(177, 20);
            MemberCount.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            MemberCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            MemberCount.Name = "MemberCount";
            MemberCount.Size = new Size(42, 23);
            MemberCount.TabIndex = 5;
            MemberCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            MemberCount.ValueChanged += MemberCount_ValueChanged;
            // 
            // GlobalMenu
            // 
            GlobalMenu.BackColor = SystemColors.Control;
            GlobalMenu.Items.AddRange(new ToolStripItem[] { 파일FToolStripMenuItem });
            GlobalMenu.Location = new Point(0, 0);
            GlobalMenu.Name = "GlobalMenu";
            GlobalMenu.Size = new Size(489, 24);
            GlobalMenu.TabIndex = 8;
            GlobalMenu.Text = "menuStrip1";
            // 
            // 파일FToolStripMenuItem
            // 
            파일FToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { HintToolStrip, 정보IToolStripMenuItem, 라이센스LToolStripMenuItem, 종료QToolStripMenuItem });
            파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
            파일FToolStripMenuItem.Size = new Size(61, 20);
            파일FToolStripMenuItem.Text = "파일 (&F)";
            // 
            // 정보IToolStripMenuItem
            // 
            정보IToolStripMenuItem.Name = "정보IToolStripMenuItem";
            정보IToolStripMenuItem.Size = new Size(196, 22);
            정보IToolStripMenuItem.Text = "정보 (&I)";
            정보IToolStripMenuItem.Click += 정보IToolStripMenuItem_Click;
            // 
            // 라이센스LToolStripMenuItem
            // 
            라이센스LToolStripMenuItem.Name = "라이센스LToolStripMenuItem";
            라이센스LToolStripMenuItem.Size = new Size(196, 22);
            라이센스LToolStripMenuItem.Text = "오픈 소스 라이센스 (&L)";
            라이센스LToolStripMenuItem.Click += 라이센스LToolStripMenuItem_Click;
            // 
            // 종료QToolStripMenuItem
            // 
            종료QToolStripMenuItem.Name = "종료QToolStripMenuItem";
            종료QToolStripMenuItem.Size = new Size(196, 22);
            종료QToolStripMenuItem.Text = "종료 (&Q)";
            종료QToolStripMenuItem.Click += 종료QToolStripMenuItem_Click;
            // 
            // BtnExit
            // 
            BtnExit.Location = new Point(335, 230);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(140, 23);
            BtnExit.TabIndex = 9;
            BtnExit.Text = "프로그램 종료 (Alt+F4)";
            BtnExit.UseVisualStyleBackColor = true;
            BtnExit.Click += BtnExit_Click;
            // 
            // HintToolStrip
            // 
            HintToolStrip.Name = "HintToolStrip";
            HintToolStrip.Size = new Size(196, 22);
            HintToolStrip.Text = "도움말 (&H)";
            HintToolStrip.Click += HintToolStrip_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(489, 265);
            Controls.Add(BtnExit);
            Controls.Add(SettingsGroup);
            Controls.Add(TimerGroup);
            Controls.Add(IngameControlG);
            Controls.Add(GlobalMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = GlobalMenu;
            MaximumSize = new Size(505, 304);
            MinimumSize = new Size(505, 304);
            Name = "Form1";
            Text = "진 힐라 계산기";
            Load += Form1_Load;
            IngameControlG.ResumeLayout(false);
            DifficultyG.ResumeLayout(false);
            DifficultyG.PerformLayout();
            TimerGroup.ResumeLayout(false);
            TimerGroup.PerformLayout();
            SettingsGroup.ResumeLayout(false);
            SettingsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DeathCounter).EndInit();
            ((System.ComponentModel.ISupportInitialize)MemberCount).EndInit();
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
        private Label LabelMemberCount;
        private NumericUpDown MemberCount;
        private TextBox BoxStringCount;
        private Label LabelStringCount;
        private NumericUpDown DeathCounter;
        private Label LabelDeathCount;
        private ToolStripMenuItem 종료QToolStripMenuItem;
        private ToolTip toolTip;
        private Button BtnExit;
        private ToolStripMenuItem 라이센스LToolStripMenuItem;
        private ToolStripMenuItem HintToolStrip;
    }
}
