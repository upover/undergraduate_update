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

namespace AutoCalibrationSystem
{
    public partial class ComSetForm : Form
    {

        //public event EventHandler ComOpenHandler;
        //public event EventHandler LanOpenHandler;
        //public event EventHandler LanCloseHandler;
        //public event EventHandler ComCloseHandler;

        public static int comNumTest = 0;
        public static int comNumStand2 = 0;

        public UtilEventArgs utilEventArgs = new UtilEventArgs();
        public delegate bool ComOpenHandler(object sender,UtilEventArgs args);
        public delegate bool ComCloseHandler(object sender, UtilEventArgs args);
        public delegate bool LanOpenHandler(object sender, UtilEventArgs args);
        public delegate bool LanCloseHandler(object sender, UtilEventArgs args);

        public ComOpenHandler comOpenHandler;
        public ComCloseHandler comCloseHandler;
        public LanOpenHandler lanOpenHandler;
        public LanCloseHandler lanCloseHandler;

        //返回各表的仪器地址号
        public string numSaddTestValue
        {
            get
            {
                return this.SaddTest.Value.ToString();
            }
            set
            {
                this.SaddTest.Value = int.Parse(value);
            }
        }


        //返回串口号
        //待校表
        public string boxComTestValue {
            get {
                return this.boxComTest.SelectedItem.ToString();
            }
            set {
                this.boxComTest.Text = value;
            }
        }

        //标准表2
        public string boxComStand2Value
        {
            get
            {
                return this.boxComStand2.SelectedItem.ToString();
            }
            set
            {
                this.boxComStand2.Text = value;
            }
        }


        //返回波特率
        //待校准表
        public string boxBaudrateTestValue
        {
            get
            {
                return this.boxBaudrateTest.SelectedItem.ToString();
            }
            set
            {
                this.boxBaudrateTest.Text = value;
            }
        }

        //标准表2
        public string boxBaudrateStand2Value
        {
            get
            {
                return this.boxBaudrateStand2.SelectedItem.ToString();
            }
            set
            {
                this.boxBaudrateStand2.Text = value;
            }
        }
       
        //返回网口IP
        public string TextIPStand2Value
        {
            get
            {
                return this.textIPStand2.Text.Trim().ToString();
            }
            set
            {
                this.textIPStand2.Text = value;
            }
        }
        //返回网口端口号
        public string TextPortStand2Value
        {
            get
            {
                return this.textPortStand2.Text.Trim().ToString();
            }
            set
            {
                this.textPortStand2.Text = value;
            }
        }
        public ComSetForm()
        {
            InitializeComponent();
        }
        private void ComSetForm_Load(object sender, EventArgs e)
        {
            this.boxComTest.Items.Clear();
            this.boxComStand2.Items.Clear();
            string[] str = SerialPort.GetPortNames();
            if (str != null)
            {
                foreach (string s in SerialPort.GetPortNames())
                {
                    this.boxComTest.Items.Add(s);
                    this.boxComStand2.Items.Add(s);

                }
                ComSetForm.comNumTest = (ComSetForm.comNumTest > str.Length) ? 0 : ComSetForm.comNumTest;
                ComSetForm.comNumStand2 = (ComSetForm.comNumStand2 > str.Length) ? 0 : ComSetForm.comNumStand2;
                this.boxComTest.SelectedIndex = ComSetForm.comNumTest;
                this.boxComStand2.SelectedIndex = ComSetForm.comNumStand2;
            }
            this.boxBaudrateTest.SelectedIndex = 1;
            this.boxBaudrateStand2.SelectedIndex = 1;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //打开串口按钮待校准表9010
        private void btnComTest_Click(object sender, EventArgs e)
        {
            utilEventArgs.Parmater = "comTest";
            if (btnComTest.Text == "打开串口")
            {
                if (comOpenHandler != null)
                {
                    //打开成功
                    if (comOpenHandler(this, utilEventArgs))
                    {
                        btnComTest.Text = "关闭串口";
                    }
                }
            }
            else if (btnComTest.Text == "关闭串口")
            {
                if (comCloseHandler != null)
                {
                    comCloseHandler(this, utilEventArgs);
                    btnComTest.Text = "打开串口";
                }

            }
        }
        //打开串口按钮标准表2
        private void btnComStand2_Click(object sender, EventArgs e)
        {
            utilEventArgs.Parmater = "comStand2";
            if (btnComStand2.Text == "打开串口")
            {
                if (comOpenHandler != null)
                {
                    if (comOpenHandler(this, utilEventArgs))
                    {
                        btnComStand2.Text = "关闭串口";
                    }
                }
            }
            else if (btnComStand2.Text == "关闭串口")
            {
                if (comCloseHandler != null)
                {
                    if (comCloseHandler(this, utilEventArgs))
                    {
                        btnComStand2.Text = "打开串口";
                    }
                }
            }
        }
        
        //网口

        private void btnLanStand2_Click(object sender, EventArgs e)
        {
            utilEventArgs.Parmater = "lanStand2";
            if (btnLanStand2.Text == "打开网口")
            {
                if (lanOpenHandler != null)
                {
                    if (lanOpenHandler(this, utilEventArgs))
                    {
                        btnLanStand2.Text = "关闭网口";
                    }
                }
            }
            else if (btnLanStand2.Text == "关闭网口")
            {
                if (lanCloseHandler != null)
                {
                    if (lanCloseHandler(this, utilEventArgs))
                    {
                        btnLanStand2.Text = "打开网口";
                    }
                }
            }
        }    
    }
}
