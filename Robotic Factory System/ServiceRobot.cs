using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotic_Factory_System
{
    public class ServiceRobot: RobotPrototype
    {
        public String ServiceTask;
        public ServiceRobot(String model, String battery, String software,String serviceTask) : base(model, battery, software)
        {
            this.ServiceTask = serviceTask;
        }
        public override RobotPrototype Clone()
        {
            return new ServiceRobot(this.Model, this.battery, this.software, this.ServiceTask);
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Service Robot - Model: {Model}, Battery: {battery}, Software: {software}, Service Task: {ServiceTask}");
        }

    }
}
