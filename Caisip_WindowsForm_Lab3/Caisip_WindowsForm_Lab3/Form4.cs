namespace Caisip_WindowsForm_Lab3
{
    public partial class Form4 : System.Windows.Forms.Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void btnDisplay_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Hello " +txtDisplay.Text+ "!" );
        }
    }
}
