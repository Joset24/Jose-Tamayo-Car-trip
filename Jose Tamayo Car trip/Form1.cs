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
           
            txtNumberofGallon.Clear();
            txtTravel.Clear();
            txtMGP.Clear();
            listbox.Items.Clear();
            

        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            // variables need to be daclared with data type - string
            
            int NumberofGallon;
            int Travel;
            int MGP;



            // input
            // Read from the txtbox into the variable
            
               Travel =int.Parse(txtTravel.Text);
               MGP = int.Parse(txtMGP.Text);
               NumberofGallon = Travel/MGP;

            // Output - every variable
            
            listbox.Items.Clear();
            listbox.Items.Add(NumberofGallon.ToString());




            btnReset.Focus();
        }

        private void btnCal_Leave(object sender, EventArgs e)
        {

        }

        
        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
