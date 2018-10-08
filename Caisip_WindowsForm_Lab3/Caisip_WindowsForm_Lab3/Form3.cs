
namespace Caisip_WindowsForm_Lab3
{
    public partial class Form3 : System.Windows.Forms.Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void btnSum_Click(object sender, System.EventArgs e)
        {
            if (txtFirst.Text == "" && txtSecond.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Please Input Some Value in the TextBox");
            }
            else {
                if (DeclareVariable.IntButtonClicked == true)
                {
                    try
                    {
                        DeclareVariable.total = System.Convert.ToInt32(txtFirst.Text) + System.Convert.ToInt32(txtSecond.Text);
                        txtFirst.Clear();
                        txtSecond.Clear();
                        System.Windows.Forms.MessageBox.Show("The answer is: " + DeclareVariable.total);
                    }
                    catch (System.FormatException)
                    {
                        txtFirst.Clear();
                        txtSecond.Clear();
                        System.Windows.Forms.MessageBox.Show("The format is incorrect!");
                    }
                }
                else if (DeclareVariable.DoubleButtonClicked == true)
                {
                    try
                    {
                        DeclareVariable.total = System.Convert.ToDouble(txtFirst.Text) + System.Convert.ToDouble(txtSecond.Text);
                        txtFirst.Clear();
                        txtSecond.Clear();
                        System.Windows.Forms.MessageBox.Show("The answer is: " + DeclareVariable.total);
                    }
                    catch (System.FormatException)
                    {
                        txtFirst.Clear();
                        txtSecond.Clear();
                        System.Windows.Forms.MessageBox.Show("The format is incorrect!");
                    }
                }
                else if (DeclareVariable.FloatButtonClicked == true)
                {
                    try
                    {
                        DeclareVariable.total = float.Parse(txtFirst.Text, System.Globalization.CultureInfo.InvariantCulture.NumberFormat) + float.Parse(txtSecond.Text, System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
                        txtFirst.Clear();
                        txtSecond.Clear();
                        System.Windows.Forms.MessageBox.Show("The answer is: " + DeclareVariable.total);
                    }
                    catch (System.FormatException)
                    {
                        txtFirst.Clear();
                        txtSecond.Clear();
                        System.Windows.Forms.MessageBox.Show("The format is incorrect!");
                    }
                }
            }
        }

        private void btnInteger_Click(object sender, System.EventArgs e)
        {
            DeclareVariable.IntButtonClicked = true;
            DeclareVariable.DoubleButtonClicked = false;
            DeclareVariable.FloatButtonClicked = false;
        }

        private void btnDouble_Click(object sender, System.EventArgs e)
        {
            DeclareVariable.IntButtonClicked = false;
            DeclareVariable.DoubleButtonClicked = true;
            DeclareVariable.FloatButtonClicked = false;
        }

        private void btnFloat_Click(object sender, System.EventArgs e)
        {
            DeclareVariable.IntButtonClicked = false;
            DeclareVariable.DoubleButtonClicked = false;
            DeclareVariable.FloatButtonClicked = true;
        }
    }
}
