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
using System.Net.Sockets;
using System.Threading;
using System.Net;
using System.IO;
using System.Collections;
using AutoCalibrationSystem.DataAccess;

namespace AutoCalibrationSystem
{
    public partial class MainForm : Form
    {
        public static int INTERNAL = 60;
        public delegate void ProcessDelegate(bool nextpage);
        //进度条
        private delegate void ProgressBarShow(int i);
        Thread progressbarThread = null;
        //新建窗体
        public static CaliItemSetForm caliItemSetForm = new CaliItemSetForm();
        public static ComSetForm comSetForm = new ComSetForm();
        public static ResultManageForm resultManageForm = new ResultManageForm();
        public static DataAnalyzeForm dataAnalyzeForm = new DataAnalyzeForm();

        //串口类
        public SerialPort comTest = new SerialPort();
        public SerialPort comStand2 = new SerialPort();
        public enum DebugComSelect {  STAND2_34401, CALITEST};
        private DebugComSelect debugComSelect = DebugComSelect.STAND2_34401;

        private EnumCaliState caliState = EnumCaliState.INITI;
        private EnumCaliState dividerState = EnumCaliState.INITI;
        //网口通信相关
        public Socket socketStand2;
        Thread threadReceive2;

        //定义接收服务端发送消息的回调
        private delegate void ReceiveMsgCallBack(string strMsg);

        //与串口接收相关的变量定义
        private StringBuilder builder = new StringBuilder();
        List<byte> buffer = new List<byte>(4096);
        public List<byte> testBuffer = new List<byte>(4096);
        
        //发送校准命令定时器
        System.Timers.Timer CS9010Timer;
        System.Timers.Timer Agilent34410ATimer;
        System.Timers.Timer Agilent34410ATimer_2;
        System.Timers.Timer SocketTimer;
        System.Timers.Timer SocketTimer_2;


        //发送命令计数
        private int sendcount9010 = 0;
        private int sendcount34410A = 0;
        private int sendcount34410A_2 = 0;

        //仪表状态
        InstrumentsState instrumentsState = new InstrumentsState();

        //校准表格DataGridView相关数据
        GridViewModel gridViewModel = new GridViewModel();
        static CaliData caliData = new CaliData();

        //当前校准状态
        CaliProcess caliProcess = new CaliProcess(EnumMode.IACI, caliData);

        //分压器表格相关数据
        DividerGridViewModel dividerGridViewModel = new DividerGridViewModel();
        static DividerData dividerData = new DividerData();
        //当前分压器测量状态
        DividerProcess dividerProcess = new DividerProcess(EnumMode.Divider_V_DCP, dividerData);

        //当前测量选项是校准还是分压器监测
        public enum MainMeasureType { CALIBRATION, DIVIDER, DEBUGCOM };
        MainMeasureType mainMeasureType = MainMeasureType.CALIBRATION;
        public MainForm()
        {
            InitializeComponent();
        }

        //校准项设置
        private void btncaliset_Click(object sender, EventArgs e)
        {
            caliItemSetForm.ShowDialog(this);
            if (caliItemSetForm.DialogResult == DialogResult.OK){
                
            }
        }

        public void IntiCaliItemGridView()
        {
            /*
            for (int i = 0; i < 21; i++){
                CaliItem item = new CaliItem(i,i*100,1,1);
                this.gridViewModel.items.Add(item);
            }
            */
            //电流
            //iac
            //for (int i = 0; i < caliData.iaciData.Count; i++)
            //{
            //    this.gridViewModel.items.Add(caliData.iaciData[i]);
            //}
            ////iacf
            //for (int i = 0; i < caliData.iacfData.Count; i++)
            //{
            //    this.gridViewModel.items.Add(caliData.iacfData[i]);
            //}
            ////idc
            //for (int i = 0; i < caliData.idcData.Count; i++)
            //{
            //    this.gridViewModel.items.Add(caliData.idcData[i]);
            //}
            ////电压
            ////vacf
            //for (int i = 0; i < caliData.vacfData.Count; i++)
            //{
            //    this.gridViewModel.items.Add(caliData.vacfData[i]);
            //}
            ////vacvl
            //for (int i = 0; i < CaliData.VLOWNUM; i++)
            //{
            //    this.gridViewModel.items.Add(caliData.vacvData[i]);
            //}
            ////vdclp
            //for (int i = 0; i < CaliData.VLOWNUM; i++)
            //{
            //    this.gridViewModel.items.Add(caliData.vdcData[i]);
            //}
            ////vdcln
            //for (int i = 0; i < CaliData.VLOWNUM; i++)
            //{
            //    this.gridViewModel.items.Add(caliData.vdcData[i+CaliData.VDCPNUM]);
            //}
            ////vacvh
            //for (int i = CaliData.VLOWNUM; i < caliData.vacvData.Count; i++)
            //{
            //    this.gridViewModel.items.Add(caliData.vacvData[i]);
            //}
            ////vdchp
            //for (int i = CaliData.VLOWNUM; i < CaliData.VDCPNUM; i++)
            //{
            //    this.gridViewModel.items.Add(caliData.vdcData[i]);
            //}
            ////vdchn
            //for (int i = CaliData.VLOWNUM; i < CaliData.VDCPNUM; i++)
            //{
            //    this.gridViewModel.items.Add(caliData.vdcData[i+CaliData.VDCPNUM]);
            //}
            //this.gridViewModel.recordCount = this.gridViewModel.items.Count;
            //this.gridViewModel.pageCount = this.gridViewModel.recordCount % 10 == 0 ? this.gridViewModel.recordCount / 10 : (this.gridViewModel.recordCount / 10 + 1);
            //this.gridViewModel.currentPage = 0;
        }
        private int getPageByCount(int count)
        {
            return (count % 10 == 0) ? count / 10 : count / 10 + 1;
        }
        private void InitGridViewByMode(EnumMode mode) 
        {
            this.gridViewModel.curMode = mode;
            this.gridViewModel.curModePage = 0;
            switch (mode)
            {
                case EnumMode.IACI:
                    this.gridViewModel.currentPage = 0;
                    break;
                case EnumMode.IACF:
                    this.gridViewModel.currentPage = getPageByCount(caliData.iaciData.Count);
                    break;
                case EnumMode.IDC:
                    this.gridViewModel.currentPage = getPageByCount(caliData.iaciData.Count) + getPageByCount(caliData.iacfData.Count);
                    break;
                case EnumMode.VACF:
                    this.gridViewModel.currentPage = getPageByCount(caliData.iaciData.Count) + getPageByCount(caliData.iacfData.Count) + getPageByCount(caliData.idcData.Count);
                    break;
                case EnumMode.VACVL:
                    this.gridViewModel.currentPage = getPageByCount(caliData.iaciData.Count) + getPageByCount(caliData.iacfData.Count) + getPageByCount(caliData.idcData.Count)
                        + getPageByCount(caliData.vacfData.Count);
                    break;
                case EnumMode.VDCL:
                    this.gridViewModel.currentPage = getPageByCount(caliData.iaciData.Count) + getPageByCount(caliData.iacfData.Count) + getPageByCount(caliData.idcData.Count)
                        + getPageByCount(caliData.vacfData.Count) + getPageByCount(CaliData.VLOWNUM);
                    break;
                case EnumMode.VACVH:
                    this.gridViewModel.currentPage = getPageByCount(caliData.iaciData.Count) + getPageByCount(caliData.iacfData.Count) + getPageByCount(caliData.idcData.Count)
                        + getPageByCount(caliData.vacfData.Count) + getPageByCount(CaliData.VLOWNUM) + getPageByCount(CaliData.VLOWNUM * 2);
                    break;
                case EnumMode.VDCHP:
                    this.gridViewModel.currentPage = getPageByCount(caliData.iaciData.Count) + getPageByCount(caliData.iacfData.Count) + getPageByCount(caliData.idcData.Count)
                        + getPageByCount(caliData.vacfData.Count) + getPageByCount(CaliData.VLOWNUM) + getPageByCount(CaliData.VLOWNUM * 2) + getPageByCount(CaliData.VACNUM - CaliData.VLOWNUM);
                    break;
                case EnumMode.VDCHN:
                    this.gridViewModel.currentPage = getPageByCount(caliData.iaciData.Count) + getPageByCount(caliData.iacfData.Count) + getPageByCount(caliData.idcData.Count)
                        + getPageByCount(caliData.vacfData.Count) + getPageByCount(CaliData.VLOWNUM) + getPageByCount(CaliData.VLOWNUM * 2) + getPageByCount(CaliData.VACNUM - CaliData.VLOWNUM)
                        + getPageByCount(CaliData.VDCPNUM - CaliData.VLOWNUM);
                    break;
            }        
        }
        private void InitGridView() 
        {                       
            this.gridViewModel.recordCount = caliData.iacfData.Count + caliData.iaciData.Count + caliData.idcData.Count +
                                             caliData.vacfData.Count + caliData.vacvData.Count + caliData.vdcData.Count;
            this.gridViewModel.pageCount = getPageByCount(caliData.iaciData.Count) + getPageByCount(caliData.iacfData.Count) + getPageByCount(caliData.idcData.Count)
                        + getPageByCount(caliData.vacfData.Count) + getPageByCount(CaliData.VLOWNUM) + getPageByCount(CaliData.VLOWNUM * 2) + getPageByCount(CaliData.VACNUM - CaliData.VLOWNUM)
                        + getPageByCount(CaliData.VDCPNUM - CaliData.VLOWNUM) + getPageByCount(CaliData.VDCPNUM - CaliData.VLOWNUM);
            this.dividerGridViewModel.recordCount = dividerData.voltageDCPData.Count + dividerData.voltageDCNData.Count +
                                                    dividerData.voltageACData.Count + dividerData.frequencyData.Count;
            this.dividerGridViewModel.pageCount = getPageByCount(dividerData.voltageDCPData.Count) + getPageByCount(dividerData.voltageDCNData.Count) +
                                                  getPageByCount(dividerData.voltageACData.Count) + getPageByCount(dividerData.frequencyData.Count);
        }
        private void InitDividerGridViewByMode(EnumMode mode)
        {
            this.dividerGridViewModel.curMode = mode;
            this.dividerGridViewModel.curModePage = 0;
            switch (mode) { 
                case EnumMode.Divider_V_DCP:
                    this.dividerGridViewModel.currentPage = 0;
                    break;
                case EnumMode.Divider_V_DCN:
                    this.dividerGridViewModel.currentPage = getPageByCount(dividerData.voltageDCPData.Count);
                    break;
                case EnumMode.Divider_V_AC:
                    this.dividerGridViewModel.currentPage = getPageByCount(dividerData.voltageDCPData.Count) + getPageByCount(dividerData.voltageDCNData.Count);
                    break;
                case EnumMode.Divider_F:
                    this.dividerGridViewModel.currentPage = getPageByCount(dividerData.voltageDCPData.Count) + getPageByCount(dividerData.voltageDCNData.Count)+
                                                            getPageByCount(dividerData.voltageACData.Count);
                    break;
            }
        }
        //窗体加载初始化函数
        private void MainForm_Load(object sender, EventArgs e)
        {
            SocketTimer = new System.Timers.Timer();
            SocketTimer_2 = new System.Timers.Timer();
 
            CS9010Timer = new System.Timers.Timer();
            CS9010Timer.Elapsed += CS9010Timer_Elapsed;
            
            Agilent34410ATimer = new System.Timers.Timer();
            Agilent34410ATimer.Elapsed += Agilent34410ATimer_Elapsed;

            Agilent34410ATimer_2 = new System.Timers.Timer();
            Agilent34410ATimer_2.Elapsed += Agilent34410ATimer_2_Elapsed_Divider;
           
            comSetForm.comOpenHandler += comSetForm_ComOpenHandler;
            comSetForm.comCloseHandler += comSetForm_ComCloseHandler;
            comSetForm.lanOpenHandler += comSetForm_LanOpenHandler;
            comSetForm.lanCloseHandler += comSetForm_LanCloseHandler;


            //默认先选iaci模式
            this.rbIACI.Checked = true;
            this.rbvdcp.Checked = true;

            //默认校准方式为当前
            this.rbTypeCur.Checked = true;            

            //暂时提供统一的一个单位
            this.rbUnitBig.Checked = true;
            this.rbBigUtilDivider.Checked = true;

            this.rbUnitSmall.Visible = false;
            this.rbSmallUtilDivider.Visible = false;
            //改变行的高度; 
            dgvCaliItem.RowTemplate.MinimumHeight = 32;
            dgvCaliItem.AutoGenerateColumns = false;
            
            dgvDivider.RowTemplate.MinimumHeight = 32;
            dgvDivider.AutoGenerateColumns = false;

            //分压器监测默认设置
            this.rbCycleNo.Checked = true;
            this.rbMeasTypeCur.Checked = true;
            this.rbSaveMan.Checked = true;
            this.rbvdcp.Checked = true;

            //显示列表
            //IntiCaliItemGridView();
            InitGridView();
            InitGridViewByMode(EnumMode.IACI);

            InitDividerGridViewByMode(EnumMode.Divider_V_DCP);
            Load_Page(false);
            Load_Page_Divider(false);

            //添加标签切换函数
            this.dmTabCtrl.SelectedIndexChanged += dmTabCtrl_SelectedIndexChanged;
        }

        //网口关闭事件
        bool comSetForm_LanCloseHandler(object sender, EventArgs e)
        {
            ComSetForm tempSetForm = (ComSetForm)sender;
            UtilEventArgs util = (UtilEventArgs)e;
            try
            {
                switch (util.Parmater)
                {
                        /*
                    case "lanStand1":
                        instrumentsState.Agilent34410AState = EnumInstrumentState.INIT;
                        SocketTimer.Enabled = false;
                        //关闭socket
                        socketStand.Close();
                        break;
                         * */
                    case "lanStand2":
                        instrumentsState.Agilent34410AState_2 = EnumInstrumentState.INIT;
                        SocketTimer_2.Enabled = false;
                        //关闭socket
                        socketStand2.Close();
                        break;
                }
                return true;
            }
            catch (Exception ex) {
                MessageBox.Show("关闭网口出错:" + ex.ToString());
                return false;
            }
        }
        //网口打开事件
        bool comSetForm_LanOpenHandler(object sender, EventArgs e)
        {
            ComSetForm tempSetForm = (ComSetForm)sender;
            UtilEventArgs util = (UtilEventArgs)e;
            try
            {

                IPAddress ip = null; 
                switch (util.Parmater)
                {
                    /*
                    case "lanStand1":
                        ip = IPAddress.Parse(tempSetForm.TextIPStandValue);
                        socketStand = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                        socketStand.Connect(ip, Convert.ToInt32(tempSetForm.TextPortStandValue));
                        Console.WriteLine("Stand1连接成功");
                        instrumentsState.Agilent34410AState = EnumInstrumentState.REMOTE;
                        //开启一个新的线程不停的接收服务器发送消息的线程
                        threadReceive = new Thread(ReceiveTimer);
                        //设置为后台线程
                        threadReceive.IsBackground = true;
                        threadReceive.Start();
                        break;
                    */
                    case "lanStand2":
                        ip = IPAddress.Parse(tempSetForm.TextIPStand2Value);
                        socketStand2 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                        socketStand2.Connect(ip, Convert.ToInt32(tempSetForm.TextPortStand2Value));
                        Console.WriteLine("Stand2连接成功");
                        instrumentsState.Agilent34410AState_2 = EnumInstrumentState.REMOTE;
                        //开启一个新的线程不停的接收服务器发送消息的线程
                        threadReceive2 = new Thread(ReceiveTimer_2);
                        //设置为后台线程
                        threadReceive2.IsBackground = true;
                        threadReceive2.Start();
                        break;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("连接服务端出错:" + ex.ToString());
                return false;
            }

        }
        //串口关闭事件
        private bool comSetForm_ComCloseHandler(object sender, EventArgs e)
        {
            ComSetForm tempSetForm = (ComSetForm)sender;
            UtilEventArgs util = (UtilEventArgs)e;
            try
            {
                switch (util.Parmater)
                {
                    case "comTest":
                        if (comTest.IsOpen)
                        {
                            comTest.Close();
                        }
                        else
                            MessageBox.Show("串口已关闭！");
                        break;
                    case "comStand2":
                        if (comStand2.IsOpen)
                        {
                            comStand2.Close();
                        }
                        else
                            MessageBox.Show("串口已关闭！");
                        break;                 
                }
            }
            catch (Exception)
            {
                Console.WriteLine("串口关闭异常");
                return false;
            }
            return true;
        }
        //串口打开事件
        bool comSetForm_ComOpenHandler(object sender, EventArgs e)
        {
            ComSetForm tempSetForm = (ComSetForm)sender;
            UtilEventArgs util = (UtilEventArgs)e;       
            switch (util.Parmater)
            {
                case "comTest":
                    if (!comTest.IsOpen)
                    {
                        comTest.PortName = tempSetForm.boxComTestValue;
                        comTest.BaudRate = int.Parse(tempSetForm.boxBaudrateTestValue);
                        comTest.DataReceived += comTest_DataReceived;
                        try
                        {
                            comTest.Open();
                        }
                        catch (UnauthorizedAccessException)
                        {
                            MessageBox.Show("串口已占用！");
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("串口已打开！");
                    }
                    break;
                case "comStand2":
                    if (!comStand2.IsOpen)
                    {
                        comStand2.PortName = tempSetForm.boxComStand2Value;
                        comStand2.BaudRate = int.Parse(tempSetForm.boxBaudrateStand2Value);
                        comStand2.DtrEnable = Enabled;
                        comStand2.DataReceived += comStand2_DataReceived;
                        try
                        {
                            comStand2.Open();
                        }
                        catch (UnauthorizedAccessException)
                        {
                            MessageBox.Show("串口已占用！");
                            return false;
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("标准表2串口有异常！");
                            return false;
                        }
                        instrumentsState.Agilent34410AState_2 = EnumInstrumentState.INIT;
                    }
                    else
                        MessageBox.Show("串口已打开！");
                    break;               
            }
            return true;
        }

        //通信设置窗体
        private void btncomset_Click(object sender, EventArgs e)
        {
            comSetForm.ShowDialog(this);
        }
        //结果管理窗体
        private void btnresult_Click(object sender, EventArgs e)
        {
            resultManageForm.ShowDialog(this);
        }
        //统计分析窗体
        private void btnanalyze_Click(object sender, EventArgs e)
        {
            dataAnalyzeForm.ShowDialog(this);
        }        

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.textReceive.Text = "";
        }

        private void dgvCaliItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btLoginout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //加载页面
        private void Load_Page(bool nextpage)
        {
            //在开始校准后，才判断是否需要自动翻页
            if (caliProcess.complete == EnumCaliState.START)
            {
                //nextpage用于标记是刷新还是翻页，使页面最后一条记录先更新后再翻页
                if (caliProcess.curTotalNum % 10 == 0 && nextpage)
                {
                    this.gridViewModel.currentPage++;
                    if (gridViewModel.currentPage >= gridViewModel.pageCount)
                        gridViewModel.currentPage = gridViewModel.pageCount - 1;
                    this.gridViewModel.curModePage++;
                }
            }
            BindingList<CaliItem> tempItems = new BindingList<CaliItem>(); //数据源
            this.gridViewModel.getItemsList(caliData, tempItems);//给数据源赋值
            this.dgvCaliItem.DataSource = tempItems;  //绑定数据源
            //清除默认选中项，选中项为上次修改项
            this.dgvCaliItem.ClearSelection();
            //判断是否是最后一页，索引是否大于最后一项
//            if (this.gridViewModel.currentPage == this.gridViewModel.pageCount - 1 && this.gridViewModel.selectIndex > i % 10)
//            {
//                this.gridViewModel.selectIndex = i % 10;
//            }
//            this.dgvCaliItem.Rows[this.gridViewModel.selectIndex].Selected = true;
//            this.dgvCaliItem.FirstDisplayedScrollingRowIndex = this.gridViewModel.selectIndex;
            labelCurPage.Text = "当前页："+(this.gridViewModel.currentPage+1).ToString()+"/" + (this.gridViewModel.pageCount).ToString();//当前页
            labelTotalRecord.Text = "总记录：" + this.gridViewModel.recordCount.ToString();//总记录数 
            this.dgvCaliItem.CellValidating += dgvCaliItem_CellValidating;
            this.dgvCaliItem.DataError += dgvCaliItem_DataError;
        }

        //分压器监测加载页面
        private void Load_Page_Divider(bool nextpage)
        {
            if (dividerProcess.complete == EnumCaliState.START)
            {
                if (dividerProcess.curTotalNum % 10 == 0 && nextpage)
                {
                    dividerGridViewModel.currentPage++;
                    if (dividerGridViewModel.currentPage >= dividerGridViewModel.pageCount)
                        dividerGridViewModel.currentPage = dividerGridViewModel.pageCount - 1;
                    this.dividerGridViewModel.curModePage++;
                }
            }
            BindingList<DividerItem> tempItems = new BindingList<DividerItem>(); //数据源
            this.dividerGridViewModel.getItemsList(dividerData, tempItems);      //给数据源赋值
            this.dgvDivider.DataSource = tempItems;                             //绑定数据源
            //清除默认选中项，选中项为上次修改项
            this.dgvCaliItem.ClearSelection();
            labelCurPageDivider.Text = "当前页：" + (dividerGridViewModel.currentPage + 1).ToString() + "/" + (dividerGridViewModel.pageCount).ToString();//当前页
            labelTotalRecordDivider.Text = "总记录：" + dividerGridViewModel.recordCount.ToString();//总记录数 
            //this.dgvCaliItem.CellValidating += dgvCaliItem_CellValidating;
            //this.dgvCaliItem.DataError += dgvCaliItem_DataError;
        }
        void dgvCaliItem_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            return;
        }
        void dgvCaliItem_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            float min = 0.0f;
            float max = 0.0f;
            switch (gridViewModel.curMode) { 
                case EnumMode.IACI:
                    max = 4000.0f;
                    break;
                case EnumMode.IACF:
                case EnumMode.VACF:
                    max = 1000.0f;
                    break;
                case EnumMode.IDC:
                    max = -4000.0f;
                    max = 4000.0f;
                    break;
                case EnumMode.VDCL:
                    min = -1.0f;
                    max = 1.0f;
                    break;
                case EnumMode.VACVL:
                    min = 0.0f;
                    max = 1.0f;
                    break;
                case EnumMode.VDCHP:
                case EnumMode.VACVH:
                    min = 1.0f;
                    max = 20.0f;
                    break;
                case EnumMode.VDCHN:
                    min = -20.0f;
                    max = -1.0f;
                    break;
            }
            if (e.ColumnIndex < 1 || e.ColumnIndex > 3)
            {
                return;
            }
            // Confirm that the cell is not empty.
            if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
                e.Cancel = true;
                MessageBox.Show("输入不能为空！");
                this.dgvCaliItem.CancelEdit();
            }
            //判断是否符合范围
            else{
                try { 
                    float temp = float.Parse(e.FormattedValue.ToString());
                    if(temp - min < -0.0001f || temp - max > 0.0001f){
                         e.Cancel = true;
                        MessageBox.Show("输入范围超出限制！");
                        this.dgvCaliItem.CancelEdit();
                    }
                }
                catch(FormatException)
                {
                    e.Cancel = true;
                    MessageBox.Show("输入不是有效数值！");
                    this.dgvCaliItem.CancelEdit();
                }
            }
        }
        //更新记录数
        private void refreshRecord()
        {
            this.gridViewModel.recordCount = this.gridViewModel.items.Count;
            this.gridViewModel.pageCount = this.gridViewModel.recordCount % 10 == 0 ? this.gridViewModel.recordCount / 10 : (this.gridViewModel.recordCount / 10 + 1);
        }
        //上一页
        private void btnPrePage_Click(object sender, EventArgs e)
        {
            gridViewModel.currentPage -= 1;
            if (gridViewModel.currentPage < 0)
                gridViewModel.currentPage = 0;
            gridViewModel.curModePage -=1;
            Load_Page(false);
            SetCaliItemRatioButton(this.gridViewModel.curMode);
        }
        //分压器监测上一页
        private void btnprepage_divider_Click(object sender, EventArgs e)
        {
            dividerGridViewModel.currentPage -= 1;
            if (dividerGridViewModel.currentPage < 0)
                dividerGridViewModel.currentPage = 0;
            dividerGridViewModel.curModePage -= 1;
            Load_Page_Divider(false);
            SetDividerRatioButton(dividerGridViewModel.curMode);
        }

        //下一页
        private void btnNextPage_Click(object sender, EventArgs e)
        {
            gridViewModel.currentPage += 1;
            if (gridViewModel.currentPage >= gridViewModel.pageCount)
                gridViewModel.currentPage = gridViewModel.pageCount - 1;
            gridViewModel.curModePage += 1;
            Load_Page(false);
            SetCaliItemRatioButton(this.gridViewModel.curMode);
        }
        //分压器监测下一页
        private void btnnextpage_divider_Click(object sender, EventArgs e)
        {
            dividerGridViewModel.currentPage += 1;
            if (dividerGridViewModel.currentPage >= dividerGridViewModel.pageCount)
                dividerGridViewModel.currentPage = dividerGridViewModel.pageCount - 1;
            dividerGridViewModel.curModePage += 1;
            Load_Page_Divider(false);
            SetDividerRatioButton(dividerGridViewModel.curMode);
        }
        //增加校准点
        private void btnAddPoint_Click(object sender, EventArgs e)
        {
            this.gridViewModel.recordCount += 1;
            CaliItem item = new CaliItem("");
            this.gridViewModel.items.Add(item);
            refreshRecord();
            Load_Page(false);
        }
        //删除选中点
        private void btnDeletePoint_Click(object sender, EventArgs e)
        {
            this.gridViewModel.recordCount -= 1;
            if (gridViewModel.recordCount < 0)
            {
                gridViewModel.recordCount = 0;
                return;
            }
            if (this.dgvCaliItem.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选中行然后再删除！");
                return;
            }
            foreach (DataGridViewRow r in this.dgvCaliItem.SelectedRows)
            {
                if (!r.IsNewRow)
                {
                    int rowNum = r.Index+this.gridViewModel.currentPage * GridViewModel.pageSize;
                    this.gridViewModel.items.RemoveAt(rowNum);
                    this.gridViewModel.SetSelectedIndex(r.Index);
                    dgvCaliItem.Rows.Remove(r);

                }
            }
            refreshRecord();
            Load_Page(false);
        }
        //插入校准点
        private void btnInsertPoint_Click(object sender, EventArgs e)
        {
            if (this.dgvCaliItem.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选中一行然后再插入！");
                return;
            }
            foreach (DataGridViewRow r in this.dgvCaliItem.SelectedRows)
            {
                if (!r.IsNewRow)
                {
                    int rowNum = r.Index + this.gridViewModel.currentPage * GridViewModel.pageSize;
                    CaliItem tempItem = new CaliItem(0,0,0);
                    this.gridViewModel.items.Insert(rowNum+1,tempItem);
                    this.gridViewModel.SetSelectedIndex(r.Index + 1);
                }
            }
            refreshRecord();
            Load_Page(false);
        }
        //重置
        private void btnReset_Click(object sender, EventArgs e)
        {

        }
        //上下页翻页时，显示当前校准项
        private void SetCaliItemRatioButton(EnumMode mode) 
        {            
            switch (mode) { 
                case EnumMode.IACI:
                    this.rbIACI.Checked = true;
                    break;
                case EnumMode.IACF:
                    this.rbIACF.Checked = true;
                    break;
                case EnumMode.IDC:
                    this.rbIDC.Checked = true;
                    break;
                case EnumMode.VACF:
                    this.rbVACF.Checked = true;
                    break;
                case EnumMode.VACVL:
                    this.rbVACVL.Checked = true;
                    break;
                case EnumMode.VACVH:
                    this.rbVACVH.Checked = true;
                    break;
                case EnumMode.VDCL:
                    this.rbVDCL.Checked = true;
                    break;
                case EnumMode.VDCHP:
                    this.rbVDCHP.Checked = true;
                    break;
                case EnumMode.VDCHN:
                    this.rbVDCHN.Checked = true;
                    break;
            }            
        }
        //分压器监测上下页翻页时显示测量选项
        public void SetDividerRatioButton(EnumMode mode)
        {
            switch (mode)
            {
                case EnumMode.Divider_V_DCP:
                    this.rbvdcp.Checked = true;
                    break;
                case EnumMode.Divider_V_DCN:
                    this.rbvdcn.Checked = true;
                    break;
                case EnumMode.Divider_V_AC:
                    this.rbvac.Checked = true;
                    break;
                case EnumMode.Divider_F:
                    this.rbf.Checked = true;
                    break;
            }
        }

        //分压器监测时根据当前测量选项，设置模式，初始化
        private void radioButton_CheckedChanged_Divider(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            EnumMode mode = new EnumMode();
            switch (rb.Text) {
                case "电压(DC+)":
                    mode = EnumMode.Divider_V_DCP;
                    break;
                case "电压(DC-)":
                    mode = EnumMode.Divider_V_DCN;
                    break;
                case "电压(AC)":
                    mode = EnumMode.Divider_V_AC;
                    break;
                case "频率":
                    mode = EnumMode.Divider_F;
                    break;
            }
            //设置开始模式为所选模式
            dividerProcess.initiMode = mode;
            dividerProcess.ResetProcess(mode, dividerData);
            InitDividerGridViewByMode(mode);
            Load_Page_Divider(false);
        }
        //校准时根据当前测量选项，设置模式，初始化
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            this.rbUnitBig.Checked = true;
            EnumMode mode = EnumMode.IACI;
            switch (rb.Text){
                case "VDC Low":
                    //this.rbUnitSmall.Text = "V";
                    this.rbUnitBig.Text = "kV";
                    mode = EnumMode.VDCL;
                    this.gridViewModel.maxNum = GridViewModel.MAXNUM_V;
                    break;
                case "VDC H Pos":
                    //this.rbUnitSmall.Text = "V";
                    this.rbUnitBig.Text = "kV";
                    this.gridViewModel.maxNum = GridViewModel.MAXNUM_V;
                    mode = EnumMode.VDCHP;
                    break;
                case "VDC H Neg":
                    //this.rbUnitSmall.Text = "V";
                    this.rbUnitBig.Text = "kV";
                    this.gridViewModel.maxNum = GridViewModel.MAXNUM_V;
                    mode = EnumMode.VDCHN;
                    break;
                case "VAC V Low":
                    //this.rbUnitSmall.Text = "V";
                    this.rbUnitBig.Text = "kV";
                    this.gridViewModel.maxNum = GridViewModel.MAXNUM_V;
                    mode = EnumMode.VACVL;
                    break;
                case "VAC V High":
                    //this.rbUnitSmall.Text = "V";
                    this.rbUnitBig.Text = "kV";
                    this.gridViewModel.maxNum = GridViewModel.MAXNUM_V;
                    mode = EnumMode.VACVH;
                    break;
                case "VAC F":
                    this.rbUnitBig.Text = "Hz";
                    this.gridViewModel.maxNum = GridViewModel.MAXNUM_F;
                    mode = EnumMode.VACF;
                    break;
                case "IDC":
                    //this.rbUnitSmall.Text = "uA";
                    this.rbUnitBig.Text = "mA";
                    this.gridViewModel.maxNum = GridViewModel.MAXNUM_I;
                    mode = EnumMode.IDC;
                    break;
                case "IAC I":
                    //this.rbUnitSmall.Text = "uA";
                    this.rbUnitBig.Text = "mA";
                    this.gridViewModel.maxNum = GridViewModel.MAXNUM_I;
                    mode = EnumMode.IACI;
                    break;
                case "IAC F":
                    this.rbUnitBig.Text = "Hz";
                    this.gridViewModel.maxNum = GridViewModel.MAXNUM_F;
                    mode = EnumMode.IACF;
                    break;
            }
            /*
            if (rb.Text == "VAC F" || rb.Text == "IAC F"){
                this.rbUnitBig.Visible = false;
            }
            else {
                this.rbUnitBig.Visible = true ;
            }
            */
            caliProcess = new CaliProcess(mode, caliData);
            InitGridViewByMode(mode); 
            Load_Page(false);
        }
        //开始校准
        private void btnstartcali_Click(object sender, EventArgs e)
        {            
            if (caliState == EnumCaliState.INITI)
            {
                //设置定时器定时时间
                //Agilent34410ATimer.Interval = INTERNAL;
                CS9010Timer.Interval = INTERNAL;
            }                
            //从取消校准，开始校准
            else if (caliState == EnumCaliState.CANCEL)
            {
                //重置caliData,caliProcess
                caliData.Reset(caliProcess);
                EnumMode mode = caliProcess.initiMode;
                caliProcess = new CaliProcess(mode,caliData);
            }
            //判断是否连接
            if (!comTest.IsOpen)
            {
                MessageBox.Show("待校准表未连接");
                return;
            }
            /*
            if ((socketStand == null || !socketStand.Connected) && !comStand.IsOpen)
            {
                MessageBox.Show("标准表未连接");
                return;
            }
             */ 
            Agilent34410ATimer.Enabled = true;
            CS9010Timer.Enabled = true;

            if (caliState != EnumCaliState.PAUSE)
            {
                InitialProgressBar(caliProcess.totalNum,mainMeasureType);
            }
            instrumentsState.CS9010State = EnumInstrumentState.INIT;
            caliProcess.complete = EnumCaliState.START; 
            caliState = EnumCaliState.START;             
        }

        //暂停校准
        private void btnpausecali_Click(object sender, EventArgs e)
        {
            //设置暂停标志
            caliState = EnumCaliState.PAUSE;
            //停止各定时函数
            //Agilent34410ATimer.Enabled = false;
            CS9010Timer.Enabled = false ;
        }
        //取消校准
        private void btncancelcali_Click(object sender, EventArgs e)
        {
            //设置取消标志
            caliState = EnumCaliState.CANCEL;
            //停止各定时函数
            //Agilent34410ATimer.Enabled = false;
            CS9010Timer.Enabled = false;
        }
        //进度条控件更新值
        private void ShowProgress(int current)
        {
            //说明，progressbar在主线程中定义，进度条线程访问progressbar时需要使用invoke，invokeRequired属性为true
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new ProgressBarShow(ShowProgress),current);
            }
            //progressbar在主线程中定义，主线程直接访问progressbar
            else
            {
                this.progressBarCali.Value = current;
                this.labelcompleted.Text = "已完成:" + current.ToString() +"/"+this.progressBarCali.Maximum;
            }

        }
        //分压器进度条控件更新值
        private void ShowProgressDivider(int current)
        {
            //说明，progressbar在主线程中定义，进度条线程访问progressbar时需要使用invoke，invokeRequired属性为true
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new ProgressBarShow(ShowProgressDivider), current);
            }
            //progressbar在主线程中定义，主线程直接访问progressbar
            else
            {
                this.progressBarDivider.Value = current;
                this.labelCompleteDivider.Text = "已完成:" + current.ToString() + "/" + this.progressBarDivider.Maximum;
            }

        }
        //进度条线程更新函数
        private void updateProgress(object end)
        {
            int current = 0;
            ShowProgress(current);
            int max = (int)end;
            while (current < this.progressBarCali.Maximum)
            {
                current = caliProcess.curTotalNum;
                ShowProgress(current);
                Thread.Sleep(1000);
            }
            progressbarThread.Abort();
            progressbarThread.Join();
        }
        //分压器进度条线程更新函数
        private void updateProgressDivider(object end)
        {
            int current = 0;
            ShowProgressDivider(current);
            int max = (int)end;
            while (current < this.progressBarDivider.Maximum)
            {
                current = dividerProcess.curTotalNum;
                ShowProgressDivider(current);
                Thread.Sleep(1000);
            }
            progressbarThread.Abort();
            progressbarThread.Join();
        }        
        //开始进度条线程
        private void InitialProgressBar(int end,MainMeasureType type)
        {
            if (type == MainMeasureType.CALIBRATION)
            {
                this.progressBarCali.Maximum = end;
                progressbarThread = new Thread(new ParameterizedThreadStart(updateProgress));
            }
            else
            {
                this.progressBarDivider.Maximum = end;
                progressbarThread = new Thread(new ParameterizedThreadStart(updateProgressDivider));
            }
            progressbarThread.Start(end);
        }
        //待校准表串口接收函数
        void comTest_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int n = comTest.BytesToRead;
            if (n <= 0)
                return;
            byte[] buf = new byte[n];//声明一个临时数组存储当前来的串口数据
            comTest.Read(buf, 0, n);
            string result = System.Text.Encoding.Default.GetString(buf);
            Console.WriteLine("CS9010Recieved:" + result);
            if (mainMeasureType == MainMeasureType.DEBUGCOM)
            {
                this.textReceive.Text += result;
                return;
            }                   
            //收到数据，已发送命令数减1
            if ( sendcount9010 > 0)
            {
                sendcount9010--;
            }
            //接收结果处理
            if (instrumentsState.CS9010State == EnumInstrumentState.INIT)
            {
                if (result.Equals("Address\n")) {
                    instrumentsState.CS9010State = EnumInstrumentState.SADD;
                    return;
                }
            }
            else if (instrumentsState.CS9010State == EnumInstrumentState.SADD)
            {
                if (result.Equals("Remote\n"))
                {
                    instrumentsState.CS9010State = EnumInstrumentState.REMOTE;
                    return;
                }
                else if (result.Equals("Local\n"))
                {
                    instrumentsState.CS9010State = EnumInstrumentState.SADD;
                }
            }
            else if (instrumentsState.CS9010State == EnumInstrumentState.REMOTE)
            {
                //处理查询到的数据
                string[] datas = result.Split(':');
                //去掉后面的单位
                switch (caliProcess.curMode) { 
                    case EnumMode.IACI:
                    case EnumMode.IDC:
                    case EnumMode.IACF:
                        datas = datas[1].Split('m');
                        break;
                    default:
                        datas = datas[1].Split('k');
                        break;
                }
                float data = float.Parse(datas[0]);
                //读数与源误差较大时，不保存
                if (data / caliProcess.curSource < 0.6f || data / caliProcess.curSource > 1.4f)
                {
                    return;
                }
                else
                {
                    //读数准确时，保存数据

                    //if (stateCS9920B == StateSource.OUT_STABLE || stateCS9920A == StateSource.OUT_STABLE || stateFluke5520A == StateSource.OUT_STABLE)
                    {
                        //保存到caliData
                        SaveTestToCaliData(data, caliProcess);
                    }
                }
            }
            else if (instrumentsState.CS9010State == EnumInstrumentState.SENDCALIDATA)
            {
                Console.WriteLine(result);
                if (result.Equals("CAL:Complete\n"))
                {

                    return;
                }
                else {
                }
            }
            else if (instrumentsState.CS9010State == EnumInstrumentState.READCALIDATA)
            {
                //接收数据格式为：CAL:IACI3:1:40.00:40.00
                string[] datas = result.Split(':');
                string mode = datas[1];
                int num = int.Parse(datas[2]) - 1;
                float standValue = float.Parse(datas[3]);
                float testValue = float.Parse(datas[4]);
                switch (mode)
                {
                    //IAC
                    case "IACI3":
                        caliData.iaciData[num].Source = standValue;
                        caliData.iaciData[num].StandOut = standValue;
                        caliData.iaciData[num].TestOut = testValue;
                        break;
                    case "IACI4":
                        caliData.iaciData[5 + num].Source = standValue;
                        caliData.iaciData[5 + num].StandOut = standValue;
                        caliData.iaciData[5 + num].TestOut = testValue;
                        break;
                    case "IACI5":
                        caliData.iaciData[10 + num].Source = standValue;
                        caliData.iaciData[10 + num].StandOut = standValue;
                        caliData.iaciData[10 + num].TestOut = testValue;
                        break;
                    case "IACI6":
                        caliData.iaciData[15 + num].Source = standValue;
                        caliData.iaciData[15 + num].StandOut = standValue;
                        caliData.iaciData[15 + num].TestOut = testValue;
                        break;
                    case "IACI7":
                        caliData.iaciData[20 + num].Source = standValue;
                        caliData.iaciData[20 + num].StandOut = standValue;
                        caliData.iaciData[20 + num].TestOut = testValue;
                        break;
                    case "IACI8":
                        caliData.iaciData[25 + num].Source = standValue;
                        caliData.iaciData[25 + num].StandOut = standValue;
                        caliData.iaciData[25 + num].TestOut = testValue;
                        break;
                    //IDCP
                    case "IDCP3":
                        caliData.idcData[num].Source = standValue;
                        caliData.idcData[num].StandOut = standValue;
                        caliData.idcData[num].TestOut = testValue;
                        break;
                    case "IDCP4":
                        caliData.idcData[5 + num].Source = standValue;
                        caliData.idcData[5 + num].StandOut = standValue;
                        caliData.idcData[5 + num].TestOut = testValue;
                        break;
                    case "IDCP5":
                        caliData.idcData[10 + num].Source = standValue;
                        caliData.idcData[10 + num].StandOut = standValue;
                        caliData.idcData[10 + num].TestOut = testValue;
                        break;
                    case "IDCP6":
                        caliData.idcData[15 + num].Source = standValue;
                        caliData.idcData[15 + num].StandOut = standValue;
                        caliData.idcData[15 + num].TestOut = testValue;
                        break;
                    case "IDCP7":
                        caliData.idcData[20 + num].Source = standValue;
                        caliData.idcData[20 + num].StandOut = standValue;
                        caliData.idcData[20 + num].TestOut = testValue;
                        break;
                    case "IDCP8":
                        caliData.idcData[25 + num].Source = standValue;
                        caliData.idcData[25 + num].StandOut = standValue;
                        caliData.idcData[25 + num].TestOut = testValue;
                        break;
                    //IDCN
                    case "IDCN3":
                        caliData.idcData[30 + num].Source = standValue;
                        caliData.idcData[30 + num].StandOut = standValue;
                        caliData.idcData[30 + num].TestOut = testValue;
                        break;
                    case "IDCN4":
                        caliData.idcData[35 + num].Source = standValue;
                        caliData.idcData[35 + num].StandOut = standValue;
                        caliData.idcData[35 + num].TestOut = testValue;
                        break;
                    case "IDCN5":
                        caliData.idcData[40 + num].Source = standValue;
                        caliData.idcData[40 + num].StandOut = standValue;
                        caliData.idcData[40 + num].TestOut = testValue;
                        break;
                    case "IDCN6":
                        caliData.idcData[45 + num].Source = standValue;
                        caliData.idcData[45 + num].StandOut = standValue;
                        caliData.idcData[45 + num].TestOut = testValue;
                        break;
                    case "IDCN7":
                        caliData.idcData[50 + num].Source = standValue;
                        caliData.idcData[50 + num].StandOut = standValue;
                        caliData.idcData[50 + num].TestOut = testValue;
                        break;
                    case "IDCN8":
                        caliData.idcData[55 + num].Source = standValue;
                        caliData.idcData[55 + num].StandOut = standValue;
                        caliData.idcData[55 + num].TestOut = testValue;
                        break;
                    //IACF
                    case "IACF":
                        caliData.iacfData[num].Source = standValue;
                        caliData.iacfData[num].StandOut = standValue;
                        caliData.iacfData[num].TestOut = testValue;
                        break;
                    //VACV
                    case "VACV":
                        if (caliData.vacvData.Count < num + 1)
                        {
                            CaliItem item = new CaliItem("VACV");
                            caliData.vacvData.Add(item);
                        }
                        caliData.vacvData[num].Source = standValue;
                        caliData.vacvData[num].StandOut = standValue;
                        caliData.vacvData[num].TestOut = testValue;
                        break;
                    //VACF
                    case "VACF":
                        caliData.vacfData[num].Source = standValue;
                        caliData.vacfData[num].StandOut = standValue;
                        caliData.vacfData[num].TestOut = testValue;
                        break;
                    //VDCP
                    case "VDCP":
                        caliData.vdcData[num].Source = standValue;
                        caliData.vdcData[num].StandOut = standValue;
                        caliData.vdcData[num].TestOut = testValue;
                        break;
                    //VDCN
                    case "VDCN":
                        caliData.vdcData[num].Source = standValue;
                        caliData.vdcData[num].StandOut = standValue;
                        caliData.vdcData[num].TestOut = testValue;
                        break;
                }
            }
        }
        //待校准表CS9010保存测量值
        public void SaveTestToCaliData(float data,CaliProcess thisCaliProcess) {
            switch (thisCaliProcess.curMode) { 
                case EnumMode.IACI:
                    caliData.iaciData[thisCaliProcess.curNum].TestOut = data;
                    break;
                case EnumMode.IACF:
                    caliData.iacfData[thisCaliProcess.curNum].TestOut = data;
                    break;
                case EnumMode.IDC:
                    caliData.idcData[thisCaliProcess.curNum].TestOut = data;
                    break;
                case EnumMode.VACF:
                    caliData.vacfData[thisCaliProcess.curNum].TestOut = data;
                    break;
                case EnumMode.VACVL:
                    caliData.vacvData[thisCaliProcess.curNum].TestOut = data;
                    break;
                case EnumMode.VACVH:
                    caliData.vacvData[CaliData.VLOWNUM + thisCaliProcess.curNum].TestOut = data;
                    break;
                case EnumMode.VDCL:
                    if (thisCaliProcess.curNum < CaliData.VLOWNUM)
                    {
                        caliData.vdcData[thisCaliProcess.curNum].TestOut = data;
                    }
                    else 
                    {
                        caliData.vdcData[CaliData.VDCPNUM + thisCaliProcess.curNum -CaliData.VLOWNUM].TestOut = data;
                    }
                    break;
                case EnumMode.VDCHP:
                    caliData.vdcData[CaliData.VLOWNUM + thisCaliProcess.curNum].TestOut = data;                   
                    break;
                case EnumMode.VDCHN:
                    caliData.vdcData[CaliData.VDCPNUM + CaliData.VLOWNUM + thisCaliProcess.curNum].TestOut = data;
                    break;
            }
            //已读
            if (thisCaliProcess.curNumTest == thisCaliProcess.curNum-1)
            {
                thisCaliProcess.curNumTest++;
            }
        }
        //CS9010定时发送指令函数
        private void CS9010Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (caliState == EnumCaliState.COMPLETE)
            {
                CS9010Timer.Enabled = false;
                return; 
            }
            if (sendcount9010 != 0)
                return;
            string command = "";
            //判断是否已处于远控状态
            if (instrumentsState.CS9010State == EnumInstrumentState.INIT)
            {
                //寻址
                command += CommandCS9010.Communication[(int)CommandCS9010.cmdCommunication.SADD];
                command += comSetForm.numSaddTestValue;
            }
            else if (instrumentsState.CS9010State == EnumInstrumentState.SADD)
            {
                //远控
                command += CommandCS9010.Communication[(int)CommandCS9010.cmdCommunication.REMOTE];               
            }
            else {               
                //判断是否需要切换模式
                if(caliProcess.changeMode && !caliProcess.changeMode9010)
                {
                    switch(caliProcess.curMode)
                    {
                        case EnumMode.IACI:                            
                            //第一个档位时需要切换模式
                            if (caliProcess.stall == EnumStall.STALL_6) 
                            {
                                command += CommandCS9010.Configure[(int)CommandCS9010.cmdConfigure.IAC];
                                TestSendMessage(command, false);
                                command = "";                                
                            }
                            //判断是否切换档位
                            if (caliProcess.stall != EnumStall.STALL_NO) {
                                command += CommandCS9010.SwitchStall[(int)caliProcess.stall];                                                                                                             
                            }
                            break;
                        case EnumMode.IACF:
                            command += CommandCS9010.Configure[(int)CommandCS9010.cmdConfigure.IAC];
                            TestSendMessage(command, false);
                            command = "";  
                            //切换档位为30mA档
                            command += CommandCS9010.Configure[(int)CommandCS9010.cmdConfigure.STALL4];                                                       
                            break;
                        case EnumMode.IDC:
                            //第一个档位时需要切换模式
                            if (caliProcess.stall == EnumStall.STALL_6)
                            {
                                command += CommandCS9010.Configure[(int)CommandCS9010.cmdConfigure.IAC];
                                TestSendMessage(command, false);
                                command = "";  
                            }
                            //判断是否切换档位
                            if (caliProcess.stall != EnumStall.STALL_NO)
                            {
                                command += CommandCS9010.SwitchStall[(int)caliProcess.stall];
                            }
                            break;
                        case EnumMode.VACVL:
                        case EnumMode.VACVH:
                        case EnumMode.VACF:
                            command += CommandCS9010.Configure[(int)CommandCS9010.cmdConfigure.VAC];                              
                            break;
                        case EnumMode.VDCL:
                        case EnumMode.VDCHP:
                        case EnumMode.VDCHN:
                            command += CommandCS9010.Configure[(int)CommandCS9010.cmdConfigure.VDC];                              
                            break;
                    }
                    if (command != "")
                    {
                        TestSendMessage(command, false);
                    }  
                    caliProcess.changeMode9010 = true;
                    return;
                }
                else
                {
                    //该模式校准完毕
                    if( caliProcess.curNumTest == caliProcess.curModeTotal - 1 )
                    {
                        return;
                    }
                    //发送查询指令时，判断是否源已经稳定
                    /*
                    if (!(stateCS9920B == StateSource.OUT_STABLE || stateCS9920A == StateSource.OUT_STABLE || stateFluke5520A == StateSource.OUT_STABLE))
                    {
                        return;
                    }
                    */
                    if (caliProcess.curMode == EnumMode.IACF || caliProcess.curMode == EnumMode.VACF)
                    {
                        //command += CommandCS9010.Measure[(int)CommandCS9010.cmdMeasure.FREQ];
                        command += CommandCS9010.Measure[(int)CommandCS9010.cmdMeasure.VALUE];
                    }
                    else {
                        command += CommandCS9010.Measure[(int)CommandCS9010.cmdMeasure.VALUE];
                    }
                }

            }
            TestSendMessage(command,true);
        }
        //CS9010串口发送数据
        public void TestSendMessage(string command,bool addCount)
        {
            string cmd = command;
            if (cmd == "")
                return;
            cmd += "#";//结束符
            if (addCount)
            {
                //已发送命令数加1
                sendcount9010++;
            }
            comTest.Write(cmd);
            Console.WriteLine("发送到CS9010:" + cmd);
        } 
        //标准表2网口socket的定时器
        private void ReceiveTimer_2()
        {
            SocketTimer_2.Elapsed += ReceiveHandler_2;    //定时事件的方法
            SocketTimer_2.Interval = 1000;
            SocketTimer_2.Enabled = true;
        }
        //标准表2接收返回的数据
        private void ReceiveHandler_2(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                byte[] buffer = new byte[100];
                int len = 0;
                if (socketStand2.Available > 0)
                {
                    //实际接收到的字节数
                    len = socketStand2.Receive(buffer, SocketFlags.None);
                }
                if (len != 0)
                {
                    string str = Encoding.Default.GetString(buffer, 0, len);
                    if (mainMeasureType == MainMeasureType.DEBUGCOM)
                    {
                        this.textReceive.Text += str;
                    }
                    else
                    {
                        ResolveDataById(str, 2); 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("接收标准表2的消息出错:" + ex.ToString());
            }
        }
        //标准表接收数据后的处理函数
        public void ResolveDataById(string receiveData,int id)
        {
            //查询数据库中源的状态
            int state = DAO.QueryDividerState(dividerProcess);
            //state=1表示源已稳定
            if (state == 1)
            {
                //对收到的字符进行转换 电压（单位V）12V: +1.20000947E+01 电流（单位A）50mA: +4.85071641E-02
                string[] strs = receiveData.Split('E');
                int sign = strs[0].StartsWith("+") == true ? 1 : -1;
                float digit;
                int exponent;
                try
                {
                    digit = float.Parse(strs[0]);
                    exponent = int.Parse(strs[1]);
                }
                catch (Exception)
                {
                    Console.WriteLine("transfer data error!");
                    return;
                }
                float value = digit * (float)Math.Pow(10, exponent);
                if (mainMeasureType == MainMeasureType.CALIBRATION)
                {
                    switch(caliProcess.curMode)
                    {
                        case EnumMode.IACI:
                        case EnumMode.IACF:
                        case EnumMode.IDC:
                            value = value * 1000;
                            break;
                        case EnumMode.VACF:
                        case EnumMode.VACVH:
                        case EnumMode.VACVL:
                        case EnumMode.VDCL:
                        case EnumMode.VDCHP:
                        case EnumMode.VDCHN:
                            value = value / 1000;
                            break;
                    }
                    //保存到caliData
                    SaveStandToCaliData(value, caliProcess);
                }
                else
                {
                    //单位为V
                    //value = value / 1000;  
                    //保存到dividerData,并获取数据库中源输入、温湿度等数据
                    SaveVoltToDividerData(value,id);
                }
            }
            if (id == 1)
            {
                if (sendcount34410A > 0)
                {
                    sendcount34410A--;
                }
            }
            else
            {
                if (sendcount34410A_2 > 0)
                {
                    sendcount34410A_2--;
                } 
            }
            Console.WriteLine("接收到34410A编号" + id + ":" + receiveData);
        }


        //校准时标准表34410A保存测量值
        public void SaveStandToCaliData(float data,CaliProcess thisCaliProcess) 
        {
            switch (thisCaliProcess.curMode)
            {
                case EnumMode.IACI:
                    caliData.iaciData[thisCaliProcess.curNum].StandOut = data;
                    break;
                case EnumMode.IACF:
                    caliData.iacfData[thisCaliProcess.curNum].StandOut = data;
                    break;
                case EnumMode.IDC:
                    caliData.idcData[thisCaliProcess.curNum].StandOut = data;
                    break;
                case EnumMode.VACF:
                    caliData.vacfData[thisCaliProcess.curNum].StandOut = data;
                    break;
                case EnumMode.VACVL:
                    caliData.vacvData[thisCaliProcess.curNum].StandOut = data;
                    break;
                case EnumMode.VACVH:
                    caliData.vacvData[CaliData.VLOWNUM + thisCaliProcess.curNum].StandOut = data;
                    break;
                case EnumMode.VDCL:
                    if (thisCaliProcess.curNum < CaliData.VLOWNUM)
                    {
                        caliData.vdcData[thisCaliProcess.curNum].StandOut = data;
                    }
                    else
                    {
                        caliData.vdcData[CaliData.VDCPNUM + thisCaliProcess.curNum - CaliData.VLOWNUM].StandOut = data;
                    }
                    break;
                case EnumMode.VDCHP:                    
                    caliData.vdcData[CaliData.VLOWNUM + thisCaliProcess.curNum].StandOut = data;
                    break;
                case EnumMode.VDCHN:                   
                    caliData.vdcData[CaliData.VDCPNUM + CaliData.VLOWNUM + thisCaliProcess.curNum].StandOut = data;
                    break;
            }
            //已读
            if (thisCaliProcess.curNumStand == thisCaliProcess.curNum-1)
            {
                thisCaliProcess.curNumStand++;
            }
        }
        //标准表2发送消息函数
        private void Stand2SendMessage(string command)
        {
            try
            {
                string cmd = command;
                cmd += "\r\n";
                if (!comStand2.IsOpen)
                {
                    byte[] buffer = new byte[100];
                    buffer = Encoding.Default.GetBytes(cmd);
                    //用网口
                    socketStand2.Send(buffer);
                }
                else
                {
                    //用串口
                    comStand2.Write(cmd);
                }
                Console.WriteLine("发送到34410A编号2:" + cmd);
            }
            catch (Exception ex)
            {
                MessageBox.Show("标准表2发送消息出错:" + ex.Message);
            }
        }
        //校准时34410A定时发送函数
        private void Agilent34410ATimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (caliState == EnumCaliState.COMPLETE)
            {
                Agilent34410ATimer.Enabled = false;
                return;
            }
            if (sendcount34410A != 0)
                return;
            string command = "";
            //判断是否已处于远控状态
            if (instrumentsState.Agilent34410AState != EnumInstrumentState.REMOTE)
            {
                command += CommandAgilent34410A.System[(int)CommandAgilent34410A.cmdSystem.Remote];
                instrumentsState.Agilent34410AState = EnumInstrumentState.REMOTE;
            }
            else
            {                
                //根据校准模式发送查询指令                
                switch (caliProcess.curMode)
                {
                    case EnumMode.IACI:
                        command += CommandAgilent34410A.Measure[(int)CommandAgilent34410A.cmdMeasure.IAC];
                        break;
                    case EnumMode.IACF:
                    case EnumMode.VACF:
                        command += CommandAgilent34410A.Measure[(int)CommandAgilent34410A.cmdMeasure.FREQ];
                        break;
                    case EnumMode.IDC:
                        command += CommandAgilent34410A.Measure[(int)CommandAgilent34410A.cmdMeasure.IDC];
                        break;
                    case EnumMode.VACVL:
                    case EnumMode.VACVH:
                        command += CommandAgilent34410A.Measure[(int)CommandAgilent34410A.cmdMeasure.VAC];
                        break;
                    case EnumMode.VDCL:
                    case EnumMode.VDCHP:
                    case EnumMode.VDCHN:
                        command += CommandAgilent34410A.Measure[(int)CommandAgilent34410A.cmdMeasure.VDC];
                        break;
                }
                //curNumStand从-1开始，到caliProcess.curModeTotal - 1时，所有点已完成
                if (caliProcess.curNumStand == caliProcess.curModeTotal - 1)
                {
                    return;
                }
                sendcount34410A++;
            }
            Stand2SendMessage(command);
        }        
       
        private void rbType_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            switch (rb.Text)
            {
                case "全部":
                    this.caliProcess.type = true;
                    break;
                case "当前":
                    this.caliProcess.type = false;
                    break;
            }
            caliProcess.setTotalNumByType(caliData);
        }
        //标签切换函数
        private void dmTabCtrl_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            switch (this.dmTabCtrl.SelectedIndex) { 
                //校准
                case 0:
                    mainMeasureType = MainMeasureType.CALIBRATION;
                    break;
                //分压器监测
                case 1:
                    mainMeasureType = MainMeasureType.DIVIDER;
                    break;
                //通信调试
                case 2:
                    mainMeasureType = MainMeasureType.DEBUGCOM;
                    this.textReceive.Text = "";
                    break;
            }
        }

        /*分压器监测时，标准表保存测量值   
        * id表示标准表序号，1测量值为输入，2测量值为输出
        */
        public void SaveVoltToDividerData(float data, int id)
        {
            if (dividerProcess.complete == EnumCaliState.COMPLETE)
            {
                return;
            }
            ProcessDelegate showProcess = new ProcessDelegate(Load_Page_Divider);
            List<DividerItem> list = null;
            switch (dividerProcess.curMode)
            {
                case EnumMode.Divider_V_AC:
                    list = dividerData.voltageACData;
                    break;
                case EnumMode.Divider_V_DCP:
                    list = dividerData.voltageDCPData;
                    break;
                case EnumMode.Divider_V_DCN:
                    list = dividerData.voltageDCNData;
                    break;
                case EnumMode.Divider_F:
                    list = dividerData.frequencyData;
                    break;
            }
            if (id == 1)
            {
                //输入测量值，已读
                if (dividerProcess.curNumStand == dividerProcess.curNum - 1)
                {
                    list[dividerProcess.curNum].StandOut = data;
                    dividerProcess.curNumStand++;
                }
            }
            else
            {
                //输出测量值，已读
                //先获取当前点序号，curNum从0开始
                int curNum = DAO.SelectCurnumFromMaster() - 1;
                if (dividerProcess.curNum < curNum)
                {
                    //点数加1
                    dividerProcess.curTotalNum++;
                    dividerProcess.curNum = curNum;
                }
                //保存输出端值
                list[dividerProcess.curNum].TestOut = data;
                //获取数据库中输入端、温湿度等数据
                bool dataValid = DAO.FillDividerDataFromMaster(dividerProcess, dividerData);
                //测量点更新为已测量
                dividerGridViewModel.updateItem(dividerData, dividerProcess);
                //刷新列表
                dgvDivider.Invoke(showProcess, false);
                //是否要切换模式
                dividerProcess.getCurMode(dividerData,dataValid);
                if(dataValid)
                {
                    dgvDivider.Invoke(showProcess, true);
                }
            }
        }
        //分压器监测时标准表2定时发送函数
        private void Agilent34410ATimer_2_Elapsed_Divider(object sender, System.Timers.ElapsedEventArgs e)       
        {
            int sourceState = 0;

            if (dividerState != EnumCaliState.START)
            {
                Agilent34410ATimer_2.Enabled = false;
                return;
            }
            if (sendcount34410A_2 != 0)
                return;
            string command = "";
            //判断是否已处于远控状态
            if (instrumentsState.Agilent34410AState_2 != EnumInstrumentState.REMOTE)
            {
                command += CommandAgilent34410A.System[(int)CommandAgilent34410A.cmdSystem.Remote];
                Stand2SendMessage(command);
                command = "";
                command += CommandAgilent34410A.System[(int)CommandAgilent34410A.cmdSystem.Clear];
                instrumentsState.Agilent34410AState_2 = EnumInstrumentState.REMOTE;
            }
            else
            {
                sourceState = DAO.QueryDividerState(dividerProcess);
                if ( sourceState != 1)
                {
                    return;
                }
                //根据校准模式发送查询指令                
                switch (dividerProcess.curMode)
                {
                    case EnumMode.Divider_V_AC:
                    case EnumMode.Divider_F:
                        command += CommandAgilent34410A.Measure[(int)CommandAgilent34410A.cmdMeasure.VAC];
                        break;
                    case EnumMode.Divider_V_DCP:
                    case EnumMode.Divider_V_DCN:
                        command += CommandAgilent34410A.Measure[(int)CommandAgilent34410A.cmdMeasure.VDC];
                        break;
                }
                if (dividerProcess.complete == EnumCaliState.COMPLETE)
                {
                    Agilent34410ATimer_2.Enabled = false;
                    return;
                }
                sendcount34410A_2++;
            }
            Stand2SendMessage(command);
        }
       
        //十六进制字符串转换为字节数组
        public byte[] HexString2Bytes(string hs)
        {
            string[] strArr = hs.Trim().Split(' ');
            byte[] bytes = new byte[strArr.Length];
            //逐个字符变为16进制字节数据
            for (int i = 0; i < strArr.Length; i++)
            {
                bytes[i] = Convert.ToByte(strArr[i], 16);
            }
            //按照指定编码将字节数组变为字符串
            return bytes;
        }
           
        //标准表2串口接收数据函数
        private void comStand2_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int n = comStand2.BytesToRead;
            if (n <= 0)
                return;
            byte[] buf = new byte[n];//声明一个临时数组存储当前来的串口数据
            comStand2.Read(buf, 0, n);
            string result = System.Text.Encoding.Default.GetString(buf);
            if (mainMeasureType == MainMeasureType.DEBUGCOM)
            {
                this.textReceive.Text += result;
            }
            else
            {
                ResolveDataById(result, 2);             
            }
        }
        //保存校准结果到数据库
        private void btnsavecali_Click(object sender, EventArgs e)
        {
            if ( DAO.SaveCaliDataAll(caliData) )
                MessageBox.Show("保存数据成功");
            else
                MessageBox.Show("保存数据出错");
        }
        //保存分压器测量数据到数据库
        private void btnSaveDivider_Click(object sender, EventArgs e)
        {
            bool result = false;
            //判断测量种类
            if (dividerProcess.modeMeasType)
            {
                //全部
                result = DAO.SaveDividerDataAll(dividerData);
            }
            else
            {
                //当前，保存当前测量项的数据
                result = DAO.SaveDividerDataByMode(dividerData, dividerProcess.initiMode);
            }
            if (result)
                MessageBox.Show("保存数据成功");
            else
                MessageBox.Show("保存数据出错");
        }
        //数据下传至待校表
        private void btnsendcali_Click(object sender, EventArgs e)
        {
            instrumentsState.CS9010State = EnumInstrumentState.SENDCALIDATA;
            //CAL:VACF 1:50.00:1001.00#CAL:VACF 2:150.00:1000.00#...CAL:VACF 10:950.00:1000.00#CAL:VACF 10E#
            var cmd = new CommandCS9010.cmdCalibrationSet();
            string[] cmds = Enum.GetNames(cmd.GetType()); 
            int cmdNum = 0;
            int num = 0;
            for (; cmdNum < cmds.Length; cmdNum++) 
            {
                string command = "";
                string preffix = CommandCS9010.CalibrationSet[cmdNum];
                int start = 0;
                int end = 0;
                float stand = 0;
                float test = 0;
                List<CaliItem> list = null;
                switch (cmdNum)
                {
                    case (int)CommandCS9010.cmdCalibrationSet.IACI:                        
                        end = caliData.iaciData.Count;
                        list = caliData.iaciData;
                        break;
                    case (int)CommandCS9010.cmdCalibrationSet.IDCP:
                        end = 30;
                        list = caliData.idcData;
                        break;
                    case (int)CommandCS9010.cmdCalibrationSet.IDCN:
                        start = 30; 
                        end = caliData.idcData.Count;
                        list = caliData.idcData;
                        break;
                    case (int)CommandCS9010.cmdCalibrationSet.IACF:
                        end = caliData.iacfData.Count;
                        list = caliData.iacfData;
                        break;
                    case (int)CommandCS9010.cmdCalibrationSet.VACF:
                        end = caliData.vacfData.Count;
                        list = caliData.vacfData;
                        break;
                    case (int)CommandCS9010.cmdCalibrationSet.VACV:
                        end = caliData.vacvData.Count;
                        list = caliData.vacvData;
                        break;
                    case (int)CommandCS9010.cmdCalibrationSet.VDCP:
                        end = CaliData.VDCPNUM;
                        list = caliData.vdcData;
                        break;
                    case (int)CommandCS9010.cmdCalibrationSet.VDCN:
                        start = CaliData.VDCPNUM;
                        end = caliData.vdcData.Count;
                        list = caliData.vdcData;
                        break;                             
                }
                if(cmdNum == (int)CommandCS9010.cmdCalibrationSet.IACI || cmdNum == (int)CommandCS9010.cmdCalibrationSet.IDCP || cmdNum == (int)CommandCS9010.cmdCalibrationSet.IDCN)
                {
                    for (num = start; num < end; num++)
                    {
                        stand = list[num].StandOut;
                        test = list[num].TestOut;
                        command += preffix;
                        //电阻序号
                        int stall = 3 + (num-start) / 5;
                        command += stall + " ";
                        //序号
                        command += 1 + (num % 5) + ":";
                        //标准值
                        command += stand + ":";
                        //测量值
                        command += test+"#";
                        if (num % 5 == 4)
                        {
                            //总和
                            command += preffix + stall + " " + 5 + "E";
                            TestSendMessage(command, false);
                            command = "";
                            Thread.Sleep(1000);//休眠时间
                        }
                    }
                }
                else{
                    for (num = start; num < end; num++)
                    {
                        stand = list[num].StandOut;
                        if (cmdNum == (int)CommandCS9010.cmdCalibrationSet.IACI || cmdNum == (int)CommandCS9010.cmdCalibrationSet.VACF)
                        {
                            stand = list[num].Source;
                        }
                        test = list[num].TestOut;
                        command += preffix;
                        //序号
                        command += 1 + num-start + ":";
                        //标准值
                        command += stand +":";
                        //测量值
                        command += test + "#";
                    }
                    //总和
                    command += preffix + (num-start) + "E";
                    TestSendMessage(command, false);                
                }
                Thread.Sleep(1000);//休眠时间
            }
            instrumentsState.CS9010State = EnumInstrumentState.REMOTE;
        }
        //读取待校表数据

        private void btnReadCali_Click(object sender, EventArgs e)
        {
            //数据查询
            var cmd = new CommandCS9010.cmdCalibrationGet();
            int i = 0;
            for (; i < Enum.GetNames(cmd.GetType()).Length; i++)
            {
                string command = CommandCS9010.CalibrationGet[i];
                TestSendMessage(command, true);
                Thread.Sleep(200);//休眠时间
            }
        }
        //分压器某一种类测量结束后，保存数据是否是自动
        private void rbSaveAuto_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            switch (rb.Text) { 
                case "自动":
                    this.dividerProcess.modeSaveData = true;
                    break;
                case "手动":
                    this.dividerProcess.modeSaveData = false;
                    break;
            }
        }
        //分压器测量种类，当前和全部
        private void rbMeasTypeCur_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            switch (rb.Text)
            {
                case "当前":
                    this.dividerProcess.modeMeasType = false;
                    break;
                case "全部":
                    this.dividerProcess.modeMeasType = true;
                    break;
            }
        }
        //分压器测量时是否循环测量
        private void rbCycleYes_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            switch (rb.Text)
            {
                case "是":
                    this.dividerProcess.modeCycleSwitch = true;
                    break;
                case "否":
                    this.dividerProcess.modeCycleSwitch = false;
                    break;
            }
        }
        //分压器开始监测，只需要读取分压器输出
        private void btnDividerStart_Click(object sender, EventArgs e)
        {
            int dividerId = (int)this.numericDividerId.Value;
            if (dividerId <= 0)
            {
                MessageBox.Show("请输入分压器编号！");
                return;
            }
            else
            {
                dividerData.dividerId = dividerId;
            }
            INTERNAL = (int)this.numericInternal.Value*1000;
            ProcessDelegate showProcess = new ProcessDelegate(Load_Page_Divider);
            this.dividerProcess.initiMode = this.dividerProcess.curMode;
            //一次监测过程完成后，重置数据再监测
            if (dividerState == EnumCaliState.COMPLETE)
            {
                resetDividerProcess(showProcess);
            }
            if (dividerState == EnumCaliState.INITI || dividerState == EnumCaliState.PAUSE)
            {
                //设置定时器定时时间
                Agilent34410ATimer_2.Interval = INTERNAL;
            }
            //从取消校准，开始校准
            else if (dividerState == EnumCaliState.CANCEL)
            {
                resetDividerProcess(showProcess);
            }
            //判断Agilent34410表是否连接
            if ((socketStand2 == null || !socketStand2.Connected) && !comStand2.IsOpen)
            {
                MessageBox.Show("标准表2未连接");
                return;
            }
            Agilent34410ATimer_2.Enabled = true;
            if (dividerState != EnumCaliState.PAUSE)
            {
                InitialProgressBar(dividerProcess.totalNum,mainMeasureType);
            }
            dividerProcess.complete = EnumCaliState.START;
            dividerState = EnumCaliState.START;
        }
        //分压器暂停监测
        private void btnDividerPause_Click(object sender, EventArgs e)
        {
            //设置暂停标志
            dividerState = EnumCaliState.PAUSE;
            //停止各定时函数
            Agilent34410ATimer_2.Enabled = false;
        }
        //分压器取消监测
        private void btnDividerCancel_Click(object sender, EventArgs e)
        {
            //设置取消标志
            dividerState = EnumCaliState.CANCEL;
            //停止各定时函数
            Agilent34410ATimer_2.Enabled = false;
        }
        //重置分压器数据
        public void resetDividerProcess(ProcessDelegate showProcess)
        {
            //重置dividerData,dividerProcess
            dividerData.Reset(dividerProcess.modeMeasType, dividerProcess.initiMode);
            dividerProcess.ResetProcess(dividerProcess.initiMode, dividerData);
            dividerGridViewModel.curModePage = 0;
            this.progressBarDivider.Value = 0;
            //刷新列表
            dgvDivider.Invoke(showProcess, false); 
        }
        //分压器重置结果
        private void btnDividerReset_Click(object sender, EventArgs e)
        {
            //重新获取数据库中数据
            dividerData.ResetSource();
            ProcessDelegate showProcess = new ProcessDelegate(Load_Page_Divider);
            resetDividerProcess(showProcess);
        }
        //通信调试时选择通信端口
        private void rbDebugComSelect_CheckedChanged(object sender, System.EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            switch (rb.Text)
            {
                case "标准表2(34401)":
                    this.debugComSelect = DebugComSelect.STAND2_34401;
                    break;
                case "待校准表":
                    this.debugComSelect = DebugComSelect.CALITEST;
                    break;
            }
        }
        //通过输入框向网口发送消息
        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                string strMsg = this.textSend.Text.TrimStart();
                switch (this.debugComSelect)
                {
                    case DebugComSelect.CALITEST:
                        if (!this.comTest.IsOpen)
                        {
                            MessageBox.Show("待校准表未连接！");
                        }
                        else
                        {
                            comTest.Write(strMsg);
                        }
                        break;
                    case DebugComSelect.STAND2_34401:
                        if ((socketStand2 == null || !socketStand2.Connected) && !comStand2.IsOpen)
                        {
                            MessageBox.Show("标准表2未连接！");
                        }
                        else
                        {
                            if (comStand2.IsOpen)
                            {
                                comStand2.Write(strMsg);
                            }
                            else
                            {
                                byte[] buffer = new byte[2048];
                                buffer = Encoding.Default.GetBytes(strMsg);
                                socketStand2.Send(buffer);
                            }
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("发送消息出错:" + ex.Message);
            }
        }
    }
}
