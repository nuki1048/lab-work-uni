using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_work_uni_csharp
{
    public partial class FrmDetailed : Form
    {
        private ViewDetailed viewDetailed;
        public FrmDetailed()
        {
            InitializeComponent();
            cbRamSize.SelectedItem = cbRamSize.Items[0];
            viewDetailed = new ViewDetailed(new Model(), new Controller(), this);
            viewDetailed.DataBind();
        }

        public Label LblTime
        {
            get
            {
                return lblTime;
            }
        }
        public TextBox TbCPU
        {
            get
            {
                return tbCPU;
            }
        }
        public TextBox TbDevice
        {
            get
            {
                return tbDevice;
            }
        }
        public ListBox LblCPUQueue
        {
            get
            {
                return lblCPUQueue;
            }
        }
        public ListBox LblDeviceQueue
        {
            get
            {
                return lblDeviceQueue;
            }
        }
        public Label LblOccupateMemSize
        {
            get
            {
                return lblOccupateMemValue;
            }
        }
        public Label LblFreeMemSize
        {
            get
            {
                return lblFreeMemSize;
            }
        }
        public NumericUpDown NudIntesity
        {
            get
            {
                return nudIntesity;
            }
        }
        public NumericUpDown NudMinValueOfBurstTime
        {
            get
            {
                return nudMinValueOfBurstTime;
            }
        }
        public NumericUpDown NudMaxValueOfBurstTime
        {
            get
            {
                return nudMaxValueOfBurstTime;
            }
        }
        public NumericUpDown NudMinValueOfAddrSpace
        {
            get
            {
                return nudMinValueOfAddrSpace;
            }
        }
        public NumericUpDown NudMaxValueOfAddrSpace
        {
            get
            {
                return nudMaxValueOfAddrSpace;
            }
        }
        public ComboBox CbRamSize
        {
            get
            {
                return cbRamSize;
            }
        }
        private void bSaveSettings_Click(object sender, EventArgs e)
        {
            sessionPreparation();
            if (rbAuto.Checked)
            {
                timerAutoMode.Start();
            }
            else
                viewDetailed.ReactToUserActions(ModelOperations.SaveSettings);           
        }

        private void bWorkingCycle_Click(object sender, EventArgs e)
        {
            viewDetailed.ReactToUserActions(ModelOperations.WorkingCycle);
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            if (rbAuto.Checked)
            {
                timerAutoMode.Stop();
            }
            viewDetailed.ReactToUserActions(ModelOperations.Clear);           
            endOfSession();
            UpdateSettings();
        }
        private void sessionPreparation()
        {
            bSaveSettings.Enabled = false;
            bClear.Enabled = true;
            bWorkingCycle.Enabled = rbManual.Checked;
            nudIntesity.Enabled = false;
            nudMaxValueOfAddrSpace.Enabled = false;
            nudMaxValueOfBurstTime.Enabled = false;
            nudMinValueOfAddrSpace.Enabled = false;
            nudMinValueOfBurstTime.Enabled = false;
            cbRamSize.Enabled = false;

        }
        private void endOfSession()
        {
            bClear.Enabled = false;
            bSaveSettings.Enabled = true;
            bWorkingCycle.Enabled = false;
            nudIntesity.Enabled = true;
            nudMaxValueOfAddrSpace.Enabled = true;
            nudMaxValueOfBurstTime.Enabled = true;
            nudMinValueOfAddrSpace.Enabled = true;
            nudMinValueOfBurstTime.Enabled = true;
            cbRamSize.Enabled = true;
        }

        private void UpdateSettings()
        {
            nudIntesity.Value = 0;
            nudMinValueOfBurstTime.Value = 1;
            nudMaxValueOfBurstTime.Value = 4;
            nudMinValueOfAddrSpace.Value = 25;
            nudMaxValueOfAddrSpace.Value = 125;
        }

        private void timerAutoMode_Tick(object sender, EventArgs e)
        {
            viewDetailed.ReactToUserActions(ModelOperations.WorkingCycle);
        }

        private void nudMinValueOfAddrSpace_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
