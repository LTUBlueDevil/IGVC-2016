using IGVC_Controller.Code.DataIO;
using IGVC_Controller.Code.Modules.Visualizer.LIDAR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGVC_Controller.Code.Modules.Visualizer
{
    class LIDAR_Visualizer : IModule
    {
        GatedVariable LIDARdata = new GatedVariable();
        LIDAR_Visualizer_Form form;// = new LIDAR_Visualizer_Form();\

        delegate void delegateCloseForm();

        delegate void delegateSetFormData(object data);
        private delegateSetFormData setFormDataDelegate;

        public LIDAR_Visualizer()
        {
            this.addSubscription(INTERMODULE_VARIABLE.LIDAR_RAW);
            this.modulePriority = 100;
            this.setFormDataDelegate = this.setFormData;
        }

        public override void recieveDataFromRegistry(INTERMODULE_VARIABLE tag, object data)
        {
            if (tag == INTERMODULE_VARIABLE.LIDAR_RAW)
                LIDARdata.setObject(data);
        }

        public override void process()
        {
            LIDARdata.shiftObject();
            if (form.InvokeRequired)
            {
                form.Invoke(this.setFormDataDelegate, new object[] { LIDARdata.getObject() });
            }

            base.process();
        }

        public override bool startup()
        {
            form = new LIDAR_Visualizer_Form();
            form.Show();

            return base.startup();
        }

        public override void shutdown()
        {
            if (form.InvokeRequired)
            {
                delegateCloseForm del = this.closeForm;
                form.Invoke(del, null);
            }
            else
            {
                form.Close();
            }

            base.shutdown();
        }

        
        private void closeForm()
        {
            form.Close();
        }

        private void setFormData(object data)
        {
            form.setLIDARData((List<long>)data);
        }
    }
}
