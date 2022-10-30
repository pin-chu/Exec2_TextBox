using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
		private void CalcButton_Click(object sender, EventArgs e)
		{
            int cars = Convert.ToInt32(CinputTextBox.Text);
            int people = Convert.ToInt32(PinputTextBox.Text);

            const int carsfee = 200;
            const int peoplefee = 60;
            var carstotal = cars * carsfee;
            var peopletotal = people * peoplefee;
            if (carstotal < peopletotal)
            {
                MessageBox.Show("總計:" + carstotal);
            }
            else
            {
                MessageBox.Show("總計:" + peopletotal);
            }


            
		}
	}
}
