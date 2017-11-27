namespace AHO_for_windows
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新規ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button25 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.button23 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.Parity = System.IO.Ports.Parity.Even;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "COM1"});
            this.comboBox1.Location = new System.Drawing.Point(20, 40);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(149, 26);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.DropDown += new System.EventHandler(this.COMComboBox_DropDown);
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.COMComboBox_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1173, 35);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新規ToolStripMenuItem,
            this.開くToolStripMenuItem,
            this.保存SToolStripMenuItem});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(94, 29);
            this.ファイルToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // 新規ToolStripMenuItem
            // 
            this.新規ToolStripMenuItem.Name = "新規ToolStripMenuItem";
            this.新規ToolStripMenuItem.Size = new System.Drawing.Size(213, 30);
            this.新規ToolStripMenuItem.Text = "新規(&N)";
            this.新規ToolStripMenuItem.Click += new System.EventHandler(this.新規ToolStripMenuItem_Click);
            // 
            // 開くToolStripMenuItem
            // 
            this.開くToolStripMenuItem.Name = "開くToolStripMenuItem";
            this.開くToolStripMenuItem.Size = new System.Drawing.Size(213, 30);
            this.開くToolStripMenuItem.Text = "開く(&O)";
            this.開くToolStripMenuItem.Click += new System.EventHandler(this.開くToolStripMenuItem_Click);
            // 
            // 保存SToolStripMenuItem
            // 
            this.保存SToolStripMenuItem.Name = "保存SToolStripMenuItem";
            this.保存SToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+S";
            this.保存SToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.保存SToolStripMenuItem.Size = new System.Drawing.Size(213, 30);
            this.保存SToolStripMenuItem.Text = "保存(&S)";
            this.保存SToolStripMenuItem.Click += new System.EventHandler(this.保存SToolStripMenuItem_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "115200"});
            this.comboBox2.Location = new System.Drawing.Point(20, 80);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(149, 26);
            this.comboBox2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 118);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 58);
            this.button1.TabIndex = 3;
            this.button1.Text = "接続";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Location = new System.Drawing.Point(20, 574);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox1.Size = new System.Drawing.Size(1131, 157);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button25);
            this.groupBox1.Controls.Add(this.button24);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button23);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button18);
            this.groupBox1.Controls.Add(this.button19);
            this.groupBox1.Controls.Add(this.button20);
            this.groupBox1.Controls.Add(this.button21);
            this.groupBox1.Controls.Add(this.button22);
            this.groupBox1.Controls.Add(this.button13);
            this.groupBox1.Controls.Add(this.button14);
            this.groupBox1.Controls.Add(this.button15);
            this.groupBox1.Controls.Add(this.button16);
            this.groupBox1.Controls.Add(this.button17);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button10);
            this.groupBox1.Controls.Add(this.button11);
            this.groupBox1.Controls.Add(this.button12);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(182, 40);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(972, 525);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "モーション";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(745, 75);
            this.button25.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(125, 34);
            this.button25.TabIndex = 29;
            this.button25.Text = "FREE";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(745, 118);
            this.button24.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(125, 38);
            this.button24.TabIndex = 28;
            this.button24.Text = "リセット";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Location = new System.Drawing.Point(430, 68);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.trackBar1.Maximum = 270;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(305, 48);
            this.trackBar1.TabIndex = 27;
            this.trackBar1.Value = 135;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(615, 124);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            270,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown1.TabIndex = 26;
            this.numericUpDown1.Value = new decimal(new int[] {
            135,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "角度";
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(545, 21);
            this.button23.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(125, 39);
            this.button23.TabIndex = 24;
            this.button23.Text = "取得";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.comboBox3.Location = new System.Drawing.Point(432, 24);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(101, 26);
            this.comboBox3.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(393, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "ID";
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(45, 206);
            this.button18.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(165, 69);
            this.button18.TabIndex = 21;
            this.button18.Text = "POS0";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(745, 440);
            this.button19.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(165, 69);
            this.button19.TabIndex = 20;
            this.button19.Text = "POS19";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(570, 440);
            this.button20.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(165, 69);
            this.button20.TabIndex = 19;
            this.button20.Text = "POS18";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(395, 440);
            this.button21.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(165, 69);
            this.button21.TabIndex = 18;
            this.button21.Text = "POS17";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(220, 440);
            this.button22.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(165, 69);
            this.button22.TabIndex = 17;
            this.button22.Text = "POS16";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(45, 440);
            this.button13.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(165, 69);
            this.button13.TabIndex = 16;
            this.button13.Text = "POS15";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(745, 362);
            this.button14.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(165, 69);
            this.button14.TabIndex = 15;
            this.button14.Text = "POS14";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(570, 362);
            this.button15.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(165, 69);
            this.button15.TabIndex = 14;
            this.button15.Text = "POS13";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(395, 362);
            this.button16.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(165, 69);
            this.button16.TabIndex = 13;
            this.button16.Text = "POS12";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(220, 362);
            this.button17.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(165, 69);
            this.button17.TabIndex = 12;
            this.button17.Text = "POS11";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(45, 362);
            this.button8.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(165, 69);
            this.button8.TabIndex = 11;
            this.button8.Text = "POS10";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(745, 284);
            this.button9.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(165, 69);
            this.button9.TabIndex = 10;
            this.button9.Text = "POS9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(570, 284);
            this.button10.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(165, 69);
            this.button10.TabIndex = 9;
            this.button10.Text = "POS8";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(395, 284);
            this.button11.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(165, 69);
            this.button11.TabIndex = 8;
            this.button11.Text = "POS7";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(220, 284);
            this.button12.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(165, 69);
            this.button12.TabIndex = 7;
            this.button12.Text = "POS6";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(187, 24);
            this.button7.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(125, 34);
            this.button7.TabIndex = 6;
            this.button7.Text = "保存";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(10, 27);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(164, 25);
            this.textBox1.TabIndex = 5;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(45, 284);
            this.button6.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(165, 69);
            this.button6.TabIndex = 4;
            this.button6.Text = "POS5";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(745, 206);
            this.button5.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(165, 69);
            this.button5.TabIndex = 3;
            this.button5.Text = "POS4";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(570, 206);
            this.button4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(165, 69);
            this.button4.TabIndex = 2;
            this.button4.Text = "POS3";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(395, 206);
            this.button3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 69);
            this.button3.TabIndex = 1;
            this.button3.Text = "POS2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(220, 206);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 69);
            this.button2.TabIndex = 0;
            this.button2.Text = "POS1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(20, 480);
            this.button26.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(152, 69);
            this.button26.TabIndex = 6;
            this.button26.Text = "実行";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "csvファイル(*.csv)|*.csv";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "csvファイル(*.csv)|*.csv";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1173, 752);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "AHO for windows";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開くToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.ToolStripMenuItem 新規ToolStripMenuItem;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem 保存SToolStripMenuItem;
    }
}

