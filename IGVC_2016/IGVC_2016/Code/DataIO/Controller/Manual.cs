﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpDX.DirectInput;


namespace IGVC_2016.Code.DataIO.Controller
{
    class Manual
    {
        Joystick joystick;

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
            if (joystickGuid == Guid.Empty)
            {
                Console.WriteLine("No joystick/Gamepad found.");
                Console.ReadKey();
                Environment.Exit(1);
            }

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
        }

        public void Task()
        {
            // Poll events from joystick
            while (true)
            {
                joystick.Poll();
                

                var datas = joystick.GetBufferedData();
                foreach (var state in datas)
                {
                    var str = state.ToString().Replace(',',' ').Split(' ');
                    //str[0] = "Offset:"
                    //str[1] = Button Name
                    //str[2] = Blank
                    //str[3] = "Value:"
                    //str[4] = Value
                    //str[5] = "TimeStamp"
                    //str[6] = time value
                    //str[7] = "Sequence"
                    //str[8] = sequence number

                    Console.WriteLine(state);
                }
            }
        }
    }
}
