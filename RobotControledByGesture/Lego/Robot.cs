using Lego.Ev3.Core;
using Lego.Ev3.Desktop;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotControledByGesture.Lego

{
    class Robot 
    {
       
        private Brick brick;

        public Robot()
        {
            
        }
        
        public async void InitializeRobotAsync(string COMPort)
        {
            brick = new Brick(new BluetoothCommunication(COMPort));
            await brick.ConnectAsync();
        }
    
        public async void StopMoving()
        {
            await brick.DirectCommand.PlayToneAsync(10, 100, 200);
         //   await brick.DirectCommand.StopMotorAsync(OutputPort.All, true);
            Debug.WriteLine("Robot stops moving.");
        }


        public async void LeftAsync()
        {
          
        
            await brick.DirectCommand.TurnMotorAtSpeedForTimeAsync(OutputPort.B, -30, 500, false);
            await brick.DirectCommand.TurnMotorAtSpeedForTimeAsync(OutputPort.A, +30, 500, false);

            Debug.WriteLine("Robot goes left.");
        }

        public async void RightAsync()
        {
           
            await brick.DirectCommand.TurnMotorAtSpeedForTimeAsync(OutputPort.A, -30, 500, false);
            await brick.DirectCommand.TurnMotorAtSpeedForTimeAsync(OutputPort.B, +30, 500, false);
            Debug.WriteLine("Robot goes right.");
        }

        public async void ForwardAsync()
        {
            await brick.DirectCommand.PlayToneAsync(10, 500, 200);

         //   await brick.DirectCommand.TurnMotorAtSpeedForTimeAsync(OutputPort.All, 40, 500, false);
            Debug.WriteLine("Robot goes forward.");
       }

        public void AbortCommands()
        {
            StopMoving();
            brick.Disconnect();
        }
    }
}
