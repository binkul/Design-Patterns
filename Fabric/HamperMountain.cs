using System;

namespace Design_Patterns.Fabric
{
    class HamperMountain : IHamper
    {
        private const string _name = "Hamper for Mountain Bike";

        public IHamper AddHamper()
        {
            Console.WriteLine($"Dodano {_name}");
            return new HamperMountain();
        }
    }
}
