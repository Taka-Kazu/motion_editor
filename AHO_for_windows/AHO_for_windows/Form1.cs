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
        string[] ports;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            try
            {
                serialPort1.PortName = comboBox1.Text;
            }
            catch (Exception exception)
            {
                MessageBox.Show("(´･ω･`)利用可能なCOMポートが選ばれていないよ");
                return;
            }
            try
            {
                serialPort1.BaudRate = int.Parse(comboBox2.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("(´･ω･`)無効なBaudRateだよ");
                return;
            }
            try
            {
                serialPort1.Open();
            }
            catch (Exception exception)
            {
                MessageBox.Show("(´･ω･`)%sが開けなかったよ", serialPort1.PortName);
                return;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            serialPort1.Close();
        }
    }
}
