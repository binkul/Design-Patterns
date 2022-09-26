using System;

namespace Design_Patterns.Builder
{
    static class BuilderPattern
    {
        static void Main(string[] args)
        {
            var boss = new Manager();
            Builder builder1 = new OneFamilyHome();
            Builder builder2 = new OfficeHome();

            boss.ChoseBuilder(builder1);
            boss.Build();
            Building building1 = boss.GetBuilding();

            boss.ChoseBuilder(builder2);
            boss.Build();
            Building building2 = boss.GetBuilding();

            Console.WriteLine("First building:");
            building1.DescribeBuilding();
            Console.WriteLine("Second building:");
            building2.DescribeBuilding();

            Console.ReadLine();
        }
    }
}
