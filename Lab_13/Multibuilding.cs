using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    sealed class Multibuilding:Building
    {
        double floor { get; set; }
        public Multibuilding (string adress, double length, double width, double height, double floor)
            :base(adress,length,width,height)
        {
            this.floor = floor;
        }

        public string Print()
        {
           string result = base.Print();
           result+= $"\nЭтажность здания:{floor}";
           return result;
        }
    }
}
