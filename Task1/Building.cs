using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Building
    {
        string buildingAddress;
        double buildingLength;
        double buildingWidth;
        double buildingHeight;

        string BuildingAdress
        {
            get
            {
                return buildingAddress;
            }
            set
            {
                if (value.Length <= 0)
                    Console.WriteLine("Отсутствует адресс");
                else buildingAddress = value;
            }
        }

        double BuildingLength
        {
            get
            {
                return buildingLength;
            }
            set
            {
                if (value <= 0)
                    Console.WriteLine("Здание должно иметь длину");
                else
                    buildingLength = value;
            }
        }

        double BuildingWidth
        {
            get
            { 
            return buildingWidth;
            }
            set
            {
                if (value <= 0)
                    Console.WriteLine("Здание должно иметь ширину");
                else
                    buildingWidth = value;
            }
        }

        double BuildingHeight
        {
            get
            {
                return buildingHeight;
            }
            set
            {
                if (value <= 0)
                    Console.WriteLine("Здание должно иметь высоту");
                else
                    buildingHeight = value;
            }
        }

        public Building(string buildingAddress, double buildingLength, double buildingWidth, double buildingHeight)
        {
            this.BuildingAdress = buildingAddress;
            this.BuildingLength = buildingLength;
            this.BuildingWidth = buildingWidth;
            this.BuildingHeight = buildingHeight;

        }

        public string Print()
        {
            return $"Дом находится по адресу: {buildingAddress}. Имеет следующие характеристики: длина {buildingLength}, ширина {buildingWidth}, высота {buildingHeight}";
        }

    }
}
