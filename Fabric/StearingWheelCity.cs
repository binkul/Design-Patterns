using System;

namespace Design_Patterns.Fabric
{
    class StearingWheelCity : IStiringWheel
    {
        private const string _name = "Stiring wheel for City Bike";
        public IStiringWheel AddStiringWheel()
        {
            Console.WriteLine($"Dodano {_name}");
            return new StearingWheelCity();
        }
    }
}
