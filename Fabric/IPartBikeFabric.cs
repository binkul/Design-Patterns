namespace Design_Patterns.Fabric
{
    interface IPartBikeFabric
    {
        IStiringWheel MakeStiringWheel();
        IWheel MakeWheel();
        IChassis MakeChassis();
        IHamper MakeHamper();
    }
}
