using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace AHO_for_windows
{
    public partial class Form1 : Form
    {
        const int SERVO_NUM = 16;
        const int POSE_NUM = 20;
        string[] ports;
        float[] neutral_angle = new float[SERVO_NUM];
        float[] min_angle = new float[SERVO_NUM];
        float[] max_angle = new float[SERVO_NUM];
        public Pose[] pose = new Pose[POSE_NUM];
        public Pose buff_pose;

        private static Form1 _form1Instance;

        public static Form1 Form1Instance
        {
            get
            {
                return _form1Instance;
            }
            set
            {
                _form1Instance = value;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1Instance = this;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            neutral_angle[0] = 114; min_angle[0] = 96; max_angle[0] = 187;
            neutral_angle[1] = 104; min_angle[1] = 48; max_angle[1] = 104;
            neutral_angle[2] = 105; min_angle[2] = 105; max_angle[2] = 169;
            neutral_angle[3] = 122; min_angle[3] = 122; max_angle[3] = 216;
            neutral_angle[4] = 132; min_angle[4] = 91; max_angle[4] = 174;
            neutral_angle[5] = 131; min_angle[5] = 64; max_angle[5] = 146;
            neutral_angle[6] = 137; min_angle[6] = 137; max_angle[6] = 213;
            neutral_angle[7] = 143; min_angle[7] = 74; max_angle[7] = 143;
            neutral_angle[8] = 123; min_angle[8] = 32; max_angle[8] = 123;
            neutral_angle[9] = 137; min_angle[9] = 137; max_angle[9] = 185;
            neutral_angle[10] = 180; min_angle[10] = 0; max_angle[10] = 180;
            neutral_angle[11] = 135; min_angle[11] = 16; max_angle[11] = 135;
            neutral_angle[12] = 16; min_angle[12] = 16; max_angle[12] = 196;
            neutral_angle[13] = 52; min_angle[13] = 52; max_angle[13] = 144;
            neutral_angle[14] = 132; min_angle[14] = 45; max_angle[14] = 227;
            neutral_angle[15] = 135; min_angle[14] = 0; max_angle[14] = 270;

            for(int i = 0; i < POSE_NUM; i++)
            {
                pose[i] = new Pose();
            }
            buff_pose = new Pose();
        }

        private void COMComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void COMComboBox_DropDown(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            ports = SerialPort.GetPortNames();
            foreach (var item in ports)
            {
                comboBox1.Items.Add(item);
            }
            
        }

        private void button1_Click(object sender, EventArgs ex)
        {
            serialPort1.Close();
            try
            {
                serialPort1.PortName = comboBox1.SelectedItem.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show("(´･ω･`)利用可能なCOMポートが選ばれていないよ\n");
                return;
            }
            try
            {
                serialPort1.BaudRate = int.Parse(comboBox2.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("(´･ω･`)無効なBaudRateだよ\n");
                return;
            }
            try
            {
                serialPort1.Open();
            }
            catch (Exception exception)
            {
                MessageBox.Show("(´･ω･`)%sが開けなかったよ\n", serialPort1.PortName);
                return;
            }
            print_log(serialPort1.PortName + "に接続しました\n");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            serialPort1.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            numericUpDown1.Value = trackBar1.Value;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            trackBar1.Value = (int)numericUpDown1.Value;
            send_angle(int.Parse(comboBox3.Text), (int)numericUpDown1.Value);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = (int)neutral_angle[int.Parse(comboBox3.Text)];
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Byte[] data = new Byte[4];
            data[0] = Convert.ToByte(0b11111111);
            data[1] = data[2] = data[3] = 0;
            try
            {
                serialPort1.Write(data, 0, 3);
            }
            catch (Exception exception)
            {
                print_log("送信時にエラーが発生しました\n");
            }

            print_log("received: ");
            for (int i = 0; i < 5; i++)
            {
                try
                {
                    if (serialPort1.BytesToRead > 0)
                    {
                        Byte value = Convert.ToByte(serialPort1.ReadByte());
                        print_log(value.ToString("X") + " ");
                        if (i == 4)
                        {
                            comboBox3.SelectedValue = value;
                        }
                    }
                    else
                    {
                        print_log("\n");
                        return;
                    }
                }
                catch (Exception exception)
                {
                    print_log("受信時にエラーが発生しました\n");
                }
            }
            print_log("\n");
        }

        public void send_angle(int id, int angle)
        {
            if(angle < min_angle[id])
            {
                angle = (int)min_angle[id];
            }else if(angle > max_angle[id])
            {
                angle = (int)max_angle[id];
            }
            angle = angle2value(angle);
            Byte[] data = new Byte[3];
            data[0] = Convert.ToByte(id | 0x80);
            data[1] = Convert.ToByte((angle >> 7) & 0b01111111);
            data[2] = Convert.ToByte(angle & 0b01111111);
            if (!serialPort1.IsOpen)
            {
                MessageBox.Show("(´･ω･`)COMポートが開かれていないよ\n");
                return;
            }

            try
            {
                serialPort1.Write(data, 0, 3);
            }
            catch (Exception exception)
            {
                print_log("送信時にエラーが発生しました\n");
            }
            print_log("send: " + data[0].ToString("X") + " " + data[1].ToString("X") + " " + data[2].ToString("X") + "\n");

            print_log("received: ");
            for (int i=0;i<6;i++) {
                try
                {
                    if(serialPort1.BytesToRead > 0)
                    {
                        Byte value = Convert.ToByte(serialPort1.ReadByte());
                        print_log(value.ToString("X") + " ");
                    }
                    else
                    {
                        print_log("\n");
                        return;
                    }
                }
                catch (Exception exception)
                {
                    print_log("受信時にエラーが発生しました\n");
                }
            }
            print_log("\n");
        }

        private int angle2value(int angle)
        {
            int value = (int)((float)angle / (270.0f) * 8000.0f + 3500.0f);
            return value;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Byte[] data = new Byte[3];
            data[0] = Convert.ToByte(Convert.ToInt32(comboBox3.SelectedValue) | 0x80);
            data[1] = 0;
            data[2] = 0;
            if (!serialPort1.IsOpen)
            {
                MessageBox.Show("(´･ω･`)COMポートが開かれていないよ\n");
                return;
            }

            try
            {
                serialPort1.Write(data, 0, 3);
            }
            catch (Exception exception)
            {
                print_log("送信時にエラーが発生しました\n");
                
            }
            print_log("send: " + data[0].ToString("X") + " " + data[1].ToString("X") + " " + data[2].ToString("X") + "\n");

            print_log("received: ");
            for (int i = 0; i < 6; i++)
            {
                try
                {
                    if (serialPort1.BytesToRead > 0)
                    {
                        Byte value = Convert.ToByte(serialPort1.ReadByte());
                        richTextBox1.Text += value.ToString("X") + " ";
                    }
                    else
                    {
                        return;
                    }
                }
                catch (Exception exception)
                {
                    print_log("受信時にエラーが発生しました\n");
                }
            }
            print_log("\n");
        }
        private void print_log(String str)
        {
            richTextBox1.AppendText(str);
            richTextBox1.Select(richTextBox1.Text.Length, 0);
            richTextBox1.ScrollToCaret();
        }

        public float get_neutral_angle(int id)
        {
            return neutral_angle[id];
        }

        public partial class Pose
        {
            public Pose()
            {
                initialize();
            }

            private int time;
            public int edit_time
            {
                set
                {
                    this.time = value;
                }
                get
                {
                    return this.time;
                }
            }
            private int[] angle;
            public void set_angle(int id, int _angle)
            {
                angle[id] = _angle;
            }
            public int get_angle(int id)
            {
                return angle[id];
            }
            private bool is_enabled;
            public void enable()
            {
                is_enabled = true;
            }
            public void disable()
            {
                is_enabled = false;
            }
            public bool be_enabled()
            {
                return is_enabled;
            }
            public void initialize()
            {
                time = 1000;
                angle = new int[SERVO_NUM];
                is_enabled = false;
                for(int i = 0; i < SERVO_NUM; i++)
                {
                    angle[i] = 135;
                }
            }
        }
        private void button18_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.set_pose_id(0);
            f.ShowDialog(this);
            f.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.set_pose_id(1);
            f.ShowDialog(this);
            f.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.set_pose_id(2);
            f.ShowDialog(this);
            f.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.set_pose_id(3);
            f.ShowDialog(this);
            f.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.set_pose_id(4);
            f.ShowDialog(this);
            f.Dispose();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.set_pose_id(5);
            f.ShowDialog(this);
            f.Dispose();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.set_pose_id(6);
            f.ShowDialog(this);
            f.Dispose();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.set_pose_id(7);
            f.ShowDialog(this);
            f.Dispose();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.set_pose_id(8);
            f.ShowDialog(this);
            f.Dispose();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.set_pose_id(9);
            f.ShowDialog(this);
            f.Dispose();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.set_pose_id(10);
            f.ShowDialog(this);
            f.Dispose();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.set_pose_id(11);
            f.ShowDialog(this);
            f.Dispose();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.set_pose_id(12);
            f.ShowDialog(this);
            f.Dispose();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.set_pose_id(13);
            f.ShowDialog(this);
            f.Dispose();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.set_pose_id(14);
            f.ShowDialog(this);
            f.Dispose();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.set_pose_id(15);
            f.ShowDialog(this);
            f.Dispose();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.set_pose_id(16);
            f.ShowDialog(this);
            f.Dispose();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.set_pose_id(17);
            f.ShowDialog(this);
            f.Dispose();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.set_pose_id(18);
            f.ShowDialog(this);
            f.Dispose();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.set_pose_id(19);
            f.ShowDialog(this);
            f.Dispose();
        }
    }
}
