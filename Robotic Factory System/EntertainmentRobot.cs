using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotic_Factory_System
{
    internal class EntertainmentRobot: RobotPrototype
    {
        public String EntertainmentTask;
        public EntertainmentRobot(String model, String battery, String software, String entertainmentTask) : base(model, battery, software)
        {
            this.EntertainmentTask = entertainmentTask;
        }
        public override RobotPrototype Clone()
        {
            return new EntertainmentRobot(this.Model, this.battery, this.software, this.EntertainmentTask);
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Entertainment Robot - Model: {Model}, Battery: {battery}, Software: {software}, Entertainment Task: {EntertainmentTask}");
        }
    }
    
    
}
