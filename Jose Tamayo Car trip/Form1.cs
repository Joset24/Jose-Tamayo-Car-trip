namespace Jose_Tamayo_Car_trip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnReset_Click(object sender, EventArgs e)
        {

            txtDestination.Clear();
            txtDistance.Clear();
            txtMGP.Clear();
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

            distance = double.Parse(txtDistance.Text);
            mpg = int.Parse(txtMGP.Text);
            numberOfGallon = distance / mpg;

            // Output - every variable

            lstOutput.Items.Clear();
            lstOutput.Items.Add(numberOfGallon.ToString());




            btnReset.Focus();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
