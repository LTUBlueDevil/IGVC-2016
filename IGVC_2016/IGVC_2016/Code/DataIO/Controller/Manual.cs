using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpDX.DirectInput;
using System.IO.Ports;


namespace IGVC_2016.Code.DataIO.Controller
{
    class Manual
    {
        Joystick joystick;
        public bool ControllerOn = false;

        public Manual()
        {
            // Initialize DirectInput
            
            var directInput = new DirectInput();

            // Find a Joystick Guid
            var joystickGuid = Guid.Empty;

            foreach (var deviceInstance in directInput.GetDevices(DeviceType.Gamepad,
                        DeviceEnumerationFlags.AllDevices))
                joystickGuid = deviceInstance.InstanceGuid;

            // If Gamepad not found, look for a Joystick
            if (joystickGuid == Guid.Empty)
                foreach (var deviceInstance in directInput.GetDevices(DeviceType.Joystick,
                        DeviceEnumerationFlags.AllDevices))
                    joystickGuid = deviceInstance.InstanceGuid;

            // If Joystick not found, throws an error
            if (joystickGuid != Guid.Empty)
            {
                //fix running code without controller
                //Environment.Exit(1);
            

                // Instantiate the joystick
                joystick = new Joystick(directInput, joystickGuid);

                Console.WriteLine("Found Joystick/Gamepad with GUID: {0}", joystickGuid);

                // Query all suported ForceFeedback effects
                var allEffects = joystick.GetEffects();
                foreach (var effectInfo in allEffects)
                    Console.WriteLine("Effect available {0}", effectInfo.Name);

                // Set BufferSize in order to use buffered data.
                joystick.Properties.BufferSize = 128;

                // Acquire the joystick
                joystick.Acquire();
                ControllerOn = true;
            }
        }

        double val = 0;

        public string Task()
        {
            // Poll events from joystick
            joystick.Poll();                

            var datas = joystick.GetBufferedData();
            foreach (var state in datas)
            {
                //str[0] = "Offset:"
                //str[1] = Button Name
                //str[2] = Blank
                //str[3] = "Value:"
                //str[4] = Value
                //str[5] = "TimeStamp"
                //str[6] = time value
                //str[7] = "Sequence"
                //str[8] = sequence number

                switch(state.Offset.ToString())
                {
                case "X":
                    {
                        val = state.Value;
                            
                        //convert value to angle (-90 -> 90) to (0 -> 65535)
                        val = .0027*val+90;

                        //send angle to arduino
                        return "F" + Math.Round(val, 2).ToString() + "\n";
                    }
                }
            }
            return "";
            //return "F" + Math.Round(val, 2).ToString() +"\n";
        }

        public bool IsAvailable()
        {
            if (joystick.GetBufferedData() != null)
                return true;
            else
                return false;
        }
    }
}
