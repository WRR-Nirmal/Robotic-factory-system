using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotic_Factory_System
{
    public class Program
    {
        static void Main(string[] args)
        {
            ServiceRobot S1 = new ServiceRobot("ServiceBot-1000", "Li-ion", "ServiceOS v1.0", "Cleaning");
            S1.DisplayInfo();
            ServiceRobot S2 = (ServiceRobot)S1.Clone();
            S2.ServiceTask = "Security";
            S2.DisplayInfo();

            IndustrialRobot I1 = new IndustrialRobot("IndustroBot-2000", "NiMH", "IndustrialOS v2.0", "Assembly");  
            I1.DisplayInfo();
            IndustrialRobot I2 = (IndustrialRobot)I1.Clone();
            I2.battery = "silicon battery";
            I2.DisplayInfo();

            EntertainmentRobot E1 = new EntertainmentRobot("EntertainoBot-3000", "Li-ion", "EntertainmentOS v3.0", "Dancing");
            E1.DisplayInfo();
            EntertainmentRobot E2 = (EntertainmentRobot)E1.Clone();
            E2.software = "verion 1.1";
            E2.DisplayInfo();
        }



    }
}
    