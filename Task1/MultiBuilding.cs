using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    sealed class MultiBuilding:Building
    {
        int floor;

        int Floor
        {
            get
            {
                return floor;
            }
            set
            {
                if (value <= 0)
                    Console.WriteLine("Здание должно иметь хотя бы один этаж");
                else
                    floor = value;
            }
        }

        public MultiBuilding(string buildingAddress, double buildingLength, double buildingWidth, double buildingHeight, int floor)
            : base(buildingAddress, buildingLength, buildingWidth, buildingHeight)
        { 
        this.Floor = floor;
        }

        public string Print()
        { 
        string result = base.Print();
            result += $",а также имеет высоту в {floor} этажей.";
            return result;
        }
            
    }
}
