using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    class Building
    {
        string adress { get; set; }
        double length { get; set; }
        double width { get; set; }
        double height { get; set; }

        public Building (string adress, double length, double width, double height)
        {
            this.adress = adress;
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public string Print()
        {
            return $"Адрес здания: {adress},\nвысота здания: {length} \nширина здания: {width}, \nвысота здания: {height}";
        }
    }
}
