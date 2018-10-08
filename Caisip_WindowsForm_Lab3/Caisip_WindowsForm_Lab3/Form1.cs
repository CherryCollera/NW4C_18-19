namespace Caisip_WindowsForm_Lab3
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void btnCalculator_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            Calculator calcu = new Calculator();
            calcu.ShowDialog();
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnDisplay_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Hello World!");
        }
    }
}
