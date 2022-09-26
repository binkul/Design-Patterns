namespace Design_Patterns.Builder
{
    class OfficeHome : Builder
    {
        public override void InsertWindows()
        {
            Building.InsertWindows("Not opened - anthracit");
        }

        public override void MountDoors()
        {
            Building.MountDoors("Revolving doors");
        }

        public override void PaintBuilding()
        {
            Building.PaintBuilding("Not painted glass elevation");
        }
    }
}
