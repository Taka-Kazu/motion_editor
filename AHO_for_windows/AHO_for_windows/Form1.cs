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
            //MessageBox.Show("彡(゜)(゜)");
            ports = SerialPort.GetPortNames();
            foreach (var item in ports)
            {
                COMComboBox.Items.Add(item);
            }
        }
    }
}
