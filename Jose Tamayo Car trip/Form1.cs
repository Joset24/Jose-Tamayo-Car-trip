namespace Jose_Tamayo_Car_trip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstOut_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCustomerName.Clear();
            txtNumGallon

        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            // variables need to be daclared with data type - string
            string customerName;
            int numQallons;


            // Read from the text into the variable
            customerName = txtCustomerName.Text;


            btnReset.Focus();
        }

        private void btnCal_Leave(object sender, EventArgs e)
        {

        }

        private void txtCustomerName_Enter(object sender, EventArgs e)
        {
            txtCustomerName.BackColor = Color.Beige;
        }

        private void txtCustomerName_Leave(object sender, EventArgs e)
        {
            txtCustomerName.BackColor = SystemColors.Window;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
