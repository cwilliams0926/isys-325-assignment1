namespace isys_325_assignment1
{
    public partial class Assignment1 : Form
    {
        private const double PAY = 10.50;
        private string firstNameString;
        private string lastNameString;
        private double hoursWorkedDouble;
        public Assignment1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void firstName_TextChanged(object sender, EventArgs e)
        {
            firstNameString = firstName.Text;
        }

        private void lastName_TextChanged(object sender, EventArgs e)
        {
            lastNameString = lastName.Text;
        }

        private void hoursWorked_TextChanged(object sender, EventArgs e)
        {
            try
            {
                hoursWorkedDouble = double.Parse(hoursWorked.Text);
                summaryLabel.ForeColor = Color.Black;
                summaryLabel.Text = "";
            }
            catch (Exception)
            {
                summaryLabel.ForeColor = Color.Red;
                summaryLabel.Text = "Invalid number of hours.";
            }
        }

        private void summarizeButton_Click(object sender, EventArgs e)
        {
            String summary = $"{firstNameString} {lastNameString} worked {hoursWorkedDouble} hours at ${PAY:F2} an hour for a total of ${PAY * hoursWorkedDouble:F2}";
            summaryLabel.Text = summary;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            firstName.Text = "";
            firstNameString = "";
            lastName.Text = "";
            lastNameString = "";
            hoursWorked.Text = "";
            hoursWorkedDouble = 0;
            summaryLabel.Text = "";
        }
    }
}
