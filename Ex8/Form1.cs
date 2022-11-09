using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex8
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            NoButton.Location = new Point(random.Next(0, this.ClientSize.Width - NoButton.Width) ,
                                          random.Next(0, this.ClientSize.Height - NoButton.Height));
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Здорово!");
        }
    }
}
