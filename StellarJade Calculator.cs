namespace test
{
    public partial class Form1 : Form
    {
        int daysSelected;
        int expressDaysYield;
        int daysYield;
        int simUniYield;
        int simUniWeeks;
        public Form1()
        {
            InitializeComponent();
            dateTimePickerStart.Format = DateTimePickerFormat.Long;
            dateTimePickerEnd.Format = DateTimePickerFormat.Long;

            dateTimePickerStart.Value = DateTime.Now;
            dateTimePickerEnd.Value = DateTime.Now.AddDays(1);
        }

        private void UpdateDaysSelected()
        {
            if (dateTimePickerEnd.Value < dateTimePickerStart.Value)
            {
                MessageBox.Show("End date must be greater / equal to start date.");
                return;
            }
            daysSelected = (dateTimePickerEnd.Value - dateTimePickerStart.Value).Days + 1; //Including starting date.
            lblDaysSelected.Text = $"Days Selected: {daysSelected}";
        }

        private void UpdateDayYield()
        {
            UpdateDaysSelected();
            daysYield = 0;
            simUniYield = 0;
            // Check if Express Pass is enabled
            if (expressPass.Checked)
            {
                // Ensure tbExpressDays.Text has a default value if empty
                string userInput = string.IsNullOrWhiteSpace(tbExpressDays.Text) ? "0" : tbExpressDays.Text;

                // Safely parse the input
                if (!int.TryParse(userInput, out int userInputEDays))
                {
                    MessageBox.Show("Please enter a valid number in Express Days.");
                    return;
                }

                int expressDays = daysSelected - userInputEDays;
                expressDaysYield = expressDays * 150;

                // Calculate days yield based on express pass usage
                if (userInputEDays >= daysSelected)
                {
                    daysYield = daysSelected * 150;  // Set to base yield if express days exceed total days
                }
                else
                {
                    expressDays = userInputEDays;
                    int regularDays = daysSelected - expressDays;
                    daysYield = (expressDays * 150) + (regularDays * 60);
                }
            }
            else
            {
                // If Express Pass is not checked, base yield calculation
                daysYield = daysSelected * 60;
            }
        }


        private void expressPass_CheckedChanged(object sender, EventArgs e)
        {
            // Show or hide the TextBox and label based on checkbox state
            tbExpressDays.Visible = expressPass.Checked;
            lblExpressActive.Visible = expressPass.Checked;

            // Only perform calculations if the checkbox is checked
            UpdateDayYield();
            UpdateDaysSelected();
        }
        private void calculateButton_Click(object sender, EventArgs e) 
        {
            UpdateDaysSelected();
            UpdateDayYield();

            lbljadesDaily.Text = $"Daily Stellar Jades: {daysYield}";
            simUniWeeks = daysSelected / 7;
            if (simUniWeeks < 1)
            {
                simUniWeeks = 1;                
            }
            else
            {
                simUniYield = simUniWeeks * 225;
            }

            lblSimUni.Text = $"Simulated Universe Weekly Stellar Jades: {simUniYield}";
        }

        private void tbExpressDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TbExpressDays_TextChanged(object sender, EventArgs e)
        {
            if (expressPass.Checked)
            {
                UpdateDayYield();
                UpdateDaysSelected();

            }
        }
        }
}
