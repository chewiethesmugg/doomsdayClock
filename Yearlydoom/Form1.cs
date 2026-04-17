using System.Diagnostics;



namespace Yearlydoom
{
    public partial class Form1 : Form
    {
        //this is a widget, no ON CLICK EVENTS!
        public Form1()
        {

            InitializeComponent();


            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
         
            this.BackColor = Color.Transparent;
            this.TransparencyKey = Color.Transparent;

            //calculate days passed 
            var passed = daysPassed();
            var daysInYear = DateTime.IsLeapYear(DateTime.Today.Year) ? 366 : 365;

            //days left and update displays
            var daysLeft = daysInYear - passed;
            Debug.WriteLine(daysLeft.ToString());

            lbOutput.Text = daysLeft.ToString();
            Debug.WriteLine("days left: " + daysLeft + "days in year: " + daysInYear);
            Debug.WriteLine("days passed: " + passed);
            float percentage = (float)passed / (float)daysInYear;
            Debug.WriteLine(percentage);

            progressBar.Maximum = 100;
            progressBar.Minimum = 0;
            progressBar.Value = (int)(percentage*100);

            lbOutput.Text=passed + "     Days Gone";
            
        }

        protected override void OnPaintBackground(PaintEventArgs e) { /* Ignore */ }

        private void label1_Click(object sender, EventArgs e)
        {

        }


       
        private void progressBar_Click(object sender, EventArgs e)
        {
           
        }

        private void dataDisplay_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private static int daysPassed()
        {
            var startDate = new DateTime(DateTime.Today.Year, 1, 1);
            var currentDate = DateTime.Today;
            return currentDate.Subtract(startDate).Days;
        }
    }
}
