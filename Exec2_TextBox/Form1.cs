using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_TextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trybutton_Click(object sender, EventArgs e)
        {
            int input=Convert.ToInt32(inputtextBox.Text);
            if (input >= 1 && input <= 99)
            {
                MessageBox.Show("數值正確");
            }
            else
            {
                MessageBox.Show("輸入錯誤");

            }
        }
    }
}
