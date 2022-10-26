using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gobutton_Click(object sender, EventArgs e)
        {
            

            DateTime dateTime=Convert.ToDateTime(inputTextBox.Text);
            DateTime today = DateTime.Today;

            if(dateTime<today)
            {
                MessageBox.Show("日期不大於今天");
            }
            else
            {
                MessageBox.Show("日期大於今天");
            }
            return;
            

            


        }
    }
}
