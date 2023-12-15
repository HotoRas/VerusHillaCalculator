namespace VerusHillaCalculator
{
    public partial class Hint : Form
    {
        public Hint()
        {
            InitializeComponent();
        }

        private void Hint_Load(object sender, EventArgs e)
        {
            tabControl1.SelectTab(HintTimer);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
