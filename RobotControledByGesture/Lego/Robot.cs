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

        public async void ForwardAsync(int speed)
        {
            await brick.DirectCommand.TurnMotorAtSpeedForTimeAsync(OutputPort.All, speed, 100, false);
        }

        public async void LeftAsync(int speed)
        {
            await brick.DirectCommand.TurnMotorAtSpeedForTimeAsync(OutputPort.A, +speed, 100, false);
            await brick.DirectCommand.TurnMotorAtSpeedForTimeAsync(OutputPort.D, -speed, 100, false);
        }

        public async void RightAsync(int speed)
        {
            await brick.DirectCommand.TurnMotorAtSpeedForTimeAsync(OutputPort.A, -speed, 100, false);
            await brick.DirectCommand.TurnMotorAtSpeedForTimeAsync(OutputPort.D, +speed, 500, false);
        }

        public async void LeftRunAsync(int speed)
        {
            await brick.DirectCommand.TurnMotorAtSpeedForTimeAsync(OutputPort.A, speed, 100, false);
            await brick.DirectCommand.TurnMotorAtSpeedForTimeAsync(OutputPort.D, speed/2, 100, false);
        }

        public async void RightRunAsync(int speed)
        {
            await brick.DirectCommand.TurnMotorAtSpeedForTimeAsync(OutputPort.A, speed/2, 100, false);
            await brick.DirectCommand.TurnMotorAtSpeedForTimeAsync(OutputPort.D, speed, 100, false);
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
