namespace Design_Patterns.Builder
{
    class OneFamilyHome : Builder
    {
        public override void InsertWindows()
        {
            Building.InsertWindows("Wood window - gold oak");
        }

        public override void MountDoors()
        {
            Building.MountDoors("Anti-theft doors with viewfinder");
        }

        public override void PaintBuilding()
        {
            Building.PaintBuilding("Yellow");
        }
    }
}
