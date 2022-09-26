using System;

namespace Design_Patterns.Fabric
{
    class StiringWheelMountain : IStiringWheel
    {
        private const string _name = "Stiring wheel for Mountain Bike";
        public IStiringWheel AddStiringWheel()
        {
            Console.WriteLine($"Dodano {_name}");
            return new StiringWheelMountain();
        }
    }
}
