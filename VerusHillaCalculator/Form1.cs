namespace VerusHillaCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            GlobalTimer.Interval = 1000;
            GlobalTimer.Tick += new EventHandler(GlobalTimer_Tick);
            GlobalTimer.Enabled = false;
        }

        private void InitializeTooltip()
        {
            toolTip.SetToolTip(BtnPhase,
                "현재 체력에 따라 다음 페이즈가 결정됩니다.");
            toolTip.SetToolTip(BtnStart,
                "시작하기 직전에 눌러주세요.");
        }

        private int time; // 총 남은 시간
        private int lastTime; // 페이즈 인터벌 기준 남은 시간
        private int phase; // 현재 페이즈
        // private int tempPhase; // 다음 페이즈
        private bool hardMode; // 하드 모드 여부

        private readonly int // 노멀 모드
            normal_start = 3 * 60 + 16,
            normal_phase1 = 3 * 60,
            normal_phase2 = 2 * 60 + 30;

        private readonly int // 하드 모드
            hard_start = 2 * 60 + 46,
            hard_phase1 = 2 * 60 + 32,
            hard_phase2 = 2 * 60 + 6,
            hard_phase3 = 1 * 60 + 40;

        private static void Timer(Label timerOut, int _time)
        {
            timerOut.Text
                = (_time / 60).ToString("00") + ":"
                + (_time % 60).ToString("00");
        }

        private int GetPhaseTime()
        {
            if (hardMode)
            {
                if (time > 30 * 60 - hard_start)
                    return hard_start;
                if (phase == 1)
                    return hard_phase1;
                if (phase == 2)
                    return hard_phase2;
                return hard_phase3;
            }

            if (time > 30 * 60 - normal_start)
                return normal_start;
            if (phase == 1)
                return normal_phase1;
            return normal_phase2;
        }

        private void Init()
        {
            BtnStart.Enabled = true;
            BtnPhase.Enabled = false;
            BtnFinish.Enabled = false;

            ModeNormal.Enabled = true;
            ModeHard.Enabled = true;

            ModeNormal.Checked = !hardMode;
            ModeHard.Checked = hardMode;

            MemberCount.ReadOnly = true;
            MemberCount.Enabled = true;

            DeathCounter.ReadOnly = true;
            DeathCounter.Enabled = true;
            DeathCounter.Value = 0;

            GameTimer.Text = "30:00";
            GlobalTimer.Stop();

            time = lastTime = phase = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            time = 0;
            hardMode = true;
            Init();
            InitializeTooltip();
        }

        private void OutgameControlG_Enter(object sender, EventArgs e)
        {

        }

        private void GlobalTimer_Tick(object sender, EventArgs e)
        {
            time--;
            if (time == 0)
            {
                BtnFinish_Click(sender,e);
            }
            Timer(GameTimer, time);
            int nowTime = GetPhaseTime() - lastTime + time - 2;
            if(nowTime <= 0)
            {
                lastTime = time;
            }
            Timer(NextTimer, nowTime);
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            BtnStart.Enabled = false;
            ModeNormal.Enabled = false;
            ModeHard.Enabled = false;
            BtnPhase.Enabled = true;
            BtnFinish.Enabled = true;
            MemberCount.ReadOnly = true;
            MemberCount.Enabled = false;
            time = 30 * 60;
            lastTime = time;
            Timer(GameTimer, time);
            Timer(NextTimer, 0);
            phase = 1;
            TimerGroup.Text = "실카 타이머 (다음 페이즈: " + (hardMode ? "61.0%" : "51.0%") + ")";
            GlobalTimer.Start();
        }

        private void ModeNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (ModeNormal.Checked)
            {
                ModeHard.Checked = false;
            }
            hardMode = ModeHard.Checked;
        }

        private void ModeHard_CheckedChanged(object sender, EventArgs e)
        {
            if (ModeHard.Checked)
            {
                ModeNormal.Checked = false;
            }
        }

        private void 정보IToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Form2();
            form.Show();
        }

        private void MemberCount_ValueChanged(object sender, EventArgs e)
        {
            DeathCounter.Maximum = MemberCount.Value * 4;
            BoxStringCount.Text
                = (MemberCount.Value * 5
                - (int)Math.Round(
                    (double)(
                    MemberCount.Value * 5 - DeathCounter.Value
                    ) / 3)
                - DeathCounter.Value)
                .ToString();
        }

        private void BtnPhase_Click(object sender, EventArgs e)
        {
            phase++;
            TimerGroup.Text = "실카 타이머 ";
            if (hardMode)
            {
                if (phase > 3) phase = 3;
                switch (phase)
                {
                    case 1:
                        TimerGroup.Text += "(다음 페이즈: 61.0%)";
                        break;
                    case 2:
                        TimerGroup.Text += "(다음 페이즈: 31.0%)";
                        break;
                    case 3:
                        TimerGroup.Text += "(마지막 페이즈!)";
                        break;
                    default: break;
                }
            }
            else
            {
                if (phase > 2) phase = 2;
                switch (phase)
                {
                    case 1:
                        TimerGroup.Text += "(다음 페이즈: 51.0%)";
                        break;
                    case 2:
                        TimerGroup.Text += "(마지막 페이즈!)";
                        break;
                    default: break;
                }
            }
        }

        private void BtnFinish_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void DeathCounter_ValueChanged(object sender, EventArgs e)
        {
            BoxStringCount.Text
                = (MemberCount.Value * 5
                - (int)Math.Round(
                    (double)(
                    MemberCount.Value * 5 - DeathCounter.Value
                    ) / 3)
                - DeathCounter.Value)
                .ToString();
        }

        private void 종료QToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void 라이센스LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new License();
            form.Show();
        }

        private void HintToolStrip_Click(object sender, EventArgs e)
        {
            Form form = new Hint();
            form.Show();
        }
    }
}
