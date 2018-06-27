namespace AutoCalibrationSystem
{
    partial class ComSetForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.boxBaudrateTest = new System.Windows.Forms.ComboBox();
            this.boxComTest = new System.Windows.Forms.ComboBox();
            this.SaddTest = new System.Windows.Forms.NumericUpDown();
            this.btnComTest = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textPortStand2 = new System.Windows.Forms.TextBox();
            this.textIPStand2 = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.boxBaudrateStand2 = new System.Windows.Forms.ComboBox();
            this.boxComStand2 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnComStand2 = new System.Windows.Forms.Button();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnLanStand2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SaddTest)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(59, 284);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 21);
            this.textBox5.TabIndex = 35;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(59, 249);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 21);
            this.textBox4.TabIndex = 34;
            this.textBox4.Text = "192.168.0.1";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(59, 214);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 33;
            this.textBox3.Text = "None";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(59, 179);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 32;
            this.textBox2.Text = "1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(59, 144);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 31;
            this.textBox1.Text = "8";
            // 
            // boxBaudrateTest
            // 
            this.boxBaudrateTest.FormattingEnabled = true;
            this.boxBaudrateTest.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "57600",
            "115200",
            ""});
            this.boxBaudrateTest.Location = new System.Drawing.Point(59, 110);
            this.boxBaudrateTest.Name = "boxBaudrateTest";
            this.boxBaudrateTest.Size = new System.Drawing.Size(100, 20);
            this.boxBaudrateTest.TabIndex = 30;
            // 
            // boxComTest
            // 
            this.boxComTest.FormattingEnabled = true;
            this.boxComTest.Location = new System.Drawing.Point(59, 76);
            this.boxComTest.Name = "boxComTest";
            this.boxComTest.Size = new System.Drawing.Size(100, 20);
            this.boxComTest.TabIndex = 29;
            // 
            // SaddTest
            // 
            this.SaddTest.Location = new System.Drawing.Point(59, 41);
            this.SaddTest.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SaddTest.Name = "SaddTest";
            this.SaddTest.Size = new System.Drawing.Size(100, 21);
            this.SaddTest.TabIndex = 28;
            this.SaddTest.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnComTest
            // 
            this.btnComTest.Font = new System.Drawing.Font("宋体", 9F);
            this.btnComTest.Location = new System.Drawing.Point(61, 315);
            this.btnComTest.Name = "btnComTest";
            this.btnComTest.Size = new System.Drawing.Size(71, 25);
            this.btnComTest.TabIndex = 26;
            this.btnComTest.Text = "打开串口";
            this.btnComTest.UseVisualStyleBackColor = true;
            this.btnComTest.Click += new System.EventHandler(this.btnComTest_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 25;
            this.label8.Text = "端口号";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 24;
            this.label7.Text = "网络IP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 23;
            this.label6.Text = "校验位";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 22;
            this.label5.Text = "停止位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 21;
            this.label4.Text = "数据位";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 20;
            this.label9.Text = "波特率";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 19;
            this.label10.Text = "串口号";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 18;
            this.label11.Text = "仪表地址";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(136, 374);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 70;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnComTest);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(2, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 347);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "待校准表参数配置";
            // 
            // textPortStand2
            // 
            this.textPortStand2.Location = new System.Drawing.Point(242, 289);
            this.textPortStand2.Name = "textPortStand2";
            this.textPortStand2.Size = new System.Drawing.Size(100, 21);
            this.textPortStand2.TabIndex = 126;
            this.textPortStand2.Text = "5025";
            // 
            // textIPStand2
            // 
            this.textIPStand2.Location = new System.Drawing.Point(242, 254);
            this.textIPStand2.Name = "textIPStand2";
            this.textIPStand2.Size = new System.Drawing.Size(100, 21);
            this.textIPStand2.TabIndex = 125;
            this.textIPStand2.Text = "169.254.4.10";
            // 
            // textBox26
            // 
            this.textBox26.Location = new System.Drawing.Point(242, 219);
            this.textBox26.Name = "textBox26";
            this.textBox26.ReadOnly = true;
            this.textBox26.Size = new System.Drawing.Size(100, 21);
            this.textBox26.TabIndex = 124;
            this.textBox26.Text = "None";
            // 
            // textBox27
            // 
            this.textBox27.Location = new System.Drawing.Point(242, 184);
            this.textBox27.Name = "textBox27";
            this.textBox27.ReadOnly = true;
            this.textBox27.Size = new System.Drawing.Size(100, 21);
            this.textBox27.TabIndex = 123;
            this.textBox27.Text = "1";
            // 
            // textBox28
            // 
            this.textBox28.Location = new System.Drawing.Point(242, 149);
            this.textBox28.Name = "textBox28";
            this.textBox28.ReadOnly = true;
            this.textBox28.Size = new System.Drawing.Size(100, 21);
            this.textBox28.TabIndex = 122;
            this.textBox28.Text = "8";
            // 
            // boxBaudrateStand2
            // 
            this.boxBaudrateStand2.FormattingEnabled = true;
            this.boxBaudrateStand2.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "57600",
            "115200",
            ""});
            this.boxBaudrateStand2.Location = new System.Drawing.Point(242, 115);
            this.boxBaudrateStand2.Name = "boxBaudrateStand2";
            this.boxBaudrateStand2.Size = new System.Drawing.Size(100, 20);
            this.boxBaudrateStand2.TabIndex = 121;
            // 
            // boxComStand2
            // 
            this.boxComStand2.FormattingEnabled = true;
            this.boxComStand2.Location = new System.Drawing.Point(242, 81);
            this.boxComStand2.Name = "boxComStand2";
            this.boxComStand2.Size = new System.Drawing.Size(100, 20);
            this.boxComStand2.TabIndex = 120;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(242, 46);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 21);
            this.numericUpDown1.TabIndex = 119;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnComStand2
            // 
            this.btnComStand2.Font = new System.Drawing.Font("宋体", 9F);
            this.btnComStand2.Location = new System.Drawing.Point(88, 314);
            this.btnComStand2.Name = "btnComStand2";
            this.btnComStand2.Size = new System.Drawing.Size(71, 25);
            this.btnComStand2.TabIndex = 118;
            this.btnComStand2.Text = "打开串口";
            this.btnComStand2.UseVisualStyleBackColor = true;
            this.btnComStand2.Click += new System.EventHandler(this.btnComStand2_Click);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(190, 293);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(41, 12);
            this.label41.TabIndex = 117;
            this.label41.Text = "端口号";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(190, 258);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(41, 12);
            this.label42.TabIndex = 116;
            this.label42.Text = "网络IP";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(190, 223);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(41, 12);
            this.label43.TabIndex = 115;
            this.label43.Text = "校验位";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(190, 188);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(41, 12);
            this.label44.TabIndex = 114;
            this.label44.Text = "停止位";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(190, 153);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(41, 12);
            this.label45.TabIndex = 113;
            this.label45.Text = "数据位";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(190, 118);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(41, 12);
            this.label46.TabIndex = 112;
            this.label46.Text = "波特率";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(190, 83);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(41, 12);
            this.label47.TabIndex = 111;
            this.label47.Text = "串口号";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(190, 48);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(53, 12);
            this.label48.TabIndex = 110;
            this.label48.Text = "仪表地址";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnLanStand2);
            this.groupBox6.Controls.Add(this.btnComStand2);
            this.groupBox6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox6.Location = new System.Drawing.Point(183, 13);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(170, 347);
            this.groupBox6.TabIndex = 127;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "标准表2参数配置";
            // 
            // btnLanStand2
            // 
            this.btnLanStand2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLanStand2.Location = new System.Drawing.Point(6, 315);
            this.btnLanStand2.Name = "btnLanStand2";
            this.btnLanStand2.Size = new System.Drawing.Size(71, 25);
            this.btnLanStand2.TabIndex = 45;
            this.btnLanStand2.Text = "打开网口";
            this.btnLanStand2.UseVisualStyleBackColor = true;
            this.btnLanStand2.Click += new System.EventHandler(this.btnLanStand2_Click);
            // 
            // ComSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 409);
            this.ControlBox = false;
            this.Controls.Add(this.textPortStand2);
            this.Controls.Add(this.textIPStand2);
            this.Controls.Add(this.textBox26);
            this.Controls.Add(this.textBox27);
            this.Controls.Add(this.textBox28);
            this.Controls.Add(this.boxBaudrateStand2);
            this.Controls.Add(this.boxComStand2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.label44);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.label46);
            this.Controls.Add(this.label47);
            this.Controls.Add(this.label48);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.boxBaudrateTest);
            this.Controls.Add(this.boxComTest);
            this.Controls.Add(this.SaddTest);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Name = "ComSetForm";
            this.Text = "通信参数设置";
            this.Load += new System.EventHandler(this.ComSetForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SaddTest)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox boxBaudrateTest;
        private System.Windows.Forms.ComboBox boxComTest;
        private System.Windows.Forms.NumericUpDown SaddTest;
        private System.Windows.Forms.Button btnComTest;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textPortStand2;
        private System.Windows.Forms.TextBox textIPStand2;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.TextBox textBox27;
        private System.Windows.Forms.TextBox textBox28;
        private System.Windows.Forms.ComboBox boxBaudrateStand2;
        private System.Windows.Forms.ComboBox boxComStand2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnComStand2;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnLanStand2;
    }
}