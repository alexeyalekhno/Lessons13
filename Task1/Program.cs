using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите адрес здания");
            string buildingAddress = Console.ReadLine();
            Console.WriteLine("Введите длину здания");
            double buildingLength = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ширину здания");
            double buildingWidth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите высоту здания");
            double buildingHeight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Сколько этажей в здании");
            int floor = Convert.ToInt32(Console.ReadLine());

            Building building = new Building(buildingAddress, buildingLength, buildingWidth, buildingHeight);
            Console.WriteLine(building.Print());
            MultiBuilding multiBuilding = new MultiBuilding(buildingAddress, buildingLength, buildingWidth, buildingHeight, floor);
            Console.WriteLine(multiBuilding.Print());
            Console.ReadKey();

        }
    }
}
