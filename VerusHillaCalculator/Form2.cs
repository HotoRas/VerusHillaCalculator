﻿namespace VerusHillaCalculator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnMIT_Click(object sender, EventArgs e)
        {
            Form form = new License();
            form.Show();
        }
    }
}
