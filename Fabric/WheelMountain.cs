using System;

namespace Design_Patterns.Fabric
{
    class WheelMountain : IWheel
    {
        private const string _name = "Wheel for Mountain Bike";

        public IWheel AddWheel()
        {
            Console.WriteLine($"Dodano {_name}");
            return new WheelMountain();
        }
    }
}
