namespace Jose_Tamayo_Car_trip
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        // Theses are the car types Const name

        const string SUV_MODEL = "Suv Model";
        const string MINIVAN_MODEL = "Minivan Model";
        const string MICRO_MODEL = "Micro Model";
        private string CarType = SUV_MODEL;



        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult buttonSelected = MessageBox.Show(
                "are you sure you want to quit",
                 "Quitting....",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question);
            if (buttonSelected == DialogResult.Yes)
            {

                this.Close();
            }
        }



        private void btnReset_Click(object sender, EventArgs e)
        {

            txtDestination.Clear();
            txtDistance.Clear();

            lstOutput.Items.Clear();


        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            // variables need to be daclared with data type - string
            string destination;
            double numberOfGallon;
            double distance;
            double mpg = 25;

            destination = txtDestination.Text;

            // input
            // Read from the txtbox into the variable

            bool isDistanceValid = double.TryParse(txtDistance.Text, out distance);
            if (!isDistanceValid || distance < 0)

            {
                MessageBox.Show("Distance should be a Postive number", "distanceinvalid");
            }


            else
            {

                switch (CarType)
                {
                    case SUV_MODEL:
                        mpg = 25;
                        break;
                    case MICRO_MODEL:
                        mpg = 20;
                        break;
                    case MINIVAN_MODEL:
                        mpg = 30;
                        break;
                }

                numberOfGallon = distance / mpg;

                // Output - every variable

                lstOutput.Items.Clear();
                lstOutput.Items.Add("To go to " + txtDestination.Text + " " + numberOfGallon.ToString()+ " gallon");
                lstOutput.Items.Add(" Destination is ");
                lstOutput.Items.Add("Distance in miles is ");
                lstOutput.Items.Add("MPG is");
                lstOutput.Items.Add("Car Type is ");
                lstOutput.Items.Add("Gallons used is ");



                btnReset.Focus();
            }
            }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rdoSuv_CheckedChanged(object sender, EventArgs e)
        {
            CarType = SUV_MODEL;
        }

        private void rdoMinivan_CheckedChanged(object sender, EventArgs e)
        {
            CarType = MINIVAN_MODEL;
        }

        private void rdoMicro_CheckedChanged(object sender, EventArgs e)
        {
            CarType = MICRO_MODEL;
        }
    }
}
