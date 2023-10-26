namespace _3rdLesson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value;
            DateTime currentDate = DateTime.Now;

            TimeSpan timeDifference = selectedDate - currentDate;

            double result = 0;
            if (radioButtonYears.Checked)
            {
                result = timeDifference.TotalDays / 365.25;
                labelResult.Text = $"�������� {result:F2} ��� �� ��������� ����.";
            }
            else if (radioButtonMonths.Checked)
            {
                result = timeDifference.TotalDays / 30.44;
                labelResult.Text = $"�������� {result:F2} ������� �� ��������� ����.";
            }
            else if (radioButtonDays.Checked)
            {
                result = timeDifference.TotalDays;
                labelResult.Text = $"�������� {result:F2} ���� �� ��������� ����.";
            }
            else if (radioButtonMinutes.Checked)
            {
                result = timeDifference.TotalMinutes;
                labelResult.Text = $"�������� {result:F2} ����� �� ��������� ����.";
            }
            else if (radioButtonSeconds.Checked)
            {
                result = timeDifference.TotalSeconds;
                labelResult.Text = $"�������� {result:F2} ������ �� ��������� ����.";
            }
        }

    }
}