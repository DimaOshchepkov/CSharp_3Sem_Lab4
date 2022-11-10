using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1
{
    public partial class Form1 : Form
    {
        float a = 0, b = 0, c = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                CalculateButton_Click(sender, e);
        }

        private void ATextBox_TextChanged(object sender, EventArgs e)
        {
            FirstRootLabel.Text = "?";
            SecondRootLabel.Text = "?";
        }

        private void BTextBox_TextChanged(object sender, EventArgs e)
        {
            FirstRootLabel.Text = "?";
            SecondRootLabel.Text = "?";
        }

        private void CTextBox_TextChanged(object sender, EventArgs e)
        {
            FirstRootLabel.Text = "?";
            SecondRootLabel.Text = "?";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            bool successRead = true;
            if (!float.TryParse(ATextBox.Text, out a))
            {
                successRead = false;
                MessageBox.Show("неправильно введено а");
            }

            if (!float.TryParse(BTextBox.Text, out b))
            {
                successRead = false;
                MessageBox.Show("неправильно введено b");
            }

            if (!float.TryParse(CTextBox.Text, out c))
            {
                successRead = false;
                MessageBox.Show("неправильно введено c");
            }

            if (!successRead)
                return;

            float discriminant = b * b - 4 * a * c;
            if (a == 0 && b == 0)
            {
                if (c != 0)
                {
                    MessageBox.Show("У этого уравнения нет корнней\n");
                    FirstRootLabel.Text = "-";
                    SecondRootLabel.Text = "-";
                }
                else
                {
                    FirstRootLabel.Text = "∞";
                    SecondRootLabel.Text = "∞";
                    MessageBox.Show("У этого уравнения бесконечно много корней\n");
                }

            }
            else if (a == 0 && b != 0)
            {
                FirstRootLabel.Text = (-c).ToString();
                SecondRootLabel.Text = "?";
            }
            else if (a != 0 && discriminant < 0)
            {
                MessageBox.Show("На данный момент программа находит только действительные корни\n");
                FirstRootLabel.Text = "?";
                SecondRootLabel.Text = "?";
            }
            else if (a != 0 && discriminant >= 0)
            {
                FirstRootLabel.Text = ((-b + Math.Sqrt(discriminant)) / (2 * a)).ToString("F4");
                SecondRootLabel.Text = ((-b - Math.Sqrt(discriminant)) / (2 * a)).ToString("F4");
            }
        }
    }
}
