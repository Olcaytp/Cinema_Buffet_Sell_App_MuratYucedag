using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_Buffet_Sell_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        int cashBox = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            int corn, tea, water, ticket, total;
            corn = Convert.ToInt16(textBox1.Text);
            tea = Convert.ToInt16(textBox2.Text);
            water = Convert.ToInt16(textBox3.Text);
            ticket = Convert.ToInt16(textBox4.Text);

            total = (corn * 30) + (tea * 20) + (water * 5) + (ticket * 50);

            label15.Text = total.ToString() + " TL";

            cashBox += total;
            label16.Text = cashBox.ToString() + " TL";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();
        }
    }
}
