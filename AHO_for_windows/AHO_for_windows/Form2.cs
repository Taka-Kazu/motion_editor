﻿using System;
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

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            numericUpDown2.Value = trackBar2.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            trackBar2.Value = (int)numericUpDown2.Value;
            ((Form1)this.Owner).send_angle(int.Parse(comboBox1.Text), (int)numericUpDown2.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numericUpDown2.Value = (int)((Form1)this.Owner).get_neutral_angle(int.Parse(comboBox1.Text));
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            numericUpDown3.Value = trackBar3.Value;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            trackBar3.Value = (int)numericUpDown3.Value;
            ((Form1)this.Owner).send_angle(int.Parse(comboBox2.Text), (int)numericUpDown3.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numericUpDown3.Value = (int)((Form1)this.Owner).get_neutral_angle(int.Parse(comboBox2.Text));
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            numericUpDown4.Value = trackBar4.Value;
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            trackBar4.Value = (int)numericUpDown4.Value;
            ((Form1)this.Owner).send_angle(int.Parse(comboBox4.Text), (int)numericUpDown4.Value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            numericUpDown4.Value = (int)((Form1)this.Owner).get_neutral_angle(int.Parse(comboBox4.Text));
        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            numericUpDown5.Value = trackBar5.Value;
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            trackBar5.Value = (int)numericUpDown5.Value;
            ((Form1)this.Owner).send_angle(int.Parse(comboBox5.Text), (int)numericUpDown5.Value);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            numericUpDown5.Value = (int)((Form1)this.Owner).get_neutral_angle(int.Parse(comboBox5.Text));
        }

        private void trackBar6_Scroll(object sender, EventArgs e)
        {
            numericUpDown6.Value = trackBar6.Value;
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            trackBar6.Value = (int)numericUpDown6.Value;
            ((Form1)this.Owner).send_angle(int.Parse(comboBox6.Text), (int)numericUpDown6.Value);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            numericUpDown6.Value = (int)((Form1)this.Owner).get_neutral_angle(int.Parse(comboBox6.Text));
        }

        private void trackBar7_Scroll(object sender, EventArgs e)
        {
            numericUpDown7.Value = trackBar7.Value;
        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            trackBar7.Value = (int)numericUpDown7.Value;
            ((Form1)this.Owner).send_angle(int.Parse(comboBox7.Text), (int)numericUpDown7.Value);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            numericUpDown7.Value = (int)((Form1)this.Owner).get_neutral_angle(int.Parse(comboBox7.Text));
        }

        private void trackBar8_Scroll(object sender, EventArgs e)
        {
            numericUpDown8.Value = trackBar8.Value;
        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {
            trackBar8.Value = (int)numericUpDown8.Value;
            ((Form1)this.Owner).send_angle(int.Parse(comboBox8.Text), (int)numericUpDown8.Value);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            numericUpDown8.Value = (int)((Form1)this.Owner).get_neutral_angle(int.Parse(comboBox8.Text));
        }

        private void trackBar16_Scroll(object sender, EventArgs e)
        {
            numericUpDown16.Value = trackBar16.Value;
        }

        private void numericUpDown16_ValueChanged(object sender, EventArgs e)
        {
            trackBar16.Value = (int)numericUpDown16.Value;
            ((Form1)this.Owner).send_angle(int.Parse(comboBox16.Text), (int)numericUpDown16.Value);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            numericUpDown16.Value = (int)((Form1)this.Owner).get_neutral_angle(int.Parse(comboBox16.Text));
        }

        private void trackBar15_Scroll(object sender, EventArgs e)
        {
            numericUpDown15.Value = trackBar15.Value;
        }

        private void numericUpDown15_ValueChanged(object sender, EventArgs e)
        {
            trackBar15.Value = (int)numericUpDown15.Value;
            ((Form1)this.Owner).send_angle(int.Parse(comboBox15.Text), (int)numericUpDown15.Value);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            numericUpDown15.Value = (int)((Form1)this.Owner).get_neutral_angle(int.Parse(comboBox15.Text));
        }

        private void trackBar14_Scroll(object sender, EventArgs e)
        {
            numericUpDown14.Value = trackBar14.Value;
        }

        private void numericUpDown14_ValueChanged(object sender, EventArgs e)
        {
            trackBar14.Value = (int)numericUpDown14.Value;
            ((Form1)this.Owner).send_angle(int.Parse(comboBox14.Text), (int)numericUpDown14.Value);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            numericUpDown14.Value = (int)((Form1)this.Owner).get_neutral_angle(int.Parse(comboBox14.Text));
        }

        private void trackBar13_Scroll(object sender, EventArgs e)
        {
            numericUpDown13.Value = trackBar13.Value;
        }

        private void numericUpDown13_ValueChanged(object sender, EventArgs e)
        {
            trackBar13.Value = (int)numericUpDown13.Value;
            ((Form1)this.Owner).send_angle(int.Parse(comboBox13.Text), (int)numericUpDown13.Value);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            numericUpDown13.Value = (int)((Form1)this.Owner).get_neutral_angle(int.Parse(comboBox13.Text));
        }

        private void trackBar12_Scroll(object sender, EventArgs e)
        {
            numericUpDown12.Value = trackBar12.Value;
        }

        private void numericUpDown12_ValueChanged(object sender, EventArgs e)
        {
            trackBar12.Value = (int)numericUpDown12.Value;
            ((Form1)this.Owner).send_angle(int.Parse(comboBox12.Text), (int)numericUpDown12.Value);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            numericUpDown12.Value = (int)((Form1)this.Owner).get_neutral_angle(int.Parse(comboBox12.Text));
        }

        private void trackBar11_Scroll(object sender, EventArgs e)
        {
            numericUpDown11.Value = trackBar11.Value;
        }

        private void numericUpDown11_ValueChanged(object sender, EventArgs e)
        {
            trackBar11.Value = (int)numericUpDown11.Value;
            ((Form1)this.Owner).send_angle(int.Parse(comboBox11.Text), (int)numericUpDown11.Value);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            numericUpDown11.Value = (int)((Form1)this.Owner).get_neutral_angle(int.Parse(comboBox11.Text));
        }

        private void trackBar10_Scroll(object sender, EventArgs e)
        {
            numericUpDown10.Value = trackBar10.Value;
        }

        private void numericUpDown10_ValueChanged(object sender, EventArgs e)
        {
            trackBar10.Value = (int)numericUpDown10.Value;
            ((Form1)this.Owner).send_angle(int.Parse(comboBox10.Text), (int)numericUpDown10.Value);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            numericUpDown10.Value = (int)((Form1)this.Owner).get_neutral_angle(int.Parse(comboBox10.Text));
        }

        private void trackBar9_Scroll(object sender, EventArgs e)
        {
            numericUpDown9.Value = trackBar9.Value;
        }

        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {
            trackBar9.Value = (int)numericUpDown9.Value;
            ((Form1)this.Owner).send_angle(int.Parse(comboBox9.Text), (int)numericUpDown9.Value);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            numericUpDown9.Value = (int)((Form1)this.Owner).get_neutral_angle(int.Parse(comboBox9.Text));
        }
    }
}