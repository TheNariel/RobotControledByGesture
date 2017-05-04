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
            await brick.DirectCommand.PlayToneAsync(50, 800, 10);
            await brick.DirectCommand.PlayToneAsync(50, 800, 10);
        }

        public async void StopMoving()
        {
            await brick.DirectCommand.StopMotorAsync(OutputPort.All, true);
        }

        public async void ForwardAsync()
        {
            await brick.DirectCommand.TurnMotorAtSpeedForTimeAsync(OutputPort.All, 50, 100, false);
        }

        public async void LeftAsync()
        {
            await brick.DirectCommand.TurnMotorAtSpeedForTimeAsync(OutputPort.A, +30, 500, false);
            await brick.DirectCommand.TurnMotorAtSpeedForTimeAsync(OutputPort.D, -30, 500, false);
        }

        public async void RightAsync()
        {
            await brick.DirectCommand.TurnMotorAtSpeedForTimeAsync(OutputPort.A, -30, 500, false);
            await brick.DirectCommand.TurnMotorAtSpeedForTimeAsync(OutputPort.D, +30, 500, false);
        }

        public async void LeftRunAsync()
        {
            await brick.DirectCommand.TurnMotorAtSpeedForTimeAsync(OutputPort.A, +40, 500, false);
            await brick.DirectCommand.TurnMotorAtSpeedForTimeAsync(OutputPort.D, 20, 500, false);
        }

        public async void RightRunAsync()
        {
            await brick.DirectCommand.TurnMotorAtSpeedForTimeAsync(OutputPort.A, 20, 500, false);
            await brick.DirectCommand.TurnMotorAtSpeedForTimeAsync(OutputPort.D, +40, 500, false);
        }

        public async void PlayToneAsync(int volume,ushort frequency,ushort duration)
        {
            await brick.DirectCommand.PlayToneAsync(volume, frequency, duration);
        }

        public void AbortCommands()
        {
            StopMoving();
            brick.Disconnect();
        }
    }
}
