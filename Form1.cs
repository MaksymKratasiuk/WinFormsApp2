namespace WinFormsApp2
{
    public partial class Form1 : Form
    {

        private int hours;
        private int minutes;
        private int seconds;
        private DateTime eventDate;
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            hours = int.Parse(textBox1.Text);
            minutes = int.Parse(textBox2.Text);
            seconds = int.Parse(textBox3.Text);

            eventDate = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, hours, minutes, seconds);

            timer1.Start();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now != eventDate)
            {
                if (seconds <= 0)
                {
                    minutes--;
                    seconds = 60;
                }
                if (minutes < 0)
                {
                    hours--;
                    minutes = 59;
                }
                if (hours < 0)
                {
                    hours += 23;
                }
                seconds--;
                textBox1.Text = $"{hours}";
                textBox2.Text = $"{minutes}";
                textBox3.Text = $"{seconds}";

            }
            else
            {
                timer1.Stop();
                MessageBox.Show(textBox_message.Text, "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}