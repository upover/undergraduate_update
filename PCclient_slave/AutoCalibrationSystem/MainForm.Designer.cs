﻿namespace AutoCalibrationSystem
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnDeleteAllPoint;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btLoginout = new System.Windows.Forms.Button();
            this.btncomset = new System.Windows.Forms.Button();
            this.btnresult = new System.Windows.Forms.Button();
            this.btnuser = new System.Windows.Forms.Button();
            this.btncaliset = new System.Windows.Forms.Button();
            this.btnstartcali = new System.Windows.Forms.Button();
            this.btnsavecali = new System.Windows.Forms.Button();
            this.dgvCaliItem = new System.Windows.Forms.DataGridView();
            this.Mode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Source = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StandOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddPoint = new System.Windows.Forms.Button();
            this.btnDeletePoint = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.rbVDCL = new System.Windows.Forms.RadioButton();
            this.rbVDCHP = new System.Windows.Forms.RadioButton();
            this.rbVACVL = new System.Windows.Forms.RadioButton();
            this.rbVACVH = new System.Windows.Forms.RadioButton();
            this.rbVACF = new System.Windows.Forms.RadioButton();
            this.rbIDC = new System.Windows.Forms.RadioButton();
            this.rbIACI = new System.Windows.Forms.RadioButton();
            this.rbIACF = new System.Windows.Forms.RadioButton();
            this.rbUnitSmall = new System.Windows.Forms.RadioButton();
            this.rbUnitBig = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbVDCHN = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textSend = new System.Windows.Forms.TextBox();
            this.textReceive = new System.Windows.Forms.TextBox();
            this.btnPrePage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.labelCurPage = new System.Windows.Forms.Label();
            this.labelTotalRecord = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btncancelcali = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbTypeAll = new System.Windows.Forms.RadioButton();
            this.rbTypeCur = new System.Windows.Forms.RadioButton();
            this.btnsendcali = new System.Windows.Forms.Button();
            this.btnanalyze = new System.Windows.Forms.Button();
            this.progressBarCali = new System.Windows.Forms.ProgressBar();
            this.btnpausecali = new System.Windows.Forms.Button();
            this.labelprogress = new System.Windows.Forms.Label();
            this.labelcompleted = new System.Windows.Forms.Label();
            this.dmTabCtrl = new DMSkin.Controls.DMTabControl();
            this.TabCalibrate = new System.Windows.Forms.TabPage();
            this.btnReadCali = new System.Windows.Forms.Button();
            this.TabEvaluate = new System.Windows.Forms.TabPage();
            this.numericDividerId = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericInternal = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.rbMeasTypeCur = new System.Windows.Forms.RadioButton();
            this.rbMeasTypeAll = new System.Windows.Forms.RadioButton();
            this.btnDividerReset = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.rbCycleYes = new System.Windows.Forms.RadioButton();
            this.rbCycleNo = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rbSmallUtilDivider = new System.Windows.Forms.RadioButton();
            this.rbBigUtilDivider = new System.Windows.Forms.RadioButton();
            this.labelTotalRecordDivider = new System.Windows.Forms.Label();
            this.labelCurPageDivider = new System.Windows.Forms.Label();
            this.btnnextpage_divider = new System.Windows.Forms.Button();
            this.btnprepage_divider = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbvac = new System.Windows.Forms.RadioButton();
            this.rbvdcn = new System.Windows.Forms.RadioButton();
            this.rbf = new System.Windows.Forms.RadioButton();
            this.rbvdcp = new System.Windows.Forms.RadioButton();
            this.labelCompleteDivider = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBarDivider = new System.Windows.Forms.ProgressBar();
            this.btnDividerPause = new System.Windows.Forms.Button();
            this.btnDividerCancel = new System.Windows.Forms.Button();
            this.btnDividerStart = new System.Windows.Forms.Button();
            this.btnSaveDivider = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbSaveAuto = new System.Windows.Forms.RadioButton();
            this.rbSaveMan = new System.Windows.Forms.RadioButton();
            this.dgvDivider = new System.Windows.Forms.DataGridView();
            this.tabDebugCom = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.rbComCaliTest = new System.Windows.Forms.RadioButton();
            this.rbCom34401 = new System.Windows.Forms.RadioButton();
            this.rbCom34410 = new System.Windows.Forms.RadioButton();
            this.ModeDivider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SourceDivider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrequencyDivider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StandDivider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestDivider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TemperatureDivider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HumidityDivider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StateDivider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnDeleteAllPoint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaliItem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.dmTabCtrl.SuspendLayout();
            this.TabCalibrate.SuspendLayout();
            this.TabEvaluate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDividerId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInternal)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDivider)).BeginInit();
            this.tabDebugCom.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeleteAllPoint
            // 
            btnDeleteAllPoint.Location = new System.Drawing.Point(363, 437);
            btnDeleteAllPoint.Name = "btnDeleteAllPoint";
            btnDeleteAllPoint.Size = new System.Drawing.Size(75, 23);
            btnDeleteAllPoint.TabIndex = 96;
            btnDeleteAllPoint.Text = "全部删除";
            btnDeleteAllPoint.UseVisualStyleBackColor = true;
            // 
            // btLoginout
            // 
            this.btLoginout.Image = ((System.Drawing.Image)(resources.GetObject("btLoginout.Image")));
            this.btLoginout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLoginout.Location = new System.Drawing.Point(451, 2);
            this.btLoginout.Name = "btLoginout";
            this.btLoginout.Size = new System.Drawing.Size(58, 23);
            this.btLoginout.TabIndex = 83;
            this.btLoginout.Text = "退出";
            this.btLoginout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLoginout.UseVisualStyleBackColor = true;
            this.btLoginout.Click += new System.EventHandler(this.btLoginout_Click);
            // 
            // btncomset
            // 
            this.btncomset.Location = new System.Drawing.Point(104, 2);
            this.btncomset.Name = "btncomset";
            this.btncomset.Size = new System.Drawing.Size(75, 23);
            this.btncomset.TabIndex = 84;
            this.btncomset.Text = "通信配置";
            this.btncomset.UseVisualStyleBackColor = true;
            this.btncomset.Click += new System.EventHandler(this.btncomset_Click);
            // 
            // btnresult
            // 
            this.btnresult.Location = new System.Drawing.Point(194, 2);
            this.btnresult.Name = "btnresult";
            this.btnresult.Size = new System.Drawing.Size(75, 23);
            this.btnresult.TabIndex = 85;
            this.btnresult.Text = "结果管理";
            this.btnresult.UseVisualStyleBackColor = true;
            this.btnresult.Click += new System.EventHandler(this.btnresult_Click);
            // 
            // btnuser
            // 
            this.btnuser.Location = new System.Drawing.Point(370, 2);
            this.btnuser.Name = "btnuser";
            this.btnuser.Size = new System.Drawing.Size(75, 23);
            this.btnuser.TabIndex = 86;
            this.btnuser.Text = "用户管理";
            this.btnuser.UseVisualStyleBackColor = true;
            // 
            // btncaliset
            // 
            this.btncaliset.Location = new System.Drawing.Point(12, 2);
            this.btncaliset.Name = "btncaliset";
            this.btncaliset.Size = new System.Drawing.Size(75, 23);
            this.btncaliset.TabIndex = 87;
            this.btncaliset.Text = "校准项配置";
            this.btncaliset.UseVisualStyleBackColor = true;
            this.btncaliset.Click += new System.EventHandler(this.btncaliset_Click);
            // 
            // btnstartcali
            // 
            this.btnstartcali.Location = new System.Drawing.Point(5, 463);
            this.btnstartcali.Name = "btnstartcali";
            this.btnstartcali.Size = new System.Drawing.Size(75, 23);
            this.btnstartcali.TabIndex = 88;
            this.btnstartcali.Text = "开始校准";
            this.btnstartcali.UseVisualStyleBackColor = true;
            this.btnstartcali.Click += new System.EventHandler(this.btnstartcali_Click);
            // 
            // btnsavecali
            // 
            this.btnsavecali.Location = new System.Drawing.Point(265, 463);
            this.btnsavecali.Name = "btnsavecali";
            this.btnsavecali.Size = new System.Drawing.Size(75, 23);
            this.btnsavecali.TabIndex = 89;
            this.btnsavecali.Text = "保存结果";
            this.btnsavecali.UseVisualStyleBackColor = true;
            this.btnsavecali.Click += new System.EventHandler(this.btnsavecali_Click);
            // 
            // dgvCaliItem
            // 
            this.dgvCaliItem.AllowUserToOrderColumns = true;
            this.dgvCaliItem.AllowUserToResizeColumns = false;
            this.dgvCaliItem.AllowUserToResizeRows = false;
            this.dgvCaliItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCaliItem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvCaliItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCaliItem.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvCaliItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCaliItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCaliItem.ColumnHeadersHeight = 48;
            this.dgvCaliItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCaliItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mode,
            this.Source,
            this.StandOut,
            this.TestOut,
            this.State});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCaliItem.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCaliItem.EnableHeadersVisualStyles = false;
            this.dgvCaliItem.GridColor = System.Drawing.Color.Black;
            this.dgvCaliItem.Location = new System.Drawing.Point(6, 66);
            this.dgvCaliItem.MinimumSize = new System.Drawing.Size(0, 32);
            this.dgvCaliItem.Name = "dgvCaliItem";
            this.dgvCaliItem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvCaliItem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCaliItem.RowTemplate.Height = 30;
            this.dgvCaliItem.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvCaliItem.Size = new System.Drawing.Size(871, 370);
            this.dgvCaliItem.StandardTab = true;
            this.dgvCaliItem.TabIndex = 92;
            this.dgvCaliItem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCaliItem_CellContentClick);
            // 
            // Mode
            // 
            this.Mode.DataPropertyName = "Mode";
            this.Mode.HeaderText = "模式";
            this.Mode.Name = "Mode";
            // 
            // Source
            // 
            this.Source.DataPropertyName = "Source";
            this.Source.HeaderText = "源";
            this.Source.Name = "Source";
            // 
            // StandOut
            // 
            this.StandOut.DataPropertyName = "StandOut";
            this.StandOut.HeaderText = "标准表";
            this.StandOut.Name = "StandOut";
            // 
            // TestOut
            // 
            this.TestOut.DataPropertyName = "TestOut";
            this.TestOut.HeaderText = "待校表";
            this.TestOut.Name = "TestOut";
            // 
            // State
            // 
            this.State.DataPropertyName = "State";
            this.State.HeaderText = "状态";
            this.State.Name = "State";
            // 
            // btnAddPoint
            // 
            this.btnAddPoint.Location = new System.Drawing.Point(175, 437);
            this.btnAddPoint.Name = "btnAddPoint";
            this.btnAddPoint.Size = new System.Drawing.Size(75, 23);
            this.btnAddPoint.TabIndex = 93;
            this.btnAddPoint.Text = "增加点";
            this.btnAddPoint.UseVisualStyleBackColor = true;
            this.btnAddPoint.Click += new System.EventHandler(this.btnAddPoint_Click);
            // 
            // btnDeletePoint
            // 
            this.btnDeletePoint.Location = new System.Drawing.Point(265, 437);
            this.btnDeletePoint.Name = "btnDeletePoint";
            this.btnDeletePoint.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePoint.TabIndex = 95;
            this.btnDeletePoint.Text = "删除点";
            this.btnDeletePoint.UseVisualStyleBackColor = true;
            this.btnDeletePoint.Click += new System.EventHandler(this.btnDeletePoint_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(455, 437);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 97;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(104, 419);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 98;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(479, 419);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 99;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // rbVDCL
            // 
            this.rbVDCL.AutoSize = true;
            this.rbVDCL.Location = new System.Drawing.Point(323, 20);
            this.rbVDCL.Name = "rbVDCL";
            this.rbVDCL.Size = new System.Drawing.Size(65, 16);
            this.rbVDCL.TabIndex = 100;
            this.rbVDCL.TabStop = true;
            this.rbVDCL.Text = "VDC Low";
            this.rbVDCL.UseVisualStyleBackColor = true;
            this.rbVDCL.Click += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rbVDCHP
            // 
            this.rbVDCHP.AutoSize = true;
            this.rbVDCHP.Location = new System.Drawing.Point(487, 20);
            this.rbVDCHP.Name = "rbVDCHP";
            this.rbVDCHP.Size = new System.Drawing.Size(77, 16);
            this.rbVDCHP.TabIndex = 101;
            this.rbVDCHP.TabStop = true;
            this.rbVDCHP.Text = "VDC H Pos";
            this.rbVDCHP.UseVisualStyleBackColor = true;
            this.rbVDCHP.Click += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rbVACVL
            // 
            this.rbVACVL.AutoSize = true;
            this.rbVACVL.Location = new System.Drawing.Point(238, 20);
            this.rbVACVL.Name = "rbVACVL";
            this.rbVACVL.Size = new System.Drawing.Size(77, 16);
            this.rbVACVL.TabIndex = 102;
            this.rbVACVL.TabStop = true;
            this.rbVACVL.Text = "VAC V Low";
            this.rbVACVL.UseVisualStyleBackColor = true;
            this.rbVACVL.Click += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rbVACVH
            // 
            this.rbVACVH.AutoSize = true;
            this.rbVACVH.Location = new System.Drawing.Point(396, 20);
            this.rbVACVH.Name = "rbVACVH";
            this.rbVACVH.Size = new System.Drawing.Size(83, 16);
            this.rbVACVH.TabIndex = 103;
            this.rbVACVH.TabStop = true;
            this.rbVACVH.Text = "VAC V High";
            this.rbVACVH.UseVisualStyleBackColor = true;
            this.rbVACVH.Click += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rbVACF
            // 
            this.rbVACF.AutoSize = true;
            this.rbVACF.Location = new System.Drawing.Point(177, 20);
            this.rbVACF.Name = "rbVACF";
            this.rbVACF.Size = new System.Drawing.Size(53, 16);
            this.rbVACF.TabIndex = 104;
            this.rbVACF.TabStop = true;
            this.rbVACF.Text = "VAC F";
            this.rbVACF.UseVisualStyleBackColor = true;
            this.rbVACF.Click += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rbIDC
            // 
            this.rbIDC.AutoSize = true;
            this.rbIDC.Location = new System.Drawing.Point(128, 20);
            this.rbIDC.Name = "rbIDC";
            this.rbIDC.Size = new System.Drawing.Size(41, 16);
            this.rbIDC.TabIndex = 105;
            this.rbIDC.TabStop = true;
            this.rbIDC.Text = "IDC";
            this.rbIDC.UseVisualStyleBackColor = true;
            this.rbIDC.Click += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rbIACI
            // 
            this.rbIACI.AutoSize = true;
            this.rbIACI.Location = new System.Drawing.Point(6, 20);
            this.rbIACI.Name = "rbIACI";
            this.rbIACI.Size = new System.Drawing.Size(53, 16);
            this.rbIACI.TabIndex = 106;
            this.rbIACI.TabStop = true;
            this.rbIACI.Text = "IAC I";
            this.rbIACI.UseVisualStyleBackColor = true;
            this.rbIACI.Click += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rbIACF
            // 
            this.rbIACF.AutoSize = true;
            this.rbIACF.Location = new System.Drawing.Point(67, 20);
            this.rbIACF.Name = "rbIACF";
            this.rbIACF.Size = new System.Drawing.Size(53, 16);
            this.rbIACF.TabIndex = 107;
            this.rbIACF.TabStop = true;
            this.rbIACF.Text = "IAC F";
            this.rbIACF.UseVisualStyleBackColor = true;
            this.rbIACF.Click += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rbUnitSmall
            // 
            this.rbUnitSmall.AutoSize = true;
            this.rbUnitSmall.Location = new System.Drawing.Point(15, 20);
            this.rbUnitSmall.Name = "rbUnitSmall";
            this.rbUnitSmall.Size = new System.Drawing.Size(29, 16);
            this.rbUnitSmall.TabIndex = 109;
            this.rbUnitSmall.TabStop = true;
            this.rbUnitSmall.Text = "V";
            this.rbUnitSmall.UseVisualStyleBackColor = true;
            // 
            // rbUnitBig
            // 
            this.rbUnitBig.AutoSize = true;
            this.rbUnitBig.Location = new System.Drawing.Point(50, 20);
            this.rbUnitBig.Name = "rbUnitBig";
            this.rbUnitBig.Size = new System.Drawing.Size(35, 16);
            this.rbUnitBig.TabIndex = 110;
            this.rbUnitBig.TabStop = true;
            this.rbUnitBig.Text = "kV";
            this.rbUnitBig.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbVDCHN);
            this.groupBox1.Controls.Add(this.rbVDCL);
            this.groupBox1.Controls.Add(this.rbVDCHP);
            this.groupBox1.Controls.Add(this.rbIACF);
            this.groupBox1.Controls.Add(this.rbVACVL);
            this.groupBox1.Controls.Add(this.rbIACI);
            this.groupBox1.Controls.Add(this.rbVACVH);
            this.groupBox1.Controls.Add(this.rbIDC);
            this.groupBox1.Controls.Add(this.rbVACF);
            this.groupBox1.Location = new System.Drawing.Point(14, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 51);
            this.groupBox1.TabIndex = 111;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "当前校准项";
            // 
            // rbVDCHN
            // 
            this.rbVDCHN.AutoSize = true;
            this.rbVDCHN.Location = new System.Drawing.Point(572, 20);
            this.rbVDCHN.Name = "rbVDCHN";
            this.rbVDCHN.Size = new System.Drawing.Size(77, 16);
            this.rbVDCHN.TabIndex = 108;
            this.rbVDCHN.TabStop = true;
            this.rbVDCHN.Text = "VDC H Neg";
            this.rbVDCHN.UseVisualStyleBackColor = true;
            this.rbVDCHN.Click += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbUnitSmall);
            this.groupBox2.Controls.Add(this.rbUnitBig);
            this.groupBox2.Location = new System.Drawing.Point(676, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(91, 51);
            this.groupBox2.TabIndex = 112;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "单位";
            // 
            // textSend
            // 
            this.textSend.Location = new System.Drawing.Point(104, 118);
            this.textSend.Multiline = true;
            this.textSend.Name = "textSend";
            this.textSend.Size = new System.Drawing.Size(344, 277);
            this.textSend.TabIndex = 113;
            // 
            // textReceive
            // 
            this.textReceive.Location = new System.Drawing.Point(479, 118);
            this.textReceive.Multiline = true;
            this.textReceive.Name = "textReceive";
            this.textReceive.Size = new System.Drawing.Size(344, 277);
            this.textReceive.TabIndex = 114;
            this.textReceive.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnPrePage
            // 
            this.btnPrePage.Location = new System.Drawing.Point(5, 437);
            this.btnPrePage.Name = "btnPrePage";
            this.btnPrePage.Size = new System.Drawing.Size(75, 23);
            this.btnPrePage.TabIndex = 115;
            this.btnPrePage.Text = "上一页";
            this.btnPrePage.UseVisualStyleBackColor = true;
            this.btnPrePage.Click += new System.EventHandler(this.btnPrePage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Location = new System.Drawing.Point(92, 437);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(75, 23);
            this.btnNextPage.TabIndex = 116;
            this.btnNextPage.Text = "下一页";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // labelCurPage
            // 
            this.labelCurPage.AutoSize = true;
            this.labelCurPage.Location = new System.Drawing.Point(674, 439);
            this.labelCurPage.Name = "labelCurPage";
            this.labelCurPage.Size = new System.Drawing.Size(41, 12);
            this.labelCurPage.TabIndex = 117;
            this.labelCurPage.Text = "当前页";
            // 
            // labelTotalRecord
            // 
            this.labelTotalRecord.AutoSize = true;
            this.labelTotalRecord.Location = new System.Drawing.Point(783, 439);
            this.labelTotalRecord.Name = "labelTotalRecord";
            this.labelTotalRecord.Size = new System.Drawing.Size(41, 12);
            this.labelTotalRecord.TabIndex = 118;
            this.labelTotalRecord.Text = "总记录";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(767, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 16);
            this.label1.TabIndex = 119;
            this.label1.Text = "提示：请先进行内部校准";
            // 
            // btncancelcali
            // 
            this.btncancelcali.Location = new System.Drawing.Point(175, 463);
            this.btncancelcali.Name = "btncancelcali";
            this.btncancelcali.Size = new System.Drawing.Size(75, 23);
            this.btncancelcali.TabIndex = 120;
            this.btncancelcali.Text = "取消校准";
            this.btncancelcali.UseVisualStyleBackColor = true;
            this.btncancelcali.Click += new System.EventHandler(this.btncancelcali_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbTypeAll);
            this.groupBox3.Controls.Add(this.rbTypeCur);
            this.groupBox3.Location = new System.Drawing.Point(773, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(99, 51);
            this.groupBox3.TabIndex = 121;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "方式";
            // 
            // rbTypeAll
            // 
            this.rbTypeAll.AutoSize = true;
            this.rbTypeAll.Location = new System.Drawing.Point(6, 20);
            this.rbTypeAll.Name = "rbTypeAll";
            this.rbTypeAll.Size = new System.Drawing.Size(47, 16);
            this.rbTypeAll.TabIndex = 109;
            this.rbTypeAll.TabStop = true;
            this.rbTypeAll.Text = "全部";
            this.rbTypeAll.UseVisualStyleBackColor = true;
            this.rbTypeAll.CheckedChanged += new System.EventHandler(this.rbType_CheckedChanged);
            // 
            // rbTypeCur
            // 
            this.rbTypeCur.AutoSize = true;
            this.rbTypeCur.Location = new System.Drawing.Point(53, 20);
            this.rbTypeCur.Name = "rbTypeCur";
            this.rbTypeCur.Size = new System.Drawing.Size(47, 16);
            this.rbTypeCur.TabIndex = 110;
            this.rbTypeCur.TabStop = true;
            this.rbTypeCur.Text = "当前";
            this.rbTypeCur.UseVisualStyleBackColor = true;
            this.rbTypeCur.CheckedChanged += new System.EventHandler(this.rbType_CheckedChanged);
            // 
            // btnsendcali
            // 
            this.btnsendcali.Location = new System.Drawing.Point(363, 463);
            this.btnsendcali.Name = "btnsendcali";
            this.btnsendcali.Size = new System.Drawing.Size(75, 23);
            this.btnsendcali.TabIndex = 122;
            this.btnsendcali.Text = "下传结果";
            this.btnsendcali.UseVisualStyleBackColor = true;
            this.btnsendcali.Click += new System.EventHandler(this.btnsendcali_Click);
            // 
            // btnanalyze
            // 
            this.btnanalyze.Location = new System.Drawing.Point(282, 2);
            this.btnanalyze.Name = "btnanalyze";
            this.btnanalyze.Size = new System.Drawing.Size(75, 23);
            this.btnanalyze.TabIndex = 125;
            this.btnanalyze.Text = "统计分析";
            this.btnanalyze.UseVisualStyleBackColor = true;
            this.btnanalyze.Click += new System.EventHandler(this.btnanalyze_Click);
            // 
            // progressBarCali
            // 
            this.progressBarCali.Location = new System.Drawing.Point(607, 466);
            this.progressBarCali.Name = "progressBarCali";
            this.progressBarCali.Size = new System.Drawing.Size(172, 20);
            this.progressBarCali.TabIndex = 126;
            // 
            // btnpausecali
            // 
            this.btnpausecali.Location = new System.Drawing.Point(92, 463);
            this.btnpausecali.Name = "btnpausecali";
            this.btnpausecali.Size = new System.Drawing.Size(75, 23);
            this.btnpausecali.TabIndex = 127;
            this.btnpausecali.Text = "暂停校准";
            this.btnpausecali.UseVisualStyleBackColor = true;
            this.btnpausecali.Click += new System.EventHandler(this.btnpausecali_Click);
            // 
            // labelprogress
            // 
            this.labelprogress.AutoSize = true;
            this.labelprogress.Location = new System.Drawing.Point(548, 471);
            this.labelprogress.Name = "labelprogress";
            this.labelprogress.Size = new System.Drawing.Size(59, 12);
            this.labelprogress.TabIndex = 128;
            this.labelprogress.Text = "当前进度:";
            // 
            // labelcompleted
            // 
            this.labelcompleted.AutoSize = true;
            this.labelcompleted.Location = new System.Drawing.Point(785, 471);
            this.labelcompleted.Name = "labelcompleted";
            this.labelcompleted.Size = new System.Drawing.Size(59, 12);
            this.labelcompleted.TabIndex = 129;
            this.labelcompleted.Text = "已完成0/0";
            // 
            // dmTabCtrl
            // 
            this.dmTabCtrl.BackColor = System.Drawing.Color.Transparent;
            this.dmTabCtrl.Controls.Add(this.TabCalibrate);
            this.dmTabCtrl.Controls.Add(this.TabEvaluate);
            this.dmTabCtrl.Controls.Add(this.tabDebugCom);
            this.dmTabCtrl.ItemSize = new System.Drawing.Size(80, 32);
            this.dmTabCtrl.Location = new System.Drawing.Point(12, 31);
            this.dmTabCtrl.Name = "dmTabCtrl";
            this.dmTabCtrl.SelectedIndex = 0;
            this.dmTabCtrl.Size = new System.Drawing.Size(939, 540);
            this.dmTabCtrl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.dmTabCtrl.TabIndex = 130;
            // 
            // TabCalibrate
            // 
            this.TabCalibrate.Controls.Add(this.btnReadCali);
            this.TabCalibrate.Controls.Add(this.dgvCaliItem);
            this.TabCalibrate.Controls.Add(this.btnpausecali);
            this.TabCalibrate.Controls.Add(this.labelcompleted);
            this.TabCalibrate.Controls.Add(this.labelTotalRecord);
            this.TabCalibrate.Controls.Add(this.labelCurPage);
            this.TabCalibrate.Controls.Add(this.groupBox1);
            this.TabCalibrate.Controls.Add(this.btnsendcali);
            this.TabCalibrate.Controls.Add(this.btnReset);
            this.TabCalibrate.Controls.Add(this.btnNextPage);
            this.TabCalibrate.Controls.Add(btnDeleteAllPoint);
            this.TabCalibrate.Controls.Add(this.labelprogress);
            this.TabCalibrate.Controls.Add(this.btnDeletePoint);
            this.TabCalibrate.Controls.Add(this.btnPrePage);
            this.TabCalibrate.Controls.Add(this.btncancelcali);
            this.TabCalibrate.Controls.Add(this.btnAddPoint);
            this.TabCalibrate.Controls.Add(this.groupBox2);
            this.TabCalibrate.Controls.Add(this.groupBox3);
            this.TabCalibrate.Controls.Add(this.progressBarCali);
            this.TabCalibrate.Controls.Add(this.btnstartcali);
            this.TabCalibrate.Controls.Add(this.btnsavecali);
            this.TabCalibrate.Location = new System.Drawing.Point(4, 36);
            this.TabCalibrate.Name = "TabCalibrate";
            this.TabCalibrate.Padding = new System.Windows.Forms.Padding(3);
            this.TabCalibrate.Size = new System.Drawing.Size(931, 500);
            this.TabCalibrate.TabIndex = 0;
            this.TabCalibrate.Text = "自动校准";
            this.TabCalibrate.UseVisualStyleBackColor = true;
            // 
            // btnReadCali
            // 
            this.btnReadCali.Location = new System.Drawing.Point(455, 463);
            this.btnReadCali.Name = "btnReadCali";
            this.btnReadCali.Size = new System.Drawing.Size(75, 23);
            this.btnReadCali.TabIndex = 130;
            this.btnReadCali.Text = "读取结果";
            this.btnReadCali.UseVisualStyleBackColor = true;
            this.btnReadCali.Click += new System.EventHandler(this.btnReadCali_Click);
            // 
            // TabEvaluate
            // 
            this.TabEvaluate.Controls.Add(this.numericDividerId);
            this.TabEvaluate.Controls.Add(this.label5);
            this.TabEvaluate.Controls.Add(this.label4);
            this.TabEvaluate.Controls.Add(this.numericInternal);
            this.TabEvaluate.Controls.Add(this.label2);
            this.TabEvaluate.Controls.Add(this.groupBox8);
            this.TabEvaluate.Controls.Add(this.btnDividerReset);
            this.TabEvaluate.Controls.Add(this.groupBox7);
            this.TabEvaluate.Controls.Add(this.groupBox6);
            this.TabEvaluate.Controls.Add(this.labelTotalRecordDivider);
            this.TabEvaluate.Controls.Add(this.labelCurPageDivider);
            this.TabEvaluate.Controls.Add(this.btnnextpage_divider);
            this.TabEvaluate.Controls.Add(this.btnprepage_divider);
            this.TabEvaluate.Controls.Add(this.groupBox5);
            this.TabEvaluate.Controls.Add(this.labelCompleteDivider);
            this.TabEvaluate.Controls.Add(this.label3);
            this.TabEvaluate.Controls.Add(this.progressBarDivider);
            this.TabEvaluate.Controls.Add(this.btnDividerPause);
            this.TabEvaluate.Controls.Add(this.btnDividerCancel);
            this.TabEvaluate.Controls.Add(this.btnDividerStart);
            this.TabEvaluate.Controls.Add(this.btnSaveDivider);
            this.TabEvaluate.Controls.Add(this.groupBox4);
            this.TabEvaluate.Controls.Add(this.dgvDivider);
            this.TabEvaluate.Location = new System.Drawing.Point(4, 36);
            this.TabEvaluate.Name = "TabEvaluate";
            this.TabEvaluate.Padding = new System.Windows.Forms.Padding(3);
            this.TabEvaluate.Size = new System.Drawing.Size(931, 500);
            this.TabEvaluate.TabIndex = 1;
            this.TabEvaluate.Text = "分压器监测";
            this.TabEvaluate.UseVisualStyleBackColor = true;
            // 
            // numericDividerId
            // 
            this.numericDividerId.Location = new System.Drawing.Point(592, 444);
            this.numericDividerId.Name = "numericDividerId";
            this.numericDividerId.Size = new System.Drawing.Size(68, 21);
            this.numericDividerId.TabIndex = 148;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(523, 446);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 147;
            this.label5.Text = "分压器编号:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(912, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 146;
            this.label4.Text = "S ";
            // 
            // numericInternal
            // 
            this.numericInternal.Location = new System.Drawing.Point(855, 23);
            this.numericInternal.Name = "numericInternal";
            this.numericInternal.Size = new System.Drawing.Size(54, 21);
            this.numericInternal.TabIndex = 145;
            this.numericInternal.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(785, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 144;
            this.label2.Text = "点间隔时间:";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.rbMeasTypeCur);
            this.groupBox8.Controls.Add(this.rbMeasTypeAll);
            this.groupBox8.Location = new System.Drawing.Point(451, 12);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(120, 45);
            this.groupBox8.TabIndex = 143;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "测量种类";
            // 
            // rbMeasTypeCur
            // 
            this.rbMeasTypeCur.AutoSize = true;
            this.rbMeasTypeCur.Location = new System.Drawing.Point(15, 20);
            this.rbMeasTypeCur.Name = "rbMeasTypeCur";
            this.rbMeasTypeCur.Size = new System.Drawing.Size(47, 16);
            this.rbMeasTypeCur.TabIndex = 109;
            this.rbMeasTypeCur.TabStop = true;
            this.rbMeasTypeCur.Text = "当前";
            this.rbMeasTypeCur.UseVisualStyleBackColor = true;
            this.rbMeasTypeCur.CheckedChanged += new System.EventHandler(this.rbMeasTypeCur_CheckedChanged);
            // 
            // rbMeasTypeAll
            // 
            this.rbMeasTypeAll.AutoSize = true;
            this.rbMeasTypeAll.Location = new System.Drawing.Point(66, 20);
            this.rbMeasTypeAll.Name = "rbMeasTypeAll";
            this.rbMeasTypeAll.Size = new System.Drawing.Size(47, 16);
            this.rbMeasTypeAll.TabIndex = 110;
            this.rbMeasTypeAll.TabStop = true;
            this.rbMeasTypeAll.Text = "全部";
            this.rbMeasTypeAll.UseVisualStyleBackColor = true;
            // 
            // btnDividerReset
            // 
            this.btnDividerReset.Location = new System.Drawing.Point(340, 467);
            this.btnDividerReset.Name = "btnDividerReset";
            this.btnDividerReset.Size = new System.Drawing.Size(75, 23);
            this.btnDividerReset.TabIndex = 142;
            this.btnDividerReset.Text = "重置结果";
            this.btnDividerReset.UseVisualStyleBackColor = true;
            this.btnDividerReset.Click += new System.EventHandler(this.btnDividerReset_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.rbCycleYes);
            this.groupBox7.Controls.Add(this.rbCycleNo);
            this.groupBox7.Location = new System.Drawing.Point(577, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(109, 45);
            this.groupBox7.TabIndex = 141;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "循环测量";
            // 
            // rbCycleYes
            // 
            this.rbCycleYes.AutoSize = true;
            this.rbCycleYes.Location = new System.Drawing.Point(15, 20);
            this.rbCycleYes.Name = "rbCycleYes";
            this.rbCycleYes.Size = new System.Drawing.Size(35, 16);
            this.rbCycleYes.TabIndex = 109;
            this.rbCycleYes.TabStop = true;
            this.rbCycleYes.Text = "是";
            this.rbCycleYes.UseVisualStyleBackColor = true;
            this.rbCycleYes.CheckedChanged += new System.EventHandler(this.rbCycleYes_CheckedChanged);
            // 
            // rbCycleNo
            // 
            this.rbCycleNo.AutoSize = true;
            this.rbCycleNo.Location = new System.Drawing.Point(66, 20);
            this.rbCycleNo.Name = "rbCycleNo";
            this.rbCycleNo.Size = new System.Drawing.Size(35, 16);
            this.rbCycleNo.TabIndex = 110;
            this.rbCycleNo.TabStop = true;
            this.rbCycleNo.Text = "否";
            this.rbCycleNo.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rbSmallUtilDivider);
            this.groupBox6.Controls.Add(this.rbBigUtilDivider);
            this.groupBox6.Location = new System.Drawing.Point(692, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(87, 45);
            this.groupBox6.TabIndex = 140;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "单位";
            // 
            // rbSmallUtilDivider
            // 
            this.rbSmallUtilDivider.AutoSize = true;
            this.rbSmallUtilDivider.Location = new System.Drawing.Point(10, 20);
            this.rbSmallUtilDivider.Name = "rbSmallUtilDivider";
            this.rbSmallUtilDivider.Size = new System.Drawing.Size(29, 16);
            this.rbSmallUtilDivider.TabIndex = 109;
            this.rbSmallUtilDivider.TabStop = true;
            this.rbSmallUtilDivider.Text = "V";
            this.rbSmallUtilDivider.UseVisualStyleBackColor = true;
            // 
            // rbBigUtilDivider
            // 
            this.rbBigUtilDivider.AutoSize = true;
            this.rbBigUtilDivider.Location = new System.Drawing.Point(44, 20);
            this.rbBigUtilDivider.Name = "rbBigUtilDivider";
            this.rbBigUtilDivider.Size = new System.Drawing.Size(35, 16);
            this.rbBigUtilDivider.TabIndex = 110;
            this.rbBigUtilDivider.TabStop = true;
            this.rbBigUtilDivider.Text = "kV";
            this.rbBigUtilDivider.UseVisualStyleBackColor = true;
            // 
            // labelTotalRecordDivider
            // 
            this.labelTotalRecordDivider.AutoSize = true;
            this.labelTotalRecordDivider.Location = new System.Drawing.Point(831, 447);
            this.labelTotalRecordDivider.Name = "labelTotalRecordDivider";
            this.labelTotalRecordDivider.Size = new System.Drawing.Size(41, 12);
            this.labelTotalRecordDivider.TabIndex = 139;
            this.labelTotalRecordDivider.Text = "总记录";
            // 
            // labelCurPageDivider
            // 
            this.labelCurPageDivider.AutoSize = true;
            this.labelCurPageDivider.Location = new System.Drawing.Point(722, 447);
            this.labelCurPageDivider.Name = "labelCurPageDivider";
            this.labelCurPageDivider.Size = new System.Drawing.Size(41, 12);
            this.labelCurPageDivider.TabIndex = 138;
            this.labelCurPageDivider.Text = "当前页";
            // 
            // btnnextpage_divider
            // 
            this.btnnextpage_divider.Location = new System.Drawing.Point(94, 440);
            this.btnnextpage_divider.Name = "btnnextpage_divider";
            this.btnnextpage_divider.Size = new System.Drawing.Size(75, 23);
            this.btnnextpage_divider.TabIndex = 137;
            this.btnnextpage_divider.Text = "下一页";
            this.btnnextpage_divider.UseVisualStyleBackColor = true;
            this.btnnextpage_divider.Click += new System.EventHandler(this.btnnextpage_divider_Click);
            // 
            // btnprepage_divider
            // 
            this.btnprepage_divider.Location = new System.Drawing.Point(14, 440);
            this.btnprepage_divider.Name = "btnprepage_divider";
            this.btnprepage_divider.Size = new System.Drawing.Size(75, 23);
            this.btnprepage_divider.TabIndex = 136;
            this.btnprepage_divider.Text = "上一页";
            this.btnprepage_divider.UseVisualStyleBackColor = true;
            this.btnprepage_divider.Click += new System.EventHandler(this.btnprepage_divider_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbvac);
            this.groupBox5.Controls.Add(this.rbvdcn);
            this.groupBox5.Controls.Add(this.rbf);
            this.groupBox5.Controls.Add(this.rbvdcp);
            this.groupBox5.Location = new System.Drawing.Point(14, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(305, 45);
            this.groupBox5.TabIndex = 135;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "控制变量";
            // 
            // rbvac
            // 
            this.rbvac.AutoSize = true;
            this.rbvac.Location = new System.Drawing.Point(171, 20);
            this.rbvac.Name = "rbvac";
            this.rbvac.Size = new System.Drawing.Size(71, 16);
            this.rbvac.TabIndex = 109;
            this.rbvac.TabStop = true;
            this.rbvac.Text = "电压(AC)";
            this.rbvac.UseVisualStyleBackColor = true;
            this.rbvac.Click += new System.EventHandler(this.radioButton_CheckedChanged_Divider);
            // 
            // rbvdcn
            // 
            this.rbvdcn.AutoSize = true;
            this.rbvdcn.Location = new System.Drawing.Point(88, 20);
            this.rbvdcn.Name = "rbvdcn";
            this.rbvdcn.Size = new System.Drawing.Size(77, 16);
            this.rbvdcn.TabIndex = 108;
            this.rbvdcn.TabStop = true;
            this.rbvdcn.Text = "电压(DC-)";
            this.rbvdcn.UseVisualStyleBackColor = true;
            this.rbvdcn.Click += new System.EventHandler(this.radioButton_CheckedChanged_Divider);
            // 
            // rbf
            // 
            this.rbf.AutoSize = true;
            this.rbf.Location = new System.Drawing.Point(248, 20);
            this.rbf.Name = "rbf";
            this.rbf.Size = new System.Drawing.Size(47, 16);
            this.rbf.TabIndex = 107;
            this.rbf.TabStop = true;
            this.rbf.Text = "频率";
            this.rbf.UseVisualStyleBackColor = true;
            this.rbf.Click += new System.EventHandler(this.radioButton_CheckedChanged_Divider);
            // 
            // rbvdcp
            // 
            this.rbvdcp.AutoSize = true;
            this.rbvdcp.Location = new System.Drawing.Point(6, 20);
            this.rbvdcp.Name = "rbvdcp";
            this.rbvdcp.Size = new System.Drawing.Size(77, 16);
            this.rbvdcp.TabIndex = 106;
            this.rbvdcp.TabStop = true;
            this.rbvdcp.Text = "电压(DC+)";
            this.rbvdcp.UseVisualStyleBackColor = true;
            this.rbvdcp.Click += new System.EventHandler(this.radioButton_CheckedChanged_Divider);
            // 
            // labelCompleteDivider
            // 
            this.labelCompleteDivider.AutoSize = true;
            this.labelCompleteDivider.Location = new System.Drawing.Point(767, 476);
            this.labelCompleteDivider.Name = "labelCompleteDivider";
            this.labelCompleteDivider.Size = new System.Drawing.Size(59, 12);
            this.labelCompleteDivider.TabIndex = 134;
            this.labelCompleteDivider.Text = "已完成0/0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(533, 476);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 133;
            this.label3.Text = "当前进度:";
            // 
            // progressBarDivider
            // 
            this.progressBarDivider.Location = new System.Drawing.Point(592, 471);
            this.progressBarDivider.Name = "progressBarDivider";
            this.progressBarDivider.Size = new System.Drawing.Size(172, 20);
            this.progressBarDivider.TabIndex = 132;
            // 
            // btnDividerPause
            // 
            this.btnDividerPause.Location = new System.Drawing.Point(93, 467);
            this.btnDividerPause.Name = "btnDividerPause";
            this.btnDividerPause.Size = new System.Drawing.Size(75, 23);
            this.btnDividerPause.TabIndex = 131;
            this.btnDividerPause.Text = "暂停监测";
            this.btnDividerPause.UseVisualStyleBackColor = true;
            this.btnDividerPause.Click += new System.EventHandler(this.btnDividerPause_Click);
            // 
            // btnDividerCancel
            // 
            this.btnDividerCancel.Location = new System.Drawing.Point(175, 467);
            this.btnDividerCancel.Name = "btnDividerCancel";
            this.btnDividerCancel.Size = new System.Drawing.Size(75, 23);
            this.btnDividerCancel.TabIndex = 130;
            this.btnDividerCancel.Text = "取消监测";
            this.btnDividerCancel.UseVisualStyleBackColor = true;
            this.btnDividerCancel.Click += new System.EventHandler(this.btnDividerCancel_Click);
            // 
            // btnDividerStart
            // 
            this.btnDividerStart.Location = new System.Drawing.Point(13, 467);
            this.btnDividerStart.Name = "btnDividerStart";
            this.btnDividerStart.Size = new System.Drawing.Size(75, 23);
            this.btnDividerStart.TabIndex = 128;
            this.btnDividerStart.Text = "开始监测";
            this.btnDividerStart.UseVisualStyleBackColor = true;
            this.btnDividerStart.Click += new System.EventHandler(this.btnDividerStart_Click);
            // 
            // btnSaveDivider
            // 
            this.btnSaveDivider.Location = new System.Drawing.Point(257, 467);
            this.btnSaveDivider.Name = "btnSaveDivider";
            this.btnSaveDivider.Size = new System.Drawing.Size(75, 23);
            this.btnSaveDivider.TabIndex = 129;
            this.btnSaveDivider.Text = "保存结果";
            this.btnSaveDivider.UseVisualStyleBackColor = true;
            this.btnSaveDivider.Click += new System.EventHandler(this.btnSaveDivider_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbSaveAuto);
            this.groupBox4.Controls.Add(this.rbSaveMan);
            this.groupBox4.Location = new System.Drawing.Point(325, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(120, 45);
            this.groupBox4.TabIndex = 122;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "保存数据";
            // 
            // rbSaveAuto
            // 
            this.rbSaveAuto.AutoSize = true;
            this.rbSaveAuto.Location = new System.Drawing.Point(15, 20);
            this.rbSaveAuto.Name = "rbSaveAuto";
            this.rbSaveAuto.Size = new System.Drawing.Size(47, 16);
            this.rbSaveAuto.TabIndex = 109;
            this.rbSaveAuto.TabStop = true;
            this.rbSaveAuto.Text = "自动";
            this.rbSaveAuto.UseVisualStyleBackColor = true;
            this.rbSaveAuto.CheckedChanged += new System.EventHandler(this.rbSaveAuto_CheckedChanged);
            // 
            // rbSaveMan
            // 
            this.rbSaveMan.AutoSize = true;
            this.rbSaveMan.Location = new System.Drawing.Point(66, 20);
            this.rbSaveMan.Name = "rbSaveMan";
            this.rbSaveMan.Size = new System.Drawing.Size(47, 16);
            this.rbSaveMan.TabIndex = 110;
            this.rbSaveMan.TabStop = true;
            this.rbSaveMan.Text = "手动";
            this.rbSaveMan.UseVisualStyleBackColor = true;
            // 
            // dgvDivider
            // 
            this.dgvDivider.AllowUserToOrderColumns = true;
            this.dgvDivider.AllowUserToResizeColumns = false;
            this.dgvDivider.AllowUserToResizeRows = false;
            this.dgvDivider.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDivider.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDivider.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvDivider.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDivider.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDivider.ColumnHeadersHeight = 48;
            this.dgvDivider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDivider.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ModeDivider,
            this.SourceDivider,
            this.FrequencyDivider,
            this.StandDivider,
            this.TestDivider,
            this.TemperatureDivider,
            this.HumidityDivider,
            this.StateDivider});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDivider.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDivider.EnableHeadersVisualStyles = false;
            this.dgvDivider.GridColor = System.Drawing.Color.Black;
            this.dgvDivider.Location = new System.Drawing.Point(10, 69);
            this.dgvDivider.MinimumSize = new System.Drawing.Size(0, 32);
            this.dgvDivider.Name = "dgvDivider";
            this.dgvDivider.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvDivider.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDivider.RowTemplate.Height = 30;
            this.dgvDivider.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvDivider.Size = new System.Drawing.Size(915, 370);
            this.dgvDivider.StandardTab = true;
            this.dgvDivider.TabIndex = 93;
            // 
            // tabDebugCom
            // 
            this.tabDebugCom.Controls.Add(this.label6);
            this.tabDebugCom.Controls.Add(this.groupBox9);
            this.tabDebugCom.Controls.Add(this.textSend);
            this.tabDebugCom.Controls.Add(this.btnSend);
            this.tabDebugCom.Controls.Add(this.textReceive);
            this.tabDebugCom.Controls.Add(this.btnClear);
            this.tabDebugCom.Location = new System.Drawing.Point(4, 36);
            this.tabDebugCom.Name = "tabDebugCom";
            this.tabDebugCom.Padding = new System.Windows.Forms.Padding(3);
            this.tabDebugCom.Size = new System.Drawing.Size(931, 506);
            this.tabDebugCom.TabIndex = 2;
            this.tabDebugCom.Text = "调试通信";
            this.tabDebugCom.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 12);
            this.label6.TabIndex = 122;
            this.label6.Text = "选择调试端口:";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.rbComCaliTest);
            this.groupBox9.Controls.Add(this.rbCom34401);
            this.groupBox9.Controls.Add(this.rbCom34410);
            this.groupBox9.Location = new System.Drawing.Point(104, 21);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(344, 91);
            this.groupBox9.TabIndex = 123;
            this.groupBox9.TabStop = false;
            // 
            // rbComCaliTest
            // 
            this.rbComCaliTest.AutoSize = true;
            this.rbComCaliTest.Location = new System.Drawing.Point(16, 21);
            this.rbComCaliTest.Name = "rbComCaliTest";
            this.rbComCaliTest.Size = new System.Drawing.Size(71, 16);
            this.rbComCaliTest.TabIndex = 121;
            this.rbComCaliTest.TabStop = true;
            this.rbComCaliTest.Text = "待校准表";
            this.rbComCaliTest.UseVisualStyleBackColor = true;
            this.rbComCaliTest.CheckedChanged += new System.EventHandler(this.rbDebugComSelect_CheckedChanged);
            // 
            // rbCom34401
            // 
            this.rbCom34401.AutoSize = true;
            this.rbCom34401.Location = new System.Drawing.Point(134, 55);
            this.rbCom34401.Name = "rbCom34401";
            this.rbCom34401.Size = new System.Drawing.Size(107, 16);
            this.rbCom34401.TabIndex = 120;
            this.rbCom34401.TabStop = true;
            this.rbCom34401.Text = "标准表2(34401)";
            this.rbCom34401.UseVisualStyleBackColor = true;
            this.rbCom34401.CheckedChanged += new System.EventHandler(this.rbDebugComSelect_CheckedChanged);
            // 
            // rbCom34410
            // 
            this.rbCom34410.AutoSize = true;
            this.rbCom34410.Location = new System.Drawing.Point(16, 55);
            this.rbCom34410.Name = "rbCom34410";
            this.rbCom34410.Size = new System.Drawing.Size(107, 16);
            this.rbCom34410.TabIndex = 119;
            this.rbCom34410.TabStop = true;
            this.rbCom34410.Text = "标准表1(34410)";
            this.rbCom34410.UseVisualStyleBackColor = true;
            this.rbCom34410.CheckedChanged += new System.EventHandler(this.rbDebugComSelect_CheckedChanged);
            // 
            // ModeDivider
            // 
            this.ModeDivider.DataPropertyName = "Mode";
            this.ModeDivider.HeaderText = "模式";
            this.ModeDivider.Name = "ModeDivider";
            // 
            // SourceDivider
            // 
            this.SourceDivider.DataPropertyName = "Source";
            this.SourceDivider.HeaderText = "源电压(kV)";
            this.SourceDivider.Name = "SourceDivider";
            // 
            // FrequencyDivider
            // 
            this.FrequencyDivider.DataPropertyName = "Frequency";
            this.FrequencyDivider.HeaderText = "源频率(Hz)";
            this.FrequencyDivider.Name = "FrequencyDivider";
            // 
            // StandDivider
            // 
            this.StandDivider.DataPropertyName = "StandOut";
            this.StandDivider.HeaderText = "分压器输入电压(V)";
            this.StandDivider.Name = "StandDivider";
            // 
            // TestDivider
            // 
            this.TestDivider.DataPropertyName = "TestOut";
            this.TestDivider.HeaderText = "分压器输出电压(V)";
            this.TestDivider.Name = "TestDivider";
            // 
            // TemperatureDivider
            // 
            this.TemperatureDivider.DataPropertyName = "Temperature";
            this.TemperatureDivider.HeaderText = "温度(℃)";
            this.TemperatureDivider.Name = "TemperatureDivider";
            // 
            // HumidityDivider
            // 
            this.HumidityDivider.DataPropertyName = "Humidity";
            this.HumidityDivider.HeaderText = "湿度(%)";
            this.HumidityDivider.Name = "HumidityDivider";
            // 
            // StateDivider
            // 
            this.StateDivider.DataPropertyName = "State";
            this.StateDivider.HeaderText = "状态";
            this.StateDivider.Name = "StateDivider";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 573);
            this.Controls.Add(this.dmTabCtrl);
            this.Controls.Add(this.btnanalyze);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncaliset);
            this.Controls.Add(this.btnuser);
            this.Controls.Add(this.btnresult);
            this.Controls.Add(this.btncomset);
            this.Controls.Add(this.btLoginout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "自动校准平台_从机";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaliItem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.dmTabCtrl.ResumeLayout(false);
            this.TabCalibrate.ResumeLayout(false);
            this.TabCalibrate.PerformLayout();
            this.TabEvaluate.ResumeLayout(false);
            this.TabEvaluate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDividerId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInternal)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDivider)).EndInit();
            this.tabDebugCom.ResumeLayout(false);
            this.tabDebugCom.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLoginout;
        private System.Windows.Forms.Button btncomset;
        private System.Windows.Forms.Button btnresult;
        private System.Windows.Forms.Button btnuser;
        private System.Windows.Forms.Button btncaliset;
        private System.Windows.Forms.Button btnstartcali;
        private System.Windows.Forms.Button btnsavecali;
        private System.Windows.Forms.DataGridView dgvCaliItem;
        private System.Windows.Forms.Button btnAddPoint;
        private System.Windows.Forms.Button btnDeletePoint;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RadioButton rbVDCL;
        private System.Windows.Forms.RadioButton rbVDCHP;
        private System.Windows.Forms.RadioButton rbVACVL;
        private System.Windows.Forms.RadioButton rbVACVH;
        private System.Windows.Forms.RadioButton rbVACF;
        private System.Windows.Forms.RadioButton rbIDC;
        private System.Windows.Forms.RadioButton rbIACI;
        private System.Windows.Forms.RadioButton rbIACF;
        private System.Windows.Forms.RadioButton rbUnitSmall;
        private System.Windows.Forms.RadioButton rbUnitBig;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textSend;
        private System.Windows.Forms.TextBox textReceive;
        private System.Windows.Forms.Button btnPrePage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Label labelCurPage;
        private System.Windows.Forms.Label labelTotalRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncancelcali;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbTypeAll;
        private System.Windows.Forms.RadioButton rbTypeCur;
        private System.Windows.Forms.Button btnsendcali;
        private System.Windows.Forms.Button btnanalyze;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Source;
        private System.Windows.Forms.DataGridViewTextBoxColumn StandOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.RadioButton rbVDCHN;
        private System.Windows.Forms.ProgressBar progressBarCali;
        private System.Windows.Forms.Button btnpausecali;
        private System.Windows.Forms.Label labelprogress;
        private System.Windows.Forms.Label labelcompleted;
        private DMSkin.Controls.DMTabControl dmTabCtrl;
        private System.Windows.Forms.TabPage TabCalibrate;
        private System.Windows.Forms.TabPage TabEvaluate;
        private System.Windows.Forms.DataGridView dgvDivider;
        private System.Windows.Forms.Label labelCompleteDivider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBarDivider;
        private System.Windows.Forms.Button btnDividerPause;
        private System.Windows.Forms.Button btnDividerCancel;
        private System.Windows.Forms.Button btnDividerStart;
        private System.Windows.Forms.Button btnSaveDivider;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbSaveAuto;
        private System.Windows.Forms.RadioButton rbSaveMan;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rbf;
        private System.Windows.Forms.RadioButton rbvdcp;
        private System.Windows.Forms.RadioButton rbvac;
        private System.Windows.Forms.RadioButton rbvdcn;
        private System.Windows.Forms.Label labelTotalRecordDivider;
        private System.Windows.Forms.Button btnnextpage_divider;
        private System.Windows.Forms.Button btnprepage_divider;
        private System.Windows.Forms.Label labelCurPageDivider;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton rbSmallUtilDivider;
        private System.Windows.Forms.RadioButton rbBigUtilDivider;
        private System.Windows.Forms.Button btnReadCali;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton rbCycleYes;
        private System.Windows.Forms.RadioButton rbCycleNo;
        private System.Windows.Forms.Button btnDividerReset;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.RadioButton rbMeasTypeCur;
        private System.Windows.Forms.RadioButton rbMeasTypeAll;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericInternal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericDividerId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabDebugCom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.RadioButton rbComCaliTest;
        private System.Windows.Forms.RadioButton rbCom34401;
        private System.Windows.Forms.RadioButton rbCom34410;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModeDivider;
        private System.Windows.Forms.DataGridViewTextBoxColumn SourceDivider;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrequencyDivider;
        private System.Windows.Forms.DataGridViewTextBoxColumn StandDivider;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestDivider;
        private System.Windows.Forms.DataGridViewTextBoxColumn TemperatureDivider;
        private System.Windows.Forms.DataGridViewTextBoxColumn HumidityDivider;
        private System.Windows.Forms.DataGridViewTextBoxColumn StateDivider;
    }
}

