using System;

namespace Design_Patterns.Fabric
{
    class WheelCity : IWheel
    {
        private const string _name = "Wheel for City Bike";

        public IWheel AddWheel()
        {
            Console.WriteLine($"Dodano {_name}");
            return new WheelCity();
        }
    }
}
