namespace project1_messagebox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I'm Kathlene Ann Marasigan Panuga", "Student Information",MessageBoxButtons.OKCancel, MessageBoxIcon.Information);//simple messagebox with titles and buttons and icon with sound
            MessageBox.Show("Have a nice day!!");
        }
    }
}