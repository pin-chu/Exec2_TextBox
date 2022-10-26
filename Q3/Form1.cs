using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btButton_Click(object sender, EventArgs e)
        {
            DateTime dayOfBirth = Convert.ToDateTime(inputTextBox.Text);
            DateTime dt = DateTime.Today;

            var age13 = dt.AddYears(-13);

            if(age13>=dayOfBirth)
            {
                MessageBox.Show("您已滿13歲");
            }
            else MessageBox.Show("您未滿13歲");

            return;




            


        }
    }
}
