using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotic_Factory_System
{
    public abstract class RobotPrototype
    {
        public String Model,battery, software;
        public RobotPrototype(String model, String battery, String software)
        {
            this.Model = model;
            this.battery = battery;
            this.software = software;
        }
        public abstract RobotPrototype Clone();
        public abstract void DisplayInfo();
    }
}
