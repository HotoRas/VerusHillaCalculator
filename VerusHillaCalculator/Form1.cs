namespace VerusHillaCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int time;
        private int lastTime;
        private int phase;
        private bool hardMode;

        private readonly int
            normal_start = 3 * 60 + 16,
            normal_phase1 = 3 * 60,
            normal_phase2 = 2 * 60 + 30;

        private readonly int
            hard_start = 2 * 60 + 46,
            hard_phase1 = 2 * 60 + 32,
            hard_phase2 = 2 * 60 + 6,
            hard_phase3 = 1 * 60 + 40;

        private static void Timer(Label timerOut, int _time)
        {
            timerOut.Text = (_time / 60).ToString() + ":" + (_time % 60).ToString();
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

            GameTimer.Text = "00:00";
            GlobalTimer.Enabled = false;
            GlobalTimer.Stop();

            time = lastTime = phase = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            time = 0;
            hardMode = true;
            Init();
        }

        private void OutgameControlG_Enter(object sender, EventArgs e)
        {

        }

        private void GlobalTimer_Tick(object sender, EventArgs e)
        {
            time--;
            Timer(GameTimer, time);
            Timer(NextTimer, GetPhaseTime() - lastTime + time);
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            BtnStart.Enabled = false;
            ModeNormal.Enabled = false;
            ModeHard.Enabled = false;
            BtnPhase.Enabled = true;
            BtnFinish.Enabled = true;
            time = 30 * 60;
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

        private void Á¤º¸IToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }
    }
}
