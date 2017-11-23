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

        int pose_id = 0;
        public void set_pose_id(int id)
        {
            pose_id = id;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            update();
        }

        private void update()
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

            textBox1.Text = ((Form1)this.Owner).pose[pose_id].edit_time.ToString();
            checkBox1.Checked = ((Form1)this.Owner).pose[pose_id].be_enabled();
            trackBar1.Value = ((Form1)this.Owner).pose[pose_id].get_angle(0);
            trackBar2.Value = ((Form1)this.Owner).pose[pose_id].get_angle(1);
            trackBar3.Value = ((Form1)this.Owner).pose[pose_id].get_angle(2);
            trackBar4.Value = ((Form1)this.Owner).pose[pose_id].get_angle(3);
            trackBar5.Value = ((Form1)this.Owner).pose[pose_id].get_angle(4);
            trackBar6.Value = ((Form1)this.Owner).pose[pose_id].get_angle(5);
            trackBar7.Value = ((Form1)this.Owner).pose[pose_id].get_angle(6);
            trackBar8.Value = ((Form1)this.Owner).pose[pose_id].get_angle(7);
            trackBar16.Value = ((Form1)this.Owner).pose[pose_id].get_angle(8);
            trackBar15.Value = ((Form1)this.Owner).pose[pose_id].get_angle(9);
            trackBar14.Value = ((Form1)this.Owner).pose[pose_id].get_angle(10);
            trackBar13.Value = ((Form1)this.Owner).pose[pose_id].get_angle(11);
            trackBar12.Value = ((Form1)this.Owner).pose[pose_id].get_angle(12);
            trackBar11.Value = ((Form1)this.Owner).pose[pose_id].get_angle(13);
            trackBar10.Value = ((Form1)this.Owner).pose[pose_id].get_angle(14);
            trackBar9.Value = ((Form1)this.Owner).pose[pose_id].get_angle(15);

            numericUpDown1.Value = ((Form1)this.Owner).pose[pose_id].get_angle(0);
            numericUpDown2.Value = ((Form1)this.Owner).pose[pose_id].get_angle(1);
            numericUpDown3.Value = ((Form1)this.Owner).pose[pose_id].get_angle(2);
            numericUpDown4.Value = ((Form1)this.Owner).pose[pose_id].get_angle(3);
            numericUpDown5.Value = ((Form1)this.Owner).pose[pose_id].get_angle(4);
            numericUpDown6.Value = ((Form1)this.Owner).pose[pose_id].get_angle(5);
            numericUpDown7.Value = ((Form1)this.Owner).pose[pose_id].get_angle(6);
            numericUpDown8.Value = ((Form1)this.Owner).pose[pose_id].get_angle(7);
            numericUpDown16.Value = ((Form1)this.Owner).pose[pose_id].get_angle(8);
            numericUpDown15.Value = ((Form1)this.Owner).pose[pose_id].get_angle(9);
            numericUpDown14.Value = ((Form1)this.Owner).pose[pose_id].get_angle(10);
            numericUpDown13.Value = ((Form1)this.Owner).pose[pose_id].get_angle(11);
            numericUpDown12.Value = ((Form1)this.Owner).pose[pose_id].get_angle(12);
            numericUpDown11.Value = ((Form1)this.Owner).pose[pose_id].get_angle(13);
            numericUpDown10.Value = ((Form1)this.Owner).pose[pose_id].get_angle(14);
            numericUpDown9.Value = ((Form1)this.Owner).pose[pose_id].get_angle(15);

            label36.Text = pose_id.ToString();
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

        private void save()
        {
            ((Form1)this.Owner).pose[pose_id].edit_time = int.Parse(textBox1.Text);
            if (checkBox1.Checked)
            {
                ((Form1)this.Owner).pose[pose_id].enable();
            }
            else
            {
                ((Form1)this.Owner).pose[pose_id].disable();
            }
            ((Form1)this.Owner).pose[pose_id].set_angle(0, trackBar1.Value);
            ((Form1)this.Owner).pose[pose_id].set_angle(1, trackBar2.Value);
            ((Form1)this.Owner).pose[pose_id].set_angle(2, trackBar3.Value);
            ((Form1)this.Owner).pose[pose_id].set_angle(3, trackBar4.Value);
            ((Form1)this.Owner).pose[pose_id].set_angle(4, trackBar5.Value);
            ((Form1)this.Owner).pose[pose_id].set_angle(5, trackBar6.Value);
            ((Form1)this.Owner).pose[pose_id].set_angle(6, trackBar7.Value);
            ((Form1)this.Owner).pose[pose_id].set_angle(7, trackBar8.Value);
            ((Form1)this.Owner).pose[pose_id].set_angle(8, trackBar16.Value);
            ((Form1)this.Owner).pose[pose_id].set_angle(9, trackBar15.Value);
            ((Form1)this.Owner).pose[pose_id].set_angle(10, trackBar14.Value);
            ((Form1)this.Owner).pose[pose_id].set_angle(11, trackBar13.Value);
            ((Form1)this.Owner).pose[pose_id].set_angle(12, trackBar12.Value);
            ((Form1)this.Owner).pose[pose_id].set_angle(13, trackBar11.Value);
            ((Form1)this.Owner).pose[pose_id].set_angle(14, trackBar10.Value);
            ((Form1)this.Owner).pose[pose_id].set_angle(15, trackBar9.Value);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                try
                {
                    ((Form1)this.Owner).pose[pose_id].edit_time = Convert.ToInt32(textBox1.Text);
                }
                catch (Exception exception)
                {
                    MessageBox.Show("(´･ω･`)100[ms]以上の時間を入力してね\n");
                    return;
                }
                save();
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            save();
            if (((Form1)this.Owner).pose[pose_id].edit_time < 100)
            {
                MessageBox.Show("(´･ω･`)100[ms]以上の時間を入力してね\n");
                e.Cancel = true;
                return;
            }
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            save();
            int loop = ((Form1)this.Owner).pose[pose_id].edit_time / 100;
            int[] d_theta = new int[20];
            for(int i = 0; i < 20; i++)
            {
                d_theta[i] = (int)((float)(((Form1)this.Owner).pose[pose_id].get_angle(i)) / loop);
            }
            for (int i=0;i<loop ;i++)
            {

                Task.Delay(100);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            save();
            ((Form1)this.Owner).buff_pose.edit_time = ((Form1)this.Owner).pose[pose_id].edit_time;
            if (((Form1)this.Owner).pose[pose_id].be_enabled())
            {
                ((Form1)this.Owner).buff_pose.enable();
            }
            else
            {
                ((Form1)this.Owner).buff_pose.disable();
            }
            for(int i= 0; i < 16; i++)
            {
                ((Form1)this.Owner).buff_pose.set_angle(i, ((Form1)this.Owner).pose[pose_id].get_angle(i));
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            ((Form1)this.Owner).pose[pose_id].edit_time = ((Form1)this.Owner).buff_pose.edit_time;
            if (((Form1)this.Owner).buff_pose.be_enabled())
            {
                ((Form1)this.Owner).pose[pose_id].enable();
            }
            else
            {
                ((Form1)this.Owner).pose[pose_id].disable();
            }
            for (int i = 0; i < 16; i++)
            {
                ((Form1)this.Owner).pose[pose_id].set_angle(i, ((Form1)this.Owner).buff_pose.get_angle(i));
            }
            update();
        }
    }
}
