using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotic_Factory_System
{
    internal class IndustrialRobot: RobotPrototype
    {
        public String ManufacturingTask;
        public IndustrialRobot(String model, String battery, String software, String manufacturingTask) : base(model, battery, software)
        {
            this.ManufacturingTask = manufacturingTask;
        }
        public override RobotPrototype Clone()
        {
            return new IndustrialRobot(this.Model, this.battery, this.software, this.ManufacturingTask);
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Industrial Robot - Model: {Model}, Battery: {battery}, Software: {software}, Manufacturing Task: {ManufacturingTask}");
        }
    
    }
}
