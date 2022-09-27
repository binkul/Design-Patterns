using System;

namespace Design_Patterns.Fabric
{
    class ChassisCity : IChassis
    {
        private const string _name = "Chassis for City Bike";

        public IChassis MakeChassis()
        {
            Console.WriteLine($"Dodano {_name}");
            return new ChassisCity();
        }
    }
}
