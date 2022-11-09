using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Ex9
{
    public partial class TriagleForm : Form
    {
        Random random = new Random();
        Point a;
        Point b;
        Point c;
        Point nextTop;
        Point curTop;

        Pen pen;
        Graphics Graph;
        public TriagleForm()
        {
            InitializeComponent();
            Graph = splitContainer1.Panel2.CreateGraphics();
            pen = new Pen(Color.Black);
        }

        bool successClick = false;
        int countIter = 0;

        private double Square(Point a, Point b, Point c)
        {
            double ab = Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
            double bc = Math.Sqrt(Math.Pow(b.X - c.X, 2) + Math.Pow(b.Y - c.Y, 2));
            double ca = Math.Sqrt(Math.Pow(c.X - a.X, 2) + Math.Pow(c.Y - a.Y, 2));
            double p = (ab + bc + ca) / 2;

            return Math.Sqrt(p * (p - ab) * (p - bc) * (p - ca));
        }

        private void TriagleForm_Load(object sender, EventArgs e)
        {
            a = new Point(random.Next(splitContainer1.Panel2.Width),
                random.Next(splitContainer1.Panel2.Height));

            b = new Point(random.Next(splitContainer1.Panel2.Width),
                random.Next(splitContainer1.Panel2.Height));

            c = new Point(random.Next(splitContainer1.Panel2.Width),
                random.Next(splitContainer1.Panel2.Height));

        }

        private void TriagleForm_Shown(object sender, EventArgs e)
        {
            Graph.DrawLine(pen, a, b);
            Graph.DrawLine(pen, a, c);
            Graph.DrawLine(pen, c, b);
        }

        private void TriagleForm_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!successClick)
            {
                MessageBox.Show("Выберите точку");
                return;
            }

            if (!int.TryParse(CountIterTextBox.Text, out countIter))
            {
                MessageBox.Show("Неправильно ввдено количество итераций");
                return;
            }

            Graph.Clear(Color.White);

            Graph.DrawLine(pen, a, b);
            Graph.DrawLine(pen, a, c);
            Graph.DrawLine(pen, c, b);

            Graph.DrawRectangle(pen, curTop.X, curTop.Y, 1, 1);

            for (int i = 0; i < countIter; i++)
            {
                //pen.Color = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
                int numTop = random.Next(3);
                if (numTop == 0)
                {
                    nextTop = new Point((curTop.X + a.X) / 2, (curTop.Y + a.Y) / 2);
                    Graph.DrawRectangle(pen, nextTop.X, nextTop.Y, 1, 1);
                    //Graph.DrawLine(pen, curTop, nextTop);
                    curTop = nextTop;
                }
                else if (numTop == 1)
                {
                    nextTop = new Point((curTop.X + b.X) / 2, (curTop.Y + b.Y) / 2);
                    Graph.DrawRectangle(pen, nextTop.X, nextTop.Y, 1, 1);
                    //Graph.DrawLine(pen, curTop, nextTop);
                    curTop = nextTop;
                }
                else if (numTop == 2)
                {
                    nextTop = new Point((curTop.X + c.X) / 2, (curTop.Y + c.Y) / 2);
                    Graph.DrawRectangle(pen, nextTop.X, nextTop.Y, 1, 1);
                    //Graph.DrawLine(pen, curTop, nextTop);
                    curTop = nextTop;
                }
            }
            
        }

        private void CountIterTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_MouseClick(object sender, MouseEventArgs e)
        {

            Point purpose = new Point(e.X, e.Y);
            if (Square(a, b, purpose) + Square(b, c, purpose) + Square(c, a, purpose) - Square(a, b, c) < Math.Pow(10, -8))
            {
                Graph.Clear(Color.White);

                Graph.DrawLine(pen, a, b);
                Graph.DrawLine(pen, a, c);
                Graph.DrawLine(pen, c, b);

                successClick = true;
                curTop = purpose;
                Graph.DrawRectangle(pen, curTop.X, curTop.Y, 1, 1);
            }
            else if (!successClick)
                MessageBox.Show("Нужно выбрать точку внутри треугольника");
        }

        private void NewTriangleButton_Click(object sender, EventArgs e)
        {

            Graph.Clear(Color.White);

            a = new Point(random.Next(splitContainer1.Panel2.Width),
               random.Next(splitContainer1.Panel2.Height));

            b = new Point(random.Next(splitContainer1.Panel2.Width),
                random.Next(splitContainer1.Panel2.Height));

            c = new Point(random.Next(splitContainer1.Panel2.Width),
                random.Next(splitContainer1.Panel2.Height));

            Graph.DrawLine(pen, a, b);
            Graph.DrawLine(pen, a, c);
            Graph.DrawLine(pen, c, b);

            successClick = false;
        }
    }
}
