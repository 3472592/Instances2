using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3WinFormsApp2Instances
{
    public class Car
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Hp { get; set; }

        public void PrintCarCridentials()
        {
            MessageBox.Show("Car name - " + Name +
                " car speed - " + Speed +
                " car horse power - " + Hp);
        }
    }
}
