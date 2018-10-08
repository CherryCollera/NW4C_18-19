namespace Caisip_WindowsForm_Lab3
{
    public partial class Calculator : System.Windows.Forms.Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void btnCLose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnPlus_Click(object sender, System.EventArgs e)
        {
            DeclareVariable.total1 = DeclareVariable.total1 + double.Parse(txtInput.Text);
            txtInput.Clear();

            DeclareVariable.plusButtonClicked = true;
            DeclareVariable.minusButtonClicked = false;
            DeclareVariable.multiplyButtonClicked = false;
            DeclareVariable.divideButtonClicked = false;
        }

        private void btnBack_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void btnMinus_Click(object sender, System.EventArgs e)
        {
            DeclareVariable.total1 = DeclareVariable.total1 + double.Parse(txtInput.Text);
            txtInput.Clear();

            DeclareVariable.plusButtonClicked = false;
            DeclareVariable.minusButtonClicked = true;
            DeclareVariable.multiplyButtonClicked = false;
            DeclareVariable.divideButtonClicked = false;
        }

        private void btnTimes_Click(object sender, System.EventArgs e)
        {
            DeclareVariable.total1 = DeclareVariable.total1 + double.Parse(txtInput.Text);
            txtInput.Clear();

            DeclareVariable.plusButtonClicked = false;
            DeclareVariable.minusButtonClicked = false;
            DeclareVariable.multiplyButtonClicked = true;
            DeclareVariable.divideButtonClicked = false;
        }

        private void btnDivide_Click(object sender, System.EventArgs e)
        {
            DeclareVariable.total1 = DeclareVariable.total1 + double.Parse(txtInput.Text);
            txtInput.Clear();

            DeclareVariable.plusButtonClicked = false;
            DeclareVariable.minusButtonClicked = false;
            DeclareVariable.multiplyButtonClicked = false;
            DeclareVariable.divideButtonClicked = true;
        }

        private void btnOne_Click(object sender, System.EventArgs e)
        {
            txtInput.Text = txtInput.Text + btnOne.Text;
        }

        private void btnClear_Click(object sender, System.EventArgs e)
        {
            txtInput.Clear();
        }

        private void btnEquals_Click(object sender, System.EventArgs e)
        {
            if (DeclareVariable.plusButtonClicked == true)
            {
                DeclareVariable.total2 = DeclareVariable.total1 + double.Parse(txtInput.Text);
            }
            else if (DeclareVariable.minusButtonClicked == true)
            {
                DeclareVariable.total2 = DeclareVariable.total1 - double.Parse(txtInput.Text);
            }
            else if (DeclareVariable.multiplyButtonClicked == true)
            {
                DeclareVariable.total2 = DeclareVariable.total1 * double.Parse(txtInput.Text);
            }
            else if (DeclareVariable.divideButtonClicked == true)
            {
                DeclareVariable.total2 = DeclareVariable.total1 / double.Parse(txtInput.Text);
            }

            txtInput.Text = DeclareVariable.total2.ToString();
            DeclareVariable.total1 = 0;
        }

        private void btnTwo_Click(object sender, System.EventArgs e)
        {
            txtInput.Text = txtInput.Text + btnTwo.Text;
        }

        private void btnThree_Click(object sender, System.EventArgs e)
        {
            txtInput.Text = txtInput.Text + btnThree.Text;
        }

        private void btnFour_Click(object sender, System.EventArgs e)
        {
            txtInput.Text = txtInput.Text + btnFour.Text;
        }

        private void btnFive_Click(object sender, System.EventArgs e)
        {
            txtInput.Text = txtInput.Text + btnFive.Text;
        }

        private void btnSix_Click(object sender, System.EventArgs e)
        {
            txtInput.Text = txtInput.Text + btnSix.Text;
        }

        private void btnSeven_Click(object sender, System.EventArgs e)
        {
            txtInput.Text = txtInput.Text + btnSeven.Text;
        }

        private void btnEight_Click(object sender, System.EventArgs e)
        {
            txtInput.Text = txtInput.Text + btnEight.Text;
        }

        private void btnNine_Click(object sender, System.EventArgs e)
        {
            txtInput.Text = txtInput.Text + btnNine.Text;
        }

        private void btnZero_Click(object sender, System.EventArgs e)
        {
            txtInput.Text = txtInput.Text + btnZero.Text;
        }

        private void btnPoint_Click(object sender, System.EventArgs e)
        {
            txtInput.Text = txtInput.Text + btnPoint.Text;
        }
    }
}
