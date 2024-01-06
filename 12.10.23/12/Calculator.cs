using System.Diagnostics;
using System.Drawing.Text;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace _12
{
    public partial class Calculator : Form
    {
        List<double> numbers = new();
        List<char> operators = new();

        public Calculator()
        {
            InitializeComponent();
        }

        private void Number1_Click(object sender, EventArgs e)
        {
            ResultBox.Text += "1";
        }

        private void Number2_Click(object sender, EventArgs e)
        {
            ResultBox.Text += "2";
        }

        private void Number3_Click(object sender, EventArgs e)
        {
            ResultBox.Text += "3";
        }

        private void Number4_Click(object sender, EventArgs e)
        {
            ResultBox.Text += "4";
        }

        private void Number5_Click(object sender, EventArgs e)
        {
            ResultBox.Text += "5";
        }

        private void Number6_Click(object sender, EventArgs e)
        {
            ResultBox.Text += "6";
        }

        private void Number7_Click(object sender, EventArgs e)
        {
            ResultBox.Text += "7";
        }

        private void Number8_Click(object sender, EventArgs e)
        {
            ResultBox.Text += "8";
        }

        private void Number9_Click(object sender, EventArgs e)
        {
            ResultBox.Text += "9";
        }

        private void Number0_Click(object sender, EventArgs e)
        {
            ResultBox.Text += "0";
        }

        private void Addition_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text.Length != 0)
                AddNumberAndOperator((Button)sender);
        }

        private void Subtraction_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text.Length != 0)
                AddNumberAndOperator((Button)sender);
        }

        private void Multiplication_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text.Length != 0)
                AddNumberAndOperator((Button)sender);
        }

        private void Division_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text.Length != 0)
                AddNumberAndOperator((Button)sender);
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text.Length != 0)
            {
                if (ResultBox.Text[0] != '-')
                    ResultBox.Text = $"-{ResultBox.Text}";
                else
                    ResultBox.Text = ResultBox.Text.TrimStart('-');
            }
        }

        private void Point_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text.Length > 0 && (int)ResultBox.Text[ResultBox.Text.Length - 1] >= 48
              && (int)ResultBox.Text[ResultBox.Text.Length - 1] <= 57)
            {
                if (!ResultBox.Text.Contains('.'))
                    ResultBox.Text += '.';
            }
        }

        private void Equally_Click(object sender, EventArgs e)
        {
            if (numbers.Count >= 1)
            {
                try
                {
                    numbers.Add(double.Parse(ResultBox.Text));
                    ResultBox.Clear();
                }
                catch (Exception ex) { }

                string a = "";
                a += numbers[0];
                for (int i = 0; i < operators.Count; i++)
                {
                    a += $"{operators[i]}{numbers[i + 1]}";
                }


                if (numbers.Count == operators.Count)
                    operators.RemoveAt(operators.Count - 1);

                void remove(ref int i)
                {
                    numbers.RemoveAt(i + 1);
                    operators.RemoveAt(i);
                    i--;
                }

                for (int i = 0; i < operators.Count; i++)
                {
                    if (operators[i] == '*')
                    {
                        if (i < numbers.Count - 1)
                        {
                            numbers[i] = numbers[i] * numbers[i + 1];
                            remove(ref i);
                        }
                    }
                    else if (operators[i] == '/')
                    {
                        if (i < numbers.Count - 1)
                        {
                            numbers[i] = numbers[i] / numbers[i + 1];
                            remove(ref i);
                        }
                    }
                }

                if (numbers.Count > 1)
                {
                    for (int i = 0; i < operators.Count; i++)
                    {
                        if (operators[i] == '+')
                        {
                            numbers[i] = numbers[i] + numbers[i + 1];
                            remove(ref i);
                        }
                        else
                        {
                            numbers[i] = numbers[i] - numbers[i + 1];
                            remove(ref i);
                        }
                    }
                }
                a += $" = {numbers[0]}";

                ResultBox.Text = a;
                numbers.Clear();
                operators.Clear();
            }
        }

        private void AddNumberAndOperator(Button sender)
        {
            try
            {
                numbers.Add(double.Parse(ResultBox.Text));
                ResultBox.Clear();
                operators.Add(char.Parse(sender.Text));
            }
            catch (Exception e)
            {
                operators[operators.Count - 1] = char.Parse(sender.Text);
            }
        }

        private void C_Click(object sender, EventArgs e)
        {
            numbers.Clear();
            operators.Clear();
            ResultBox.Clear();
        }

        private void Backspace_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text.Length > 0)
            {
                ResultBox.Text = ResultBox.Text.Remove(ResultBox.Text.Length - 1);
            }
        }

        private void Mugivara_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://jut.su/oneepiece/episode-1.html",
                UseShellExecute = true
            });
        }
    }
}