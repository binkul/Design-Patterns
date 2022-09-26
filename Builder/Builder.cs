namespace Design_Patterns.Builder
{
    public abstract class Builder
    {
        protected Building Building;

        public void NewBuilding()
        {
            Building = new Building();
        }

        public Building GetBuilding()
        {
            return Building;
        }

        public abstract void InsertWindows();
        public abstract void MountDoors();
        public abstract void PaintBuilding();
    }
}
