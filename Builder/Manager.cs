namespace Design_Patterns.Builder
{
    class Manager
    {
        private Builder _builder;

        public void ChoseBuilder(Builder builder)
        {
            _builder = builder;
        }

        public Building GetBuilding()
        {
            return _builder.GetBuilding();
        }

        public void Build()
        {
            _builder.NewBuilding();
            _builder.InsertWindows();
            _builder.MountDoors();
            _builder.PaintBuilding();
        }
    }
}
