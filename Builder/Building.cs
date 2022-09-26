using System;

namespace Design_Patterns.Builder
{
    public class Building
    {
        private string _windows;
        private string _doors;
        private string _elevColour;

        public void InsertWindows(string window)
        {
            _windows = window;
        }

        public void MountDoors(string door)
        {
            _doors = door;
        }

        public void PaintBuilding(string elevColour)
        {
            _elevColour = elevColour;
        }

        public void DescribeBuilding()
        {
            if (!string.IsNullOrEmpty(_windows))
            {
                Console.WriteLine("Widnows: " + _windows);
            }

            if (!string.IsNullOrEmpty(_doors))
            {
                Console.WriteLine("Doors: " + _doors);
            }

            if (!string.IsNullOrEmpty(_elevColour))
            {
                Console.WriteLine("Elevation is in colour: " + _elevColour);
            }

        }
    }
}
