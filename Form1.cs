using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float stopaInflacije = Convert.ToInt32(textBox1.Text);
            float novac = Convert.ToInt32(textBox2.Text);
            float godine = Convert.ToInt32(textBox3.Text);

            float worth = novac + (novac * (stopaInflacije / 100));

            for(int i = 1; i < godine; i++)
            {
                worth += worth * (stopaInflacije / 100);
            }

            MessageBox.Show("Današnjih " + novac + "€ za " + godine + " godina će vrijediti " + worth + "€");
        }
    }
}
