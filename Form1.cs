namespace Activity_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            double grams = double.Parse(gramsBox.Text);
            double cupCalc = grams / 128; 
            String cups = cupCalc.ToString();

            cupsBox.Text = cups;

        }
    }
}