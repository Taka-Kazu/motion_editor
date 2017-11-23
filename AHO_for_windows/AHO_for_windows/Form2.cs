using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AHO_for_windows
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox3.SelectedIndex = 0;
            comboBox1.SelectedIndex = 1;
            comboBox2.SelectedIndex = 2;
            comboBox4.SelectedIndex = 3;
            comboBox5.SelectedIndex = 4;
            comboBox6.SelectedIndex = 5;
            comboBox7.SelectedIndex = 6;
            comboBox8.SelectedIndex = 7;
            comboBox16.SelectedIndex = 8;
            comboBox15.SelectedIndex = 9;
            comboBox14.SelectedIndex = 10;
            comboBox13.SelectedIndex = 11;
            comboBox12.SelectedIndex = 12;
            comboBox11.SelectedIndex = 13;
            comboBox10.SelectedIndex = 14;
            comboBox9.SelectedIndex = 15;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            numericUpDown1.Value = trackBar1.Value;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            trackBar1.Value = (int)numericUpDown1.Value;
            ((Form1)this.Owner).send_angle(int.Parse(comboBox3.Text), (int)numericUpDown1.Value);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = (int)((Form1)this.Owner).get_neutral_angle(int.Parse(comboBox3.Text));
        }
    }
}
