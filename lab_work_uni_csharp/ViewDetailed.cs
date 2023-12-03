
using System.ComponentModel;
using System.Globalization;

namespace lab_work_uni_csharp
{
    class ViewDetailed: View
    {
        public ViewDetailed(Model model, Controller controller, FrmDetailed frm) : base(model, controller)
        {
            this.frm = frm;
        }
        public override void DataBind()
        {
            frm.LblTime.DataBindings.Add(new Binding("Text", Model.Clock, "Clock"));

            frm.TbCPU.DataBindings.Add(new Binding("Text", Model.Cpu, "ActiveProcess"));

            frm.TbDevice.DataBindings.Add(new Binding("Text", Model.Device, "ActiveProcess"));                   

            frm.LblOccupateMemSize.DataBindings.Add(new Binding("Text", Model.Ram, "OccupiedSize"));

            frm.LblFreeMemSize.DataBindings.Add(new Binding("Text", Model.Ram, "FreeSize"));

            Binding intestityBinding = new Binding("Value", Model.ModelSettings, "Intensity");
            intestityBinding.ControlUpdateMode = ControlUpdateMode.Never;
            frm.NudIntesity.DataBindings.Add(intestityBinding);

            Binding minValueOfBurstTimeBinding = new Binding("Value", Model.ModelSettings, "MinValueOfBurstTime");
            minValueOfBurstTimeBinding.ControlUpdateMode = ControlUpdateMode.Never;
            frm.NudMinValueOfBurstTime.DataBindings.Add(minValueOfBurstTimeBinding);

            Binding maxValueOfBurstTimeBinding = new Binding("Value", Model.ModelSettings, "MaxValueOfBurstTime");
            maxValueOfBurstTimeBinding.ControlUpdateMode = ControlUpdateMode.Never;
            frm.NudMaxValueOfBurstTime.DataBindings.Add(maxValueOfBurstTimeBinding);

            Binding minValueOfAddrSpaceBinding = new Binding("Value", Model.ModelSettings, "MinValueOfAddrSpace");
            minValueOfAddrSpaceBinding.ControlUpdateMode = ControlUpdateMode.Never;
            frm.NudMinValueOfAddrSpace.DataBindings.Add(minValueOfAddrSpaceBinding);

            Binding maxValueOfAddrSpaceBinding = new Binding("Value", Model.ModelSettings, "MaxValueOfAddrSpace");
            maxValueOfAddrSpaceBinding.ControlUpdateMode = ControlUpdateMode.Never;
            frm.NudMaxValueOfAddrSpace.DataBindings.Add(maxValueOfAddrSpaceBinding);

            Binding valueOfRAMSizeBindings = new Binding("SelectedItem", Model.ModelSettings, "ValueOfRAMSize");
            valueOfRAMSizeBindings.Parse += new ConvertEventHandler(objectToInt);
            valueOfRAMSizeBindings.ControlUpdateMode = ControlUpdateMode.Never;
            frm.CbRamSize.DataBindings.Add(valueOfRAMSizeBindings);

            Subscribe();
        }
        private void objectToInt(object sender, ConvertEventArgs cevent)
        {
            if (cevent.DesiredType != typeof(int))
            {
                return;
            }

            cevent.Value = int.Parse(cevent.Value.ToString(), NumberStyles.Integer, null);
        }

        public override void DataUnbind()
        {
            frm.NudIntesity.DataBindings.RemoveAt(0);
            frm.NudMinValueOfBurstTime.DataBindings.RemoveAt(0);
            frm.NudMaxValueOfBurstTime.DataBindings.RemoveAt(0);
            frm.NudMinValueOfAddrSpace.DataBindings.RemoveAt(0);
            frm.NudMaxValueOfAddrSpace.DataBindings.RemoveAt(0);
            frm.CbRamSize.DataBindings.RemoveAt(0);

            Unsubscribe();
        }
        private void Subscribe()
        {
            Model.PropertyChanged += PropertyChangedHandler;
        }

        private void Unsubscribe()
        {
            Model.PropertyChanged -= PropertyChangedHandler;

        }

        private void PropertyChangedHandler(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "ReadyQueue")
                updateListBox(Model.ReadyQueue, frm.LblCPUQueue);
            else
                updateListBox(Model.DeviceQueue, frm.LblDeviceQueue);           
        }
        private void updateListBox(Queue<Process> queue, ListBox lb)
        {
            lb.Items.Clear();
            if(queue.Count != 0)
                lb.Items.AddRange(queue.ToArray());
        }
        private FrmDetailed frm;
    }
}
