using System;

namespace Design_Patterns.Fabric
{
    class HamperCity : IHamper
    {
        private const string _name = "Hamper for City Bike";

        public IHamper AddHamper()
        {
            Console.WriteLine($"Dodano {_name}");
            return new HamperCity();
        }
    }
}
