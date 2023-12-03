namespace lab_work_uni_csharp
{
    partial class FrmDetailed
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
            this.components = new System.ComponentModel.Container();
            this.tBL1 = new System.Windows.Forms.TableLayoutPanel();
            this.tBL2_1 = new System.Windows.Forms.TableLayoutPanel();
            this.bClear = new System.Windows.Forms.Button();
            this.bWorkingCycle = new System.Windows.Forms.Button();
            this.bSaveSettings = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbAuto = new System.Windows.Forms.RadioButton();
            this.rbManual = new System.Windows.Forms.RadioButton();
            this.lblTime = new System.Windows.Forms.Label();
            this.tBL3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCPUQueue = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblDeviceQueue = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbCPU = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tbDevice = new System.Windows.Forms.TextBox();
            this.tBL4 = new System.Windows.Forms.TableLayoutPanel();
            this.tBL4_3 = new System.Windows.Forms.TableLayoutPanel();
            this.nudMaxValueOfBurstTime = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.tBL4_4 = new System.Windows.Forms.TableLayoutPanel();
            this.cbRamSize = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBL4_1 = new System.Windows.Forms.TableLayoutPanel();
            this.nudIntesity = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tBL4_2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.nudMinValueOfBurstTime = new System.Windows.Forms.NumericUpDown();
            this.tBL4_5 = new System.Windows.Forms.TableLayoutPanel();
            this.nudMinValueOfAddrSpace = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.tBL4_6 = new System.Windows.Forms.TableLayoutPanel();
            this.nudMaxValueOfAddrSpace = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblOccupateMemValue = new System.Windows.Forms.Label();
            this.lblFreeMemSize = new System.Windows.Forms.Label();
            this.timerAutoMode = new System.Windows.Forms.Timer(this.components);
            this.tBL1.SuspendLayout();
            this.tBL2_1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tBL3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tBL4.SuspendLayout();
            this.tBL4_3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxValueOfBurstTime)).BeginInit();
            this.tBL4_4.SuspendLayout();
            this.tBL4_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntesity)).BeginInit();
            this.tBL4_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinValueOfBurstTime)).BeginInit();
            this.tBL4_5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinValueOfAddrSpace)).BeginInit();
            this.tBL4_6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxValueOfAddrSpace)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tBL1
            // 
            this.tBL1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBL1.AutoSize = true;
            this.tBL1.ColumnCount = 1;
            this.tBL1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tBL1.Controls.Add(this.tBL2_1, 0, 3);
            this.tBL1.Controls.Add(this.tBL3, 0, 1);
            this.tBL1.Controls.Add(this.tBL4, 0, 0);
            this.tBL1.Controls.Add(this.groupBox6, 0, 2);
            this.tBL1.Location = new System.Drawing.Point(1, 0);
            this.tBL1.Name = "tBL1";
            this.tBL1.RowCount = 4;
            this.tBL1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tBL1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62F));
            this.tBL1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tBL1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tBL1.Size = new System.Drawing.Size(786, 560);
            this.tBL1.TabIndex = 0;
            // 
            // tBL2_1
            // 
            this.tBL2_1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBL2_1.AutoSize = true;
            this.tBL2_1.ColumnCount = 5;
            this.tBL2_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.523719F));
            this.tBL2_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.61955F));
            this.tBL2_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28557F));
            this.tBL2_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28557F));
            this.tBL2_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28557F));
            this.tBL2_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tBL2_1.Controls.Add(this.groupBox1, 1, 0);
            this.tBL2_1.Controls.Add(this.lblTime, 0, 0);
            this.tBL2_1.Controls.Add(this.bClear, 4, 0);
            this.tBL2_1.Controls.Add(this.bWorkingCycle, 3, 0);
            this.tBL2_1.Controls.Add(this.bSaveSettings, 2, 0);
            this.tBL2_1.Location = new System.Drawing.Point(3, 506);
            this.tBL2_1.Name = "tBL2_1";
            this.tBL2_1.RowCount = 1;
            this.tBL2_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tBL2_1.Size = new System.Drawing.Size(780, 51);
            this.tBL2_1.TabIndex = 3;
            // 
            // bClear
            // 
            this.bClear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bClear.Enabled = false;
            this.bClear.Location = new System.Drawing.Point(670, 3);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(107, 45);
            this.bClear.TabIndex = 0;
            this.bClear.Text = "Очистка";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bWorkingCycle
            // 
            this.bWorkingCycle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bWorkingCycle.Enabled = false;
            this.bWorkingCycle.Location = new System.Drawing.Point(559, 3);
            this.bWorkingCycle.Name = "bWorkingCycle";
            this.bWorkingCycle.Size = new System.Drawing.Size(105, 45);
            this.bWorkingCycle.TabIndex = 1;
            this.bWorkingCycle.Text = "Рабочий такт";
            this.bWorkingCycle.UseVisualStyleBackColor = true;
            this.bWorkingCycle.Click += new System.EventHandler(this.bWorkingCycle_Click);
            // 
            // bSaveSettings
            // 
            this.bSaveSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bSaveSettings.Location = new System.Drawing.Point(448, 3);
            this.bSaveSettings.Name = "bSaveSettings";
            this.bSaveSettings.Size = new System.Drawing.Size(105, 45);
            this.bSaveSettings.TabIndex = 2;
            this.bSaveSettings.Text = "Сохранение настроек";
            this.bSaveSettings.UseVisualStyleBackColor = true;
            this.bSaveSettings.Click += new System.EventHandler(this.bSaveSettings_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAuto);
            this.groupBox1.Controls.Add(this.rbManual);
            this.groupBox1.Location = new System.Drawing.Point(77, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 44);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Режим работы";
            // 
            // rbAuto
            // 
            this.rbAuto.AutoSize = true;
            this.rbAuto.Location = new System.Drawing.Point(74, 14);
            this.rbAuto.Name = "rbAuto";
            this.rbAuto.Size = new System.Drawing.Size(109, 17);
            this.rbAuto.TabIndex = 1;
            this.rbAuto.Text = "Автоматический";
            this.rbAuto.UseVisualStyleBackColor = true;
            // 
            // rbManual
            // 
            this.rbManual.AutoSize = true;
            this.rbManual.Checked = true;
            this.rbManual.Location = new System.Drawing.Point(8, 14);
            this.rbManual.Name = "rbManual";
            this.rbManual.Size = new System.Drawing.Size(60, 17);
            this.rbManual.TabIndex = 0;
            this.rbManual.TabStop = true;
            this.rbManual.Text = "Ручной";
            this.rbManual.UseVisualStyleBackColor = true;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(3, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(68, 51);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "0";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tBL3
            // 
            this.tBL3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBL3.AutoSize = true;
            this.tBL3.ColumnCount = 2;
            this.tBL3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tBL3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tBL3.Controls.Add(this.groupBox2, 0, 1);
            this.tBL3.Controls.Add(this.groupBox3, 1, 1);
            this.tBL3.Controls.Add(this.groupBox4, 0, 0);
            this.tBL3.Controls.Add(this.groupBox5, 1, 0);
            this.tBL3.Location = new System.Drawing.Point(3, 103);
            this.tBL3.Name = "tBL3";
            this.tBL3.RowCount = 2;
            this.tBL3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tBL3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tBL3.Size = new System.Drawing.Size(780, 341);
            this.tBL3.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.lblCPUQueue);
            this.groupBox2.Location = new System.Drawing.Point(3, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 284);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Очередь к центральному процессору";
            // 
            // lblCPUQueue
            // 
            this.lblCPUQueue.FormattingEnabled = true;
            this.lblCPUQueue.Location = new System.Drawing.Point(5, 15);
            this.lblCPUQueue.Name = "lblCPUQueue";
            this.lblCPUQueue.Size = new System.Drawing.Size(377, 264);
            this.lblCPUQueue.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lblDeviceQueue);
            this.groupBox3.Location = new System.Drawing.Point(393, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(384, 284);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Очередь к внешнему устройству";
            // 
            // lblDeviceQueue
            // 
            this.lblDeviceQueue.FormattingEnabled = true;
            this.lblDeviceQueue.Location = new System.Drawing.Point(-2, 14);
            this.lblDeviceQueue.Name = "lblDeviceQueue";
            this.lblDeviceQueue.Size = new System.Drawing.Size(384, 264);
            this.lblDeviceQueue.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.AutoSize = true;
            this.groupBox4.Controls.Add(this.tbCPU);
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(384, 45);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Центральный процессор";
            // 
            // tbCPU
            // 
            this.tbCPU.Location = new System.Drawing.Point(6, 20);
            this.tbCPU.Name = "tbCPU";
            this.tbCPU.Size = new System.Drawing.Size(373, 20);
            this.tbCPU.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tbDevice);
            this.groupBox5.Location = new System.Drawing.Point(393, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(382, 44);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Внешнее устройство";
            // 
            // tbDevice
            // 
            this.tbDevice.Location = new System.Drawing.Point(5, 19);
            this.tbDevice.Name = "tbDevice";
            this.tbDevice.Size = new System.Drawing.Size(374, 20);
            this.tbDevice.TabIndex = 0;
            // 
            // tBL4
            // 
            this.tBL4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBL4.AutoSize = true;
            this.tBL4.ColumnCount = 6;
            this.tBL4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tBL4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tBL4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tBL4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tBL4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tBL4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tBL4.Controls.Add(this.tBL4_3, 0, 0);
            this.tBL4.Controls.Add(this.tBL4_4, 0, 0);
            this.tBL4.Controls.Add(this.tBL4_1, 0, 0);
            this.tBL4.Controls.Add(this.tBL4_2, 0, 0);
            this.tBL4.Controls.Add(this.tBL4_5, 4, 0);
            this.tBL4.Controls.Add(this.tBL4_6, 5, 0);
            this.tBL4.Location = new System.Drawing.Point(3, 3);
            this.tBL4.Name = "tBL4";
            this.tBL4.RowCount = 1;
            this.tBL4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tBL4.Size = new System.Drawing.Size(780, 94);
            this.tBL4.TabIndex = 2;
            // 
            // tBL4_3
            // 
            this.tBL4_3.ColumnCount = 1;
            this.tBL4_3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tBL4_3.Controls.Add(this.nudMaxValueOfBurstTime, 0, 1);
            this.tBL4_3.Controls.Add(this.label4, 0, 0);
            this.tBL4_3.Location = new System.Drawing.Point(263, 3);
            this.tBL4_3.Name = "tBL4_3";
            this.tBL4_3.RowCount = 2;
            this.tBL4_3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tBL4_3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tBL4_3.Size = new System.Drawing.Size(123, 88);
            this.tBL4_3.TabIndex = 12;
            // 
            // nudMaxValueOfBurstTime
            // 
            this.nudMaxValueOfBurstTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudMaxValueOfBurstTime.Location = new System.Drawing.Point(3, 65);
            this.nudMaxValueOfBurstTime.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMaxValueOfBurstTime.Name = "nudMaxValueOfBurstTime";
            this.nudMaxValueOfBurstTime.Size = new System.Drawing.Size(117, 20);
            this.nudMaxValueOfBurstTime.TabIndex = 6;
            this.nudMaxValueOfBurstTime.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 52);
            this.label4.TabIndex = 6;
            this.label4.Text = "Максимальное значение промежутка работы на ЦП";
            // 
            // tBL4_4
            // 
            this.tBL4_4.ColumnCount = 1;
            this.tBL4_4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tBL4_4.Controls.Add(this.cbRamSize, 0, 1);
            this.tBL4_4.Controls.Add(this.label3, 0, 0);
            this.tBL4_4.Location = new System.Drawing.Point(393, 3);
            this.tBL4_4.Name = "tBL4_4";
            this.tBL4_4.RowCount = 2;
            this.tBL4_4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tBL4_4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tBL4_4.Size = new System.Drawing.Size(123, 88);
            this.tBL4_4.TabIndex = 11;
            // 
            // cbRamSize
            // 
            this.cbRamSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRamSize.DisplayMember = "3200";
            this.cbRamSize.FormattingEnabled = true;
            this.cbRamSize.Items.AddRange(new object[] {
            "3200",
            "6400"});
            this.cbRamSize.Location = new System.Drawing.Point(3, 64);
            this.cbRamSize.Name = "cbRamSize";
            this.cbRamSize.Size = new System.Drawing.Size(117, 21);
            this.cbRamSize.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Размер оперативной памяти";
            // 
            // tBL4_1
            // 
            this.tBL4_1.ColumnCount = 1;
            this.tBL4_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tBL4_1.Controls.Add(this.nudIntesity, 0, 1);
            this.tBL4_1.Controls.Add(this.label1, 0, 0);
            this.tBL4_1.Location = new System.Drawing.Point(3, 3);
            this.tBL4_1.Name = "tBL4_1";
            this.tBL4_1.RowCount = 2;
            this.tBL4_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tBL4_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tBL4_1.Size = new System.Drawing.Size(123, 88);
            this.tBL4_1.TabIndex = 10;
            // 
            // nudIntesity
            // 
            this.nudIntesity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudIntesity.DecimalPlaces = 1;
            this.nudIntesity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudIntesity.Location = new System.Drawing.Point(3, 65);
            this.nudIntesity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudIntesity.Name = "nudIntesity";
            this.nudIntesity.Size = new System.Drawing.Size(117, 20);
            this.nudIntesity.TabIndex = 5;
            this.nudIntesity.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Интенсивность поступления процессов";
            // 
            // tBL4_2
            // 
            this.tBL4_2.ColumnCount = 1;
            this.tBL4_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tBL4_2.Controls.Add(this.label2, 0, 0);
            this.tBL4_2.Controls.Add(this.nudMinValueOfBurstTime, 0, 1);
            this.tBL4_2.Location = new System.Drawing.Point(133, 3);
            this.tBL4_2.Name = "tBL4_2";
            this.tBL4_2.RowCount = 2;
            this.tBL4_2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.45454F));
            this.tBL4_2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.54545F));
            this.tBL4_2.Size = new System.Drawing.Size(123, 88);
            this.tBL4_2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 52);
            this.label2.TabIndex = 6;
            this.label2.Text = "Миниманьное значение промежутка работы на ЦП";
            // 
            // nudMinValueOfBurstTime
            // 
            this.nudMinValueOfBurstTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudMinValueOfBurstTime.Location = new System.Drawing.Point(3, 65);
            this.nudMinValueOfBurstTime.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMinValueOfBurstTime.Name = "nudMinValueOfBurstTime";
            this.nudMinValueOfBurstTime.Size = new System.Drawing.Size(117, 20);
            this.nudMinValueOfBurstTime.TabIndex = 5;
            this.nudMinValueOfBurstTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tBL4_5
            // 
            this.tBL4_5.ColumnCount = 1;
            this.tBL4_5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tBL4_5.Controls.Add(this.nudMinValueOfAddrSpace, 0, 1);
            this.tBL4_5.Controls.Add(this.label5, 0, 0);
            this.tBL4_5.Location = new System.Drawing.Point(523, 3);
            this.tBL4_5.Name = "tBL4_5";
            this.tBL4_5.RowCount = 2;
            this.tBL4_5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tBL4_5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tBL4_5.Size = new System.Drawing.Size(123, 88);
            this.tBL4_5.TabIndex = 13;
            // 
            // nudMinValueOfAddrSpace
            // 
            this.nudMinValueOfAddrSpace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudMinValueOfAddrSpace.Location = new System.Drawing.Point(3, 65);
            this.nudMinValueOfAddrSpace.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMinValueOfAddrSpace.Name = "nudMinValueOfAddrSpace";
            this.nudMinValueOfAddrSpace.Size = new System.Drawing.Size(117, 20);
            this.nudMinValueOfAddrSpace.TabIndex = 7;
            this.nudMinValueOfAddrSpace.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudMinValueOfAddrSpace.ValueChanged += new System.EventHandler(this.nudMinValueOfAddrSpace_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 52);
            this.label5.TabIndex = 8;
            this.label5.Text = "Минимальный размер адресного пространства процесса";
            // 
            // tBL4_6
            // 
            this.tBL4_6.ColumnCount = 1;
            this.tBL4_6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tBL4_6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tBL4_6.Controls.Add(this.nudMaxValueOfAddrSpace, 0, 1);
            this.tBL4_6.Controls.Add(this.label6, 0, 0);
            this.tBL4_6.Location = new System.Drawing.Point(653, 3);
            this.tBL4_6.Name = "tBL4_6";
            this.tBL4_6.RowCount = 2;
            this.tBL4_6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tBL4_6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tBL4_6.Size = new System.Drawing.Size(124, 88);
            this.tBL4_6.TabIndex = 14;
            // 
            // nudMaxValueOfAddrSpace
            // 
            this.nudMaxValueOfAddrSpace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudMaxValueOfAddrSpace.Location = new System.Drawing.Point(3, 65);
            this.nudMaxValueOfAddrSpace.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMaxValueOfAddrSpace.Name = "nudMaxValueOfAddrSpace";
            this.nudMaxValueOfAddrSpace.Size = new System.Drawing.Size(118, 20);
            this.nudMaxValueOfAddrSpace.TabIndex = 8;
            this.nudMaxValueOfAddrSpace.Value = new decimal(new int[] {
            260,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 52);
            this.label6.TabIndex = 9;
            this.label6.Text = "Максимальный размер адресного пространства процесса";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.AutoSize = true;
            this.groupBox6.Controls.Add(this.tableLayoutPanel1);
            this.groupBox6.Location = new System.Drawing.Point(3, 450);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(780, 50);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Оперативная память";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblOccupateMemValue, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFreeMemSize, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(761, 24);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Размер свободной памяти:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(383, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "Размер занятой памяти:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOccupateMemValue
            // 
            this.lblOccupateMemValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOccupateMemValue.AutoSize = true;
            this.lblOccupateMemValue.Location = new System.Drawing.Point(573, 0);
            this.lblOccupateMemValue.Name = "lblOccupateMemValue";
            this.lblOccupateMemValue.Size = new System.Drawing.Size(185, 24);
            this.lblOccupateMemValue.TabIndex = 3;
            this.lblOccupateMemValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFreeMemSize
            // 
            this.lblFreeMemSize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFreeMemSize.AutoSize = true;
            this.lblFreeMemSize.Location = new System.Drawing.Point(193, 0);
            this.lblFreeMemSize.Name = "lblFreeMemSize";
            this.lblFreeMemSize.Size = new System.Drawing.Size(184, 24);
            this.lblFreeMemSize.TabIndex = 4;
            this.lblFreeMemSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timerAutoMode
            // 
            this.timerAutoMode.Interval = 1000;
            this.timerAutoMode.Tick += new System.EventHandler(this.timerAutoMode_Tick);
            // 
            // FrmDetailed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 561);
            this.Controls.Add(this.tBL1);
            this.Name = "FrmDetailed";
            this.Text = "Lab_3";
            this.tBL1.ResumeLayout(false);
            this.tBL1.PerformLayout();
            this.tBL2_1.ResumeLayout(false);
            this.tBL2_1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tBL3.ResumeLayout(false);
            this.tBL3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tBL4.ResumeLayout(false);
            this.tBL4_3.ResumeLayout(false);
            this.tBL4_3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxValueOfBurstTime)).EndInit();
            this.tBL4_4.ResumeLayout(false);
            this.tBL4_4.PerformLayout();
            this.tBL4_1.ResumeLayout(false);
            this.tBL4_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntesity)).EndInit();
            this.tBL4_2.ResumeLayout(false);
            this.tBL4_2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinValueOfBurstTime)).EndInit();
            this.tBL4_5.ResumeLayout(false);
            this.tBL4_5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinValueOfAddrSpace)).EndInit();
            this.tBL4_6.ResumeLayout(false);
            this.tBL4_6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxValueOfAddrSpace)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tBL1;
        private System.Windows.Forms.TableLayoutPanel tBL3;
        private System.Windows.Forms.TableLayoutPanel tBL4;
        private System.Windows.Forms.TableLayoutPanel tBL2_1;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button bWorkingCycle;
        private System.Windows.Forms.Button bSaveSettings;
        private System.Windows.Forms.NumericUpDown nudMaxValueOfAddrSpace;
        private System.Windows.Forms.NumericUpDown nudMinValueOfAddrSpace;
        private System.Windows.Forms.NumericUpDown nudMinValueOfBurstTime;
        private System.Windows.Forms.ComboBox cbRamSize;
        private System.Windows.Forms.TableLayoutPanel tBL4_2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tBL4_4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tBL4_3;
        private System.Windows.Forms.NumericUpDown nudMaxValueOfBurstTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tBL4_5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tBL4_6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timerAutoMode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbAuto;
        private System.Windows.Forms.RadioButton rbManual;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbCPU;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tbDevice;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tBL4_1;
        private System.Windows.Forms.NumericUpDown nudIntesity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblOccupateMemValue;
        private System.Windows.Forms.Label lblFreeMemSize;
        private System.Windows.Forms.ListBox lblCPUQueue;
        private System.Windows.Forms.ListBox lblDeviceQueue;
    }
}

